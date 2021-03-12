using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static ReportManager.Enums;

namespace ReportManager
{
	public class ReportModel
	{
		protected string testProjectName = string.Empty;
		public IList<TestMethodModel> methods = null;
		private TestMethodModel actualMethod = null;
		private static IParser _parser;

		public ReportModel(TestContext context)
		{
			Initialize("name");
		}
		public void Initialize(string _testName)
		{
			_parser = ParserFactory.GetParserObj();
			testProjectName = _testName;
			methods = new List<TestMethodModel>();
		}

		public void NewMethod(string _methodName)
		{
			var _newMethod = new TestMethodModel(this.testProjectName, methods.Count+1);
			methods.Add(_newMethod);
			actualMethod = _newMethod;
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

		public TestCaseModel NewCase(){
			return new TestCaseModel(cases.Count+1);
		}
	}

	//Per element
	public class TestCaseModel
	{
		public int num;
		public bool result;
		public string info;
		public byte[] screenshot = null;
		public Element element = null;

		public TestCaseModel(int _caseNum)
		{
			num = _caseNum;
			element = new Element();
		}

		public void SetResult(bool _result)
		{
			this.result = _result;
		}

		public void SetScreenshot(byte[] _screenshot)
		{
			this.screenshot = _screenshot;
		}

		public void SetInfo(string _info)
		{
			this.info = _info;
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
