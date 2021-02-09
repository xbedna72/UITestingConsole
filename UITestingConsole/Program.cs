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
using FluentArgs;

namespace UITestingConsole
{
	class Program
	{
		public static ConsoleManager consoleManager = null;
		public static string info = "";

		public static void Main(string[] args)
		{
			consoleManager = ConsoleManager.Instance;

			if (args.Count() > 0)
			{
				//FluentArgs to process argumants
				if(!ParseInputArguments(args)){
					ErrorEnd("Wrong input arguments. Ends with Error.");
				}
			}

			consoleManager.InfoMessage("Starting console.");
			try
			{
				consoleManager.StartControl();
				Loop();
			}
			catch (Exception e)
			{
				consoleManager.ErrorMessage(e.Message.ToString());
			}

			End();
		}

		static void Loop()
		{
			while (true)
			{
				Console.Write(">> ");
				consoleManager.input = Console.ReadLine().Split(' ');
				int r = consoleManager.Decision();
				switch (r)
				{
					case 0: //"exit" in input
						return;
					case 1:
						//Process();
						Console.WriteLine("Run");
						break;
					case 2:
						consoleManager.NewSettingFile();
						break;
					case 3:
						if(!consoleManager.Set()){
							consoleManager.ErrorMessage("Unable to set setting file.");
						}
						break;
					case 4:
						consoleManager.ShowAllSettingFiles();
						break;
					case 4:
						consoleManager.ShowListOfSettingFiles();
						break;
					default:
						consoleManager.ErrorMessage("Unknown command or wrong format of argument.");
						break;
				}
			}
		}

		static bool ParseInputArguments(string[] args){
			return FluentArgsBuilder.New().DisallowUnusedArguments()
					.Given.Flag("-l", "--logging").Then(() =>
					{
						consoleManager.Logging = true;
					})
					.Given.Flag("-r", "--run").Then(() =>
					{
						consoleManager.Run = true;
					})
					.Parameter("-sf", "--settingFile")
					.IsOptional()
					.Call(settingFile =>
					{
						consoleManager.settingFile = settingFile;
					}).Parse(args);
		}

		static void End()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Closing Console.");
			Console.ForegroundColor = ConsoleColor.White;
			Thread.Sleep(1000);
			Environment.Exit(0);
		}
		static void ErrorEnd(string _messeage)
		{
			consoleManager.ErrorMessage(_messeage);
			Thread.Sleep(1000);
			Environment.Exit(1);
		}
	}
}
