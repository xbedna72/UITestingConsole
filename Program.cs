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
			if(!IsWinAppDriverRunning()){
				Console.WriteLine("The WinAppDriver is not running. Console executting.");
				Console.ReadLine();
				return;
			}

			ProcessStartInfo info = new ProcessStartInfo();
			info.CreateNoWindow = false;
			info.UseShellExecute = false;
			info.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\LaunchDevCmd.bat";
			info.RedirectStandardInput = true;
			info.RedirectStandardOutput = true;
			info.RedirectStandardError = true;
			Process cmd = Process.Start(info);

			cmd.StandardInput.WriteLine(@"cd C:\Tools\XUnitTests\bin\\Debug\netcoreapp3.1 &&" +
			@" vstest.console.exe XUnitTests.dll /TestAdapterPath:C:\Tools\XUnitTests\bin\Debug\netcoreapp3.1"+ 
			@"/Logger:trx;LogFileName=C:\Tools\Results\output.trx;verbosity=detailed > C:\Tools\note.txt");
			cmd.StandardInput.Flush();
			cmd.StandardInput.Close();

			Console.WriteLine(cmd.StandardOutput.ReadToEnd());
		}

		static public bool IsWinAppDriverRunning()
		{
			Process[] process = Process.GetProcessesByName("WinAppDriver");
			if (process.Length > 0)
			{
				return true;
			}
			return false;
		}
	}
}
