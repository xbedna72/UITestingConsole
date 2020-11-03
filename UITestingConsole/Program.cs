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
		public static SettingStringsObject settingStringsObject = null;
		static void Main(string[] args)
		{
			settingStringsObject = new SettingStringsObject();
			var currDir = Directory.GetCurrentDirectory();
			currDir = Regex.Replace(currDir, @"\\bin\\Debug", @"\\SettingFile", RegexOptions.IgnoreCase);

			if (File.Exists(currDir))
			{
				using (new Parser(currDir, settingStringsObject)){

				}
			}
			else
			{
				Console.WriteLine("Unable to locate SettingFile");
			}

			Console.ReadKey();
		}
	}

	class SettingStringsObject
	{
		public string TestPath = string.Empty;
		public string TestName = string.Empty;
		public string AppPath = string.Empty;
		public string AppName = string.Empty;

		public SettingStringsObject SetupObject(){
			return this;
		}

		public void SetTestPath(StringType type, string _string){
			switch (type) {
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
				default:
					break;
			}
			this.TestPath = _string;
		}
	}
}
