﻿using System;
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
		private static string runSettings = @"C:\Users\mbednarova\source\repos\UITestingConsole\UITestingConsole\runsettings.txt";

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
			if (_object != null)
			{
				if (_object.buildRequest)
				{
					string[] _string = Regex.Split(_object.sourceProject, "(.+)\\\\(.+)$");
					RunGitScript(_string[0], _string[1], true.ToString());
				}
				RunDevCmd(_object);
				return;
			}
			throw new Exception("Setting object not defined.");
		}

		private void RunDevCmd(SettingObject _object)
		{
			string args = string.Empty;
			args += $"cd C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\Tools && vstest.console.exe {_object.testProjectPath}";
			args += $" /TestAdapterPath:{_object.testAdapterPath}";
			args += $" /Settings:{runSettings}";
			args += $" /ResultsDirectory:{_object.testResults}";
			System.Diagnostics.Process prc = new System.Diagnostics.Process();
			prc.StartInfo.FileName = devCmd;
			prc.StartInfo.Arguments = args;
			prc.StartInfo.CreateNoWindow = true;
			prc.StartInfo.RedirectStandardInput = true;
			prc.StartInfo.RedirectStandardOutput = true;
			prc.StartInfo.RedirectStandardError = false;
			prc.StartInfo.UseShellExecute = false;
			prc.Start();
			prc.WaitForExit();
		}

		void RunGitScript(string _path, string _name, string _flag)
		{
			string scriptPath = Environment.CurrentDirectory.Replace("bin\\Debug", "gitScript.ps1");
			if (!File.Exists(scriptPath))
			{
				throw new Exception("gitScript does not exists.");
			}
			scriptPath = scriptPath.Replace(@"\\", @"\");
			_path = _path.Replace(@"\\", @"\");
			RunScript(scriptPath, _path, _name, _flag);
		}

		public void TestBuild(string _path)
		{
			string[] _string = Regex.Split(_path, "(.+)\\\\(.+)$");
			RunGitScript(_string[1], _string[2], false.ToString());
		}

		private void RunScript(string _script, string _path, string _name, string _flag)
		{
			PowerShell ps = PowerShell.Create();
			ps.AddScript($"{_script} {_path} {_name} {_flag}");
			ps.Invoke();
			if (ps.HadErrors)
			{
				throw new Exception(ps.HadErrors.ToString());
			}
			ps.Dispose();
		}

		public string GetTestProjectPath(string _path){
			string[] _string = Regex.Split(_path, "(.+)\\\\(.+)$");
			string[] _name = Regex.Split(_string[2], "(.+)\\..+$");
			_string[1] += $"\\bin\\Debug\\{_name[1]}.dll";

			return _string[1];
		}

		public string GetTestResultsPath(string _path){
			string[] _string = Regex.Split(_path, "(.+)\\\\(.+)$");

			return _string[1];
		}
	}
}
