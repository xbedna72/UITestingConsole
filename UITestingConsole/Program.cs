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
		static void Main(string[] args)
		{
			consoleManager = new ConsoleManager();
			if (args.Count() > 0)
			{
				foreach (string arg in args) {
					string[] str = arg.Split(' ');
					if (str[0].Equals("-s")){
						if(str.Length == 2){ 
							consoleManager.settingStringsObject.Group = str[1];
						}else{
							consoleManager.errorFlag = true;
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Wrong -s argument format. Error flag set.");
							Console.ForegroundColor = ConsoleColor.White;
						}
					}
					else if(str[0].Equals("-r")){
						if (str.Length == 2)
						{
							consoleManager.settingStringsObject.buildRequest = (str[1].Contains("Y")| str[1].Contains("y")) ? true : false;
						}
						else
						{
							consoleManager.errorFlag = true;
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Wrong -s argument format. Error flag set.");
							Console.ForegroundColor = ConsoleColor.White;
						}
					}
					else if(str[0].Equals("-Run")){

					}else{
						
					}
				}
			}
			else
			{
				Loop();
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Closing Console.");
			Thread.Sleep(1000);
			Environment.Exit(0);
		}

		static void Loop()
		{
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
					Console.WriteLine("Process");
					break;
				case 2:
					//New setting file
					Console.WriteLine("New setting file");
					break;
				case 3:
					//Set paramethers
					Console.WriteLine("Set paramether");
					break;
				default:
					break;
			}
			Loop();
		}
	}

	class SettingStringsObject
	{
		public string TestPath = string.Empty;
		public string TestName = string.Empty;
		public string AppPath = string.Empty;
		public string AppName = string.Empty;
		public string Group = string.Empty;
		public string SettingsDirectory = string.Empty;
		public bool buildRequest;

		public SettingStringsObject SetupObject()
		{
			return this;
		}

		public void SetTest(StringType type, string _string)
		{
			switch (type)
			{
				case (StringType)0:
					TestPath = _string;
					break;
				case (StringType)1:
					TestName = _string;
					break;
				case (StringType)2:
					AppPath = _string;
					break;
				case (StringType)3:
					AppName = _string;
					break;
				case (StringType)4:
					Group = _string;
					break;
				default:
					break;
			}
			this.TestPath = _string;
		}
	}

	class ConsoleManager{
		public bool errorFlag = false;
		public bool runFlag = false;
		public SettingStringsObject settingStringsObject = null;
		public string input = null;

		public ConsoleManager Create(){
			settingStringsObject = new SettingStringsObject();
			var currDir = Directory.GetCurrentDirectory();
			currDir = Regex.Replace(currDir, @"\\bin\\Debug", @"\\SettingsDirectory", RegexOptions.IgnoreCase);
			if(!File.Exists(currDir)){
				Directory.CreateDirectory(currDir);
			}
			settingStringsObject.SettingsDirectory = currDir;
			return this;
		}
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
			else if (this.input.Equals("new file"))
			{
				return 2;
			}
			return -2;
		}
	}
}
