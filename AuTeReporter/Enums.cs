using System;
using System.Collections.Generic;
using System.Text;

namespace ReportManager
{
	public class Enums
	{
		public enum TestResult{
			Failed=0,
			Passed=2,
			Error=4,
			Timeout=5,
			Unknown=7,
			NotRunnable=8
		}

		public enum Actions{
			Find=0,
			Click=1,
			SendKey=2,
			CheckAtribute=3,
			Note=4,
			None=-1
		}
	}
}
