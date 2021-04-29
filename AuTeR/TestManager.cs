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
using System.Collections.ObjectModel;

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

		public void Run(SettingObject _object)
		{
			if (_object != null)
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
				prc.StartInfo.RedirectStandardError = true;
				prc.StartInfo.UseShellExecute = false;
				InfoMessage("Process Start");
				prc.Start();
				string str = "";
				while (!prc.HasExited)
				{
					str += prc.StandardOutput.ReadToEnd();
				}
				InfoMessage(str);
				TearDown(_object);
				return;
			}
			throw new Exception("Setting object not defined.");
		}

		public void TestBuild(string _path)
		{
			string[] _string = Regex.Split(_path, "(.+)\\\\(.+)$");
			RunScript(_string[1], _string[2], false.ToString());
		}

		public void ProjectPullAndBuild(string _project)
		{
			string[] _string = Regex.Split(_project, "(.+)\\\\(.+)$");
			RunScript(_string[0], _string[1], true.ToString());
		}

		private void RunScript(string _path, string _name, string _flag)
		{
			_path = _path.Replace(@"\\", @"\");
			
			PowerShell ps = PowerShell.Create();
			ps.AddScript($"Set-Location -Path \"{GetScriptsDirectory()}\"");
			ps.AddScript($".\\gitScript.ps1 {_path} {_name} {_flag}");
			

		}

		public string GetTestProjectPath(string _projectPath, string _adapterPath)
		{
			string[] _string = Regex.Split(_projectPath, "(.+)\\\\(.+)$");
			string[] _name = Regex.Split(_string[2], "(.+)\\..+$");
			var result = $"{_adapterPath}\\{_name[1]}.dll";

			if (!File.Exists(result))
			{
				throw new Exception("Path to test adapter file does not exists. Maite because of failer of build process.");
			}

			return result;
		}

		private string GetScriptsDirectory()
		{
			string path = Regex.Replace(Directory.GetCurrentDirectory(), @"\\bin\\Release", @"\Scripts");
			return path;
		}

		private string GetRunSettings()
		{
			string path = Regex.Replace(Directory.GetCurrentDirectory(), @"\\bin\\Release", @"\Scripts\runsettings.txt");
			return path;
		}

		private void TearDown(SettingObject _object)
		{
			RunSettingFileManager.DeleteCreatedSettingFile();
		}

		public string GetTestResultsFolder(string _path)
		{
			string[] res1 = Regex.Split(_path, @"\\bin\\");
			string result = $"{res1[0]}\\TestResults";
			
			if (!Directory.Exists(result))
			{
				Directory.CreateDirectory(result);
			}
			return result;
		}
	}
}
