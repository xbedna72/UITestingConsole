using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	public interface IParser
	{
		IList<string> GetResults();
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

		public void GetInfo(WindowsElement element, string xPath = null, string name = null, string accessibilityId = null)
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
			}
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
