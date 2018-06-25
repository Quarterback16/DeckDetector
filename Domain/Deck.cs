﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Deck
    {
        public string  Name { get; set; }
		public string Prototype { get; set; }
		public int Rank { get; set; }
        public int Tier { get; set; }
        public Hero HeroClass { get; set; }
        public List<Card> Cards { get; set; }

        public bool HasCardNamed(string cardName)
        {
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
				Console.WriteLine($"{string.Format("{0,2}", card.ManaCost())}-{card.Name}");
				Console.ForegroundColor = oldColour;
			}
			Console.WriteLine("------------------------------");
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
	}
}
