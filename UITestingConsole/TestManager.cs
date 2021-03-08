using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.IO;
using System.Management.Automation;

namespace UITestingConsole
{
	sealed class TestManager : Base
	{
		private static string devCmd = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat";

		private static readonly object padlock = new object();
		private static TestManager instance = null;
		public static TestManager Instance
		{
			get
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new TestManager();
					}
					return instance;
				}
			}
		}

		public void Process(SettingObject _object)
		{
			InfoMessage("Process.");
			if (_object != null)
			{
				if (_object.buildRequest)
				{
					InfoMessage("Building solution of system udner test.");
					string[] _string = Regex.Split(_object.sourceProject, "(.+)\\\\(.+)$");
					RunScript(_string[0], _string[1], true.ToString());
				}
				RunDevCmd(_object);
				return;
			}
			throw new Exception("Setting object not defined.");
		}

		private void RunDevCmd(SettingObject _object)
		{
			InfoMessage("Preparing for execution of vstest console.");
			string args = string.Empty;
			args += $"&& cd C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\Tools && vstest.console.exe {_object.testProjectPath}";
			args += $" /TestAdapterPath:{_object.testAdapterPath}";
			args += $" /Settings:{GetRunSettings()}";
			args += $" /ResultsDirectory:{_object.resultsDirectory}";
			System.Diagnostics.Process prc = new System.Diagnostics.Process();
			prc.StartInfo.FileName = devCmd;
			prc.StartInfo.Arguments = args;
			prc.StartInfo.CreateNoWindow = true;
			prc.StartInfo.RedirectStandardInput = true;
			prc.StartInfo.RedirectStandardOutput = true;
			prc.StartInfo.RedirectStandardError = false;
			prc.StartInfo.UseShellExecute = false;
			InfoMessage("Process Start");
			prc.Start();
			InfoMessage("Waiting for exit");
			prc.WaitForExit();
			InfoMessage("End of tests");
			TearDown(_object);
		}
		public void TestBuild(string _path)
		{
			InfoMessage("Preparing for test building process.");
			string[] _string = Regex.Split(_path, "(.+)\\\\(.+)$");
			RunScript(_string[1], _string[2], false.ToString());
			InfoMessage("Done.");
		}

		private void RunScript(string _path, string _name, string _flag)
		{
			_path = _path.Replace(@"\\", @"\");
			PowerShell ps = PowerShell.Create();
			ps.AddScript($"cd {GetScriptsDirectory()}");
			ps.AddScript($".\\gitScript.ps1 {_path} {_name} {_flag}");
			ps.Invoke();
			ps.Dispose();
		}

		public string GetTestProjectPath(string _projectPath, string _adapterPath)
		{
			string[] _string = Regex.Split(_projectPath, "(.+)\\\\(.+)$");
			string[] _name = Regex.Split(_string[2], "(.+)\\..+$");
			var result = $"{_adapterPath}\\{_name[1]}.dll";

			return result;
		}

		public string GetTestResultsPath(string _path)
		{
			string[] _string = Regex.Split(_path, "(.+)\\\\(.+)$");

			return _string[1];
		}

		private string GetScriptsDirectory()
		{
			string path = Regex.Replace(Directory.GetCurrentDirectory(), @"\\bin\\Debug", @"\Scripts");
			return path;
		}

		private string GetRunSettings()
		{
			string path = Regex.Replace(Directory.GetCurrentDirectory(), @"\\bin\\Debug", @"\runsettings.txt");
			return path;
		}

		private void TearDown(SettingObject _object)
		{
			Parser.UpdateRunsetting(_object.application);
		}
	}
}
