using Domain;
using Domain.Metas;
using HsEventStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Application.Tests
{
	[TestClass]
	public class DeckDetectorTests
	{
		private DeckDetector sut;

		[TestInitialize]
		public void TestInitialize()
		{
			sut = SystemUnderTest();
		}

		private DeckDetector SystemUnderTest()
		{
			return new DeckDetector(DescentOfDragons.LoadMeta());
		}

		[TestMethod]
		public void DumpNotes_ForTheMirror_DoesNotDoubleCount()
		{
			var eventStore = new HsEventStore.HsEventStore();
			var events = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");

			sut.DumpNotes(
				homeDeck: "Control Priest",
				oppDeck: "Control Priest",
				results: events);
		}

		[TestMethod]
		public void DumpNotes_ForConjurerMage()
		{
			var eventStore = new HsEventStore.HsEventStore();
			var events = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");

			sut.DumpNotes(
				homeDeck: "Lackey Rogue",
				oppDeck: "Conjurer Mage",
				results: events);
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
		public void DeckDetector_KnowsHeroForDeck()
		{
			var result = sut.DeckHeroClass("Mech Paladin");
			Assert.IsTrue(result == HeroClass.Paladin);
		}
	}
}
