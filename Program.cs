using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
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
		private static string project_dir = string.Empty;
		private static string project_name = string.Empty;

		private static string test_dir = string.Empty;
		private static string test_name = string.Empty;

		private static string driver_name = string.Empty;
		private static string driver_dir = string.Empty;
		private static string working_branch = string.Empty;
		static void Main(string[] args)
		{
			Console.WriteLine("UI testing routine___" + DateTime.Now + "__");

			if (!ParseSettingInfo())
			{
				Console.WriteLine("Unable to open SettingFile. Process end silently...");
				Console.WriteLine("Press any key to close window.....");
				Console.ReadLine();
				return;
			}

			if (!Constructor())
			{
				Console.WriteLine("Unable to open PowerShell command line." +
				"Press any key to ");
				Console.ReadLine();
				return;
			}

			//if (BranchContol(project_dir) < 0)
			//{
			//	return;
			//}

			//PullAndRebuild(project_dir + "\\" + project_name);

			//if (BranchContol(test_dir) < 0)
			//{
			//	return;
			//}

			//PullAndRebuild(test_dir + "\\" + test_name);

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

		private static int BranchContol(string project_dir)
		{
			Console.WriteLine("Starting Branch control");

			ps.AddScript("cd " + project_dir);
			ps.Invoke();
			ps.AddScript("git branch");
			Collection<PSObject> results = ps.Invoke();
			foreach (var branch in results)
			{
				if (Regex.IsMatch(branch.ToString(), @"\*\s.+"))
				{
					Match match = Regex.Match(branch.ToString(), @"\* " + working_branch);
					if (!match.Success)
					{
						ps.AddScript("git checkout " + working_branch);
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
			ps.AddScript(@"C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe " + file + " /property:Configuration=Release");
			ps.Invoke();
		}

		private static void RunDeveloperCmd()
		{
			Console.WriteLine("DeveloperOpenning");
			Process.Start(driver_dir + @"\" + driver_name);
		}

		private static void RunTests()
		{
			Process cmd = new Process();
			cmd.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\LaunchDevCmd.bat";
			cmd.StartInfo.RedirectStandardInput = true;
			cmd.StartInfo.RedirectStandardOutput = true;
			cmd.StartInfo.RedirectStandardError = true;
			cmd.StartInfo.UseShellExecute = false;
			cmd.Start();

			cmd.StandardInput.WriteLine("cd C:\\Projekty\\PMS2.0-LW\\src\\UITests\\src\\AppiumUITests\\bin\\Debug &&" +
			" vstest.console.exe C:\\Projekty\\PMS2.0-LW\\src\\UITests\\src\\AppiumUITests\\bin\\Debug\\AppiumUITests.dll" +
			" /TestAdapterPath:C:\\Projekty\\PMS2.0-LW\\src\\UITests\\src\\AppiumUITests\\bin\\Debug" +
			" /Logger:trx;LogFileName=C:\\Tools\\UITestingConsole\\Results\\output.trx;verbosity=detailed");
			cmd.StandardInput.Flush();
			cmd.StandardInput.Close();

			Console.WriteLine(cmd.StandardOutput.ReadToEnd());
		}

		private static void EndProcesses()
		{
			ps.AddScript("powershell -command 'Stop-Process -Name WinAppDriver -Force'");
			ps.Invoke();

			Process[] process_array = Process.GetProcessesByName("FullTest");

			if (process_array.Length != 0)
			{
				ps.AddScript("powershell -command 'Stop-Process -Name FullTest -Force'");
				ps.Invoke();
			}
		}

		private static bool ParseSettingInfo()
		{
			var curDir = Directory.GetCurrentDirectory();
			string settingsFilePath = Regex.Replace(curDir, @"\\bin\\Debug", @"\setting.file.txt");

			string[] content = System.IO.File.ReadAllLines(settingsFilePath);
			string[] splited_string;
			foreach (string line in content)
			{
				if (Regex.IsMatch(line, @"ProjectDirectory:\s.*"))
				{
					splited_string = Regex.Split(line, @"\s_");
					project_dir = splited_string[1];
					project_dir = Regex.Replace(project_dir, @"_", @"");
				}
				else if (Regex.IsMatch(line, @"ProjectName:\s.*"))
				{
					splited_string = Regex.Split(line, @"\s_");
					project_name = splited_string[1];
					project_name = Regex.Replace(project_name, @"_", @"");
				}
				else if (Regex.IsMatch(line, @"TestDirectory:\s.*"))
				{
					splited_string = Regex.Split(line, @"\s_");
					test_dir = splited_string[1];
					test_dir = Regex.Replace(test_dir, @"_", @"");
				}
				else if (Regex.IsMatch(line, @"TestName:\s.*"))
				{
					splited_string = Regex.Split(line, @"\s_");
					test_name = splited_string[1];
					test_name = Regex.Replace(test_name, @"_", @"");
				}
				else if (Regex.IsMatch(line, @"DriverName:\s.*"))
				{
					splited_string = Regex.Split(line, @"\s_");
					driver_name = splited_string[1];
					driver_name = Regex.Replace(driver_name, @"_", @"");
				}
				else if (Regex.IsMatch(line, @"DriverDirectory:\s.*"))
				{
					splited_string = Regex.Split(line, @"\s_");
					driver_dir = splited_string[1];
					driver_dir = Regex.Replace(driver_dir, @"_", @"");
				}
				else if (Regex.IsMatch(line, @"WorkingBranch:\s.*"))
				{
					splited_string = Regex.Split(line, @"\s_");
					working_branch = splited_string[1];
					working_branch = Regex.Replace(working_branch, @"_", @"");
				}

				//Implicitně se při nezadání pracovní branch volí dev.
				if (working_branch == string.Empty)
				{
					working_branch = "dev";
				}
			}

			return driver_dir != string.Empty && driver_name != string.Empty && test_name != string.Empty
			&& test_dir != string.Empty && project_name != string.Empty && project_dir != string.Empty;
		}
	}
}
