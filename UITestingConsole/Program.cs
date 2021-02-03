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
		static bool logging = true;

		static void Main(string[] args)
		{
			InfoMessage("Starting console.");
			consoleManager = ConsoleManager.Instance;
			StartControl();

			if (args.Count() > 0)
			{
				//FluentArgs to process argumants	

				//if (!consoleManager.ProcessArguments(consoleManager, args, ref info))
				//{
				//	Console.ForegroundColor = ConsoleColor.Red;
				//	Console.WriteLine(info);
				//	Console.ForegroundColor = ConsoleColor.White;
				//	if (consoleManager.runFlag)
				//	{
				//		Console.WriteLine("Closing Console.");
				//		Thread.Sleep(1000);
				//		Environment.Exit(0);
				//	}
				//}
				//if (consoleManager.runFlag)
				//{
				//	Console.WriteLine("Executing tests.");
				//}
			}
			Loop();
			End();
		}

		static void Loop()
		{
			try
			{
				while (true)
				{
					Console.Write(">>");
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
							Console.WriteLine("New");
							break;
						case 3:
							if (consoleManager.runFlag)
							{
								Console.WriteLine("Run");
								return;
							}
							break;
						default:
							ErrorMessage("Unknown command or wrong format of argument.");
							break;
					}
				}
			}
			catch (Exception e)
			{
				ErrorMessage(e.Message.ToString());
			}
		}

		static void ErrorMessage(string _message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(_message);
			Console.ForegroundColor = ConsoleColor.White;
		}

		static void InfoMessage(string _message)
		{
			if (logging)
			{
				Console.WriteLine(_message);
			}
		}

		static bool StartControl()
		{
			InfoMessage("Control the Setting directory.");
			var path = Directory.GetCurrentDirectory();
			path = Regex.Replace(path, @"\\bin\\Debug.*", @"\SettingDirectory\");
			if (File.Exists(path))
			{
				return true;
			}
			return false;
		}
		static void End()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Closing Console.");
			Console.ForegroundColor = ConsoleColor.White;
			Thread.Sleep(1000);
			Environment.Exit(0);
		}
	}
}
