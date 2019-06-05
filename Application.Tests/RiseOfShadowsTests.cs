using Domain;
using Domain.Metas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Application.Tests
{
	[TestClass]
	public class RiseOfShadowsTests
	{
		private DeckDetector sut;

		[TestInitialize]
		public void TestInitialize()
		{
			sut = SystemUnderTest();
		}

		private DeckDetector SystemUnderTest()
		{
			return new DeckDetector(RiseOfShadows.LoadMeta());
		}

		[TestMethod]
		public void DeckDetector_OnInstantiation_HasRsMeta()
		{
			Assert.AreEqual(
				expected: "RS",
				actual: sut.CurrentMeta.Code);
		}

		[TestMethod]
		public void DeckDetector_WithRsMeta_HasHas_232_PlayableCards()
		{
			var result = sut.PlayableCards();
			Assert.AreEqual(
				expected: 232,
				actual: result.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecks_Returns_19_Decks()
		{
			var results = sut.ListDecks();
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 19,
				actual: results.Count);
		}

		[TestMethod]
		public void DeckDetector_List_pr_Decks_Returns_3_Decks()
		{
			var results = sut.ListDecks("pr");
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 3,
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
			Assert.AreEqual(0, results.Count);
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
