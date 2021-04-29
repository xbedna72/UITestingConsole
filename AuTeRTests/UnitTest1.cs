using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace AuTeRTests
{
	[TestClass]
	public class UnitTest1
	{
		string pathToExe = "";

		[TestInitialize]
		public void Initialize(){
			pathToExe = Environment.CurrentDirectory.Replace(@"AuTeRTests\bin\x64\Release\netcoreapp3.1", @"AuTeR\bin\Release\AuTeR.exe");
		}

		[TestMethod]
		public void TestMethod1()
		{
			Assert.IsNotNull(pathToExe);
			Process process = new Process();
			process.StartInfo.FileName = pathToExe;
		}
	}
}
