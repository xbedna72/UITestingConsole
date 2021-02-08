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
				FluentArgsBuilder.New()
					.Given.Flag("-l", "--logging").Then(() =>
					{
						consoleManager.Logging = true;
					})
					.Parameter("-sf", "--settingFile")
					.WithDescription("")
					.IsOptional()
					.Call(settingFile =>
					{
						consoleManager.settingFile = settingFile;
					}).Parse(args);
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
						consoleManager.Set();
						break;
					default:
						consoleManager.ErrorMessage("Unknown command or wrong format of argument.");
						break;
				}
			}
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
