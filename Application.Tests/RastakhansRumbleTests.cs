using Domain;
using Domain.Metas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Application.Tests
{
	[TestClass]
	public class RastakhansRumbleTests
	{
		private DeckDetector sut;

		[TestInitialize]
		public void TestInitialize()
		{
			sut = SystemUnderTest();
		}

		private DeckDetector SystemUnderTest()
		{
			return new DeckDetector(RastakhansRumble.LoadMeta());
		}

		[TestMethod]
		public void DeckDetector_OnInstantiation_HasRrMeta()
		{
			Assert.AreEqual(
				expected: "RR",
				actual: sut.CurrentMeta.Code);
		}

		[TestMethod]
		public void DeckDetector_WithRrMeta_HasHas_206_PlayableCards()
		{
			//  top 2 tiers
			var result = sut.PlayableCards();
			Assert.AreEqual(
				expected: 206,
				actual: result.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecks_Returns_16_Decks()
		{
			var results = sut.ListDecks();
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 16,
				actual: results.Count);
		}

		[TestMethod]
		public void DeckDetector_ListPriestDecks_Returns3Decks()
		{
			var results = sut.ListDecks("Priest");
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 3, 
				actual: results.Count);
		}

		[TestMethod]
		public void DeckDetector_HeathDb_HasAllCards()
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
