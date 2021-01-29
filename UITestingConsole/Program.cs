using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UITestingConsole.Enums;

namespace UITestingConsole
{
	class Program
	{
		public static ConsoleManager consoleManager = null;
		public static bool settingFlag = false;
		public static string info = "";
		static void Main(string[] args)
		{
			consoleManager = new ConsoleManager();
			if (args.Count() > 0)
			{
				if (!consoleManager.ProcessArguments(args, ref info))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(info);
					Console.ForegroundColor = ConsoleColor.White;
					if (consoleManager.runFlag)
					{
						Console.WriteLine("Closing Console.");
						Thread.Sleep(1000);
						Environment.Exit(0);
					}
				}
				if (consoleManager.runFlag)
				{
					Console.WriteLine("Executing tests.");
				}
			}
			Loop();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Closing Console.");
			Thread.Sleep(1000);
			Environment.Exit(0);
		}

		static void Loop()
		{
			Console.Write(">>");
			consoleManager.input = Console.ReadLine();
			int r = consoleManager.Decision();
			switch (r)
			{
				case -1:
					Console.WriteLine("Wrong format or argument.");
					break;
				case 0:
					return;
				case 1:
					//Process();
					Console.WriteLine("Run");
					break;
				case 2:
					Console.WriteLine("New");
					break;
				default:
					Console.WriteLine("Unknown command.");
					break;
			}

			Loop();
		}
	}

	class ConsoleManager
	{
		public bool runFlag = false;
		public SettingObject settingObject = null;
		public string input = null;

		public int Decision()
		{
			if (this.input.Equals("exit"))
			{
				return 0;
			}
			else if (this.input.Equals("run"))
			{
				return 1;
			}
			else if (this.input.Equals("new setting file"))
			{
				return 2;
			}
			return -2;
		}

		public bool NewSettingFile()
		{
			settingObject = new SettingObject();
			Console.WriteLine("Creating new setting file");
			string _input = string.Empty;

			_input = Console.ReadLine();
			if (Regex.IsMatch(_input, "^[a-zA-Z0-9]+$"))
			{
				settingObject.SettingFileName = _input;
			}
			else
			{
				Console.WriteLine("Wrong formate.");
			}

			return false;
		}

		public bool ProcessArguments(string[] args, ref string info)
		{
			foreach (string arg in args)
			{
				string[] str = arg.Split(' ');
				if (str[0].Equals("-s"))
				{
					if (str.Length == 2)
					{
						settingObject.SettingFileName = str[1];
					}
					else
					{
						info = "Wrong -s argument format. Error flag set.";
						return false;
					}
				}
				else if (str[0].Equals("-r"))
				{
					if (str.Length == 2)
					{
						settingObject.buildRequest = (str[1].Contains("Y") | str[1].Contains("y")) ? true : false;
					}
					else
					{
						info = "Wrong -s argument format. Error flag set.";
						return false;
					}
				}
				else if (str[0].Equals("-Run"))
				{

				}
				else
				{

				}
			}
			return true;
		}

		public bool Parser(){
			Console.Write(">>");
			while(true){
				if(settingObject.SettingFileName != string.Empty){
					
				}else{
					Console.Write("New setting file name: ");
				}
			}

			return false;
		}
	}
}
