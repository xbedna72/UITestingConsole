using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UITestingConsole
{
	public static class Parser
	{
		public static SettingObject GetSettings(SettingObject _settingObject, string _path)
		{
			try
			{
				System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(SettingObject));
				StreamReader file = new StreamReader($"{_path}{_settingObject.settingFileName}.xml");
				_settingObject = (SettingObject)reader.Deserialize(file);
				file.Close();
				return (SettingObject)_settingObject;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message.ToString());
			}
		}

		public static void ParseSettings(SettingObject _settingObject, string _path)
		{
			if (_settingObject != null)
			{
				try
				{
					System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(SettingObject));
					var path = $"{_path}{_settingObject.settingFileName}.xml";
					
					if(File.Exists(path)){
						File.Delete(path);
					}
					
					using (FileStream file = File.OpenWrite(path))
					{
						writer.Serialize(file, _settingObject);
						file.Close();
					}
				}
				catch (Exception e)
				{
					throw new Exception(e.Message.ToString());
				}
			}
		}

		public static void InsertAppNameParameter(string appName){
			var path = Environment.CurrentDirectory.Replace("bin\\Debug", ".runsettings.txt");
			string text = File.ReadAllText(path);
			text = text.Replace("***", appName);
			File.WriteAllText(path, text);
		}
	}
}
