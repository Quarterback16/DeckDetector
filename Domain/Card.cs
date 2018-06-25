using System;

namespace Domain
{
    public class Card : IEquatable<Card>
    {
        public string Name { get; set; }

        public Hero HeroClass { get; set; }

        internal bool HasTheseInitials(string cardName)
        {
			if (cardName == Initials())
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

		public string Initials()
		{
			var inits = string.Empty;
			string[] output = Name.Split(' ');
			foreach (var word in output)
			{
				inits += word[0];
			}
			return inits;
		}

        public bool HasAoe()
        {
            var isAoe = false;
            isAoe = HearthDb.HasAoe(this);
            return isAoe;
        }

		public bool IsSecret()
		{
			var isSecret = false;
			isSecret = HearthDb.IsSecret(this);
			return isSecret;
		}

		public bool IsWeapon()
		{
			var isWeapon = false;
			isWeapon = HearthDb.IsWeapon(this);
			return isWeapon;
		}

		public bool IsRemoval()
		{
			var isSecret = false;
			isSecret = HearthDb.IsSecret(this);
			return isSecret;
		}

		public bool IsBurn()
		{
			var isBurn = false;
			isBurn = HearthDb.IsBurn(this);
			return isBurn;
		}
	}
}
