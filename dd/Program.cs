using Application;
using CommandLine;
using Domain;
using HsEventStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dd
{
    internal static class Program
    {
		private const string K_DividerLine = "--------------------------------------------------";

		private static void Main(string[] args)
		{
			var dd = new DeckDetector();

			var homeDeck = Environment.GetEnvironmentVariable("HOMEDECK");
#if DEBUG
			homeDeck = "Zoo Warlock";
			Console.WriteLine($"Home Deck is {homeDeck}");
#endif
			var eventStore = new HsEventStore.HsEventStore();
#if DEBUG
			Validate(eventStore,dd);
#endif
			var oppDeck = string.Empty;

			var options = new Options();
			IEnumerable<string> cardsPlayed = new List<string>();

			var result = Parser.Default.ParseArguments<Options>(args)
				.WithParsed(o => options.Report = o.Report)
				.WithParsed(o => options.ReportDate = o.ReportDate)
				.WithParsed(o => options.HeroClass = o.HeroClass)
				.WithParsed(o => options.Opponent = o.Opponent)
				.WithParsed(o => options.Mulligan = o.Mulligan)
				.WithParsed(o => options.Quota = o.Quota)
				.WithParsed(o => cardsPlayed = o.Played);

			if (options.Report != null)
			{
				//  -r 
				dd.Report(
					report: options.Report,
					eventStore: eventStore,
					homeDeck: homeDeck,
					dd: dd,
					reportDate: options.ReportDate,
					heroClass: options.HeroClass,
					quota: GetQuoua(options.Quota));
#if DEBUG
				Console.ReadLine();
#endif
				return;
			}

			if (string.IsNullOrEmpty(options.Opponent))
			{
				var decks = dd.ListDecks(
					heroClass: options.HeroClass,
					played: cardsPlayed.ToArray());

				if (decks.Count == 0)
					Console.WriteLine("Off-Meta Deck");
				else
					oppDeck = DumpDecks(decks);
			}
			else
			{
				oppDeck = options.Opponent;
				var displayDeck = dd.FindDeck(oppDeck);
				if (displayDeck.IsEmpty())
				{
					Console.WriteLine($"{oppDeck} not found");
					return;
				}
				displayDeck.Dump();
			}

			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");

			//if (cardsPlayed.Any())
			//{
			dd.DumpMetaRecord(
				results);
			dd.DumpPreviousMonthRecord(
				results);
			dd.DumpMonthRecord(
				results);
			dd.DumpDeckRecord(
				homeDeck, results);
			dd.DumpDeckMonthRecord(
				homeDeck,
				results);
			dd.DumpRunRecord(
				results);
			dd.DumpDailyRecord(
				results);
			Console.WriteLine(
				value: K_DividerLine);
			dd.DumpDeckRecordVsHero(
				homeDeck,
				results,
				options.HeroClass);
			//}
			dd.DumpNotes(
				homeDeck,
				oppDeck,
				results);
			Console.WriteLine(
				value: K_DividerLine);
			dd.DumpTips(
				homeDeck,
				oppDeck);
			if (!cardsPlayed.Any())
			{
				if (!string.IsNullOrEmpty(options.Mulligan))
					dd.DumpMulligans(
						homeDeck,
						oppDeck,
						options.Mulligan);
			}

			Console.WriteLine();
#if DEBUG
			Console.ReadLine();
#endif
		}

		private static int GetQuoua(string quota)
		{
			if (string.IsNullOrEmpty(quota))
				return 20;
			return Int32.Parse(quota);
		}

#if DEBUG
		private static void Validate(
			HsEventStore.HsEventStore eventStore,
			DeckDetector dd)
		{
			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");
			foreach (var game in results)
			{
				if (! dd.IsValidDeckname(game.HomeDeck) )
					Console.WriteLine($"Unknown deck {game.HomeDeck}");

				if (! dd.IsValidDeckname(game.OpponentDeck))
					Console.WriteLine($"Unknown deck {game.OpponentDeck}");
			}
		}
#endif
		private static string DumpDecks(
			List<Deck> results)
        {
            var deckCount = 0;
			var oppDeck = string.Empty;
            Deck theFirstDeck = new Deck();
            Deck theDeck = new Deck();
            foreach (var deck in results)
            {
                deckCount++;
                if (deckCount == 1)
                    theFirstDeck = deck;
                Console.WriteLine($@"T{
					deck.Tier
					} {
					deck.Name
					} ({
					deck.Rank
					})  {
					deck.Prototype
					}");
                theDeck = deck;
            }
			if (results.Count == 1)
			{
				theDeck.Dump();
				return theDeck.Name;
			}
			else if (deckCount > 1)
			{
				theFirstDeck.Dump();
				return theFirstDeck.Name;
			}
			return oppDeck;
		}
    }
}
