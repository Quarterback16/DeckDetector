using Domain;
using Domain.Metas;
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

            var list = CurrentMeta.Decks.Where(d => d.HeroClass.Name.StartsWith(heroClass));
            return list.ToList();
        }

        public List<Deck> ListDecks(string heroClass, string[] played)
        {
            if (played.Length == 0)
                return ListDecks(heroClass);

            //  deck must v all the cards played
            var shortList = new List<Deck>();
            var list = CurrentMeta.Decks.Where(d => d.HeroClass.Name.StartsWith(heroClass));
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
	}
}
