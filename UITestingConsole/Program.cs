using System;
using System.Collections.Generic;
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
			string currDir = Directory.GetCurrentDirectory();
			currDir = Regex.Replace(currDir, @"\\bin\\Debug", @"\\SettingFile", RegexOptions.IgnoreCase);

			if (File.Exists(currDir))
			{
				
			}
			else
			{
				Console.WriteLine("Unable to locate SettingFile");
			}
			
			Console.ReadKey();
		}
	}
}
