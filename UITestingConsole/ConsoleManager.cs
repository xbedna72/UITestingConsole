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
	public sealed class ConsoleManager : Parser
	{
		public bool runFlag = false;
		private static SettingObject settingObject = null;
		public string[] input = null;
		public bool settingFlag = false;
		public bool logging = true;
		public static string directory;

		ConsoleManager()
		{
			var path = Directory.GetCurrentDirectory();
			directory = Regex.Replace(path, @"\\bin\\Debug.*", @"\SettingDirectory\");
		}

		private static readonly object padlock = new object();
		private static ConsoleManager instance = null;
		public static ConsoleManager Instance{
			get{
				lock(padlock){
					if(instance == null){
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

		public bool GetSettingFile(string _string){
			
			if(File.Exists($"{directory}{_string}")){
				try{
					settingObject = GetSettings(_string, new SettingObject(), directory);
					return true;
				}catch(Exception e){
					ErrorMessage(e.Message.ToString());
				}
			}
			return false;
		}

		public void NewSettingFile()
		{
			Console.Write("new file: ");
			string _input = string.Empty;
			_input = Console.ReadLine();
			if (Regex.IsMatch(_input, "^[a-zA-Z0-9]+$"))
			{
				try{
					ParseSettings(settingObject, directory, _input);
				}catch(Exception e){
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
			var path = Directory.GetCurrentDirectory();
			path = Regex.Replace(path, @"\\bin\\Debug.*", @"\SettingDirectory");
			if (DirectoryControl(path))
			{
				InfoMessage("SettingDirectory control was successful.");
			}else{
				CreateDirectory(path);
			}
		}

		private bool DirectoryControl(string _path)
		{
			bool result = Directory.Exists(_path);
			return result;
		}

		private void CreateDirectory(string _path){
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
			if (logging)
			{
				Console.WriteLine(_message);
			}
		}

		public void Set(){
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
					InfoMessage("Create new setting file? (Yes/no)");
					var inf = Console.ReadLine();
					if (inf.Contains("Y") || inf.Contains("y"))
					{
						NewSettingFile();
					}
				}
			}
		}

		//public bool ProcessArguments(ConsoleManager manager, string[] args, ref string info)
		//{

		//	foreach (string arg in args)
		//	{
		//		string[] str = arg.Split(' ');
		//		if (str[0].Equals("-s"))
		//		{
		//			if (str.Length == 2)
		//			{
		//				settingObject.SetString(StringType.SettingFileName, str[1]);
		//			}
		//			else
		//			{
		//				info = "Wrong -s argument format. Error flag set.";
		//				return false;
		//			}
		//		}
		//		else if (str[0].Equals("-B"))
		//		{
		//			if (str.Length == 2)
		//			{
		//				settingObject.BuildRequest = (str[1].Contains("Y") | str[1].Contains("y")) ? true : false;
		//			}
		//			else
		//			{
		//				info = "Wrong -s argument format. Error flag set.";
		//				return false;
		//			}
		//		}
		//		else if (str[0].Equals("-R"))
		//		{
		//			manager.runFlag = true;
		//		}
		//		else
		//		{

		//		}
		//	}
		//	return true;
		//}
	}
}
