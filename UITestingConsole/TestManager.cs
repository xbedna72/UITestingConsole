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
		private static string runSettings = @"C:\Users\mbednarova\source\repos\UITestingConsole\UITestingConsole\.runsettings";

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
			args += $"& ";
			args += $"{_object.testProjectPath} ";
			args += $"/Settings: {runSettings}";
			args += $"/TestAdapther: {_object.testAdapterPath} ";
			Parser.InsertParameter(_object.appName);
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = devCmd;
			startInfo.Arguments = args;
			startInfo.RedirectStandardOutput = true;
			startInfo.RedirectStandardError = true;
			startInfo.UseShellExecute = false;
		}

		void RunGitScript(string _path, string _name, string _flag)
		{
			string scriptPath = Environment.CurrentDirectory.Replace("bin\\Debug", "gitScript.ps1");
			if (!File.Exists(scriptPath))
			{
				throw new Exception("gitScript does not exists.");
			}
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
