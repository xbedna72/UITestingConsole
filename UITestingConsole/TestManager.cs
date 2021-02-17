using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace UITestingConsole
{
	sealed class TestManager : Base
	{
		private static string devCmd = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat";
		private Process process = null;

		private static readonly object padlock = new object();
		private static TestManager instance = null;
		public static TestManager Instance
		{
			get
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new TestManager();
					}
					return instance;
				}
			}
		}

		public bool Process(SettingObject _object)
		{
			if (_object != null)
			{
				if(_object.buildRequest){
					var name = Regex.Match(_object.sourceProject, '[^\\]*[^\\]*$');
					RunGitScript(_object.sourceProject);
				}
				InfoMessage("Processing");
				return true;
			}
			return false;
		}

		private void RunDevCmd()
		{
			//ProcessStartInfo info = 
			//process = System.Diagnostics.Process.Start(devCmd);
		}

		void RunGitScript(string _path, string _name, bool _flag)
		{
			
		}

		public List<string> TestBuild(IList<string> _list)
		{
			var i = new List<string>();
			foreach (var path in _list)
			{
				
			}
			return i;
		}
	}
}
