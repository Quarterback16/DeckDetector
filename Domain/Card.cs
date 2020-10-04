using System;

namespace Domain
{
    public class Card : IEquatable<Card>
    {
		public Card()
		{
		}

		public Card(
			string name,
			int manaCost,
			string cardType)
		{
			Name = name;
			Mana = manaCost;
			CardType = cardType;
		}

        public string Name { get; set; }

		public int Mana { get; set; }

		public string CardType { get; set; }

		public Hero HeroClass { get; set; }

		public bool Single { get; set; }

		public string Spell { get; set; }
		public int? Attack { get; set; }
		public int? Health { get; set; }

		internal bool HasTheseInitials(string cardName)
        {
#if DEBUG
			Console.WriteLine($"{Name}={Initials()}");
#endif
			if (cardName.ToUpper() == Initials())
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
            var manaCost = HearthDb.ManaCost(Name);
            return manaCost;
        }

		public string Initials()
		{
			//  lower case intials not included
			var inits = string.Empty;
			string[] output = Name.Split(' ');
			foreach (var word in output)
			{
				var possible = word[0];
				var ascii = (int)possible;
				if (ascii < 97)
					inits += possible;
			}
			return inits;
		}

		public string CardName()
		{
			return $"{ManaCost()}-{Name}";
		}

		internal string SpellFor()
		{
			var spell = HearthDb.SpellFor(Name);
			if (string.IsNullOrEmpty(spell))
				return string.Empty;
			return spell;
		}

		internal string Stats()
		{
			Attack = HearthDb.AttackFor(Name);
			if (Attack == null)
				return string.Empty;
			Health = HearthDb.HealthFor(Name);
			var stats = $"{Attack.ToString().Trim()}/{Health.ToString().Trim()}";
			if (HearthDb.Taunt(Name))
				stats += "-T";
			if (HearthDb.DivineShield(Name))
				stats += "-S";
			return stats;
		}

		public int CardCount()
		{
			var cardCount = 2;
			if (Single)
				cardCount = 1;
			return cardCount;
		}

		public bool HasAoe()
        {
			bool isAoe = HearthDb.HasAoe(this);
			return isAoe;
        }

		public bool IsSecret()
		{
			bool isSecret = HearthDb.IsSecret(this);
			return isSecret;
		}

		public bool IsWeapon()
		{
			bool isWeapon = HearthDb.IsWeapon(this);
			return isWeapon;
		}

		public bool IsWeaponRemoval()
		{
			bool isWeaponRemoval = HearthDb.IsWeaponRemoval(this);
			return isWeaponRemoval;
		}

		public bool IsRemoval()
		{
			bool isSecret = HearthDb.IsSecret(this);
			return isSecret;
		}

		public bool IsBurn()
		{
			bool isBurn = HearthDb.IsBurn(this);
			return isBurn;
		}
	}
}
