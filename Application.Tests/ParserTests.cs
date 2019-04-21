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
			sut.LoadInput("SilencePriest");
			sut.DisplayCode();
		}

		[TestMethod]
		public void DeckParserLoadsMany()
		{
			var sut = new DeckParser();
			var filesIn = new List<string>
			{
				"DragonWarrior",
				"WallPriest",
				"ThiefRogue"
			};
			foreach (var item in filesIn)
			{
				sut.LoadInput(item);
				sut.DisplayCode();
			}
		}
	}
}
