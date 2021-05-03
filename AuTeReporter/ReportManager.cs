using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.IO;

namespace ReportManager
{
	//Zdroj: https://github.com/microsoft/WinAppDriver/blob/master/Tests/AbsoluteXPath/DesktopSession.cs
	public class ReportManager
	{
		private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
		private const string WinAppDriverExe = @"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe";
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

		public static void FailerTask(){
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

			FinalTasks();
			Assert.Fail();
		}

		public static void Initialize(TestContext context)
		{
			if (!WinAppDriverControl())
			{
				throw new Exception("WinAppDriver path does not exists. See README for more information about needed settings.");
			}

			application = context.Properties["application"].ToString(); //"Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
			winAppDriver = System.Diagnostics.Process.Start(WinAppDriverExe);
			ActualReportModel = new ReportModel(context.FullyQualifiedTestClassName, application);
			ActualReportModel.testProjectPath = context.Properties["testProjectPath"].ToString();
			resultDirectory = context.Properties["resultDirectory"].ToString();
		}

		public static void Initialize(string _application, string _resultDirectory)
		{
			if(!File.Exists(_application)){
				throw new Exception("Path to SUT does not exists.");
			}
			if(!WinAppDriverControl()){
				throw new Exception("WinAppDriver path does not exists. See README for more information about needed settings.");
			}
			if(!Directory.Exists(_resultDirectory)){
				throw new Exception("Path to result directory does not exists.");
			}

			application = _application;
			winAppDriver = System.Diagnostics.Process.Start(WinAppDriverExe);
			ActualReportModel = new ReportModel("test", application);
			ActualReportModel.testProjectPath = "Test";
			resultDirectory = _resultDirectory;
		}

		public static void Initialize(string _application)
		{
			if (!File.Exists(_application))
			{
				throw new Exception("Path to SUT does not exists.");
			}
			if (!WinAppDriverControl())
			{
				throw new Exception("WinAppDriver path does not exists. See README for more information about needed settings.");
			}

			application = _application;
			winAppDriver = System.Diagnostics.Process.Start(WinAppDriverExe);
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

		private static bool WinAppDriverControl()
		{
			if (!File.Exists(WinAppDriverExe))
			{
				return false;
			}

			return true;
		}
	}
}
