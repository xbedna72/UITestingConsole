using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	public class Tools
	{
		//Hash jmena screenschotu pro ulozeni snimku + vytisknuti jako atribut k elementu
		public IList<string> GetResults(){
			return _parser.GetResults();
		}
	}
}
