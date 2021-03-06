using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ReportManager
{
	public class SessionSettingClass
	{
		protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
		protected static WindowsDriver<WindowsElement> desktopSession;
		protected static WindowsDriver<WindowsElement> root;
		protected static string appName = string.Empty;
		static System.Diagnostics.Process winAppDriver = null;
		static System.Diagnostics.Process app = null;

		public static bool Setup(TestContext context)
		{
			if (desktopSession == null)
			{
				try
				{
					AppiumOptions options = new AppiumOptions();
					options.AddAdditionalCapability("app", context.Properties["appName"].ToString());
					options.AddAdditionalCapability("platformName", "windows");
					options.AddAdditionalCapability("automationName", "windows");
					desktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);

					if (desktopSession == null || desktopSession.SessionId == null)
					{
						return false;
					}
				}
				catch (Exception e)
				{}
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

			if (desktopSession != null)
			{
				desktopSession.Close();
				desktopSession.Quit();
				desktopSession = null;
			}
		}

		public static void ExecuteApps(TestContext context)
		{
			winAppDriver = System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
		}

		public static void StopRunningApps(){
			winAppDriver.Kill();
			winAppDriver.WaitForExit();
			winAppDriver.Dispose();
		}
	}
}
