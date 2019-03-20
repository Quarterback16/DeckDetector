﻿using Application;
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
			homeDeck = "Control Priest";
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
				.WithParsed(o => options.HeroClass = o.HeroClass)
                .WithParsed(o => cardsPlayed = o.Played);

			if (options.Report != null)
			{
				FrequencyReport(eventStore);
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

			DumpNotes(homeDeck, oppDeck, eventStore);

            Console.WriteLine();
#if DEBUG
			Console.ReadLine();
#endif
		}

		private static void FrequencyReport(
			HsEventStore.HsEventStore eventStore)
		{
			var d = new Dictionary<string, int>();
			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");
			foreach (var game in results)
			{
				if (d.ContainsKey(game.OpponentDeck))
					d[game.OpponentDeck]++;
				else
					d.Add(game.OpponentDeck, 1);
			}
			Console.WriteLine($"Frequency Report          {results.Count()}");
			var myList = d.ToList();
			myList.Sort(
				(pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
			foreach (KeyValuePair<string, int> pair in myList)
			{
				Console.WriteLine("  {0,-24} {1}",
					pair.Key,
					pair.Value);
			}
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

		private static void DumpNotes(
			string homeDeck, 
			string oppDeck,
			HsEventStore.HsEventStore eventStore)
		{
			var notes = new List<string>();
			var gameCount = 0;
			var wins = 0;
			var losses = 0;

			var results = (List<HsGamePlayedEvent>) 
				eventStore.Get<HsGamePlayedEvent>("game-played");
			foreach (var game in results)
			{
				if (game.HomeDeck == homeDeck
					&& game.OpponentDeck == oppDeck)
				{
					gameCount++;
					if (game.Result.Equals("win"))
					{
						notes.Add($"W-F-{game.Notes}");
						wins++;
					}
					else
					{
						notes.Add($"L-F-{game.Notes}");
						losses++;
					}
				}
				if (game.OpponentDeck == homeDeck
					&& game.HomeDeck == oppDeck)
				{
					gameCount++;
					if (game.Result.Equals("win"))
					{
						notes.Add($"L-A-{game.Notes}");
						losses++;
					}
					else
					{
						notes.Add($"W-A-{game.Notes}");
						wins++;
					}
				}
			}
			var monthRecord = MonthRecord(results);
			Console.WriteLine(monthRecord.ToString());
			var deckRecord = DeckRecord(results, homeDeck);
			Console.WriteLine(deckRecord.ToString());
			var runRecord = RunRecord(results);
			Console.WriteLine(runRecord.ToString());

			Console.WriteLine($@"Notes: for {
				homeDeck
				} games: {
				gameCount
				} ({wins}-{losses})");

			if (notes.Any())
			{
				foreach (var item in notes)
				{
					Console.WriteLine(item);
				}
			}
		}

		private static Record RunRecord(List<HsGamePlayedEvent> results)
		{
			var record = new Record();
			var latestRun = 0;
			foreach (var game in results)
			{
				if (game.Run != latestRun)
				{
					latestRun = game.Run;
					record.Name = $"Run {game.Run}";
					record.Wins = 0;
					record.Losses = 0;
				}
				if (game.Result.Equals("win"))
					record.Wins++;
				else
					record.Losses++;
			}
			return record;
		}

		private static Record MonthRecord(List<HsGamePlayedEvent> results)
		{
			var record = new Record();
			var currMonth = DateTime.Now.Month;
			record.Name = $"Overall {DateTime.Now.Year}-{currMonth:0#} Record";
			record.Wins = 0;
			record.Losses = 0;
			foreach (var game in results)
			{
				if (game.DatePlayed.Month == currMonth)
				{
					if (game.Result.Equals("win"))
						record.Wins++;
					else
						record.Losses++;
				}

			}
			return record;
		}

		private static Record DeckRecord(
			List<HsGamePlayedEvent> results,
			string deckName)
		{
			var record = new Record();
			var currMonth = DateTime.Now.Month;
			record.Name = $"Deck {DateTime.Now.Year}-{currMonth:0#} Record";
			record.Wins = 0;
			record.Losses = 0;
			foreach (var game in results)
			{
				if (   game.DatePlayed.Month == currMonth
					&& game.HomeDeck.Equals(deckName) )
				{
					if (game.Result.Equals("win"))
						record.Wins++;
					else
						record.Losses++;
				}

			}
			return record;
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
