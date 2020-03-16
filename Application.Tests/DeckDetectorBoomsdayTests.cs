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
		public void DeckDetector_WithRbMeta_HasHas_311_PlayableCards()
		{
			var result = sut.PlayableCards();
			Assert.AreEqual(
				expected: 311,
				actual: result.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecks_Returns_28_Decks()
		{
			var results = sut.ListDecks();
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 28,
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

		[TestMethod]
		public void DeckDetector_ListDruidDecksHavingPowerOfTheWild_Returns2Deck()
		{
			var heroClass = "Druid";
			var played = new string[]
			{
				"PW"
			};
			var results = sut.ListDecks(heroClass, played);
			sut.DumpDecks(results);
			Assert.IsTrue(results.Count == 1);
		}

		[TestMethod]
		public void Card_PowerOfTheWild_HasInitialsPW()
		{
			var cut = new Card
			{
				Name = "Power of the Wild"
			};
			var result = cut.Initials();
			Assert.AreEqual("PW", result );
		}

	}
}
