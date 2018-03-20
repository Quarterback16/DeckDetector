using System.Collections.Generic;

namespace Domain
{
    public class Deck
    {
        public string  Name { get; set; }
        public Hero HeroClass { get; set; }
        public List<Card> Cards { get; set; }

        public bool HasCardNamed(string cardName)
        {
            foreach (var card in Cards)
            {
                if (card.Name.Equals(cardName))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
