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
		public IList<string> TestPaths
		{
			get;
			set;
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

		public void SetString(StringType type, string _string, IList<string> _list){
			switch((int)type){
				case 0:
					TestPaths = _list;
					break;
				case 1:
					TestName = _string;
					break;
				case 2:
					AppName = _string;
					break;
				case 3:
					Executable = _string;
					break;
				case 4:
					SettingFileName = _string;
					break;
				default:
					break;
			}
		}
	}
}
