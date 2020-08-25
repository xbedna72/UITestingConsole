using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITestingConsole
{
	class Program
	{
		public static PowerShell ps;
		static void Main(string[] args)
		{
			Console.WriteLine("UI testing routine___" + DateTime.Now + "__");
			
			if(!Constructor()){
				Console.WriteLine("Unable to open PowerShell command line." +
				"Press any key to ");
				Console.ReadLine();
			}
			
			Console.WriteLine(InputLanguage.CurrentInputLanguage.Culture.Name);
			if (InputLanguage.CurrentInputLanguage.Culture.Name != "en-US")
			{
				ChangeSystemLanguage();
			}
			Console.WriteLine(InputLanguage.CurrentInputLanguage.Culture.Name);
			Console.ReadLine();
		}

		private static bool Constructor()
		{
			try
			{
				ps = PowerShell.Create();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		private static void ChangeSystemLanguage()
		{
			ps.AddCommand("powershell - command 'Set-WinUserLanguageList -LanguageList en-US -Force'").Invoke();
		}
	}
}
