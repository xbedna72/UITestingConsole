using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	//Zdroj: https://github.com/microsoft/WinAppDriver/blob/master/Tests/AbsoluteXPath/DesktopSession.cs
	//-------------------------------------------------------------------------------------------------
	public static class Helper
	{
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
			if (ReportManager.ActualReportModel != null)
			{
				if(!ReportManager.ActualReportModel.NewCase(uiTarget, xPath: xPath)){
					ReportManager.FailerTask();
				}
			}
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
			if(ReportManager.ActualReportModel != null){
				if(!ReportManager.ActualReportModel.NewCase(uiTarget, accessibilityId: accessibilityId)){
					ReportManager.FailerTask();
				}
			}
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
			if (ReportManager.ActualReportModel != null)
			{
				if(!ReportManager.ActualReportModel.NewCase(uiTarget, name: name)){
					ReportManager.FailerTask();
				}
			}
			return uiTarget;
		}
		//-------------------------------------------------------------------------------------------------
		public static void Note(
			this WindowsDriver<WindowsElement> MyDesktopSession,
			string note,
			int nTryCount = 3)
		{
			if (ReportManager.ActualReportModel != null)
			{
				ReportManager.ActualReportModel.NewNote(note);
			}
		}
	}
}
