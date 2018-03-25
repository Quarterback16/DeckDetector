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

        public void AddDeck( Deck deck)
        {
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
