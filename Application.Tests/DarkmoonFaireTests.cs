using Domain;
using Domain.Metas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Application.Tests
{
	[TestClass]
	public class DarkoonFaireTests
	{
		private DeckDetector sut;

		[TestInitialize]
		public void TestInitialize()
		{
			sut = SystemUnderTest();
		}

		private DeckDetector SystemUnderTest()
		{
			return new DeckDetector(
				DarkmoonFaire.LoadMeta());
		}

		[TestMethod]
		public void DeckDetector_OnInstantiation_HasCorrectMetaCode()
		{
			Assert.AreEqual(
				expected: "DF",
				actual: sut.CurrentMeta.Code);
		}

		[TestMethod]
		public void DeckDetector_HeathDb_HasAllCards()
		{
			var missingCount = 0;
			var cards = sut.PlayableCards();
			foreach (var card in cards)
			{
				if (!HearthDb.Contains(card))
				{
					Console.WriteLine(
						$" [\"{card.Name}\", new CardData [ ManaCost = 0 ] ],"
						);
					missingCount++;
				}
			}
			Console.WriteLine($"{missingCount} missing");
		}

		[TestMethod]
		public void MetaHasDeck()
		{
			var deck = sut.FindDeck(
				"Miracle Rogue");
			Assert.IsNotNull(deck.Name);
		}

		[TestMethod]
		public void DeckDetector_KnowsMostPopularCards()
		{
			var cards = sut.CardPopularity(
				dump: true);
			Console.WriteLine($"{cards.Count} used");
		}

		[TestMethod]
		public void DeckDetector_Knows_WhichExpensiveCardsMustBeCrafted()
		{
			var cards = sut.CardPopularity(
				dump: true,
				collectablesOnly: true);

			Console.WriteLine($"{cards.Count} collectables");
		}
	}
}
