using Domain;
using Domain.Metas;
using HsEventStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class DeckDetector
    {
        public Meta CurrentMeta { get; set; }

        public DeckDetector()
        {
            CurrentMeta = RastakhansRumble.LoadMeta();
        }

		public DeckDetector(Meta meta)
		{
			CurrentMeta = meta;
		}

		public List<Card> PlayableCards(bool dump = false)
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

        public List<Deck> ListDecks(string heroClass)
        {
            if (string.IsNullOrEmpty(heroClass))
                return ListDecks();

            var list = CurrentMeta
				.Decks
				.Where(
					d => d.HeroClass.Name.ToUpper().StartsWith(
						heroClass.ToUpper()));
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

        public List<Deck> ListDecks(string heroClass, string[] played)
        {
            if (played.Length == 0)
                return ListDecks(heroClass);

            //  deck must v all the cards played
            var shortList = new List<Deck>();
            var list = CurrentMeta.Decks
				.Where(d => d.HeroClass.Name.ToUpper()
				            .StartsWith(heroClass.ToUpper()));
            foreach (Deck deck in list.ToList())
            {
                var cardCount = 0;
                for (int i = 0; i < played.Length; i++)
                {
                    List<Card> cards = deck.Cards;
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

		public void DumpDecks(List<Deck> results)
		{
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

		public void DumpNotes(
			string homeDeck,
			string oppDeck,
			List<HsGamePlayedEvent> results)
		{
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

		public void DumpRunRecord(List<HsGamePlayedEvent> results)
		{
			var runRecord = RunRecord(results);
			Console.WriteLine(runRecord.ToString());
		}

		public void DumpDeckRecord(string homeDeck, List<HsGamePlayedEvent> results)
		{
			var deckRecord = DeckRecord(results, homeDeck);
			Console.WriteLine(deckRecord.ToString());
		}

		public void DumpMonthRecord(List<HsGamePlayedEvent> results)
		{
			var monthRecord = MonthRecord(results);
			Console.WriteLine(monthRecord.ToString());
		}

		public void DumpMetaRecord(List<HsGamePlayedEvent> results)
		{
			var metaRecord = MetaRecord(results);
			Console.WriteLine(metaRecord.ToString());
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

		private Record MetaRecord(List<HsGamePlayedEvent> results)
		{
			var record = new Record();
			var currMonth = DateTime.Now.Month;
			record.Name = $"Meta {CurrentMeta} Record";
			record.Wins = 0;
			record.Losses = 0;
			foreach (var game in results)
			{
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
	}
}
