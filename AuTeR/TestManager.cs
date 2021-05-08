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
using System.Collections;

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
				string args = string.Empty;
				args += $"&& cd C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\Tools && vstest.console.exe {_object.testProjectPath}";
				args += $" /TestAdapterPath:{_object.testAdapterPath}";
				args += $" /Settings:{GetRunSettings()}";
				args += $" /ResultsDirectory:{_object.resultsDirectory}";
				Process prc = new Process();
				prc.StartInfo.FileName = devCmd;
				prc.StartInfo.Arguments = args;
				prc.StartInfo.CreateNoWindow = true;
				prc.StartInfo.RedirectStandardInput = true;
				prc.StartInfo.RedirectStandardOutput = true;
				prc.StartInfo.RedirectStandardError = true;
				prc.StartInfo.UseShellExecute = false;
				InfoMessage("Executing test project");
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
			RunScript(_string[1], _string[2], false);
		}

		public void ProjectPullAndBuild(string _project)
		{
			string[] _string = Regex.Split(_project, "(.+)\\\\(.+)$");
			RunScript(_string[0], _string[1], true);
		}

		private void RunScript(string _path, string _name, bool _flag)
		{
			string path = _path.Replace(@"\\", @"\");
			if(_flag){
				Pull(path);
			}
			Clean(path, _name);
			Build(path, _name);
		}

		private void Clean(string _path, string _name){
			Process process = new Process();
			process.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.com";
			process.StartInfo.Arguments = $"{_path}\\{_name} /Clean";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			string str = "";
			while (!process.HasExited)
			{
				str += process.StandardOutput.ReadToEnd();
			}
			InfoMessage($"Clean action done: {str}");
		}

		private void Build(string _path, string _name)
		{
			Process process = new Process();
			process.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.com";
			process.StartInfo.Arguments = $"{_path}\\{_name} /Build";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			string str = "";
			while (!process.HasExited)
			{
				str += process.StandardOutput.ReadToEnd();
			}
			if (!str.Contains("0 failed"))
			{
				throw new Exception($"Clean action failed: {str}");
			}
			InfoMessage($"Build action done: {str}");
		}

		private void Pull(string _path){
			Process process = new Process();
			process.StartInfo.WorkingDirectory = _path;
			process.StartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
			process.StartInfo.Arguments = $"git pull";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			string str = "";
			while (!process.HasExited)
			{
				str += process.StandardOutput.ReadToEnd();
			}
			if (str.Contains("Clean: 1 succeeded, 0 failed, 0 skipped") || str.Contains("Already up to date."))
			{
				InfoMessage($"Pull action done: {str}");
			}
			else{
				throw new Exception($"Clean action failed: {str}");
			}
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
