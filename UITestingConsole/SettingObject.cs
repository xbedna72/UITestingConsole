using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UITestingConsole.Enums;

namespace UITestingConsole
{
	public class SettingObject
	{
		public string TestPath = string.Empty;
		public string TestName = string.Empty;
		public string AppPath = string.Empty;
		public string AppName = string.Empty;
		public string Executable = string.Empty;
		public string SettingFileName = string.Empty;
		public string SettingsDirectory = string.Empty;
		public bool buildRequest;

		public SettingObject()
		{}
	}
}
