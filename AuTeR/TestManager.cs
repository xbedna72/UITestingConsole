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
		//Author: vanco
		//Date: November 10, 2019
		//Title: Execute Command Prompt commands from C#
		//Type: Concept and source code of System.Diagnostic.Process class
		//Url: https://code-ai.mk/execute-command-prompt-commands-from-c/

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
			string devCmd = Directory.Exists(@"C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools") ? @"C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools\Common7\Tools\" : @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\";
			if (_object != null)
			{
				string args = string.Empty;
				args += $"&& cd \"{devCmd}\" && " +
				$"\"C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\TestAgent\\Common7\\IDE\\CommonExtensions\\Microsoft\\TestWindow\\vstest.console.exe\" {_object.testProjectPath}";
				args += $" /TestAdapterPath:{_object.testAdapterPath}";
				args += $" /Settings:{GetRunSettings()}";
				args += $" /ResultsDirectory:{_object.resultsDirectory}";
				InfoMessage(args);
				Process prc = new Process();
				prc.StartInfo.FileName = devCmd + "VsDevCmd.bat";
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
			GetWarnings(RunScript(_string[1], _string[2], true));
		}

		private string RunScript(string _path, string _name, bool _flag)
		{
			string path = _path.Replace(@"\\", @"\");
			string str = null;
			if (_flag)
			{
				Pull(path);
			}
			str = Build(path, _name);
			return str;
		}

		//Author: Terry G. Lee, Gordon Hogenson, John Parente, Dennis Lee, Drew Noakes,
		// Andy Sterland, Mike Jacobs, Genevieve Warren, Mohit Chakraborty, Mike Jones, Saisang Cai
		//Date: 10.12.2018
		//Title: Devenv command-line switches
		//Type: Concept of the tool devenv for building and cleaning project solutions
		//Url: https://docs.microsoft.com/en-us/visualstudio/ide/reference/devenv-command-line-switches?view=vs-2019

		private string Build(string _path, string _name)
		{
			string devCmd = Directory.Exists(@"C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools") ? @"C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools\MSBuild\Current\Bin\MSBuild.exe" : @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe";
			Process process = new Process();
			process.StartInfo.FileName = devCmd;
			process.StartInfo.Arguments = $"{_path}\\{_name} -t:Build";
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
			if (!str.Contains("0 Error(s)") && !str.Contains("Počet chyb: 0"))
			{
				throw new Exception($"Build action failed: {str}");
			}
			InfoMessage($"Build action done: {str}");

			Match split = Regex.Match(str, @"\d [W].*");

			return split.Groups[0].ToString();
		}

		private void Pull(string _path)
		{
			Process process = new Process();
			process.StartInfo.WorkingDirectory = _path;
			process.StartInfo.FileName = @"C:\Windows\system32\cmd.exe";
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.Arguments = $"git pull";
			process.EnableRaisingEvents = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			InfoMessage("Pull done");
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

		private string GetRunSettings()
		{
			string path = @"C:\Users\Administrator\Documents\Tools\bin\Debug\runsettings.txt";
			return path;
		}

		private void TearDown(SettingObject _object)
		{
			CloseRunningSUT(_object.executable);
			RunSettingFileManager.DeleteCreatedSettingFile();
		}

		public string GetTestResultsFolder(string _path)
		{
			string[] res1 = Regex.Split(_path, @"\\bin\\");
			string result = $"{res1[0]}\\TestResults";

			if (!Directory.Exists(result))
			{
				InfoMessage($"Creating TestResults directory in: {result}");
				Directory.CreateDirectory(result);
			}
			return result;
		}
		
		private void GetWarnings(string str)
		{
			ConsoleManager.settingObject.warnings = str;
		}

		private void CloseRunningSUT(string appName)
		{
			foreach(var process in Process.GetProcessesByName(appName)){
				process.Kill();
			}
		}
	}
}
