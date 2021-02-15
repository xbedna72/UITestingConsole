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

		public void TestBuild(IList<string> _list)
		{
			foreach (var path in _list)
			{
				try{
					Microsoft.Build.Evaluation.Project p = new Microsoft.Build.Evaluation.Project(path);
					p.SetGlobalProperty("Configuration", "Release");
					p.Build();
				}catch(Exception e){
					ErrorMessage(e.ToString());
				}
			}
		}
	}
}
