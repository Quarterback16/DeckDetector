using Domain;
using Domain.Metas;
using HsEventStore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Application
{
    public class DeckDetector
    {
        public Meta CurrentMeta { get; set; }

        public DeckDetector()
        {
            CurrentMeta = ScholomanceAcademy.LoadMeta();
        }

		public DeckDetector(Meta meta)
		{
			CurrentMeta = meta;
		}

		public List<Card> PlayableCards(
			bool dump = false)
        {
            var pc = CurrentMeta.PlayableCards().OrderBy(c => c.Name).ToList();

			if (dump)
			{
				foreach (var card in pc)
				{
					Console.WriteLine(card.ToString());
				}
			}
            return pc;
        }

        public bool CardsAreValid()
        {
            foreach (Deck deck in CurrentMeta.Decks)
            {
                foreach (var card in deck.Cards)
                {
                    if (HearthDb.ManaCost(card) < 0)
                    {
                        Console.WriteLine($"{card} is invalid");
                        return false;
                    }
                }
            }
            return true;
        }

        public List<Deck> ListDecks()
        {
            return CurrentMeta.Decks;
        }

        public List<Deck> ListDecks(
			string heroClass)
        {
            if (string.IsNullOrEmpty(heroClass))
                return ListDecks();

            var list = CurrentMeta
				.Decks
				.Where(
					d => d.HeroClass.Name.ToUpper(
							CultureInfo.CurrentCulture).StartsWith(
								heroClass.ToUpper(
									CultureInfo.CurrentCulture),
									false,
									CultureInfo.CurrentCulture));
            return list.ToList();
        }

		public bool IsValidDeckname( string deckName )
		{
			var list = CurrentMeta
				.Decks
				.Where(
					d => d.Name.Equals(deckName));
			return list.Count() == 1;
		}

        public List<Deck> ListDecks(
			string heroClass,
			string[] played)
		{
			if (played == null || played.Length == 0)
				return ListDecks(heroClass);

			//  deck must v all the cards played
			var shortList = new List<Deck>();
			IEnumerable<Deck> list = DecksFor(heroClass);
			foreach (Deck deck in list.ToList())
			{
				var cardCount = 0;
				for (int i = 0; i < played.Length; i++)
				{
					if (deck.HasCardNamed(played[i]))
					{
						cardCount++;
					}
				}
				if (cardCount.Equals(played.Length))
					shortList.Add(deck);
			}
			return shortList.ToList();
		}

		public IEnumerable<Deck> DecksFor(
			string abbrHeroClass)
		{
			return CurrentMeta.Decks
				.Where(d => d.HeroClass.Name.ToUpper(
					CultureInfo.CurrentCulture)
						.StartsWith(
							abbrHeroClass.ToUpper(
								CultureInfo.CurrentCulture),
							false,
							CultureInfo.CurrentCulture));
		}

		public void DumpDeckRecordVsHero(
			string homeDeck,
			List<HsGamePlayedEvent> results,
			string abbrHeroClass)
		{
			if (string.IsNullOrEmpty(abbrHeroClass))
				return;

			var heroClass = AbbrToHeroClass(abbrHeroClass);

			var deckRecord = DeckTotalRecordVsHero(
				results,
				homeDeck,
				heroClass);
			Console.WriteLine(deckRecord.ToString());
		}

		private HeroClass AbbrToHeroClass(
			string abbrHeroClass)
		{
			var decks = DecksFor(abbrHeroClass);
			var deck = decks.First();
			return deck.HeroClass.HeroClass;
		}

		public Record DeckTotalRecordVsHero(
			List<HsGamePlayedEvent> results,
			string deckName,
			HeroClass heroClass)
		{
			var record = new Record
			{
				Name = $@"{
					deckName
					} Record vs {
					heroClass}",
				Wins = 0,
				Losses = 0
			};
			if (results is null)
				return record;
			foreach (var game in results)
			{
				if (game == null)
					continue;
				var oppHero = DeckHeroClass(game.OpponentDeck);
				if (!oppHero.Equals(heroClass))
					continue;
				if ( game.HomeDeck.Equals(deckName))
				{
					if (game.Result.Equals("win"))
						record.Wins++;
					else
						record.Losses++;
				}
			}
			return record;
		}

		public HeroClass DeckHeroClass(string opponentDeck)
		{
			foreach (var deck in CurrentMeta.Decks)
			{
				if ( deck.Name.Equals(opponentDeck))
				{
					return deck.HeroClass.HeroClass;
				}
			}
			return HeroClass.Priest;
		}

		public void DumpDecks(List<Deck> results)
		{
			if (results is null)
				return;

			Deck theDeck = new Deck();
			foreach (var deck in results)
			{
				Console.WriteLine($"T{deck.Tier} {deck.Name} ({deck.Rank})");
				theDeck = deck;
			}
			if (results.Count == 1)
			{
				theDeck.Dump();
			}
		}

		public void AlphaList(List<Deck> results)
		{
			if (results is null)
				return;
			results.Sort();
			foreach (var deck in results)
			{
				Console.WriteLine($"{deck.Name} T{deck.Tier} ({deck.Rank})");
			}
			Console.WriteLine();
			Console.WriteLine($"{results.Count} decks in meta");
		}

		public void DumpNotes(
			string homeDeck,
			string oppDeck,
			List<HsGamePlayedEvent> results)
		{
			if (results is null)
				return;

			var notes = new List<string>();
			var gameCount = 0;
			var wins = 0;
			var losses = 0;

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
				if (oppDeck.Equals(homeDeck))
					continue;  //  mirror dont double count

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

			var homeDeckRecord = new Record
			{
				Losses = losses,
				Wins = wins,
			};
			Console.WriteLine($@"Notes: for {
				homeDeck
				} games: {
				gameCount
				} ({
				wins
				}-{
				losses
				})  {
				homeDeckRecord.Percent()
				}");

			if (notes.Count > 0)
			{
				foreach (var item in notes)
				{
					Console.WriteLine(item);
				}
			}
		}

		public string RecordVersusDeck(
			string homeDeck,
			string oppDeck,
			List<HsGamePlayedEvent> results,
			string reportDate = "")
		{
			var record = new Record();
			if (results is null )
				return record.ToString();

			foreach (var game in results)
			{
				if (!string.IsNullOrEmpty(reportDate))
				{
					if (game.DatePlayed < DateTime.Parse(reportDate))
						continue;
				}
				if (   game.HomeDeck == homeDeck
					&& game.OpponentDeck == oppDeck)
				{
					if (game.Result.Equals("win"))
					{
						record.Wins++;
					}
					else
					{
						record.Losses++;
					}
				}
			}

			return record.ToString();
		}

		public void DumpDailyRecord(
			List<HsGamePlayedEvent> results)
		{
			if (results is null)
				return;
			var runRecord = DailyRecord(results);
			Console.WriteLine(runRecord.ToString());
		}

		public void DumpRunRecord(
			List<HsGamePlayedEvent> results)
		{
			if (results is null)
				return;

			var runRecord = RunRecord(results);
			Console.WriteLine(runRecord.ToString());
		}

		public void DumpDeckRecord(
			string homeDeck, 
			List<HsGamePlayedEvent> results)
		{
			if (results is null)
				return;

			var deckRecord = DeckTotalRecord(results, homeDeck);
			Console.WriteLine(deckRecord.ToString());
		}

		public void DumpDeckMonthRecord(
			string homeDeck, 
			List<HsGamePlayedEvent> results)
		{
			if (results is null)
				return;

			var deckRecord = DeckRecord(results, homeDeck);
			Console.WriteLine(deckRecord.ToString());
		}

		public void DumpMonthRecord(
			List<HsGamePlayedEvent> results)
		{
			if (results is null)
				return;

			var monthRecord = MonthRecord(results);
			Console.WriteLine(monthRecord.ToString());
		}

		public void DumpPreviousMonthRecord(
			List<HsGamePlayedEvent> results)
		{
			if (results is null)
				return;

			var monthRecord = PreviousMonthRecord(results);
			Console.WriteLine(monthRecord.ToString());
		}

		public void DumpMetaRecord(
			List<HsGamePlayedEvent> results)
		{
			if (results is null)
				return;

			var metaRecord = MetaRecord(results);
			Console.WriteLine(metaRecord.ToString());
		}

		private static Record DailyRecord(
			List<HsGamePlayedEvent> results)
		{
			var record = new Record
			{
				Name = $"Daily Record"
			};

			foreach (var game in results)
			{
				if (game.DatePlayed.Date == DateTime.Now.Date)
				{
					if (game.Result.Equals("win"))
						record.Wins++;
					else
						record.Losses++;
				}
			}
			return record;
		}

		private static Record RunRecord(
			List<HsGamePlayedEvent> results)
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

		private Record MetaRecord(
			List<HsGamePlayedEvent> results)
		{
			var record = new Record
			{
				Name = $"Meta {CurrentMeta} Record",
				Wins = 0,
				Losses = 0
			};
			foreach (var game in results)
			{
				if (game.Result.Equals("win"))
					record.Wins++;
				else
					record.Losses++;
			}
			return record;
		}

		private static Record PreviousMonthRecord(
			List<HsGamePlayedEvent> results)
		{
			var record = new Record();
			var previousDate = DateTime.Now.AddMonths(-1);
			var prevMonth = previousDate.Month;
			record.Name = $"Overall {previousDate.Year}-{prevMonth:0#} Record";
			record.Wins = 0;
			record.Losses = 0;
			foreach (var game in results)
			{
				if (game.DatePlayed.Month == prevMonth)
				{
					if (game.Result.Equals("win"))
						record.Wins++;
					else
						record.Losses++;
				}
			}
			return record;
		}

		private static Record MonthRecord(
			List<HsGamePlayedEvent> results	)
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
			record.Name = $"{deckName} {DateTime.Now.Year}-{currMonth:0#} Record";
			record.Wins = 0;
			record.Losses = 0;
			foreach (var game in results)
			{
				if (game.DatePlayed.Month == currMonth
					&& game.HomeDeck.Equals(deckName))
				{
					if (game.Result.Equals("win"))
						record.Wins++;
					else
						record.Losses++;
				}
			}
			return record;
		}

		private static Record DeckTotalRecord(
			List<HsGamePlayedEvent> results,
			string deckName)
		{
			var record = new Record
			{
				Name = $"{deckName} Record",
				Wins = 0,
				Losses = 0
			};
			foreach (var game in results)
			{
				if (game.HomeDeck.Equals(deckName))
				{
					if (game.Result.Equals("win"))
						record.Wins++;
					else
						record.Losses++;
				}
			}
			return record;
		}

		public void Report(
			string report,
			HsEventStore.HsEventStore eventStore,
			string homeDeck,
			DeckDetector dd,
			string reportDate = "")
		{
			if (dd is null 
				|| eventStore is null
				|| string.IsNullOrEmpty(report))
				return;

			if (string.Equals(report, "F", StringComparison.CurrentCultureIgnoreCase))
			{
				FrequencyReport(
					eventStore,
					homeDeck,
					dd,
					reportDate);
			}
			else if (report.ToUpper(CultureInfo.CurrentCulture) == "D")
			{
				DeckReport(
					eventStore,
					homeDeck,
					dd);
			}
			else if (report.ToUpper(CultureInfo.CurrentCulture) == "C")
			{
				ChampDeckReport(
					eventStore);
			}
			else if (report.ToUpper(CultureInfo.CurrentCulture) == "L")
			{
				LastMonthReport(
					eventStore);
			}
			else if (report.ToUpper(CultureInfo.CurrentCulture) == "T")
			{
				ThisMonthReport(
					eventStore);
			}
			else if (report.ToUpper(CultureInfo.CurrentCulture) == "A")
			{
				AlphaReport(
					dd);
			}
#if DEBUG
			//Console.ReadLine();
#endif
		}

		private static void DeckReport(
			HsEventStore.HsEventStore eventStore,
			string homeDeck,
			DeckDetector dd)
		{
			var OppDeckDict = new Dictionary<string, int>();
			var OppDeckDateDict = new Dictionary<string, DateTime>();
			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");
			var gamesPlayed = 0;
			foreach (var game in results)
			{
				if (game.HomeDeck.Equals(homeDeck))
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
					gamesPlayed++;
				}
			}
			Console.WriteLine($"Deck: {homeDeck}");
			Console.WriteLine($"Home Deck Report              {gamesPlayed}        Deck Record");
			var mysortedDeckList = OppDeckDict.ToList();
			mysortedDeckList.Sort(
				(pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
			foreach (KeyValuePair<string, int> pair in mysortedDeckList)
			{
				Console.WriteLine("  {0,-27} {1,2} {2,4} {3}  {4,2}",
					pair.Key,
					pair.Value,
					MeetFrequency(gamesPlayed, pair.Value),
					dd.RecordVersusDeck(homeDeck, pair.Key, results),
					DaysSince(OppDeckDateDict[pair.Key]));
			}
		}

		private static void ThisMonthReport(
			HsEventStore.HsEventStore eventStore)
		{
			var thisMonth = DateTime.Now.Month;
			MonthReport(
				eventStore,
				thisMonth,
				"This Month");
		}

		private static void LastMonthReport(
			HsEventStore.HsEventStore eventStore)
		{
			var lastMonth = DateTime.Now.AddMonths(-1).Month;
			MonthReport(
				eventStore,
				lastMonth,
				"Last Month");
		}

		private static void AlphaReport(DeckDetector dd)
		{
			dd.AlphaList(dd.ListDecks());
		}

		private static void MonthReport(
			HsEventStore.HsEventStore eventStore,
			int month,
			string reportName)
		{
			var deckDict = new Dictionary<string, Record>();
			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");
			var totalRecord = new Record();
			var maxDeckNameLength = 0;

			foreach (var game in results)
			{
				if (game.DatePlayed.Month != month)
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
			if (deckDict.Count > 0)
			{
				var mysortedDeckList = deckDict.ToList();
				mysortedDeckList.Sort(
					(pair1, pair2) => pair2.Value.Clip().CompareTo(pair1.Value.Clip()));
				if (maxDeckNameLength < 17)
					maxDeckNameLength = 18;
				var spacer = new String(' ', maxDeckNameLength - 17);
				Console.WriteLine($"{reportName} Report{spacer}     GP    W    L   Percent");
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
			else
			{
				Console.WriteLine("No Decks to report on");
			}
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
			if (maxDeckNameLength < 20)
				maxDeckNameLength = 20;
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

		private static void FrequencyReport(
			HsEventStore.HsEventStore eventStore,
			string homeDeck,
			DeckDetector dd,
			string reportDate = "")
		{
			var OppDeckDict = new Dictionary<string, int>();
			var OppDeckDateDict = new Dictionary<string, DateTime>();
			var results = (List<HsGamePlayedEvent>)
				eventStore.Get<HsGamePlayedEvent>("game-played");
			var deckRecord = new Record();
			var totalGames = 0;
			foreach (var game in results)
			{
				if (!string.IsNullOrEmpty(reportDate))
				{
					if (game.DatePlayed < DateTime.Parse(
							reportDate, 
							CultureInfo.CurrentCulture))
						continue;
				}
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
				totalGames++;
				if (game.HomeDeck == homeDeck)
				{
					if (game.Result.Equals("win"))
						deckRecord.Wins++;
					else
						deckRecord.Losses++;
				}
			}
			Console.WriteLine($"Deck: {homeDeck}");
			Console.WriteLine($@"Frequency Report {DateOut(reportDate)}   {totalGames,3:N0}    Deck Record  {
				deckRecord
				}");
			var mysortedDeckList = OppDeckDict.ToList();
			mysortedDeckList.Sort(
				(pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
			foreach (KeyValuePair<string, int> pair in mysortedDeckList)
			{
				Console.WriteLine("  {0,-28} {1,2} {2,4} {3}  {4,2}",
					pair.Key,
					pair.Value,
					MeetFrequency(
						totalGames: totalGames,
						frequency: pair.Value),
					dd.RecordVersusDeck(
						homeDeck,
						pair.Key,
						results,
						reportDate),
					DaysSince(OppDeckDateDict[pair.Key]));
			}
			ArchTypeFrequency(
				results,
				dd,
				reportDate);
			ClassFrequency(
				results,
				dd,
				reportDate);
		}

		private static object DateOut(
			string reportDate = "")
		{
			if (string.IsNullOrEmpty(reportDate))
				return "   meta   ";
			return reportDate;
		}

		public static double DaysSince(DateTime gameDate)
		{
			TimeSpan difference = DateTime.Now.Date - gameDate.Date;

			return difference.TotalDays;
		}

		private static void ClassFrequency(
			List<HsGamePlayedEvent> results,
			DeckDetector dd,
			string reportDate = "")
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

			var resultsUsed = 0;
			foreach (var game in results)
			{
				if (!string.IsNullOrEmpty(reportDate))
				{
					if (game.DatePlayed < DateTime.Parse(reportDate))
						continue;
				}
				resultsUsed++;
				var deck = GetDeck(
					decks,
					game.OpponentDeck);
				if (deck.HeroClass == null)
				{
					Console.WriteLine($"Hero class {game.OpponentDeck} not found");
				}
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
					MeetFrequency(resultsUsed, pair.Value));
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
					MeetFrequency(
						results.Count,
						pair.Value));
			}
		}

		private static void ArchTypeFrequency(
			List<HsGamePlayedEvent> results,
			DeckDetector dd,
			string reportDate = "")
		{
			var decks = dd.ListDecks();

			var d = new Dictionary<string, int>
			{
				{ "CONTROL", 0 },
				{ "MIDRANGE", 0 },
				{ "AGGRO", 0 },
				{ "COMBO", 0 }
			};

			var usedResults = new List<HsGamePlayedEvent>();
			foreach (var game in results)
			{
				if (!string.IsNullOrEmpty(reportDate))
				{
					if (game.DatePlayed < DateTime.Parse(reportDate))
						continue;
				}
				usedResults.Add(game);
				var deck = GetDeck(
					decks,
					game.OpponentDeck);
				if (deck.Prototype == null)
				{
					Console.WriteLine($"Deck {game.OpponentDeck} not found");
				}
				else
				{
					if (d.ContainsKey(deck.Prototype))
						d[deck.Prototype]++;
					else
						d.Add(deck.Prototype, 1);
				}
			}

			MeetFrequencyBy(
				topic: "Prototypes",
				results: usedResults,
				d: d);
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

		private static string MeetFrequency(
			int totalGames,
			int frequency)
		{
			var record = new Record
			{
				Wins = frequency,
				Losses = totalGames - frequency
			};
			return record.Percent();
		}
	}
}
