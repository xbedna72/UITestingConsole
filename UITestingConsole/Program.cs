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
		static void Main(string[] args)
		{
			consoleManager = ConsoleManager.Instance;

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
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Closing Console.");
			Thread.Sleep(1000);
			Environment.Exit(0);
		}

		static void Loop()
		{
			while (true)
			{
				Console.Write(">>");
				consoleManager.input = Console.ReadLine().Split(' ');
				int r = consoleManager.Decision();
				switch (r)
				{
					case -1:
						Console.WriteLine("Wrong format or argument.");
						break;
					case 0:	//"exit" in input
						return;
					case 1:
						//Process();
						Console.WriteLine("Run");
						break;
					case 2:
						Console.WriteLine("New");
						break;
					case 3:
						consoleManager.FindAndSet();
						if(consoleManager.runFlag){
							Console.WriteLine("Run");
							return;
						}
						break;
					default:
						Console.WriteLine("Unknown command.");
						break;
				}
			}
		}
	}
}
