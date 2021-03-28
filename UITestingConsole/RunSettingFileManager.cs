using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingConsole
{
	public class RunSettingFileManager
	{
		public string content = "";

		public RunSettingFileManager(){
			content += $"<?xml version=\"1.0\" encoding=\"utf - 8\"?>\n" +
			$"<RunSettings>\n<TestRunParameters>\n";
		}

		public void AddParameter(string _parameter, int _parameter){
			
		}

		public void Final() 
		{
			content += $"</TestRunParameters>\n</RunSettings>\n";
		}
	}
}