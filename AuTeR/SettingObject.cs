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
		public string testProjectPath;
		public string testAdapterPath;
		public string executable;
		public string settingFileName;
		public bool pull;
		public string sourceProject;
		public string pullRequest;
		public string resultsDirectory;
		public string warnings;
		#endregion
	}
}
