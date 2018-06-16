using Domain;
using Domain.Metas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
		public void DeckDetector_WithRw2Meta_HasHas_319_PlayableCards()
		{
			var result = sut.PlayableCards();
			Assert.AreEqual(
				expected: 218,
				actual: result.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecks_Returns_27_Decks()
		{
			var results = sut.ListDecks();
			sut.DumpDecks(results);
			Assert.IsTrue(results.Count == 16);
		}

		[TestMethod]
		public void DeckDetector_ListPriestDecks_Returns4Decks()
		{
			var results = sut.ListDecks("Priest");
			sut.DumpDecks(results);
			Assert.AreEqual(1,results.Count);
		}

	}
}
