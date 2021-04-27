using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UITestingConsole
{
	abstract class Base
	{
		#region IOMethods
		public void ErrorMessage(string _message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			string error = "[ERROR:AuTeR.exe]:" + _message;
			Console.WriteLine(error);
			Console.ForegroundColor = ConsoleColor.White;
		}

		public void InfoMessage(string _message)
		{
			Console.WriteLine(_message);
		}

		public string GetAswer(string _question)
		{
			Console.Write(_question);
			return Console.ReadLine();
		}

		public void End()
		{
			Thread.Sleep(1000);
			Environment.Exit(0);
		}
		public void ErrorEnd(string _messeage)
		{
			ErrorMessage(_messeage);
			Thread.Sleep(1000);
			Environment.Exit(1);
		}
		#endregion
	}
}
