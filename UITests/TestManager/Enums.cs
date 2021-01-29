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
	}
}
