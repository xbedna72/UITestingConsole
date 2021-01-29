using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	public class Tools
	{
		public void BaseControl(WindowsElement element, string _element = "")
		{
			string info = string.Empty;
			if (element == null)
			{
				info = $"Unable to find element: {_element}\n";
				
			}
			else
			{
				info = $"Name:{element.TagName} Text:{element.Text} Location-X:{element.Location.X} Location-Y:{element.Location.Y}\n";
				//actualElement = element;
			}
		}

		//Hash jmena screenschotu pro ulozeni snimku + vytisknuti jako atribut k elementu
		private static string CreateHash(DateTime date)
		{
			string val = new TimeSpan(date.Ticks).ToString();
			return val;
		}
	}
}
