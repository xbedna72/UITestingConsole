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
	public class Arguments{
		public string settingFile;
		private bool logging = false;

		public bool Logging{
			get{
				return logging;
			}
			set{
				logging = value;
			}
		}
	}

	public sealed class ConsoleManager : Arguments
	{
		public bool runFlag = false;
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
			}
			else
			{
				if (this.input[0].Equals("set", StringComparison.OrdinalIgnoreCase))
				{
					return 3;
				}
			}
			return -2;
		}

		public bool GetSettingFile(string _string)
		{

			if (File.Exists($"{directory}{_string}.xml"))
			{
				try
				{
					settingObject = Parser.GetSettings(_string, new SettingObject(), directory);
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
			_input = GetAswer("new file: ");
			if (Regex.IsMatch(_input, "^[a-zA-Z0-9]+$"))
			{
				try
				{
					var s = new SettingObject();
					s.AppName = "App name";
					s.AppPath = "App Path";
					s.BuildRequest = false;
					s.Executable = ".exe";
					s.TestName = "Test Name";
					s.TestPath = "c:\\...testPath\\";
					Parser.ParseSettings(s, directory, _input);
				}
				catch (Exception e)
				{
					ErrorMessage(e.Message.ToString());
				}
			}
			else
			{
				Console.WriteLine("Wrong formate.");
			}
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

		private string GetAswer(string _question){
			Console.Write(_question);
			return Console.ReadLine();
		}

		public void Set()
		{
			if (GetSettingFile(input[1]))
			{
				if (runFlag)
				{
					Console.WriteLine("Run");
					return;
				}
			}
			else
			{
				ErrorMessage("Setting file does not exist.");
				if (runFlag)
				{
					return;
				}
				else
				{
					var inf = GetAswer("Create new setting file? (Yes/no):  ");
					if (inf.Equals("yes", StringComparison.OrdinalIgnoreCase) || inf.Equals("y", StringComparison.OrdinalIgnoreCase))
					{
						NewSettingFile();
					}
				}
			}
		}
	}
}
