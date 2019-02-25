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
		public void DeckDetector_WithRrMeta_HasHas_444_PlayableCards()
		{
			var result = sut.PlayableCards();
			Assert.AreEqual(
				expected: 446,
				actual: result.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecks_Returns_51_Decks()
		{
			var results = sut.ListDecks();
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 51,
				actual: results.Count);
		}

		[TestMethod]
		public void DeckDetector_List_pr_Decks_Returns_8_Decks()
		{
			var results = sut.ListDecks("pr");
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 8,
				actual: results.Count);
		}

		[TestMethod]
		public void DeckDetector_ListPriestDecks_Returns_8_Decks()
		{
			var results = sut.ListDecks("Priest");
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 8, 
				actual: results.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecksHavingBaku_IncludesOddMage()
		{
			var heroClass = "Mage";
			var played = new string[]
			{
				"BM"
			};
			var results = sut.ListDecks(heroClass, played);
			var containsCard = false;
			foreach (var deck in results)
			{
				if (   deck.Name == "Odd Control Mage"
					|| deck.Name == "Odd Aggro Mage")
					containsCard = true;
			}
			Assert.IsTrue(
				containsCard,
				"results should include Odd Mage");
		}

		[TestMethod]
		public void DeckDetector_InitialsForAcolyteOfPainAre()
		{
			var cut = new Card { Name = "Acolyte of Pain" };
			var result = cut.Initials();
			Assert.AreEqual(
				"AP",
				result);
		}

		[TestMethod]
		public void DeckDetector_CaseShouldBeInsensitiveForCards()
		{
			var heroClass = "Priest";
			var played = new string[]
			{
				"ap"
			};
			var results = sut.ListDecks(heroClass, played);
			var countAoP = results.Count;
			played = new string[]
			{
				"AP"
			};
			results = sut.ListDecks(heroClass, played);
			var countAOP = results.Count;
			Assert.AreEqual(
				countAoP,
				countAOP);
		}

		[TestMethod]
		public void DeckDetector_CaseShouldBeInsensitiveForHeros()
		{
			var played = new string[]
			{
				"AP"
			};
			var results = sut.ListDecks(
				"Pr", 
				played);
			var countMixed = results.Count;
			played = new string[]
			{
				"AP"
			};
			results = sut.ListDecks(
				"pr", 
				played);
			var countLower = results.Count;
			Assert.AreEqual(
				countMixed,
				countLower);
		}

		[TestMethod]
		public void DeckDetector_ListDecksHavingBaku_ReturnsOddPaladin()
		{
			TestDeckContainsCards(
				heroClass: "Paladin",
				cardsPlayed: new string[] { "BM" },
				deckName: "Odd Paladin" );
		}

		private void TestDeckContainsCards(
			string heroClass,
			string[] cardsPlayed,
			string deckName )
		{
			var results = sut.ListDecks(heroClass, cardsPlayed);
			var containsCard = false;
			foreach (var deck in results)
			{
				Console.WriteLine(deck.Name);
				if (deck.Name == deckName)
					containsCard = true;
			}
			Assert.IsTrue(
				containsCard,
				$"results should include {deckName}");
		}

		[TestMethod]
		public void DeckDetector_ListDecksHavingHct_ReturnsOddRogue()
		{
			var heroClass = "Rogue";
			var played = new string[]
			{
				"HT"
			};
			var results = sut.ListDecks(heroClass, played);
			Console.WriteLine($"{results.Count} decks");
			var containsCard = false;
			foreach (var deck in results)
			{
				Console.WriteLine(deck.Name);
				if (deck.Name == "Odd Rogue")
					containsCard = true;
			}
			Assert.IsTrue(
				containsCard,
				"results should include Odd Rogue");
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
