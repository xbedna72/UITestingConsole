using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static ReportManager.Enums;

namespace ReportManager
{
	public class ReportModel
	{
		public string testProjectName = string.Empty;
		public string testProjectPath = string.Empty;
		public IList<TestMethodModel> methods = null;
		private TestMethodModel actualMethod = null;
		private static IParser _parser;
		private static WindowsDriver<WindowsElement> driver = null;

		public ReportModel(string _projectName)
		{
			Initialize(_projectName);
		}
		public void Initialize(string _testProject)
		{
			_parser = ParserFactory.GetParserObj();
			testProjectName = _testProject;
			methods = new List<TestMethodModel>();
		}

		public void NewMethod(WindowsDriver<WindowsElement> _driver)
		{
			driver = _driver;
			var _newMethod = new TestMethodModel(methods.Count + 1);
			methods.Add(_newMethod);
			actualMethod = _newMethod;
		}

		public void NewCase(WindowsElement windowsElement, string xPath = null, string name = null, string accessibilityId = null)
		{
			var newElement = new TestCaseModel(actualMethod.cases.Count + 1);
			newElement = _parser.GetInfo(windowsElement, driver, newElement, xPath: xPath, name: name, accessibilityId: accessibilityId);
			actualMethod.cases.Add(newElement);
			if(!newElement.result)
			{
				actualMethod.testMethodResult = Enums.TestResult.Failed;
			}
		}
	}

	public class TestMethodModel
	{
		public string methodName = string.Empty;
		public int num;
		public Enums.TestResult testMethodResult = Enums.TestResult.Unknown;
		public IList<TestCaseModel> cases = null;
		public string screenshot = null;

		public TestMethodModel(int _num)
		{
			num = _num;
			cases = new List<TestCaseModel>();
		}
	}

	//Per element
	public class TestCaseModel
	{
		public int num;
		public bool result;
		public string info = "";
		public Element element = null;
		public MainWindow window = null;

		public TestCaseModel(int _caseNum)
		{
			num = _caseNum;
			element = new Element();
			window = new MainWindow();
		}
	}

	public class Element
	{
		public string TagName;
		public string Text;
		public Point Location;
		public Size Size;
	}

	public class MainWindow
	{
		public byte[] screenshot = null;
		public Point Position;
		public Size Size;
	}
}
