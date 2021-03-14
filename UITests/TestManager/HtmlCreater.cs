using System;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	public class HtmlCreater
	{
		string filePath;
		
		public HtmlCreater(string _path){
			filePath = _path;
			GenerateResultFileName();
		}
		public string GenerateResultFileName()
		{
			string _fileName = "Report-";
			DateTime date = DateTime.Now;
			_fileName = $"{_fileName}{date.ToShortTimeString()}.html";
			this.filePath = $"{this.filePath}\\{_fileName}";
			return this.filePath;
		}
	}
}
