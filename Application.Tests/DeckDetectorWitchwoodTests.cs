﻿using Domain;
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
		public void DeckDetector_WithRw2Meta_HasHas_326_PlayableCards()
		{
			var result = sut.PlayableCards();
			Assert.AreEqual(
				expected: 326,
				actual: result.Count);
		}

		[TestMethod]
		public void DeckDetector_ListDecks_Returns_28_Decks()
		{
			var results = sut.ListDecks();
			sut.DumpDecks(results);
			Assert.AreEqual(
				expected: 28,
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
	}
}