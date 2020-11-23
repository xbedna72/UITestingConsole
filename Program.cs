using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITestingConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("UI testing routine___" + DateTime.Now.ToString() + "___");

			Console.WriteLine("Press any key to close window.....");
			Console.ReadLine();

			Process cmd = new Process();
			cmd.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\LaunchDevCmd.bat";
			cmd.StartInfo.RedirectStandardInput = true;
			cmd.StartInfo.RedirectStandardOutput = true;
			cmd.StartInfo.RedirectStandardError = true;
			cmd.StartInfo.UseShellExecute = false;
			cmd.Start();

			cmd.StandardInput.WriteLine(@"cd C:\\Tools\\UITestingConsole\\TestingFramework\\bin\\Debug &&" +
			@" vstest.console.exe C:\\Tools\\UITestingConsole\\TestingFramework\\bin\\Debug\\AppiumUITests.dll" +
			@" /TestAdapterPath:C:\\Tools\\UITestingConsole\\TestingFramework\\bin\\Debug\\netcoreapp3.1" +
			@" /Logger:trx;LogFileName=C:\\Tools\\Results\\output.trx;verbosity=detailed");
			cmd.StandardInput.Flush();
			cmd.StandardInput.Close();

			Console.WriteLine(cmd.StandardOutput.ReadToEnd());
		}
	}
}
