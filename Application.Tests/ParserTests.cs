using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Application.Tests
{
	[TestClass]
	public class ParserTests
	{
		[TestMethod]
		public void DeckParserLoadsInput()
		{
			var sut = new DeckParser();
			sut.LoadInput("Handlock");
			sut.DisplayCode();
		}

		[TestMethod]
		public void DeckParserLoadsMany()
		{
			var sut = new DeckParser();
			var filesIn = new List<string>
			{
				"HolyWrathPaladin",
				"MechathunWarrior",
				"MechathunShaman",
				"CycloneGiantsMage"
			};
			foreach (var item in filesIn)
			{
				sut.LoadInput(item);
				sut.DisplayCode();
			}
		}
	}
}
