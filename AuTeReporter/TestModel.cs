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
			testProjectName = _parser.ParseProjectName(_testProject);
			methods = new List<TestMethodModel>();
		}

		public void NewMethod(WindowsDriver<WindowsElement> _driver)
		{
			driver = _driver;
			var _newMethod = new TestMethodModel(methods.Count + 1);
			methods.Add(_newMethod);
			actualMethod = _newMethod;
			try
			{
				actualMethod.startScreenshot = _driver.GetScreenshot().AsByteArray;
			}
			catch{}
		}

		public void EndMethod(WindowsDriver<WindowsElement> _driver){
			try{
				actualMethod.endScreenshot = _driver.GetScreenshot().AsByteArray;
			}catch{}
			driver = null;
			actualMethod = null;
		}

		public void NewCase(WindowsElement windowsElement, string xPath = null, string name = null, string accessibilityId = null)
		{
			var newElement = new TestCaseModel(actualMethod.count + 1);
			newElement = _parser.SetInfo(windowsElement, driver, newElement, xPath: xPath, name: name, accessibilityId: accessibilityId);
			actualMethod.AddCase(newElement);
			if(!newElement.result)
			{
				actualMethod.testMethodResult = Enums.TestResult.Failed;
			}
		}

		public void NewNote(string note){
			var newElement = new TestCaseModel(actualMethod.cases.Count + 1);
			newElement = _parser.SetNote(note, newElement);
			actualMethod.AddCase(newElement);
		}
	}

	public class TestMethodModel
	{
		public string methodName = string.Empty;
		public int num;
		public Enums.TestResult testMethodResult = Enums.TestResult.Unknown;
		public IList<TestCaseModel> cases = null;
		public byte[] startScreenshot = null;
		public byte[] endScreenshot = null;
		public int count = 0;

		public TestMethodModel(int _num)
		{
			num = _num;
			cases = new List<TestCaseModel>();
		}
		public void AddCase(TestCaseModel _case){
			if(_case.action == Actions.Note){
				cases.Add(_case);
			}else{
				count += 1;
				cases.Add(_case);
			}
		}
	}

	public class TestCaseModel
	{
		public int num;
		public bool result;
		public string info = "";
		public Element element = null;
		public Enums.Actions action = Enums.Actions.None;

		public TestCaseModel(int _caseNum)
		{
			num = _caseNum;
			element = new Element();
		}
	}

	public class Element
	{
		public string TagName;
		public string Text;
		public Point Location;
		public Size Size;
		public byte[] elementScreenshot = null;
		public byte[] windowScreenshot = null;
	}
}
