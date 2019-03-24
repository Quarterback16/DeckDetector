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
			return new DeckDetector(RastakhansRumble.LoadMeta());
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
	}
}
