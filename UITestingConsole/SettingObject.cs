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
		#region Properties
		public List<string> TestProjectPaths;
		public string appName;
		public string executable;
		public string settingFileName;
		public bool buildRequest;
		#endregion
	}
}
