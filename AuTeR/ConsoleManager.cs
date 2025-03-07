﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static UITestingConsole.Enums;

namespace UITestingConsole
{
	sealed class ConsoleManager : Base
	{
		public static SettingObject settingObject = null;
		public string[] input = null;
		public static string directory;
		public string actualSettingFile = null;

		#region Params
		private bool runFlag = false;
		private bool errorInputFlag = false;
		private bool pullFlag = false;
		private bool sendFlag = false;

		public string testName = null;
		public string executable = null;
		public string slnPath = null;
		public string adapterPath = null;
		public string resultsDirestory = null;
		public string emailsPath = null;

		public bool Run
		{
			get { return runFlag; }
			set { runFlag = value; }
		}
		public bool ErrorInput
		{
			get { return errorInputFlag; }
			set { errorInputFlag = value; }
		}
		public bool PullFlag
		{
			get { return pullFlag; }
			set { pullFlag = value; }
		}
		public bool SendFlag
		{
			get { return sendFlag; }
			set { sendFlag = value; }
		}
		#endregion

		ConsoleManager()
		{
			var path = Directory.GetCurrentDirectory();
			directory = Regex.Replace(path, @"\\bin\\Release.*", @"\SettingDirectory\");
		}

		private static readonly object padlock = new object();
		private static ConsoleManager instance = null;
		public static ConsoleManager Instance
		{
			get
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new ConsoleManager();
					}
					return instance;
				}
			}
		}

		public void Process()
		{
			var tm = new TestManager();
			if (actualSettingFile != null)
			{
				if (!GetSettingFileByName(actualSettingFile))
				{
					throw new Exception("Setting file was not found.");
				}
			}
			else
			{
				InputAgumentsProcess(tm);
			}

			LastControl();
			if (settingObject.pull)
			{
				tm.ProjectPullAndBuild(settingObject.sourceProject);
			}
			RunSettingFileManager.CreateSettingFile(settingObject);
			Parser.SetTestDB();
			tm.Run(settingObject);
			return;
		}

		private void LastControl()
		{
			if (!File.Exists(settingObject.testProjectPath))
			{
				throw new Exception("Path to project of tests does not exists.");
			}
			if (!Directory.Exists(settingObject.testAdapterPath))
			{
				throw new Exception("Path to test adapter directory does not exists.");
			}
			if (!Directory.Exists(settingObject.resultsDirectory))
			{
				throw new Exception("Path to result directory does not exists.");
			}
			if (settingObject.sourceProject != null)
			{
				if (!File.Exists(settingObject.sourceProject))
				{
					throw new Exception("Path to source project file does not exists.");
				}
			}

			return;
		}

		private void InputAgumentsProcess(TestManager _tm)
		{
			settingObject = new SettingObject();
			_tm.TestBuild(testName);
			settingObject.testProjectPath = _tm.GetTestProjectPath(testName, adapterPath).Replace(@"\\", @"\");
			settingObject.testAdapterPath = adapterPath.Replace(@"\\", @"\");
			settingObject.resultsDirectory = resultsDirestory == null ? _tm.GetTestResultsFolder(settingObject.testAdapterPath) : resultsDirestory.Replace(@"\\", @"\");
			settingObject.executable = executable.Replace(@"\\", @"\");
			settingObject.pull = PullFlag;
			settingObject.sourceProject = PullFlag ? slnPath.Replace(@"\\", @"\") : null;
		}

		private void SetTestingDatabase()
		{
			
		}

		//Next features....................................................................................................
		#region NextFeature
		public int Decision()
		{
			if (this.input.Length == 1)
			{
				if (this.input[0].Equals("exit", StringComparison.OrdinalIgnoreCase))
				{
					return 0;
				}
				else if (this.input[0].Equals("run", StringComparison.OrdinalIgnoreCase))
				{
					return 1;
				}
				else if (this.input[0].Equals("new", StringComparison.OrdinalIgnoreCase))
				{
					return 2;
				}
				else if (this.input[0].Equals("show", StringComparison.OrdinalIgnoreCase))
				{
					return 4;
				}
			}
			else if (this.input.Length == 2)
			{
				if (this.input[0].Equals("set", StringComparison.OrdinalIgnoreCase))
				{
					return 3;
				}
				else if (this.input[0].Equals("delete", StringComparison.OrdinalIgnoreCase))
				{
					//deleteSettingFile(input[1])
				}
			}
			return -2;
		}
		#endregion

		#region SettingFile
		public void ShowAllSettingFiles()
		{
			string[] all = Directory.GetFiles(directory);
			var formate = String.Format("{0,20} {1,20}\n\n", "LastWriteTime", "Name");
			FileInfo fi = null;
			foreach (string file in all)
			{
				fi = new FileInfo(file);
				formate += String.Format("{0,20} {1,20}\n", fi.LastWriteTimeUtc, fi.Name);
			}
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(formate);
			Console.ForegroundColor = ConsoleColor.White;
		}

		public bool GetSettingFileByName(string _string)
		{
			InfoMessage($"Get Setting File {_string}.");
			if (File.Exists($"{directory}{_string}"))
			{
				try
				{
					settingObject = Parser.GetSettings(new SettingObject(), directory);
					return true;
				}
				catch (Exception e)
				{
					ErrorMessage(e.Message.ToString());
				}
			}
			return false;
		}

		public void NewSettingFile()
		{
			string _input = string.Empty;
			_input = GetAswer("new file name: ");
			if (Regex.IsMatch(_input, "^[a-zA-Z0-9]+$"))
			{
				try
				{
					var s = NewSettingFileArgumentsParser(_input);
					if (s != null)
						Parser.ParseSettings(s, directory);
				}
				catch (Exception e)
				{
					ErrorMessage(e.Message.ToString());
				}
				InfoMessage($"{_input} was created.");
				return;
			}
			Console.WriteLine("Wrong format of file name.");
		}

		public bool SetSettingFile()
		{
			if (GetSettingFileByName(input[1]))
			{
				InfoMessage($"{settingObject.settingFileName} was set.");
				return true;
			}
			ErrorMessage("Setting file was not found.");
			GetAswer("For crating new setting file run command: New [new_file]");
			return false;
		}

		private SettingObject NewSettingFileArgumentsParser(string _settingFileName)
		{
			//var _new = new SettingObject();
			//Console.Write("Absolute path of application under test: ");
			//var _input = Console.ReadLine();
			//if (Regex.IsMatch(_input, "[A-Z]:\\\\([a-zA-Z0-9]+\\\\)*([a-zA-Z0-9]+.exe)"))
			//{
			//	_new.settingFileName = _settingFileName;

			//	_new.executable = _input;
			//	var m = Regex.Match(_input, @"([a-zA-Z0-9]+).exe");
			//	_new.appName = m.Groups[0].Value;

			//	Console.Write("Pull and build project?(Yes/no): ");
			//	_input = Console.ReadLine();
			//	if(_input.Contains("Y")){
			//		_new.buildRequest = true;
			//		Console.Write("Absolute path of file for pull: ");
			//		_new.pullRequest = Console.ReadLine();
			//		Console.Write("Absolute path of source project for builde: ");
			//		_new.sourceProject = Console.ReadLine();
			//	}
			//	else if(_input.Contains("n")){
			//		_new.buildRequest = false;
			//	}
			//	Console.Write("List of absolute paths of test projects (separete with ';'): ");
			//	_input = Console.ReadLine();
			//	_new.TestProjectPaths = _input.Split(';').ToList();
			//	return _new;
			//}
			//else
			//{
			//	throw new Exception("Wrong name format application under test.");
			//}
			return null;
		}
		#endregion

		#region Directory
		public void StartControl()
		{
			if (DirectoryControl(directory))
			{
				InfoMessage("SettingDirectory control was successful.");
			}
			else
			{
				InfoMessage("Creating SettingDirectory.");
				try
				{
					CreateDirectory(directory);
				}
				catch (Exception e)
				{
					ErrorMessage(e.Message.ToString());
				}
			}
		}

		private bool DirectoryControl(string _path)
		{
			bool result = Directory.Exists(_path);
			return result;
		}

		private void CreateDirectory(string _path)
		{
			Directory.CreateDirectory(_path);
			InfoMessage("SettingDirectory created.");
		}
		#endregion
	}
}
