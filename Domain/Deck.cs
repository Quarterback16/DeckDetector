using System;
using System.Collections.Generic;

namespace Domain
{
    public class Deck
    {
        public string  Name { get; set; }
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

        public void Dump()
        {
            Console.WriteLine("------------------");
            foreach (var card in Cards)
            {
                Console.WriteLine($"{card.ManaCost()}-{card.Name}");
            }
            Console.WriteLine("------------------");
        }
    }
}
