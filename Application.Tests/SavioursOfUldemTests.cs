using Domain;
using Domain.Metas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Application.Tests
{
	[TestClass]
	public class SavioursOfUldemTests
	{
		private DeckDetector sut;

		[TestInitialize]
		public void TestInitialize()
		{
			sut = SystemUnderTest();
		}

		private DeckDetector SystemUnderTest()
		{
			return new DeckDetector(SavioursOfUldem.LoadMeta());
		}

		[TestMethod]
		public void DeckDetector_OnInstantiation_HasSuMeta()
		{
			Assert.AreEqual(
				expected: "SU",
				actual: sut.CurrentMeta.Code);
		}

		[TestMethod]
		public void DeckDetector_WithSuMeta_HasHas_357_PlayableCards()
		{
			var result = sut.PlayableCards();
			Assert.AreEqual(
				expected: 357,
				actual: result.Count);
		}


		[TestMethod]
		public void DeckDetector_ListDecks_Returns_34_Decks()
		{
			var results = sut.ListDecks();
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 34,
				actual: results.Count);
		}

		[TestMethod]
		public void DeckDetector_List_pr_Decks_Returns_6_Decks()
		{
			var results = sut.ListDecks("pr");
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 6,
				actual: results.Count);
		}

		[TestMethod]
		public void MageQuery_DoesntFallOver()
		{
			var heroClass = "Mage";
			var played = new string[]
			{
				"aso",
				"ra"
			};
			var results = sut.ListDecks(heroClass, played);
			sut.DumpDecks(results);
			Assert.AreEqual(0, results.Count);
		}

		[TestMethod]
		public void PaladinQuery_DoesntFallOver()
		{
			var heroClass = "Paladin";
			var played = new string[]
			{
				"lh"
			};
			var results = sut.ListDecks(heroClass, played);
			sut.DumpDecks(results);
			Assert.AreEqual(5, results.Count);
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
