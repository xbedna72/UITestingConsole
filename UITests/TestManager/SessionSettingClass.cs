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

		//Will be execute before every  TestClass
		public static bool Setup(TestContext context)
		{
			if (desktopSession == null)
			{
				AppiumOptions options = new AppiumOptions();
				options.AddAdditionalCapability("app", appName);
				options.AddAdditionalCapability("ms:waitForAppLaunch", "20000");
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

		public static void GetContextParameters(TestContext context){
			appName = Convert.ToString(context.Properties["appName"]);
		}
	}
}
