using System;

namespace Domain
{
    public class Card : IEquatable<Card>
    {
        public string Name { get; set; }

        public Hero HeroClass { get; set; }

        internal bool HasTheseInitials(string cardName)
        {
            if (cardName.Length > 3)
                return false;

            var matchCount = 0;
            for (int i = 0; i < cardName.Length; i++)
            {
                var initial = cardName.Substring(i, 1);
                if (Name.Contains(initial))
                    matchCount++;
            }
            if (matchCount.Equals(cardName.Length))
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public bool Equals(Card other)
        {
            if (other.Name == Name)
            {
                return true;
            }
            return false;
        }

        public int ManaCost()
        {
            var manaCost = 0;
            manaCost = HearthDb.ManaCost(Name);
            return manaCost;
        }
    }
}
