﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
		public IList<TestMethodModel> methods = null;
		private TestMethodModel actualMethod = null;
		private static IParser _parser;

		public ReportModel(string _projectName)
		{
			Initialize(_projectName);
		}
		public void Initialize(string _testName)
		{
			_parser = ParserFactory.GetParserObj();
			testProjectName = _testName;
			methods = new List<TestMethodModel>();
		}

		public void NewMethod(string _methodName)
		{
			var _newMethod = new TestMethodModel(this.testProjectName, methods.Count + 1);
			methods.Add(_newMethod);
			actualMethod = _newMethod;
		}

		public void NewCase(WindowsElement windowsElement, string xPath = null, string name = null, string accessibilityId = null)
		{
			var newElement = new TestCaseModel(actualMethod.cases.Count + 1);
			newElement = _parser.GetInfo(windowsElement, newElement, xPath: xPath, name: name, accessibilityId: accessibilityId);
			actualMethod.cases.Add(newElement);
			if(!newElement.result){
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

		public TestMethodModel(string _methodName, int _num)
		{
			methodName = _methodName;
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
		public string screenshot = null;
		public Element element = null;

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
	}
}
