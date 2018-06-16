using Domain;
using Domain.Metas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Application.Tests
{
    [TestClass]
    public class DeckDetectorKoboldsTests
    {
        private DeckDetector sut;

        [TestInitialize]
        public void TestInitialize()
        {
            sut = SystemUnderTest();
        }

        private DeckDetector SystemUnderTest()
        {
            return new DeckDetector(KatacombsAndKoboldsPostNerf.LoadMeta());
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
            sut.DumpDecks(results);
        }


        [TestMethod]
        public void DeckDetector_OnInstantiation_HasMc2Meta()
        {
            Assert.AreEqual(
                expected: "KC2",
                actual: sut.CurrentMeta.Code);
        }

        [TestMethod]
        public void DeckDetector_WithMc2Meta_HasHas_319_PlayableCards()
        {
            var result = sut.PlayableCards();
            Assert.AreEqual(
                expected: 319,
                actual: result.Count);
        }

        [TestMethod]
        public void DeckDetector_ListDecks_Returns_27_Decks()
        {
            var results = sut.ListDecks();
            sut.DumpDecks(results);
            Assert.IsTrue(results.Count == 27);
        }

        [TestMethod]
        public void DeckDetector_CanDisplayDeck()
        {
            var heroClass = "Priest";
            var played = new string[]
            {
                "PV"
            };
            var results = sut.ListDecks(heroClass, played);
            sut.DumpDecks(results);
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
            sut.DumpDecks(results);
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
            sut.DumpDecks(results);
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
            sut.DumpDecks(results);
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
            sut.DumpDecks(results);
            Assert.IsTrue(results.Count == 2);
        }


        [TestMethod]
        public void DeckDetector_ListDruidDecksHavingUltimateInfestation_Returns2Decks()
        {
            var heroClass = "D";
            var played = new string[]
            {
                "UI",
            };
            var results = sut.ListDecks(heroClass, played);
            sut.DumpDecks(results);
            Assert.AreEqual(3, results.Count);
        }

        [TestMethod]
        public void DeckDetector_ListDruidDecksHavingWildGrowth_Returns2Decks()
        {
            var heroClass = "D";
            var played = new string[]
            {
                "WG",
            };
            var results = sut.ListDecks(heroClass, played);
            sut.DumpDecks(results);
            Assert.AreEqual(2, results.Count);
        }
    }
}
