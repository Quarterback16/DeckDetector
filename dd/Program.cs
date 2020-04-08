using Application;
using CommandLine;
using Domain;
using HsEventStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dd
{
    class Program
    {
        static void Main(string[] args)
        {
			var dd = new DeckDetector();

			var homeDeck = Environment.GetEnvironmentVariable("HOMEDECK");
#if DEBUG
			homeDeck = "HSR Mech Paladin";
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
                .WithParsed(o => cardsPlayed = o.Played);

			if (options.Report != null)
			{
				//  -r 
				dd.Report(
					report: options.Report,
					eventStore: eventStore,
					homeDeck: homeDeck,
					dd: dd,
					reportDate: options.ReportDate);
#if DEBUG
				Console.ReadLine();
#endif
				return;
			}

            var decks = dd.ListDecks(
				heroClass: options.HeroClass,
				played: cardsPlayed.ToArray());

            if (decks.Count == 0)
                Console.WriteLine("Off-Meta Deck");
            else
                oppDeck = DumpDecks(decks);

			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");

			if (cardsPlayed.Count() == 0)
			{
				dd.DumpMetaRecord(results);
				dd.DumpPreviousMonthRecord(results);
				dd.DumpMonthRecord(results);
				dd.DumpDeckRecord(homeDeck, results);
				dd.DumpDeckMonthRecord(homeDeck, results);
				dd.DumpRunRecord(results);
				dd.DumpDailyRecord(results);
				Console.WriteLine("-----------------------------------");
				dd.DumpDeckRecordVsHero(
					homeDeck, 
					results, 
					options.HeroClass);
			}
			dd.DumpNotes(homeDeck, oppDeck, results);

            Console.WriteLine();
#if DEBUG
			Console.ReadLine();
#endif
		}

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

		private static string DumpDecks(List<Deck> results)
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
				oppDeck = theDeck.Name;
			}
			else if (deckCount > 1)
			{
				theFirstDeck.Dump();
				oppDeck = theFirstDeck.Name;
			}
			return oppDeck;
		}
    }
}
