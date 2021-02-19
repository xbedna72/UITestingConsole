using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.IO;

namespace UITestingConsole
{
	sealed class TestManager : Base
	{
		private static string devCmd = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat";
		private Process process = null;

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
				InfoMessage("Processing");
				return;
			}
			throw new Exception("Setting object not defined.");
		}

		private void RunDevCmd()
		{
			//ProcessStartInfo info = 
			//process = System.Diagnostics.Process.Start(devCmd);
		}

		void RunGitScript(string _path, string _name, string _flag)
		{
			string scriptPath = Environment.CurrentDirectory.Replace("\\bin\\Debug", "gitScript.ps1");
			if (!File.Exists(scriptPath))
			{
				throw new Exception("GitScript does not exists.");
			}
			RunScript(scriptPath, _path, _name, _flag);
		}

		public List<string> TestBuild(IList<string> _list)
		{
			var i = new List<string>();
			foreach (var path in _list)
			{
				string[] _string = Regex.Split(path, "(.+)\\\\(.+)$");
				RunGitScript(_string[0], _string[1], false.ToString());
				i.Add($"_string[0]\\bin\\Debug\\");
			}
			return i;
		}

		private void RunScript(string _script, string _path, string _name, string _flag)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = $"{_script}";
			startInfo.Arguments = $"& {_path} {_name} {_flag}";
			startInfo.RedirectStandardOutput = true;
			startInfo.RedirectStandardError = true;
			startInfo.UseShellExecute = false;
			startInfo.CreateNoWindow = true;
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
			string output = process.StandardOutput.ReadToEnd();
			InfoMessage(output);
			string error = process.StandardError.ReadToEnd();
			if (error.Length > 0)
			{
				throw new Exception(error);
			}
		}
	}
}
