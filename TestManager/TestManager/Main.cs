using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.IO;
using Xunit;

namespace TestManager
{
	public class Main
	{
		protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

		protected static WindowsDriver<WindowsElement> desktopSession;
		protected static WindowsDriver<WindowsElement> root;

		public static void Setup(TestContext context)
		{
			if (root == null)
			{
				string ApplicationPath = $"{Directory.GetCurrentDirectory().Replace("\\UITests\\src\\AppiumUITests", string.Empty)}\\FullTest";

				AppiumOptions opts = new AppiumOptions();
				opts.AddAdditionalCapability("app", "Root");
				//opts.AddAdditionalCapability("deviceName", "WindowsPC");
				root = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), opts);

				AppiumOptions options = new AppiumOptions();
				options.AddAdditionalCapability("app", ApplicationPath);
				
				desktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);


				Xunit.Assert.NotNull(desktopSession);
				Xunit.Assert.NotNull(desktopSession.SessionId);

				root.Manage().Timeouts().ImplicitWait =
					TimeSpan.FromSeconds(2.5);

				desktopSession.Manage().Timeouts().ImplicitWait =
					TimeSpan.FromSeconds(2.5);
			}

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

	public static class Helper
	{
		public static WindowsElement FindElementByAbsoluteXPath(
			this WindowsDriver<WindowsElement> MyDesktopSession,
			string xPath,
			int nTryCount = 5)
		{
			WindowsElement uiTarget = null;
			while (nTryCount-- > 0)
			{
				try
				{
					System.Threading.Thread.Sleep(0);
					uiTarget = MyDesktopSession.FindElementByXPath(xPath);
				}
				catch
				{
				}
				if (uiTarget != null)
				{
					break;
				}
				else
				{
					System.Threading.Thread.Sleep(500);
				}
			}
			return uiTarget;
		}
		public static WindowsElement FindElementByAccessibilityId(
			this WindowsDriver<WindowsElement> MyDesktopSession,
			string accessibilityId,
			int nTryCount = 5)
		{
			WindowsElement uiTarget = null;
			while (nTryCount-- > 0)
			{
				try
				{
					uiTarget = MyDesktopSession.FindElementByAccessibilityId(accessibilityId);
				}
				catch
				{
				}
				if (uiTarget != null)
				{
					break;
				}
				else
				{
					System.Threading.Thread.Sleep(500);
				}
			}
			return uiTarget;
		}
		public static WindowsElement FindElementByName(
			this WindowsDriver<WindowsElement> MyDesktopSession,
			string name,
			int nTryCount = 5)
		{
			WindowsElement uiTarget = null;
			while (nTryCount-- > 0)
			{
				try
				{
					uiTarget = MyDesktopSession.FindElementByName(name);
				}
				catch
				{
				}
				if (uiTarget != null)
				{
					break;
				}
				else
				{
					System.Threading.Thread.Sleep(500);
				}
			}
			return uiTarget;
		}
	}
}

