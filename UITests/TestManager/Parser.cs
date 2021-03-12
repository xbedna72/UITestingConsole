using System;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	public interface IParser
	{
		void NewTestCase(string _info);
		IList<string> GetResults();
	}
	public class Parser : IParser
	{
		private IList<string> results = null;

		public Parser()
		{
			results = new List<string>();
		}

		public void NewTestCase(string _info)
		{
			results.Add(_info);
		}

		public IList<string> GetResults(){
			return results;
		}
	}

	public class ParserFactory
	{
		public static IParser GetParserObj(){
			return new Parser();
		}
	}
}
