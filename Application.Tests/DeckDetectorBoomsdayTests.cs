using Domain;
using Domain.Metas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Application.Tests
{
	[TestClass]
	public class DeckDetectorBoomsdayTests
	{
		private DeckDetector sut;

		[TestInitialize]
		public void TestInitialize()
		{
			sut = SystemUnderTest();
		}

		private DeckDetector SystemUnderTest()
		{
			return new DeckDetector(BoomsDayInitial.LoadMeta());
		}

		[TestMethod]
		public void DeckDetector_OnInstantiation_HasRbMeta()
		{
			Assert.AreEqual(
				expected: "RB",
				actual: sut.CurrentMeta.Code);
		}

		[TestMethod]
		public void DeckDetector_WithRbMeta_HasHas_302_PlayableCards()
		{
			var result = sut.PlayableCards();
			Assert.AreEqual(
				expected: 302,
				actual: result.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecks_Returns_27_Decks()
		{
			var results = sut.ListDecks();
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 27,
				actual: results.Count);
		}

		[TestMethod]
		public void DeckDetector_ListPriestDecks_Returns2Decks()
		{
			var results = sut.ListDecks("Priest");
			sut.DumpDecks(results);
			Assert.AreEqual(2, results.Count);
		}

		[TestMethod]
		public void DeckDetector_HeathDb_HasAllBoomsdayCards()
		{
			var cards = sut.PlayableCards();
			foreach (var card in cards)
			{
				if (!HearthDb.Contains(card))
				{
					Console.WriteLine(
						$" [\"{card.Name}\", new CardData [ ManaCost = 0 ] ],"
						);
				}
			}
		}

	}
}
