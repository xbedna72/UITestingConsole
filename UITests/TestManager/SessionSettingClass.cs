using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportManager
{
	public class SessionSettingClass
	{
		protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
		protected static WindowsDriver<WindowsElement> desktopSession;
		protected static WindowsDriver<WindowsElement> root;
		protected static string applicationPath = $"C:\\Projekty\\PMS2.0-LW\\src\\Bin\\Debug\\FullTest";

		//Will be execute before every  TestClass
		public static bool Setup(TestContext context, string applicationPath)
		{
			if (desktopSession == null)
			{
				AppiumOptions options = new AppiumOptions();
				options.AddAdditionalCapability("app", applicationPath);
				desktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);

				if (desktopSession == null || desktopSession.SessionId == null){
					return false;
				}

				desktopSession.Manage().Timeouts().ImplicitWait =
					TimeSpan.FromSeconds(2.5);
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
					TimeSpan.FromSeconds(2.5);
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
	}
}
