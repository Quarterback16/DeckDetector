using System;
using System.Collections.Generic;

namespace Domain
{
    public class Meta
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public List<Deck> Decks { get; set; }

        public Meta(
            string code,
            string name )
        {
            Code = code;
            Name = name;
            Decks = new List<Deck>();
        }

		internal void AddDecks(List<Deck> decks, int tier)
		{
			foreach (var deck in decks)
			{
				AddDeck(deck, tier);
			}
		}

		public void AddDeck( Deck deck)
        {
			deck.Rank = Decks.Count + 1;
            Decks.Add(deck);
        }

		public void AddDeck(Deck deck, int tier)
		{
			deck.Rank = Decks.Count + 1;
			deck.Tier = tier;
			Decks.Add(deck);
		}

		public List<Card> PlayableCards()
        {
            var playableCards = new List<Card>();
            foreach (var deck in Decks)
            {
                foreach (var card in deck.Cards)
                {
                    if (!playableCards.Contains(card))
                        playableCards.Add(card);
                }
            }
            return playableCards;
        }
    }
}
