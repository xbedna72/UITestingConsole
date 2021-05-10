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
		string output = "";
		string errors = "";

		[TestInitialize]
		public void Initialize() {
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

		[TestMethod]
		public void EmptyString()
		{
			Assert.AreEqual(1, StartConsoleApplication(""));
			Assert.IsTrue(errors.Contains("No arguments passed. Invalid input."));
		}

		[TestMethod]
		public void RandomString() {
			Assert.AreEqual(1, StartConsoleApplication("cnaOCASNYV9E8FU}}}}}}}}}}}}}}PL>|MIOAOEHFESFAYNFOAIEHFV7E8F03doihvagfueibcba8ec"));
			Assert.IsTrue(errors.Contains("Unknown command. Invalid input."));
		}

		[TestMethod]
		public void WrongTestSolutionPathFormat() {
			Assert.AreEqual(1, StartConsoleApplication("/TestSolutionPath: vDIUVOAEU FAOEIFOE FSOEI W33F798GDVbasebc"));
			Assert.IsTrue(errors.Contains("Wrong format of Test solution absolute path.File type.sln."));
		}

		[TestMethod]
		public void WrongTestSolutionPathFormat2()
		{
			Assert.AreEqual(1, StartConsoleApplication("/TestSolutionPath: vDIUVOAEU FAOEIFOEFSOEI W33F798GDVbasebc.sln"));
			Assert.IsTrue(errors.Contains("Wrong format of Test solution absolute path.File type.sln."));
		}

		[TestMethod]
		public void WrongTestSolutionPathFormat3()
		{
			Assert.AreEqual(1, StartConsoleApplication("/TestSolutionPath: vDIUVOAEU\\Fkccccai8730vvfsEFSOEI\\W33F798GDVbasebc.sln"));
			Assert.IsTrue(errors.Contains("Wrong format of Test solution absolute path.File type.sln."));
		}

		[TestMethod]
		public void WrongTestSolutionPathFormat4()
		{
			Assert.AreEqual(1, StartConsoleApplication("/TestSolutionPath: C:fffff\\vDIUVOAEU\\Fkccccai8730vvfsEFSOEI\\W33F798GDVbasebc.sln"));
			Assert.IsTrue(errors.Contains("Wrong format of Test solution absolute path.File type.sln."));
		}

		[TestMethod]
		public void WrongTestSolutionPathFormat5()
		{
			Assert.AreEqual(1, StartConsoleApplication("/TestSolutionPath: C:\\vDIUVOAEU\\Fkccccai8730vvfsEFSOEI\\W33F798GDVbasebc.slnfdfbbs"));
			Assert.IsTrue(errors.Contains("Wrong format of Test solution absolute path.File type.sln."));
		}

		public void WrongTestSolutionPathFormat6()
		{
			Assert.AreEqual(1, StartConsoleApplication("/TestSolutionPath: C:\\vDIUVOAEU\\Fkccccai8730vvfsEFSOEI\\W33F798GDVbasebc.s"));
			Assert.IsTrue(errors.Contains("Wrong format of Test solution absolute path.File type.sln."));
		}

		[TestMethod]
		public void NoTestAdapterPath()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath}"));
			Assert.IsTrue(errors.Contains("Parameter TestAdapterPath is missing."));
		}

		[TestMethod]
		public void UnknownParameterAfterTestSolutionPath()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: C:vDIUVOAddddddddddv\\W33F798GDVbasebc.sln /Teth:"));
			Assert.IsTrue(errors.Contains("Parameter TestAdapterPath is missing."));
		}

		[TestMethod]
		public void NoTestAdapterPath2()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath:"));
			Assert.IsTrue(errors.Contains("Wrong format or empty string to adapter loaction."));
		}

		[TestMethod]
		public void WrongTestAdapterFormat5()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: sgrgaeryab4w56 346	q3#% #52"));
			Assert.IsTrue(errors.Contains("Wrong format or empty string to adapter loaction."));
		}

		[TestMethod]
		public void DefinedTestResultsDirectoryButNoInput()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /TestResultsDirectory:"));
			Assert.IsTrue(errors.Contains("Input path to results directory is empty or not exists."));
		}

		[TestMethod]
		public void UnknownParameterAfterTestsDirectory()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /TestResultsDirectory: C:\\Tools 7s988e ef "));
			Assert.IsTrue(errors.Contains("Input path to results directory is empty or not exists."));
		}

		[TestMethod]
		public void AfterAdapterPathUknowInput()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /somethingElse"));
			Assert.IsTrue(errors.Contains("Unknown parameter. Wrong input."));
		}

		[TestMethod]
		public void NoExecutableDefined()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath}"));
			Assert.IsTrue(errors.Contains("Not defined executable file. Wrong input."));
		}

		[TestMethod]
		public void EmptyExecutableDefined()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: "));
			Assert.IsTrue(errors.Contains("Wrong format or empty string of Executable path."));
		}

		[TestMethod]
		public void UnknownParameter()
		{
			Assert.AreEqual(1, StartConsoleApplication($"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} -eable: "));
			Assert.IsTrue(errors.Contains("Unknown parameter. Wrong input."));
		}

		[TestMethod]
		public void ExecutableDefinedWrong()
		{
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: afdiau3 e 879ef.sln";
			Assert.IsTrue(errors.Contains("Wrong format or empty string of Executable path."));
		}

		[TestMethod]
		public void UnknownFlag()
		{
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator} -q";
			Assert.IsTrue(errors.Contains("Unknown input."));
		}

		[TestMethod]
		public void PullAndBuildFlagWithoutSolution()
		{
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator} -p";
			Assert.IsTrue(errors.Contains("The path into a folder with project solution file is wrong or empty."));
		}

		[TestMethod]
		public void PullAndBuildFlagWrongSolution()
		{
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator} -p C:\\randomgdriouhgf";
			Assert.IsTrue(errors.Contains("The path into a folder with project solution file is wrong or empty."));
		}

		[TestMethod]
		public void UnknownInputInTheEnd()
		{
			start.Arguments = $"/TestSolutionPath: {testSolutionPath} /TestAdapterPath: {testAdapterPath} /Executable: {calculator} -p C:\\Some.solution\\neco -bairsu";
			Assert.IsTrue(errors.Contains("Unknown input."));
		}
	}
}
