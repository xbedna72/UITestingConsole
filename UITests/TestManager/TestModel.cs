using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static ReportManager.Enums;

namespace ReportManager
{
	public class TestModel
	{
		protected string testName = string.Empty;
		public IList<TestMethodModel> methods = null;
		public TestResult result = TestResult.Unknown;

		public TestModel(string _testName){
			testName = _testName;
			methods = new List<TestMethodModel>();
		}

		public void NewMethod(){
			var _newMethod = new TestMethodModel(this.testName, methods.Count);
			methods.Add(_newMethod);
		}

		public void SetResult(TestResult _result){
			result = _result;
		}
	}

	public class TestMethodModel
	{
		public string testName = string.Empty;
		public int num;
		public IList<TestCaseModel> cases = null;

		public TestMethodModel(string _testName, int _num){
			testName = _testName;
			num = _num;
			cases = new List<TestCaseModel>();
		}
	}

	//Per element
	public class TestCaseModel
	{
		public int num;
		public bool result;
		public byte[] screenshot = null;
		public TestCaseModel()
		{
		}

		public TestCaseModel(int _num){
			num = _num;
		}

		public void SetResult(bool _result){
			this.result = _result;
		}

		public void SetScreenshot(byte[] _screenshot){
			this.screenshot = _screenshot;
		}
	}
}
