using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingConsole
{
	public static class RunSettingFileManager
	{
		public static string content = "";
		private static SettingObject settingObject = null;

		public static void CreateSettingFile(SettingObject _object)
		{
			settingObject = _object;
			content += $"<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
			$"<RunSettings>\n\t<TestRunParameters>\n";
			if (settingObject.application != null)
			{
				AddParameter("application", settingObject.application);
			}

			if (settingObject.resultsDirectory != null)
			{
				AddParameter("resultDirectory", settingObject.resultsDirectory);
			}

			if (settingObject.sourceProject != null)
			{
				AddParameter("sourceProject", settingObject.sourceProject);
			}
			else
			{
				AddParameter("sourceProject", "null");
			}

			if (settingObject.testProjectPath != null)
			{
				AddParameter("testProject", settingObject.testProjectPath);
			}
			Final();
		}

		public static void AddParameter(string _name, string _value)
		{
			content += $"\t<Parameter name=\"{_name}\" value=\"{_value}\" />\n";
		}

		public static void Final()
		{
			content += $"\t</TestRunParameters>\n</RunSettings>\n";
			CreateRunSettingFile(content);
		}

		private static void CreateRunSettingFile(string _content)
		{
			var path = Environment.CurrentDirectory.Replace("bin\\Debug", "runsettings.txt");
			try
			{
				using (FileStream fs = File.Create(path))
				{
					byte[] info = new UTF8Encoding(true).GetBytes(_content);
					fs.Write(info, 0, info.Length);
				}
			}
			catch (Exception e)
			{
				throw new Exception($"Unable to create runsetting file.: {e.ToString()}");
			}
		}

		public static void DeleteCreatedSettingFile()
		{
			//try
			//{
			//	File.Delete(Environment.CurrentDirectory.Replace("bin\\Debug", "runsettings.txt"));
			//}
			//catch (Exception e)
			//{
			//	throw new Exception($"Unable to delete runsettingfile.: {e.ToString()}");
			//}
		}
	}
}