using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingConsole
{
	public class RunSettingFileManager
	{
		public string content = "";

		public RunSettingFileManager()
		{
			content += $"<?xml version=\"1.0\" encoding=\"utf - 8\"?>\n" +
			$"<RunSettings>\n<TestRunParameters>\n";
		}

		public void AddParameter(string _name, string _value)
		{
			content += $"<Parameter name=\"{_name}\" value=\"{_value}\" />\n";
		}

		public void Final()
		{
			content += $"</TestRunParameters>\n</RunSettings>\n";
			CreateRunSettingFile(content);
		}

		private void CreateRunSettingFile(string _content)
		{
			var path = Environment.CurrentDirectory.Replace("bin\\Debug", "runsettings.txt");
			using (FileStream fs = File.Create(path))
			{
				byte[] info = new UTF8Encoding(true).GetBytes(_content);
				fs.Write(info, 0, info.Length);
			}
		}
	}
}