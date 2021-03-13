using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReportManager
{
	public class ReportManagerClass
	{
		protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
		protected static WindowsDriver<WindowsElement> desktopSession;
		protected static WindowsDriver<WindowsElement> root;
		protected static string application = string.Empty;
		static System.Diagnostics.Process winAppDriver = null;
		public static ReportModel ActualReportModel = null;
		public static bool Setup(TestContext context)
		{
			if (desktopSession == null)
			{
				AppiumOptions options = new AppiumOptions();
				options.AddAdditionalCapability("app", application);
				options.AddAdditionalCapability("platformName", "windows");
				options.AddAdditionalCapability("automationName", "windows");
				desktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);
				if (desktopSession == null || desktopSession.SessionId == null)
				{
					return false;
				}
			}

			if (root == null)
			{
				AppiumOptions opts = new AppiumOptions();
				opts.AddAdditionalCapability("app", "Root");
				root = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), opts);

				if (root == null || root.SessionId == null)
				{
					return false;
				}

				root.Manage().Timeouts().ImplicitWait =
					TimeSpan.FromSeconds(5);
			}
			ActualReportModel.NewMethod(context.TestName);
			return true;
		}

		public static void TearDown()
		{
			if (root != null)
			{
				root.Close();
				root.Quit();
				root = null;
			}
		}

		public static void Initialize(TestContext context)
		{
			application = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App"; //context.Properties["appName"].ToString();
			winAppDriver = System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
			ActualReportModel = new ReportModel(context);
			
		}

		public static void StopRunningApps()
		{
			AppiumOptions options = new AppiumOptions();
			options.AddAdditionalCapability("app", application);
			options.AddAdditionalCapability("platformName", "windows");
			options.AddAdditionalCapability("automationName", "windows");
			desktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);
			foreach(var handle in desktopSession.WindowHandles){
				desktopSession.SwitchTo().Window(handle);
				desktopSession.Close();
			}
			desktopSession.Quit();
			desktopSession = null;

			winAppDriver.Kill();
			winAppDriver.WaitForExit();
			winAppDriver.Dispose();

			var path = @"C:\Users\MayBee\Desktop\Results\r.txt";
			string all = "";
			all += $"{ActualReportModel.testProjectName}\n";
			foreach(var method in ActualReportModel.methods){
				all += $"Test Method name: {method.methodName} #{method.num}\n";
				all += $"{method.testMethodResult}\n";
				foreach(var _case in method.cases){
					all += $"Case: {_case.num}\n";
					all += $"{_case.info}\n";
					all += $"{_case.element.TagName}\n";
				}
			}
			File.WriteAllText(path, all);
		}
	}
}
