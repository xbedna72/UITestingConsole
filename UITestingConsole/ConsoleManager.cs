using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static UITestingConsole.Enums;

namespace UITestingConsole
{
	public sealed class ConsoleManager
	{
		public bool runFlag = false;
		private SettingObject settingObject = null;
		public string[] input = null;
		public bool settingFlag = false;

		ConsoleManager()
		{}

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
					if(FindSettingFile(this.input[1]))
					return 3;
				}
			}
			return -2;
		}

		private bool FindSettingFile(string _string){
			return false;
		}

		public bool NewSettingFile()
		{
			settingObject = new SettingObject();
			Console.WriteLine("Creating new setting file");
			string _input = string.Empty;

			_input = Console.ReadLine();
			if (Regex.IsMatch(_input, "^[a-zA-Z0-9]+$"))
			{
				settingObject.SetString(StringType.SettingFileName, _input);
			}
			else
			{
				Console.WriteLine("Wrong formate.");
			}

			return false;
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

		public bool FindAndSet()
		{
			return false;
		}
	}
}
