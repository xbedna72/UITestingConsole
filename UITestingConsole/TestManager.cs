using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace UITestingConsole
{
	public sealed class TestManager : IDisposable
	{
		private static string devCmd = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat";
		private Process process = null;

		public static bool Process(SettingObject _object)
		{
			if(_object != null){
				
			}

			return false;
		}

		private void RunDevCmd(){
			//ProcessStartInfo info = 
			//process = System.Diagnostics.Process.Start(devCmd);
		}

		public static void TestBuild(IList<string> _list){
			foreach(var path in _list){
				
			}
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
