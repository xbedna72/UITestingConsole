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
		//Author: Tom Dykstra and olprod
		//Date: 30. 03. 2017
		//Title: Příklady serializace XML
		//Type: source code and concept of System.Xml.Serialization.XmlSerializer class.
		//Url: https://docs.microsoft.com/cs-cz/dotnet/standard/serialization/examples-of-xml-serialization

		public static SettingObject GetSettings(SettingObject _settingObject, string _path)
		{
			try
			{
//...............................................................................................................................
				System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(SettingObject));
				StreamReader file = new StreamReader($"{_path}{_settingObject.settingFileName}.xml");
				_settingObject = (SettingObject)reader.Deserialize(file);
//...............................................................................................................................
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
//...............................................................................................................................
					System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(SettingObject));
					var path = $"{_path}{_settingObject.settingFileName}.xml";

					if (File.Exists(path))
					{
						File.Delete(path);
					}

					using (FileStream file = File.OpenWrite(path))
					{
						writer.Serialize(file, _settingObject);
						file.Close();
					}
//...............................................................................................................................
				}
				catch (Exception e)
				{
					throw new Exception(e.Message.ToString());
				}
			}
		}

		public static void SetTestDB()
		{
			//string path = @"C:\Users\Administrator\Documents\Projekt\PMS2.0-LW\src\Bin\Debug\FullTest.exe.config";
			//XmlDocument document = new XmlDocument();
			//document.Load(path);

			//XmlNodeList nodes = document.SelectNodes("/configuration/applicationSettings/AppLoader.Properties.Settings/setting");
			//foreach (XmlNode node in nodes)
			//{
			//	XmlAttribute attribute = node.Attributes["name"];

			//	if (attribute != null && attribute.Value == "DEV_MainDatabase")
			//	{
			//		XmlNodeList children = node.ChildNodes;

			//		foreach (XmlNode child in children)
			//		{
			//			child.InnerText = @"Data Source=DEVSRV\SQL2012;Initial Catalog=PMS2_DB_AUTOTESTS;uid=sa;pwd=sa;Connect Timeout=10";
			//			break;
			//		}
			//	}
			//}
			//document.Save(path);
		}
	}
}
