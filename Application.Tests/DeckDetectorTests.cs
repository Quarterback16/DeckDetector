using Domain;
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
            return new DeckDetector();
        }

        [TestMethod]
        public void DeckDetector_ListDecksHavingCertainCards_ReturnsDeck()
        {
            var heroClass = "Rogue";
            var played = new string[]
            {
                "Cavern Shinyfinder",

            };
            var results = sut.ListDecks(heroClass, played);
            DumpDecks(results);
        }


        [TestMethod]
        public void DeckDetector_OnInstantiation_HasMc2Meta()
        {
            Assert.AreEqual(
                expected: "MC2",
                actual: sut.CurrentMeta.Code);
        }

        [TestMethod]
        public void DeckDetector_WithMc2Meta_HasHas_320_PlayableCards()
        {
            var result = sut.PlayableCards();
            Assert.AreEqual(
                expected: 320,
                actual: result.Count);
        }

        [TestMethod]
        public void DeckDetector_ListDecks_Returns_27_Decks()
        {
            var results = sut.ListDecks();
            DumpDecks(results);
            Assert.IsTrue(results.Count == 27);
        }

        [TestMethod]
        public void DeckDetector_CardsAllHaveAManaCost()
        {
            Assert.IsTrue(sut.CardsAreValid());
        }

        [TestMethod]
        public void DeckDetector_ListPriestDecks_Returns4Decks()
        {
            var results = sut.ListDecks("Priest");
            DumpDecks(results);
            Assert.IsTrue(results.Count == 4);
        }

        [TestMethod]
        public void DeckDetector_ListPriestDecksHavingRadientElelmental_Returns2Deck()
        {
            var heroClass = "Priest";
            var played = new string[]
            {
                "Radiant Elemental"
            };
            var results = sut.ListDecks(heroClass, played);
            DumpDecks(results);
            Assert.IsTrue(results.Count == 2);
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
            DumpDecks(results);
            Assert.IsTrue(results.Count == 2);
        }

        [TestMethod]
        public void DeckDetector_ListPriestDecksHavingTwoCards_Returns2Decks()
        {
            var heroClass = "Priest";
            var played = new string[]
            {
                "Duskbreaker",
                "Radiant Elemental"
            };
            var results = sut.ListDecks(heroClass, played);
            DumpDecks(results);
            Assert.IsTrue(results.Count == 2);
        }


        private static void DumpDecks(List<Deck> results)
        {
            Deck theDeck = new Deck();
            foreach (var deck in results)
            {
                Console.WriteLine($"T{deck.Tier} {deck.Name} ({deck.Rank})");
                theDeck = deck;
            }
            if ( results.Count == 1 )
            {
                theDeck.Dump();
            }
        }
    }
}
