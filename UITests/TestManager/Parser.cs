using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	public interface IParser
	{
		IList<string> GetResults();
		TestCaseModel GetInfo(WindowsElement element, WindowsDriver<WindowsElement> _driver, TestCaseModel _case, string xPath = null, string name=null, string accessibilityId = null);
	}
	public class Parser : IParser
	{
		private IList<string> results = null;

		public Parser()
		{
			results = new List<string>();
		}

		public IList<string> GetResults(){
			return results;
		}

		public TestCaseModel GetInfo(WindowsElement element, WindowsDriver<WindowsElement> _driver, TestCaseModel _case, string xPath = null, string name=null, string accessibilityId = null)
		{
			if(element == null){
				if(xPath != null){
					_case.info = $"Unable to find element with xPath: {xPath}\n";
				}else if(name != null){
					_case.info = $"Unable to find element with name: {name}\n";
				}else{
					_case.info = $"Unable to find element with accessibilityId: {accessibilityId}\n";
				}
				_case.result = false;
			}
			else{
				_case.element.TagName = element.TagName;
				if(element.TagName.EndsWith("Button")){
					_case.screenshot = _driver.GetScreenshot().AsByteArray;
				}
				_case.element.Text = element.Text;
				_case.element.Size = element.Size;
				_case.element.Location = element.Location;
				_case.result = true;
			}

			return _case;
		}

		private static string CreateHash(DateTime date)
		{
			string val = new TimeSpan(date.Ticks).ToString();
			return val;
		}
	}

	public class ParserFactory
	{
		public static IParser GetParserObj(){
			return new Parser();
		}
	}
}
