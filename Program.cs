using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITestingConsole
{
	class Program
	{
		public static PowerShell ps;
		private static string project_dir = "C:\\Projekty\\PMS2.0-LW\\src";
		private static string project_file = "PMS2.0.sln";

		private static string test_dir = "C:\\Projekty\\PMS2.0-LW\\src\\UITests\\src";
		private static string test_file = "AppiumUITests.sln";
		static void Main()
		{
			Console.WriteLine("UI testing routine___" + DateTime.Now + "__");

			if (!Constructor())
			{
				Console.WriteLine("Unable to open PowerShell command line." +
				"Press any key to ");
				Console.ReadLine();
				return;
			}

			if (InputLanguage.CurrentInputLanguage.Culture.Name != "en-US")
			{
				ChangeSystemLanguage();
			}

			//if (BranchContol(project_dir) < 0)
			//{
			//	return;
			//}

			//PullAndRebuild(project_dir + "\\" + project_file);

			//if (BranchContol(test_dir) < 0)
			//{
			//	return;
			//}

			//PullAndRebuild(test_dir + "\\" + test_file);

			RunDeveloperCmd();
			RunTests();
			EndProcesses();
			Console.WriteLine("Press any key to close window.....");
			Console.ReadLine();
		}

		private static bool Constructor()
		{
			try
			{
				ps = PowerShell.Create();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		private static void ChangeSystemLanguage()
		{
			Console.WriteLine("Language changed");
			ps.AddScript("powershell - command 'Set-WinUserLanguageList -LanguageList en-US -Force'").Invoke();
		}

		private static int BranchContol(string project_dir)
		{
			Console.WriteLine("Starting Branch control");

			ps.AddScript("cd " + project_dir);
			ps.Invoke();
			ps.AddScript("git branch");
			Collection<PSObject> results = ps.Invoke();
			foreach (var branch in results)
			{
				if (Regex.IsMatch(branch.ToString(), "\\*\\s.+"))
				{
					Match match = Regex.Match(branch.ToString(), "\\* Feature#7990");
					if (!match.Success)
					{
						ps.AddScript("git checkout Feature#7990");
						ps.Invoke();
					}
					return 0;
				}
			}

			Console.WriteLine("Unable to find connected branch.");
			return -1;
		}

		private static void PullAndRebuild(string file)
		{
			ps.AddScript("git pull");
			ps.Invoke();
			ps.AddScript("C:\\WINDOWS\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe " + file + " /property:Configuration=Release");
			ps.Invoke();
		}

		private static void RunDeveloperCmd()
		{
			Console.WriteLine("DeveloperOpenning");
			Process.Start("C:\\Program Files (x86)\\Windows Application Driver\\WinAppDriver.exe");
		}

		private static void RunTests()
		{
			Process cmd = new Process();
			cmd.StartInfo.FileName = "\"C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\Tools\\LaunchDevCmd.bat\"";
			cmd.StartInfo.RedirectStandardInput = true;
			cmd.StartInfo.RedirectStandardOutput = true;
			cmd.StartInfo.RedirectStandardError = true;
			cmd.StartInfo.UseShellExecute = false;
			cmd.Start();

			cmd.StandardInput.WriteLine("cd C:\\Projekty\\PMS2.0-LW\\src\\UITests\\src\\AppiumUITests\\bin\\Debug &&" +
			" vstest.console.exe C:\\Projekty\\PMS2.0-LW\\src\\UITests\\src\\AppiumUITests\\bin\\Debug\\AppiumUITests.dll" +
			" /TestAdapterPath:C:\\Projekty\\PMS2.0-LW\\src\\UITests\\src\\AppiumUITests\\bin\\Debug" +
			" /Logger:trx;LogFileName=C:\\Tools\\output.trx;verbosity=detailed") ;
			cmd.StandardInput.Flush();
			cmd.StandardInput.Close();

			Console.WriteLine(cmd.StandardOutput.ReadToEnd());
		}

		private static void EndProcesses() {
			ps.AddScript("powershell -command 'Stop-Process -Name WinAppDriver -Force'");
			ps.Invoke();

			Process[] process_array = Process.GetProcessesByName("FullTest");

			if (process_array.Length != 0)
			{
				ps.AddScript("powershell -command 'Stop-Process -Name FullTest -Force'");
				ps.Invoke();
			}
		}
	}
}
