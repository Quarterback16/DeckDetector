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
        public void DeckDetector_OnInstantiation_HasMc2Meta()
        {
            Assert.AreEqual(
                expected: "MC2",
                actual: sut.CurrentMeta.Code);
        }

        [TestMethod]
        public void DeckDetector_ListDecks_Returns2Decks()
        {
            var results = sut.ListDecks();
            DumpDecks(results);
            Assert.IsTrue(results.Count == 11);
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
            foreach (var deck in results)
            {
                Console.WriteLine(deck.Name);
            }
        }
    }
}
