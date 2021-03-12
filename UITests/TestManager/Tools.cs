using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	public class Tools
	{
		private static IParser _parser;
		public Tools()
		{
			_parser = ParserFactory.GetParserObj();
		}

		public static void GetInfo(WindowsElement element, string xPath = null, string name = null, string accessibilityId = null)
		{
			string info = string.Empty;
			if (element == null)
			{
				if (xPath != null)
				{
					info = $"Unable to find element by xPath: {xPath}\n";
				}
				else if (name != null)
				{
					info = $"Unable to find element by name: {name}\n";
				}
				else if (accessibilityId != null)
				{
					info = $"Unable to find element by accessibilityId: {accessibilityId}\n";
				}
			}
			else
			{
				info = $"Name:{element.TagName} Text:{element.Text} Location-X:{element.Location.X} Location-Y:{element.Location.Y}\n";
				_parser.NewTestCase(info);
			}
		}

		//Hash jmena screenschotu pro ulozeni snimku + vytisknuti jako atribut k elementu
		private static string CreateHash(DateTime date)
		{
			string val = new TimeSpan(date.Ticks).ToString();
			return val;
		}

		public IList<string> GetResults(){
			return _parser.GetResults();
		}
	}
}
