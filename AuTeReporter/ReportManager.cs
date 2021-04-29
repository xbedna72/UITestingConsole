using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace ReportManager
{
	public class ReportManager
	{
		protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
		protected static WindowsDriver<WindowsElement> desktopSessionMain;
		protected static WindowsDriver<WindowsElement> desktopSession;
		protected static string application = string.Empty;
		protected static string resultDirectory = string.Empty;
		static System.Diagnostics.Process winAppDriver = null;
		public static ReportModel ActualReportModel = null;
		public static System.Collections.IDictionary contextProperties = null;

		public static bool Setup(TestContext context)
		{
			if (desktopSessionMain == null)
			{
				AppiumOptions options = new AppiumOptions();
				options.AddAdditionalCapability("app", application);
				options.AddAdditionalCapability("platformName", "windows");
				options.AddAdditionalCapability("automationName", "windows");
				desktopSessionMain = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);
				if (desktopSessionMain == null || desktopSessionMain.SessionId == null)
				{
					return false;
				}
			}

			if (desktopSession == null)
			{
				AppiumOptions opts = new AppiumOptions();
				opts.AddAdditionalCapability("app", "Root");
				desktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), opts);

				if (desktopSession == null || desktopSession.SessionId == null)
				{
					return false;
				}

				desktopSession.Manage().Timeouts().ImplicitWait =
					TimeSpan.FromSeconds(5);
			}
			if (ActualReportModel != null)
			{
				ActualReportModel.NewMethod(desktopSession);
			}
			return true;
		}

		public static void TearDown()
		{
			if (ActualReportModel != null)
			{
				ActualReportModel.EndMethod(desktopSession);
			}

			if (desktopSession != null)
			{
				desktopSession.Close();
				desktopSession.Quit();
				desktopSession = null;
			}
		}

		public static void Initialize(TestContext context)
		{
			application = context.Properties["application"].ToString(); //"Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
			winAppDriver = System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
			ActualReportModel = new ReportModel(context.FullyQualifiedTestClassName);
			ActualReportModel.testProjectPath = context.Properties["testProjectPath"].ToString();
			resultDirectory = context.Properties["resultDirectory"].ToString();
		}

		public static void Initialize(string _application, string _resultDirectory)
		{
			application = _application;
			winAppDriver = System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
			ActualReportModel = new ReportModel("test");
			ActualReportModel.testProjectPath = "Test";
			resultDirectory = _resultDirectory;
		}

		public static void FinalTasks()
		{
			if (desktopSessionMain != null)
			{
				foreach (var handle in desktopSessionMain.WindowHandles)
				{
					desktopSessionMain.SwitchTo().Window(handle);
					desktopSessionMain.Close();
				}
				desktopSessionMain.Quit();
				desktopSessionMain = null;
			}

			winAppDriver.Kill();
			winAppDriver.WaitForExit();
			winAppDriver.Dispose();

			if (ActualReportModel != null)
			{
				new HtmlCreater(ActualReportModel, resultDirectory);
			}
		}
	}
}
