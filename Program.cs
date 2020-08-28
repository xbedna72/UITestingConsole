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
		public static Process driver;
		private static string project_dir = "C:\\Projekty\\PMS2.0-LW\\src";
		private static string project_file = "PMS2.0.sln";

		private static string test_dir = "C:\\Projekty\\PMS2.0-LW\\src\\UITests\\src";
		private static string test_file = "AppiumUITests.sln";
		static void Main()
		{
			Console.WriteLine("UI testing routine___" + DateTime.Now + "__");

			if (!Constructor()) {
				Console.WriteLine("Unable to open PowerShell command line." +
				"Press any key to ");
				Console.ReadLine();
				return;
			}

			Console.WriteLine(InputLanguage.CurrentInputLanguage.Culture.Name);
			if (InputLanguage.CurrentInputLanguage.Culture.Name != "en-US")
			{
				ChangeSystemLanguage();
			}

			if (BranchContol(project_dir) < 0) {
				return;
			}

			PullAndRebuild(project_dir+"\\"+project_file);

			if (BranchContol(test_dir) < 0)
			{
				return;
			}

			PullAndRebuild(test_dir + "\\" + test_file);

			RunDeveloperCmd();
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

		private static int BranchContol(string project_dir) {
			Console.WriteLine("Starting Branch control");

			ps.AddScript("cd " + project_dir);
			ps.Invoke();
			ps.AddScript("git branch");
			Collection<PSObject> results = ps.Invoke();
			foreach (var branch in results)
			{
				if (Regex.IsMatch(branch.ToString(), "\\*\\s.+")) {
					Match match = Regex.Match(branch.ToString(), "\\* Feature#7990");
					if (!match.Success) {
						ps.AddScript("git checkout Feature#7990");
						ps.Invoke();
					}
					return 0;
				}
			}

			Console.WriteLine("Unable to find connected branch.");
			return -1;
		}

		private static void PullAndRebuild(string file) {
			ps.AddScript("git pull");
			ps.Invoke();
			ps.AddScript("C:\\WINDOWS\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe "+file+" /property:Configuration=Release");
			ps.Invoke();
		}

		private static void RunDeveloperCmd(){
			//driver.
		}
	}
}
