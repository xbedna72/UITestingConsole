using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace AuTeRTests
{
	[TestClass]
	public class InputTest
	{
		string pathToExe = "";
		string testSolutionPath = "";
		string testAdapterPath = "";
		ProcessStartInfo start = null;
		private static string calculator = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

		[TestInitialize]
		public void Initialize(){
			string environment = Environment.CurrentDirectory;
			pathToExe = environment.Replace(@"AuTeRTests\bin\x64\Release\netcoreapp3.1", @"AuTeR\bin\Release\AuTeR.exe");
			testSolutionPath = environment.Replace(@"AuTeRTests\bin\x64\Release\netcoreapp3.1", @"UITests\AppiumUITests\AppiumUITests.sln");
			testAdapterPath = environment.Replace(@"AuTeRTests\bin\x64\Release\netcoreapp3.1", @"UITests\AppiumUITests\bin\Debug");
			start = new ProcessStartInfo();
		}

		private int StartConsoleApplication(string arguments)
		{
			// Initialize process here
			Process proc = new Process();
			proc.StartInfo.FileName = pathToExe;
			// add arguments as whole string
			proc.StartInfo.Arguments = arguments;

			// use it to start from testing environment
			proc.StartInfo.UseShellExecute = false;

			// redirect outputs to have it in testing console
			proc.StartInfo.RedirectStandardOutput = true;
			proc.StartInfo.RedirectStandardError = true;

			// set working directory
			proc.StartInfo.WorkingDirectory = Environment.CurrentDirectory;

			// start and wait for exit
			proc.Start();
			proc.WaitForExit();

			// get output to testing console.
			System.Console.WriteLine(proc.StandardOutput.ReadToEnd());
			System.Console.Write(proc.StandardError.ReadToEnd());

			// return exit code
			return proc.ExitCode;
		}

		[TestMethod]
		public void EmptyString()
		{
			Assert.AreEqual(1, StartConsoleApplication(""));
		}

		[TestMethod]
		public void RandomString(){
			start.FileName = pathToExe;
			start.Arguments = "cnaOCASNYV9E8FU}}}}}}}}}}}}}}PL>|MIOAOEHFESFAYNFOAIEHFV7E8F03doihvagfueibcba8ec";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}

		}
		[TestMethod]
		public void WrongTestSolutionPathFormat(){
			start.FileName = pathToExe;
			start.Arguments = "/TestSolutionPath: vDIUVOAEU FAOEIFOE FSOEI W33F798GDVbasebc";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void WrongTestSolutionPathFormat2()
		{
			start.FileName = pathToExe;
			start.Arguments = "/TestSolutionPath: vDIUVOAEU FAOEIFOEFSOEI W33F798GDVbasebc.sln";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void WrongTestSolutionPathFormat3()
		{
			start.FileName = pathToExe;
			start.Arguments = "/TestSolutionPath: vDIUVOAEU\\Fkccccai8730vvfsEFSOEI\\W33F798GDVbasebc.sln";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void WrongTestSolutionPathFormat4()
		{
			start.FileName = pathToExe;
			start.Arguments = "/TestSolutionPath: C:fffff\\vDIUVOAEU\\Fkccccai8730vvfsEFSOEI\\W33F798GDVbasebc.sln";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void WrongTestSolutionPathFormat5()
		{
			start.FileName = pathToExe;
			start.Arguments = "/TestSolutionPath: C:\\vDIUVOAEU\\Fkccccai8730vvfsEFSOEI\\W33F798GDVbasebc.slnfdfbbs";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		public void WrongTestSolutionPathFormat6()
		{
			start.FileName = pathToExe;
			start.Arguments = "/TestSolutionPath: C:\\vDIUVOAEU\\Fkccccai8730vvfsEFSOEI\\W33F798GDVbasebc.s";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void NoTestAdapterPath()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath}";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void NoTestAdapterPath2()
		{
			start.FileName = pathToExe;
			start.Arguments = "/TestSolutionPath: C:\\vDIUVO\\Addddddddddv\\W33F798GDVbasebc.sln /TestAdapterPath:";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void WrongTestAdapterPathFormat1()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: C:vDIUVOAddddddddddv\\W33F798GDVbasebc.sln /Teth:";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void WrongTestAdapterFormat2()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /Teth:";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void WrongTestAdapterFormat3()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /Teth:";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void WrongTestAdapterFormat4()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath:";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void WrongTestAdapterFormat5()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: sgrgaeryab4w56 346	q3#% #52";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void DefinedTestResultsDirectoryButNoInput()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /TestResultsDirectory:";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void UnknownParameterAfterTestsDirectory()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /TestResultsDirectory: C:\\Tools 7s988e ef ";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void DefinedTestResultsDirectoryButRandomInput()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /TestResultsDirectory: C:\\.sEGreaw4565wta4y5e";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void NoExecutableDefined()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath}";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void EmptyExecutableDefined()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: ";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void UnknownParameter()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} -eable: ";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void ExecutableDefinedWrong()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: afdiau3 e 879ef.sln";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void UnknownFlag()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator} -d";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void PullAndBuildFlagWithoutSolution()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator} -b";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void PullAndBuildFlagWrongSolution()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator} -b C:\\randomgdriouhgf";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(proc.ExitCode, 1);
			}
		}

		[TestMethod]
		public void UnknownInputInTheEnd()
		{
			start.FileName = pathToExe;
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator} -b C:\\Some.solution\\neco.sln bairsu ae98rq 3";
			start.WindowStyle = ProcessWindowStyle.Hidden;
			start.CreateNoWindow = true;
			using (Process proc = Process.Start(start))
			{
				proc.WaitForExit();
				Assert.AreEqual(1, proc.ExitCode);
			}
		}

		//Good input, but MSTests has problem with creating needed files. Access denied.
		//[TestMethod]
		//public void GoodInput()
		//{
		//	Assert.AreEqual(0, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator}"));
		//}
	}
}
