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
		private String testPath;
		public String TestPath
		{
			get
			{
				return testPath;
			}
			set
			{
				testPath = value;
			}
		}

		private String testName;
		public String TestName
		{
			get
			{
				return testName;
			}
			set
			{
				testName = value;
			}
		}
		private String appPath;
		public String AppPath
		{
			get
			{
				return appPath;
			}
			set
			{
				appPath = value;
			}
		}
		private String appName;
		public String AppName
		{
			get
			{
				return appName;
			}
			set
			{
				appName = value;
			}
		}
		private String executable;
		public String Executable
		{
			get
			{
				return executable;
			}
			set
			{
				executable = value;
			}
		}
		private String settingFileName;
		public String SettingFileName
		{
			get
			{
				return settingFileName;
			}
			set
			{
				settingFileName = value;
			}
		}
		private String settingsDirectory;
		public String SettingsDirectory
		{
			get
			{
				return settingsDirectory;
			}
			set
			{
				settingsDirectory = value;
			}
		}
		private bool buildRequest;
		public bool BuildRequest
		{
			get
			{
				return buildRequest;
			}
			set
			{
				buildRequest = value;
			}
		}
#endregion

		public SettingObject()
		{}

		public void SetString(StringType type, string _string){
			switch((int)type){
				case 0:
					TestPath = _string;
					break;
				case 1:
					TestName = _string;
					break;
				case 2:
					AppPath = _string;
					break;
				case 3:
					AppName = _string;
					break;
				case 4:
					Executable = _string;
					break;
				case 5:
					SettingFileName = _string;
					break;
				case 6:
					SettingsDirectory = _string;
					break;
				default:
					break;
			}
		}
	}
}
