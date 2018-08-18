using Domain;
using Domain.Metas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Application.Tests
{
	[TestClass]
	public class DeckDetectorWitchwoodTests
	{
		private DeckDetector sut;

		[TestInitialize]
		public void TestInitialize()
		{
			sut = SystemUnderTest();
		}

		private DeckDetector SystemUnderTest()
		{
			return new DeckDetector(WitchwoodBalanced.LoadMeta());
		}

		[TestMethod]
		public void DeckDetector_OnInstantiation_HasRw2Meta()
		{
			Assert.AreEqual(
				expected: "RW2",
				actual: sut.CurrentMeta.Code);
		}

		[TestMethod]
		public void DeckDetector_WithRw2Meta_HasHas_326_PlayableCards()
		{
			var result = sut.PlayableCards();
			Assert.AreEqual(
				expected: 323,
				actual: result.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecks_Returns_29_Decks()
		{
			var results = sut.ListDecks();
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 29,
				actual: results.Count );
		}

		[TestMethod]
		public void DeckDetector_ListPriestDecks_Returns3Decks()
		{
			var results = sut.ListDecks("Priest");
			sut.DumpDecks(results);
			Assert.AreEqual(3,results.Count);
		}

		[TestMethod]
		public void DeckDetector_HeathDb_HasAllWitchwoodCards()
		{
			var cards = sut.PlayableCards();
			foreach (var card in cards)
			{
				if ( !HearthDb.Contains(card))
				{
					Console.WriteLine(
						$" [\"{card.Name}\", new CardData [ ManaCost = 0 ] ],"
						);
				}
			}
		}

		[TestMethod]
		public void DeckDetector_ListDecksHavingCertainCards_ReturnsDeck()
		{
			var heroClass = "Hunter";
			var played = new string[]
			{
				"Wandering Monster",
			};
			var results = sut.ListDecks(heroClass, played);
			sut.DumpDecks(results);
		}

		[TestMethod]
		public void DeckDetector_ListWarlockDecksHavingGG_ReturnsEvenWarlok()
		{
			var heroClass = "Warlock";
			var played = new string[]
			{
				"GG"
			};
			var results = sut.ListDecks(heroClass, played);
			sut.DumpDecks(results);
			Assert.AreEqual(1, results.Count);
		}

		[TestMethod]
		public void DeckDetector_ListWarlockDecksHavingLordGodfrey_Returns2Decks()
		{
			var heroClass = "Warlock";
			var played = new string[]
			{
				"Lord Godfrey"
			};
			var results = sut.ListDecks(heroClass, played);
			sut.DumpDecks(results);
			Assert.AreEqual(2, results.Count);
		}


		[TestMethod]
		public void DeckDetector_ListPriestDecksHavingRE_Returns2Deck()
		{
			var heroClass = "Priest";
			var played = new string[]
			{
				"RE"
			};
			var results = sut.ListDecks(heroClass, played);
			sut.DumpDecks(results);
			Assert.AreEqual(1, results.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecksHavingWanderingMonster_ReturnsRecruitHunter()
		{
			var heroClass = "Hunter";
			var played = new string[]
			{
				"ST"
			};
			var results = sut.ListDecks(heroClass, played);
			var containsRecruitHunter = false;
			foreach (var deck in results)
			{
				if (deck.Name == "Recruit Hunter")
					containsRecruitHunter = true;
			}
			Assert.IsTrue(
				containsRecruitHunter, 
				"results should include Recruit Hunter");
		}
	}
}
