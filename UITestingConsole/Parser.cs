using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingConsole
{
	public class Parser : IDisposable
	{
		public Parser()
		{
		}

		public SettingObject GetSettings(string _name, object _settingObject, string _path)
		{
			try
			{
				System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(SettingObject));
				StreamReader file = new StreamReader($"{_path}{_name}.xml");
				_settingObject = (SettingObject)reader.Deserialize(file);
				file.Close();
				return (SettingObject)_settingObject;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message.ToString());
			}
		}

		public void ParseSettings(object _settingObject, string _path, string _name)
		{
			if (_settingObject != null)
			{
				try
				{
					System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(SettingObject));
					var path = $"{_path}{_name}.xml";
					
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

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
