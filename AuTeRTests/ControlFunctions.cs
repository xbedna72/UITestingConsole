using System;
using System.Collections.Generic;
using System.Text;

namespace AuTeRTests
{
	[TestClass]
	public class ControlFunctions
	{
		string pathToExe = "";
		string testSolutionPath = "";
		string testAdapterPath = "";
		ProcessStartInfo start = null;
		private static string calculator = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
		string output = "";
		string errors = "";

		[TestInitialize]
		public void Initialize()
		{
			string environment = Environment.CurrentDirectory;
			pathToExe = environment.Replace(@"AuTeRTests\bin\x64\Release\netcoreapp3.1", @"AuTeR\bin\x64\Release\AuTeR.exe");
			testSolutionPath = environment.Replace(@"AuTeRTests\bin\x64\Release\netcoreapp3.1", @"UITests\AppiumUITests.sln");
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
			errors += proc.StandardOutput.ReadToEnd();

			// return exit code
			return proc.ExitCode;
		}

		//Good input, but MSTests has problem with creating needed files. Access denied.
		[TestMethod]
		public void GoodInput()
		{
			StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator}");
			Assert.IsTrue(output.Contains("Access denied"));
		}
	}
}
