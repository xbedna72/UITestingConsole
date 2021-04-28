using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReportManager
{
	public interface IParser
	{
		IList<string> GetResults();
		TestCaseModel SetInfo(WindowsElement element, WindowsDriver<WindowsElement> _driver, TestCaseModel _case, string xPath = null, string name=null, string accessibilityId = null);
		string ParseProjectName(string _name);

		TestCaseModel SetNote(string note, TestCaseModel _case);
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

		public TestCaseModel SetInfo(WindowsElement element, WindowsDriver<WindowsElement> _driver, TestCaseModel _case, string xPath = null, string name=null, string accessibilityId = null)
		{
			_case.action = Enums.Actions.Find;
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
					try{
						_case.element.screenshot = _driver.GetScreenshot().AsByteArray;
						_case.element.Size = element.Size;
						_case.element.Location = element.Location;
					}
					catch{
						_case.element.screenshot = null;
					}
				}
				_case.element.Text = element.Text;
				_case.result = true;
			}

			return _case;
		}

		public string ParseProjectName(string _name){
			string[] str = Regex.Split(_name, @"\.");
			return str[str.Length - 1].ToString();
		}

		private static string CreateHash(DateTime date)
		{
			string val = new TimeSpan(date.Ticks).ToString();
			return val;
		}

		public TestCaseModel SetNote(string note, TestCaseModel _case){
			_case.info = note;
			_case.result = true;
			_case.action = Enums.Actions.Note;
			return _case;
		}
	}

	public class ParserFactory
	{
		public static IParser GetParserObj(){
			return new Parser();
		}
	}
}
