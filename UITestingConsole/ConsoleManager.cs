﻿using FluentArgs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static UITestingConsole.Enums;

namespace UITestingConsole
{
	#region ArgumentsClass
	public class Arguments
	{
		public string settingFile;
		private bool logging = false;
		private bool run = false;

		public bool Logging
		{
			get
			{
				return logging;
			}
			set
			{
				logging = value;
			}
		}

		public bool Run
		{
			get
			{
				return run;
			}
			set
			{
				run = value;
			}
		}
	}
	#endregion

	public sealed class ConsoleManager : Arguments
	{
		private static SettingObject settingObject = null;
		public string[] input = null;
		public static string directory;

		ConsoleManager()
		{
			var path = Directory.GetCurrentDirectory();
			directory = Regex.Replace(path, @"\\bin\\Debug.*", @"\SettingDirectory\");
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
			else if(this.input.Length == 2)
			{
				if (this.input[0].Equals("set", StringComparison.OrdinalIgnoreCase))
				{
					return 3;
				}
				else if (this.input[0].Equals("delete", StringComparison.OrdinalIgnoreCase)){
					//deleteSettingFile(input[1])
				}
			}
			return -2;
		}

		public void ShowAllSettingFiles()
		{
			string[] all = Directory.GetFiles(directory);
			var formate = String.Format("{0,20} {1,10}\n\n", "LastWriteTime", "Name");
			FileInfo fi = null;
			foreach (string file in all)
			{
				fi = new FileInfo(file);
				formate += String.Format("{0,20} {1,20}\n", fi.LastWriteTimeUtc, fi.Name);
			}
			Console.WriteLine(formate);
		}

		public bool GetSettingFile(string _string)
		{
			if (File.Exists($"{directory}{_string}.xml"))
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

		public bool NewSettingFile()
		{
			string _input = string.Empty;
			_input = GetAswer("new file name: ");
			if (Regex.IsMatch(_input, "^[a-zA-Z0-9]+$"))
			{
				try
				{
					var s = NewFileArgumentsParser(_input);
					Parser.ParseSettings(s, directory);
				}
				catch (Exception e)
				{
					ErrorMessage(e.Message.ToString());
					return false;
				}
				InfoMessage($"{_input} was created.");
			}
			Console.WriteLine("Wrong formate.");
			return false;
		}

		public void ShowListOfSettingFiles()
		{
			
		}

		public void StartControl()
		{
			if (DirectoryControl(directory))
			{
				InfoMessage("SettingDirectory control was successful.");
			}
			else
			{
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

		//private Dictionary GetDirectory(){
			
		//}

		private void CreateDirectory(string _path)
		{
			Directory.CreateDirectory(_path);
			InfoMessage("SettingDirectory created.");
		}

		public void ErrorMessage(string _message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(_message);
			Console.ForegroundColor = ConsoleColor.White;
		}

		public void InfoMessage(string _message)
		{
			if (Logging)
			{
				Console.WriteLine(_message);
			}
		}

		private string GetAswer(string _question)
		{
			Console.Write(_question);
			return Console.ReadLine();
		}

		public bool Set()
		{
			if (GetSettingFile(input[1]))
			{
				InfoMessage($"{settingObject.SettingFileName} was set.");
				return true;
			}
			ErrorMessage("Setting file was not found.");
			GetAswer("For crating new setting file run command: New [new_file]");
			return false;
		}

		private SettingObject NewFileArgumentsParser(string _settingFileName){
			var _new = new SettingObject();
			Console.Write("Absolute path of the tested application: ");
			var _input = Console.ReadLine();
			if (Regex.IsMatch(_input, "[A-Z]:\\([a-zA-Z0-9]+\\)*([a-zA-Z0-9]+.exe)"))
			{
				//_new.AppName = name;
				
				_new.AppPath = "App Path";
				_new.BuildRequest = false;
				_new.Executable = ".exe";
				_new.TestName = "Test Name";
				_new.TestPath = "c:\\...testPath\\";
				return _new;
			}
			else
			{
				ErrorMessage("Wrong format name of tested application.");
			}
			return null;
		}
	}
}
