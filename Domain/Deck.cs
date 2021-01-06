using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Deck : IComparable
    {
        public string  Name { get; set; }
		public string Prototype { get; set; }
		public int Rank { get; set; }
        public int Tier { get; set; }
        public Hero HeroClass { get; set; }
        public List<Card> Cards { get; set; }
		public Dictionary<string, List<string>> Advice 
		{
			get; 
			set; 
		}
		public Dictionary<string, List<string>> Mulligans1
		{
			get;
			set;
		}
		public Dictionary<string, List<string>> Mulligans2
		{
			get;
			set;
		}

		public List<string> KeyPlays
		{
			get;
			set;
		}

		public Deck()
		{
			Mulligans1 = new Dictionary<string, List<string>>();
			Mulligans2 = new Dictionary<string, List<string>>();
			Advice = new Dictionary<string, List<string>>();
			KeyPlays = new List<string>();
		}

		public void AddAdvice(
			string oppDeck,
			string tip)
		{
			if (!Advice.ContainsKey(oppDeck))
			{
				Advice.Add(
					key: oppDeck,
					value: new List<string>());
			}
			Advice[oppDeck].Add(tip);
		}

		public void AddMulligans1(
			string oppHero,
			List<string> mulligans)
		{
			if (!Mulligans1.ContainsKey(oppHero))
			{
				Mulligans1.Add(
					key: oppHero,
					value: new List<string>());
			}
			Mulligans1[oppHero].AddRange(mulligans);
		}

		public void AddMulligans2(
		string oppHero,
		List<string> mulligans)
		{
			if (!Mulligans2.ContainsKey(oppHero))
			{
				Mulligans2.Add(
					key: oppHero,
					value: new List<string>());
			}
			Mulligans2[oppHero].AddRange(mulligans);
		}

		public void AddKeyPlays(
			string play)
		{
			KeyPlays.Add(play);
		}

		public bool HasCardNamed(string cardName)
        {
#if DEBUG
			Console.WriteLine();
			Console.WriteLine($"Deck: {Name}");
			Console.WriteLine();
#endif
			foreach (var card in Cards)
            {
                if (card.Name.Equals(cardName) 
                    || card.HasTheseInitials(cardName))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return NameOut();
        }

        public string NameOut()
        {
            return $"T{Tier} {Name} ({Rank})";
        }

        public void Dump()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"   {NameOut()}  {Prototype}");
            Console.WriteLine("-----------------------------");
            foreach (var card in Cards.OrderBy(c=>c.ManaCost()))
			{
				ConsoleColor oldColour = Console.ForegroundColor;
				SetColour(card);
				Console.WriteLine(
					$"{string.Format("{0,2}", card.ManaCost())}-{card.Name} {card.Stats()} {card.SpellFor()}");
				Console.ForegroundColor = oldColour;
			}
			Console.WriteLine("------------------------------");
        }

		public bool IsEmpty()
		{
			return Tier == 0;
		}

		private static void SetColour(Card card)
		{
			if (card.IsSecret() )
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				return;
			}
			if (card.HasAoe())
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				return;
			}
			if (card.IsWeapon())
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				return;
			}
			if (card.IsWeaponRemoval())
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				return;
			}
			if (card.IsRemoval())
			{
				Console.ForegroundColor = ConsoleColor.Red;
				return;
			}
			if (card.IsBurn())
			{
				Console.ForegroundColor = ConsoleColor.Green;
				return;
			}
		}

		public int CompareTo(object obj)
		{
			var objDeck = (Deck) obj;
			return Name.CompareTo(objDeck.Name);
		}
	}
}
