using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Tests
{
	[TestClass]
	public class CardParserTests
	{
		[TestMethod]
		public void CardParserLoadsCsv()
		{
			var sut = new CardParser();
			var lines = sut.LoadInput("DoD");
			Assert.IsTrue(lines > 0);
			sut.DisplayCode();
		}
	}
}
