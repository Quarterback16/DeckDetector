using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Meta
    {
        public string Code { get; set; }
        public string Name { get; set; }
		public decimal PatchNo { get; set; }

        public List<Deck> Decks { get; set; }

        public Meta(
            string code,
            string name,
			decimal patchNo)
        {
            Code = code;
            Name = name;
			PatchNo = patchNo;
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

		public string ToWiki(string deckName )
		{
			var deck = GetDeck(deckName);
			var sb = new StringBuilder();
			AddLine(sb, MetaHeading());
			AddLine(sb, string.Empty);
			AddLine(sb, "|| **Count** || **Card**  ||  **Notes**  ||");
			foreach (var card in deck.Cards)
			{
				AddLine(sb, $"|| {card.CardCount()} || {card.CardName()} ||  ||");
			}
			return sb.ToString();
		}

		private Deck GetDeck(string deckName)
		{
			var d = new Deck();
			foreach (var deck in Decks)
			{
				if (deck.Name.Equals(deckName))
				{
					d = deck;
					break;
				}
			};
			return d;
		}

		private void AddLine(StringBuilder sb, string v)
		{
			sb.AppendLine(v);
		}

		private string MetaHeading()
		{
			return $"=== [[{WikiLink(Name)}]] {PatchNo} edition ===";
		}

		private string WikiLink(string name)
		{
			return name.Replace(" ", string.Empty);
		}
	}
}
