using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuTeReporterTests
{
	[TestClass]
	public class UnitTest1 : ReportManager.ReportManager
	{
		[TestMethod]
		public void EmptyInitialize()
		{
			Initialize("");
		}
	}
}
