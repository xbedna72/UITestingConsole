using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	public static class Helper
	{
		private static Tools tools = null;
		public static Tools Tools
		{
			get
			{
				if (tools == null)
				{
					tools = new Tools();
				}
				return tools;
			}
		}
		public static WindowsElement FindByXPath(
			this WindowsDriver<WindowsElement> MyDesktopSession,
			string xPath,
			int nTryCount = 3)
		{
			WindowsElement uiTarget = null;
			while (nTryCount-- > 0)
			{
				try
				{
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
			Tools.GetInfo(uiTarget, xPath);
			return uiTarget;
		}

		public static WindowsElement FindByAccessibilityId(
			this WindowsDriver<WindowsElement> MyDesktopSession,
			string accessibilityId,
			int nTryCount = 3)
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
			Tools.GetInfo(uiTarget, accessibilityId);
			return uiTarget;
		}

		public static WindowsElement FindByName(
			this WindowsDriver<WindowsElement> MyDesktopSession,
			string name,
			int nTryCount = 3)
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
					System.Threading.Thread.Sleep(1000);
				}
			}
			Tools.GetInfo(uiTarget, name);
			return uiTarget;
		}

		public static IList<string> GetResults(){
			return Tools.GetResults();
		}
	}
}
