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
			homeDeck = "Cyclone Giants Mage";
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
				//  -r 
				Report(
					report: options.Report,
					eventStore: eventStore,
					homeDeck: homeDeck,
					dd: dd);
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
			}
			dd.DumpNotes(homeDeck, oppDeck, results);

            Console.WriteLine();
#if DEBUG
			Console.ReadLine();
#endif
		}

		private static void Report(
			string report,
			HsEventStore.HsEventStore eventStore,
			string homeDeck,
			DeckDetector dd)
		{
			if (report.ToUpper() == "F")
			   FrequencyReport(
				   eventStore, 
				   homeDeck, 
				   dd);
			else if (report.ToUpper() == "C")
				ChampDeckReport(
					eventStore);
			else if (report.ToUpper() == "M")
				LastMonthReport(
					eventStore);
			else if (report.ToUpper() == "A")
				AlphaReport(
					dd);
#if DEBUG
			Console.ReadLine();
#endif
		}

		private static void AlphaReport(DeckDetector dd)
		{
			dd.AlphaList(dd.ListDecks());
		}

		private static void LastMonthReport(
			HsEventStore.HsEventStore eventStore)
		{
			var deckDict = new Dictionary<string, Record>();
			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");
			var totalRecord = new Record();
			var maxDeckNameLength = 0;
			var lastMonth = DateTime.Now.AddMonths(-1).Month;

			foreach (var game in results)
			{
				if (game.DatePlayed.Month != lastMonth)
					continue;

				if (!deckDict.ContainsKey(game.HomeDeck))
				{
					deckDict.Add(
						game.HomeDeck,
						new Record
						{
							Name = game.HomeDeck
						});
					if (game.HomeDeck.Length > maxDeckNameLength)
						maxDeckNameLength = game.HomeDeck.Length;
				}
				var record = deckDict[game.HomeDeck];
				if (game.Result == "win")
				{
					record.Wins++;
					totalRecord.Wins++;
				}
				else
				{
					record.Losses++;
					totalRecord.Losses++;
				}
			}
			var mysortedDeckList = deckDict.ToList();
			mysortedDeckList.Sort(
				(pair1, pair2) => pair2.Value.Clip().CompareTo(pair1.Value.Clip()));
			var spacer = new String(' ', maxDeckNameLength - 20);
			Console.WriteLine($"Champion Deck Report{spacer}     GP    W    L   Percent");
			Console.WriteLine();
			foreach (KeyValuePair<string, Record> pair in mysortedDeckList)
			{
				Console.WriteLine("  {0,-" + maxDeckNameLength + "} {1,4} {2,4} {3,4}  {4,6}",
					pair.Key,
					pair.Value.TotalGames(),
					pair.Value.Wins,
					pair.Value.Losses,
					pair.Value.Percent());
			}
			Console.WriteLine();
			Console.WriteLine("  {0,-" + maxDeckNameLength + "} {1,4} {2,4} {3,4}  {4,6}",
				"Totals",
				totalRecord.TotalGames(),
				totalRecord.Wins,
				totalRecord.Losses,
				totalRecord.Percent());
		}

		private static void ChampDeckReport(
			HsEventStore.HsEventStore eventStore)
		{
			var deckDict = new Dictionary<string, Record>();
			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");
			var totalRecord = new Record();
			var maxDeckNameLength = 0;

			foreach (var game in results)
			{
				if (!deckDict.ContainsKey(game.HomeDeck))
				{
					deckDict.Add(
						game.HomeDeck, 
						new Record 
						{ 
							Name = game.HomeDeck
						});
					if (game.HomeDeck.Length > maxDeckNameLength)
						maxDeckNameLength = game.HomeDeck.Length;
				}
				var record = deckDict[game.HomeDeck];
				if (game.Result == "win")
				{
					record.Wins++;
					totalRecord.Wins++;
				}
				else
				{
					record.Losses++;
					totalRecord.Losses++;
				}
			}
			var mysortedDeckList = deckDict.ToList();
			mysortedDeckList.Sort(
				(pair1, pair2) => pair2.Value.Clip().CompareTo(pair1.Value.Clip()));
			var spacer = new String(' ', maxDeckNameLength - 20);
			Console.WriteLine($"Champion Deck Report{spacer}     GP    W    L   Percent");
			Console.WriteLine();
			foreach (KeyValuePair<string, Record> pair in mysortedDeckList)
			{
				Console.WriteLine("  {0,-" + maxDeckNameLength + "} {1,4} {2,4} {3,4}  {4,6}",
					pair.Key,
					pair.Value.TotalGames(),
					pair.Value.Wins,
					pair.Value.Losses,
					pair.Value.Percent() );
			}
			Console.WriteLine();
			Console.WriteLine("  {0,-" + maxDeckNameLength + "} {1,4} {2,4} {3,4}  {4,6}",
				"Totals",
				totalRecord.TotalGames(),
				totalRecord.Wins,
				totalRecord.Losses,
				totalRecord.Percent());
		}

		private static void FrequencyReport(
			HsEventStore.HsEventStore eventStore,
			string homeDeck,
			DeckDetector dd)
		{
			var OppDeckDict = new Dictionary<string, int>();
			var OppDeckDateDict = new Dictionary<string, DateTime>();
			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");
			foreach (var game in results)
			{
				if (OppDeckDict.ContainsKey(game.OpponentDeck))
				{
					OppDeckDict[game.OpponentDeck]++;
					OppDeckDateDict[key: game.OpponentDeck] = game.DatePlayed;
				}
				else
				{
					OppDeckDict.Add(game.OpponentDeck, 1);
					OppDeckDateDict[key: game.OpponentDeck] = game.DatePlayed;
				}
			}
			Console.WriteLine($"Deck: {homeDeck}");
			Console.WriteLine($"Frequency Report           {results.Count()}        Deck Record");
			var mysortedDeckList = OppDeckDict.ToList();
			mysortedDeckList.Sort(
				(pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
			foreach (KeyValuePair<string, int> pair in mysortedDeckList)
			{
				Console.WriteLine("  {0,-26} {1,2} {2,4} {3}  {4,2}",
					pair.Key,
					pair.Value,
					MeetFrequency(results.Count(),pair.Value),
					dd.RecordVersusDeck(homeDeck,pair.Key,results),
					DaysSince(OppDeckDateDict[pair.Key]));
			}
			ArchTypeFrequency(
				results,
				dd);
			ClassFrequency(
				results,
				dd);
		}

		public static double DaysSince(DateTime gameDate)
		{
			TimeSpan difference = DateTime.Now.Date - gameDate.Date;

			return difference.TotalDays;
		}

		private static void ClassFrequency(
			List<HsGamePlayedEvent> results,
			DeckDetector dd)
		{
			var decks = dd.ListDecks();

			var classDict = new Dictionary<string, int>
			{
				{ "Mage", 0 },
				{ "Warrior", 0 },
				{ "Warlock", 0 },
				{ "Shaman", 0 },
				{ "Rogue", 0 },
				{ "Paladin", 0 },
				{ "Druid", 0 },
				{ "Hunter", 0 },
				{ "Priest", 0 }
			};

			foreach (var game in results)
			{
				var deck = GetDeck(
					decks,
					game.OpponentDeck);
				if (deck.HeroClass == null)
					Console.WriteLine($"Hero class {game.OpponentDeck} not found");
				else
				{
					if (classDict.ContainsKey(deck.HeroClass.Name))
						classDict[deck.HeroClass.Name]++;
					else
						classDict.Add(deck.HeroClass.Name, 1);
				}
			}
			var mySortedClassList = classDict.ToList();
			mySortedClassList.Sort(
				(pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
			Console.WriteLine();
			foreach (KeyValuePair<string, int> pair in mySortedClassList)
			{
				Console.WriteLine("  {0,-24} {1,2} {2,4}",
					pair.Key,
					pair.Value,
					MeetFrequency(results.Count(), pair.Value));
			}
		}

		private static void MeetFrequencyBy(
			string topic, 
			List<HsGamePlayedEvent> results, 
			Dictionary<string, int> d)
		{
			Console.WriteLine();
			Console.WriteLine(topic);
			foreach (KeyValuePair<string, int> pair in d)
			{
				Console.WriteLine("  {0,-24} {1,2} {2,4}",
					pair.Key,
					pair.Value,
					MeetFrequency(results.Count(), pair.Value));
			}
		}

		private static void ArchTypeFrequency(
			List<HsGamePlayedEvent> results,
			DeckDetector dd)
		{
			var decks = dd.ListDecks();

			var d = new Dictionary<string, int>
			{
				{ "CONTROL", 0 },
				{ "MIDRANGE", 0 },
				{ "AGGRO", 0 },
				{ "COMBO", 0 }
			};

			foreach (var game in results)
			{
				var deck = GetDeck(
					decks,
					game.OpponentDeck);
				if (deck.Prototype == null)
					Console.WriteLine($"Deck {game.OpponentDeck} not found");
				else
				{
					if (d.ContainsKey(deck.Prototype))
						d[deck.Prototype]++;
					else
						d.Add(deck.Prototype, 1);
				}
			}

			MeetFrequencyBy("Prototypes", results, d);
		}

		private static Deck GetDeck(List<Deck> decks, string opponentDeck)
		{
			Deck foundDeck = new Deck();
			foreach (var deck in decks)
			{
				if (deck.Name.Equals(opponentDeck))
				{
					foundDeck = deck;
					break;
				}
			}
			return foundDeck;
		}

		private static string MeetFrequency(int count, int games)
		{
			var record = new Record
			{
				Wins = games,
				Losses = count
			};
			return record.Percent();
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
