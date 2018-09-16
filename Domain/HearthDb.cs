﻿using System.Collections.Generic;

namespace Domain
{
    public static class HearthDb
    {
        public static Dictionary<string, CardData> CardBase { get; set; }

        public static int ManaCost(string cardName)
        {
            if (CardBase == null)
                LoadCardBase();

            var cardData = new CardData();
            if (CardBase.TryGetValue(cardName, out cardData))
            {
                return cardData.ManaCost;
            }
            return -1;
        }

        public static int ManaCost(Card card)
        {
            if (CardBase == null)
                LoadCardBase();

            var cardData = new CardData();
            if (CardBase.TryGetValue(card.Name, out cardData))
            {
                return cardData.ManaCost;
            }
            return -1;
        }

        public static bool HasAoe(Card card)
        {
            if (CardBase == null)
                LoadCardBase();
            var cardData = new CardData();
            if (CardBase.TryGetValue(card.Name, out cardData))
            {
                return cardData.Aoe;
            }
            return false;
        }

		public static bool IsSecret(Card card)
		{
			if (CardBase == null)
				LoadCardBase();
			var cardData = new CardData();
			if (CardBase.TryGetValue(card.Name, out cardData))
			{
				return cardData.IsSecret;
			}
			return false;
		}


		public static bool IsWeapon(Card card)
		{
			if (CardBase == null)
				LoadCardBase();
			var cardData = new CardData();
			if (CardBase.TryGetValue(card.Name, out cardData))
			{
				return cardData.IsWeapon;
			}
			return false;
		}

		public static bool IsRemoval(Card card)
		{
			if (CardBase == null)
				LoadCardBase();
			var cardData = new CardData();
			if (CardBase.TryGetValue(card.Name, out cardData))
			{
				return cardData.IsRemoval;
			}
			return false;
		}

		public static bool IsBurn(Card card)
		{
			if (CardBase == null)
				LoadCardBase();
			var cardData = new CardData();
			if (CardBase.TryGetValue(card.Name, out cardData))
			{
				return cardData.IsBurn;
			}
			return false;
		}

		public static bool Contains(Card card)
		{
			if (CardBase == null)
				LoadCardBase();

			var cardData = new CardData();
			if (CardBase.TryGetValue(card.Name, out cardData))
			{
				return true;
			}
			return false;
		}


		private static void LoadCardBase()
        {
            CardBase = new Dictionary<string, CardData>
            {
{ "Acidic Swamp Ooze", new CardData { ManaCost = 2 } },
{ "Acolyte of Pain", new CardData { ManaCost = 3 } },
{ "Alexstrasza", new CardData { ManaCost = 9 } },
{ "Alleycat", new CardData { ManaCost = 1 } },
{ "Aluneth", new CardData { ManaCost = 6, IsWeapon = true } },
{ "Animal Companion", new CardData { ManaCost = 3 } },
{ "Arcane Artificer", new CardData { ManaCost = 1 } },
{ "Arcane Intellect", new CardData { ManaCost = 3 } },
{ "Arcanite Reaper", new CardData { ManaCost = 5 } },
{ "Arcanologist", new CardData { ManaCost = 2 } },
{ "Archmage Antonidas", new CardData { ManaCost = 7 } },
{ "Argent Squire", new CardData { ManaCost = 1 } },
{ "Aya Blackpaw", new CardData { ManaCost = 4} },
{ "Babbling Book", new CardData { ManaCost = 1 } },
{ "Backstab", new CardData { ManaCost = 0 } },
{ "Barnes", new CardData { ManaCost = 4 } },
{ "Beckoner of Evil", new CardData { ManaCost = 2 } },
{ "Bittertide Hydra", new CardData { ManaCost = 5 } },
{ "Blazecaller", new CardData { ManaCost = 7 } },
{ "Blizzard", new CardData { ManaCost = 6, Aoe = true } },
{ "Blood Razor", new CardData { ManaCost = 4, IsWeapon = true } },
{ "Blood Knight", new CardData { ManaCost = 3 } },
{ "Bloodfury Potion", new CardData { ManaCost = 3, Aoe = true } },
{ "Bloodlust", new CardData { ManaCost = 5 } },
{ "Bloodreaver Gul'dan", new CardData { ManaCost = 10 } },
{ "Bloodsail Cultist", new CardData { ManaCost = 3 } },
{ "Bloodsail Raider", new CardData { ManaCost = 2 } },
{ "Bluegill Warrior", new CardData { ManaCost = 2 } },
{ "Book Wyrm", new CardData { ManaCost = 6 } },
{ "Branching Paths", new CardData { ManaCost = 4 } },
{ "Brawl", new CardData { ManaCost = 5, Aoe = true } },
{ "Bright-Eyed Scout", new CardData { ManaCost = 4 } },
{ "Bring It On!", new CardData { ManaCost = 2 } },
{ "Cabal Shadow Priest", new CardData { ManaCost = 6 } },
{ "Cabalist's Tome", new CardData { ManaCost = 5 } },
{ "Cairn Bloodhoof", new CardData { ManaCost = 6 } },
{ "Call of the Wild", new CardData { ManaCost = 8 } },
{ "Call to Arms", new CardData { ManaCost = 4 } },
{ "Candleshot", new CardData { ManaCost = 1, IsWeapon = true } },
{ "Captain Greenskin", new CardData { ManaCost = 5 } },
{ "Carnivorous Cube", new CardData { ManaCost = 5 } },
{ "Cat Trick", new CardData { ManaCost = 2, IsSecret = true } },
{ "Cavern Shinyfinder", new CardData { ManaCost = 2 } },
{ "Cobalt Scalebane", new CardData { ManaCost = 5 } },
{ "Cold Blood", new CardData { ManaCost = 1 } },
{ "Coldlight Oracle", new CardData { ManaCost = 3 } },
{ "Coldlight Seer", new CardData { ManaCost = 3 } },
{ "Consecration", new CardData { ManaCost = 4 , Aoe = true} },
{ "Corridor Creeper", new CardData { ManaCost = 7 } },
{ "Counterfeit Coin", new CardData { ManaCost = 0 } },
{ "Counterspell", new CardData { ManaCost = 3, IsSecret = true } },
{ "Crackling Razormaw", new CardData { ManaCost = 2 } },
{ "Crystalweaver", new CardData { ManaCost = 4 } },
{ "C'Thun", new CardData { ManaCost = 10 } },
{ "C'Thun's Chosen", new CardData { ManaCost = 4 } },
{ "Curious Glimmerroot", new CardData { ManaCost = 3 } },
{ "Crystal Lion", new CardData { ManaCost = 6 } },
{ "Dark Arakkoa", new CardData { ManaCost = 6 } },
{ "Dark Pact", new CardData { ManaCost = 1 } },
{ "Dead Man's Hand", new CardData { ManaCost = 2 } },
{ "Deadly Poison", new CardData { ManaCost = 1 } },
{ "Deadly Shot", new CardData { ManaCost = 3, IsRemoval = true } },
{ "Deathstalker Rexxar", new CardData { ManaCost = 6, Aoe = true } },
{ "Deathwing", new CardData { ManaCost = 10 } },
{ "Deathwing, Dragonlord", new CardData { ManaCost = 10 } },
{ "Defile", new CardData { ManaCost = 2, Aoe = true } },
{ "Demonfire", new CardData { ManaCost = 1 } },
{ "Despicable Dreadlord", new CardData { ManaCost = 5, Aoe = true } },
{ "Devolve", new CardData { ManaCost = 2, Aoe = true } },
{ "Dire Mole", new CardData { ManaCost = 1 } },
{ "Dire Wolf Alpha", new CardData { ManaCost = 2 } },
{ "Dirty Rat", new CardData { ManaCost = 2 } },
{ "Disciple of C'Thun", new CardData { ManaCost = 3 } },
{ "Divine Favor", new CardData { ManaCost = 3 } },
{ "Divine Spirit", new CardData { ManaCost = 2 } },
{ "Doomerang", new CardData { ManaCost = 1 } },
{ "Doomguard", new CardData { ManaCost = 5 } },
{ "Doomsayer", new CardData { ManaCost = 2, Aoe = true  } },
{ "Dopplegangster", new CardData { ManaCost = 5 } },
{ "Dragoncaller Alanna", new CardData { ManaCost = 9 } },
{ "Dragonhatcher", new CardData { ManaCost = 9 } },
{ "Dragon's Fury", new CardData { ManaCost = 5, Aoe = true } },
{ "Drakkari Enchanter", new CardData { ManaCost = 3 } },
{ "Drakonid Operative", new CardData { ManaCost = 5 } },
{ "Dread Corsair", new CardData { ManaCost = 4 } },
{ "Druid of the Swarm", new CardData { ManaCost = 2 } },
{ "Drygulch Jailor", new CardData { ManaCost = 2 } },
{ "Drywhisker Armorer", new CardData { ManaCost = 2 } },
{ "Duskbreaker", new CardData { ManaCost = 4 , Aoe = true} },
{ "Eaglehorn Bow", new CardData { ManaCost = 3, IsWeapon = true } },
{ "Earthen Scales", new CardData { ManaCost = 1 } },
{ "Edwin VanCleef", new CardData { ManaCost = 3 } },
{ "Elise the Trailblazer", new CardData { ManaCost = 5 } },
{ "Elven Minstrel", new CardData { ManaCost = 4 } },
{ "Enchanted Raven", new CardData { ManaCost = 1 } },
{ "Equality", new CardData { ManaCost = 2, Aoe = true } },
{ "Eternal Servitude", new CardData { ManaCost = 4 } },
{ "Eviscerate", new CardData { ManaCost = 1 } },
{ "Evolve", new CardData { ManaCost =  1 } },
{ "Execute", new CardData { ManaCost = 2, IsRemoval = true } },
{ "Explosive Runes", new CardData { ManaCost = 3, IsSecret = true } },
{ "Explosive Trap", new CardData { ManaCost = 2, Aoe = true, IsSecret = true } },
{ "Faceless Manipulator", new CardData { ManaCost = 5 } },
{ "Fal'dorei Strider", new CardData { ManaCost = 4 } },
{ "Fan of Knives", new CardData { ManaCost = 3, Aoe = true } },
{ "Fandral Staghelm", new CardData { ManaCost = 4 } },
{ "Fiery War Axe", new CardData { ManaCost = 2, IsWeapon = true } },
{ "Finja the Flying Star", new CardData { ManaCost = 5 } },
{ "Fire Fly", new CardData { ManaCost = 1 } },
{ "Fire Plume Phoenix", new CardData { ManaCost = 4 } },
{ "Fireball", new CardData { ManaCost = 4, IsBurn = true } },
{ "Firelands Portal", new CardData { ManaCost = 7 } },
{ "Flame Imp", new CardData { ManaCost = 1 } },
{ "Flamestrike", new CardData { ManaCost = 7, Aoe = true } },
{ "Flametongue Totem", new CardData { ManaCost = 2 } },
{ "Flanking Strike", new CardData { ManaCost = 4 } },
{ "Flare", new CardData { ManaCost = 2 } },
{ "Free From Amber", new CardData { ManaCost = 8 } },
{ "Freezing Trap", new CardData { ManaCost = 1, IsSecret = true } },
{ "Frost Lich Jaina", new CardData { ManaCost = 9 } },
{ "Frost Nova", new CardData { ManaCost = 3, Aoe = true } },
{ "Frostbolt", new CardData { ManaCost = 2, IsBurn = true } },
{ "Frothing Berserker", new CardData { ManaCost = 3 } },
{ "Fungalmancer", new CardData { ManaCost = 5 } },
{ "Gadgetzan Auctioneer", new CardData { ManaCost = 6 } },
{ "Gadgetzan Ferryman", new CardData { ManaCost = 2 } },
{ "Glacial Shard", new CardData { ManaCost = 1 } },
{ "Gentle Megasaur", new CardData { ManaCost = 4 } },
{ "Grand Archivist", new CardData { ManaCost = 8 } },
{ "Greater Healing Potion", new CardData { ManaCost = 4 } },
{ "Greedy Sprite", new CardData { ManaCost = 3 } },
{ "Grimscale Chum", new CardData { ManaCost = 1 } },
{ "Grumble Worldshaker", new CardData { ManaCost = 6 } },
{ "Harrison Jones", new CardData { ManaCost = 5 } },
{ "Healing Rain", new CardData { ManaCost = 3 } },
{ "Hellfire", new CardData { ManaCost = 4 , Aoe = true} },
{ "Heroic Strike", new CardData { ManaCost = 2 } },
{ "Hex", new CardData { ManaCost = 3, IsRemoval = true } },
{ "Holy Smite", new CardData { ManaCost = 1 } },
{ "Hemet Jungle Hunter", new CardData { ManaCost = 6 } },
{ "Houndmaster", new CardData { ManaCost = 4 } },
{ "Hungry Crab", new CardData { ManaCost = 1 } },
{ "Hunter's Mark", new CardData { ManaCost = 1 } },
{ "Hydrologist", new CardData { ManaCost = 2 } },
{ "Ice Barrier", new CardData { ManaCost = 3, IsSecret = true } },
{ "Ice Block", new CardData { ManaCost = 3, IsSecret = true } },
{ "Inner Fire", new CardData { ManaCost = 1 } },
{ "Innervate", new CardData { ManaCost = 1 } },
{ "Jade Behemoth", new CardData { ManaCost = 6 } },
{ "Jade Blossom", new CardData { ManaCost = 3 } },
{ "Jade Chieftan", new CardData { ManaCost = 7 } },
{ "Jade Claws", new CardData { ManaCost = 4 } },
{ "Jade Idol", new CardData { ManaCost = 1 } },
{ "Jade Lightning", new CardData { ManaCost = 4 } },
{ "Jade Spirit", new CardData { ManaCost = 4 } },
{ "Jinyu Waterspeaker", new CardData { ManaCost = 4 } },
{ "Kabal Crystal Runner", new CardData { ManaCost = 6 } },
{ "Kabal Lackey", new CardData { ManaCost = 1 } },
{ "Kabal Songstealer", new CardData { ManaCost = 5 } },
{ "Kabal Talonpriest", new CardData { ManaCost = 3 } },
{ "Kill Command", new CardData { ManaCost = 3, IsRemoval = true } },
{ "Kindly Grandmother", new CardData { ManaCost = 2 } },
{ "Kingsbane", new CardData { ManaCost = 1, IsWeapon = true } },
{ "Kirin Tor Mage", new CardData { ManaCost = 3 } },
{ "Knife Juggler", new CardData { ManaCost = 2 } },
{ "Kobold Librarian", new CardData { ManaCost = 1 } },
{ "Kor'kron Elite", new CardData { ManaCost = 3 } },
{ "Kun the Forgotten King", new CardData { ManaCost = 10 } },
{ "Leeching Poison", new CardData { ManaCost = 2 } },
{ "Leeroy Jenkins", new CardData { ManaCost = 5, IsBurn = true } },
{ "Lesser Amethyst Spellstone", new CardData { ManaCost = 4 } },
{ "Lesser Diamond Spellstone", new CardData { ManaCost = 7 } },
{ "Lesser Emerald Spellstone", new CardData { ManaCost = 5 } },
{ "Lesser Jasper Spellstone", new CardData { ManaCost = 1 } },
{ "Level Up!", new CardData { ManaCost = 5, Aoe = true } },
{ "Lightfused Stegodon", new CardData { ManaCost = 4 } },
{ "Living Mana", new CardData { ManaCost = 5 , Aoe = true} },
{ "Loot Hoarder", new CardData { ManaCost = 2 } },
{ "Lost in the Jungle", new CardData { ManaCost = 1 } },
{ "Maelstrom Portal", new CardData { ManaCost = 1 , Aoe = true} },
{ "Malchezaar's Imp", new CardData { ManaCost = 1 } },
{ "Malfurion the Pestilent", new CardData { ManaCost = 7 } },
{ "Malygos", new CardData { ManaCost = 9 } },
{ "Mana Bind", new CardData { ManaCost = 3 } },
{ "Mana Tide Totem", new CardData { ManaCost = 3 } },
{ "Mana Wyrm", new CardData { ManaCost = 1 } },
{ "Mark of the Lotus", new CardData { ManaCost = 1 } },
{ "Mark of Y'Shaarj", new CardData { ManaCost = 2 } },
{ "Mass Dispel", new CardData { ManaCost = 4 } },
{ "Master Oakheart", new CardData { ManaCost = 9 } },
{ "Master of Evolution", new CardData { ManaCost = 4 } },
{ "Medivh the Guardian", new CardData { ManaCost = 8 } },
{ "Medivh's Valet", new CardData { ManaCost = 2 } },
{ "Meteor", new CardData { ManaCost = 6, Aoe = true } },
{ "Mimic Pod", new CardData { ManaCost = 3 } },
{ "Mind Blast", new CardData { ManaCost = 2 } },
{ "Mind Control", new CardData { ManaCost = 10 } },
{ "Mind Control Tech", new CardData { ManaCost = 3 } },
{ "Mire Keeper", new CardData { ManaCost = 4 } },
{ "Mistress of Mixtures", new CardData { ManaCost = 1 } },
{ "Molten Reflection", new CardData { ManaCost = 4 } },
{ "Mortal Coil", new CardData { ManaCost = 1 } },
{ "Mountain Giant", new CardData { ManaCost = 12 } },
{ "Murloc Tidecaller", new CardData { ManaCost = 1 } },
{ "Murloc Warleader", new CardData { ManaCost = 3 } },
{ "Murmuring Elemental", new CardData { ManaCost = 2 } },
{ "Nage Corsair", new CardData { ManaCost = 4 } },
{ "Netherspite Historian", new CardData { ManaCost = 2 } },
{ "Northshire Cleric", new CardData { ManaCost = 1 } },
{ "Nourish", new CardData { ManaCost = 5 } },
{ "Novice Engineer", new CardData { ManaCost = 2 } },
{ "N'Zoth the Corruptor", new CardData { ManaCost = 10 } },
{ "N'Zoth's First Mate", new CardData { ManaCost = 1 } },
{ "Oaken Summons", new CardData { ManaCost = 4 } },
{ "Obsidian Statue", new CardData { ManaCost = 9 } },
{ "Open the Waygate", new CardData { ManaCost = 1 } },
{ "Patches the Pirate", new CardData { ManaCost = 1 } },
{ "Pint-Size Potion", new CardData { ManaCost = 1 } },
{ "Plated Beetle", new CardData { ManaCost = 2 } },
{ "Polymorph", new CardData { ManaCost = 4 } },
{ "Possessed Lackey", new CardData { ManaCost = 5 } },
{ "Potion of Madness", new CardData { ManaCost = 1 } },
{ "Power of the Wild", new CardData { ManaCost = 2 } },
{ "Power Word: Shield", new CardData { ManaCost = 1 } },
{ "Preparation", new CardData { ManaCost = 0 } },
{ "Priest of the Feast", new CardData { ManaCost = 4 } },
{ "Primordial Drake", new CardData { ManaCost = 8 } },
{ "Primordial Glyph", new CardData { ManaCost = 2 } },
{ "Prince Keleseth", new CardData { ManaCost = 2 } },
{ "Prince Taldaram", new CardData { ManaCost = 3 } },
{ "Prophet Velen", new CardData { ManaCost = 7 } },
{ "Psychic Scream", new CardData { ManaCost = 7, Aoe = true } },
{ "Pyroblast", new CardData { ManaCost = 10, IsBurn = true } },
{ "Radiant Elemental", new CardData { ManaCost = 2 } },
{ "Ragnaros Lightlord", new CardData { ManaCost = 8 } },
{ "Rallying Blade", new CardData { ManaCost = 3, IsWeapon = true } },
{ "Raven Familiar", new CardData { ManaCost = 2 } },
{ "Rhok'delar", new CardData { ManaCost = 7, IsWeapon = true } },
{ "Righteous Protector", new CardData { ManaCost = 1 } },
{ "Rin the First Disciple", new CardData { ManaCost = 6 } },
{ "Rockpool Hunter", new CardData { ManaCost = 2 } },
{ "Rummaging Kobold", new CardData { ManaCost = 3 } },
{ "Sap", new CardData { ManaCost = 2 } },
{ "Saronite Chang Gang", new CardData { ManaCost = 4 } },
{ "Savage Roar", new CardData { ManaCost = 3 } },
{ "Scavenging Hyena", new CardData { ManaCost = 2 } },
{ "Scourgelord Garrosh", new CardData { ManaCost = 8 } },
{ "Shadow Ascendant", new CardData { ManaCost = 2 } },
{ "Shadow Essence", new CardData { ManaCost = 6 } },
{ "Shadow Visions", new CardData { ManaCost = 2 } },
{ "Shadow Word: Death", new CardData { ManaCost = 3 } },
{ "Shadow Word: Horror", new CardData { ManaCost = 4 } },
{ "Shadowcaster", new CardData { ManaCost = 5 } },
{ "Shadowreaper Anduin", new CardData { ManaCost = 8 } },
{ "Shadowstep", new CardData { ManaCost = 0 } },
{ "Shield Block", new CardData { ManaCost = 3 } },
{ "Shield Slam", new CardData { ManaCost = 1 } },
{ "Shiv", new CardData { ManaCost = 2 } },
{ "SI:7 Agent", new CardData { ManaCost = 3 } },
{ "Siphon Soul", new CardData { ManaCost = 6 } },
{ "Skulking Geist", new CardData { ManaCost = 6 } },
{ "Skull of the Man'ari", new CardData { ManaCost = 5 } },
{ "Slam", new CardData { ManaCost = 2 } },
{ "Sleep with the Fishes", new CardData { ManaCost = 2, Aoe = true } },
{ "Sleepy Dragon", new CardData { ManaCost = 9 } },
{ "Sonya Shadowdancer", new CardData { ManaCost = 3 } },
{ "Sorcerer's Apprentice", new CardData { ManaCost = 2 } },
{ "Soulfire", new CardData { ManaCost = 1 } },
{ "Southsea Captain", new CardData { ManaCost = 3 } },
{ "Southsea Deckhand", new CardData { ManaCost = 1 } },
{ "Southsea Squidface", new CardData { ManaCost = 4 } },
{ "Spellbreaker", new CardData { ManaCost = 4 } },
{ "Spikeridged Steed", new CardData { ManaCost = 6 } },
{ "Spirit Lash", new CardData { ManaCost = 2, Aoe = true } },
{ "Spiteful Summoner", new CardData { ManaCost = 6 } },
{ "Spreading Plague", new CardData { ManaCost = 5 } },
{ "Stand Against Darkness", new CardData { ManaCost = 5 } },
{ "Steward of Darkshire", new CardData { ManaCost = 3 } },
{ "Stonehill Defender", new CardData { ManaCost = 3 } },
{ "Stonetusk Boar", new CardData { ManaCost = 1 } },
{ "Sunkeeper Tarim", new CardData { ManaCost = 6 } },
{ "Swipe", new CardData { ManaCost = 4 , Aoe = true} },
{ "Tar Creeper", new CardData { ManaCost = 3 } },
{ "The Caverns Below", new CardData { ManaCost = 1 } },
{ "The Lich King", new CardData { ManaCost = 8 } },
{ "Thrall Deathseer", new CardData { ManaCost = 5 } },
{ "Tirion Fordring", new CardData { ManaCost = 8 } },
{ "Tracking", new CardData { ManaCost = 1 } },
{ "Twilight Acolyte", new CardData { ManaCost = 3 } },
{ "Twilight Drake", new CardData { ManaCost = 4 } },
{ "Twilight Elder", new CardData { ManaCost = 3 } },
{ "Twin Emperor Vak'lor", new CardData { ManaCost = 7 } },
{ "Twisting Nether", new CardData { ManaCost = 8 , Aoe = true} },
{ "Ultimate Infestation", new CardData { ManaCost = 10 } },
{ "Unidentified Maul", new CardData { ManaCost = 3, IsWeapon = true } },
{ "Unleash the Hounds", new CardData { ManaCost = 3 , Aoe = true} },
{ "Unlicensed Apothecary", new CardData { ManaCost = 3 } },
{ "Unstable Evolution", new CardData { ManaCost = 1 } },
{ "Upgrade!", new CardData { ManaCost = 0 } },
{ "Uther of the Ebon Blade", new CardData { ManaCost = 9 } },
{ "Val'anyr", new CardData { ManaCost = 6 } },
{ "Valeera the Hollow", new CardData { ManaCost = 9 } },
{ "Vanish", new CardData { ManaCost = 6 } },
{ "Vilefin Inquisitor", new CardData { ManaCost = 1 } },
{ "Vilespine Slayer", new CardData { ManaCost = 5, IsRemoval = true } },
{ "Vinecleaver", new CardData { ManaCost = 7, IsWeapon = true } },
{ "Violent Teacher", new CardData { ManaCost = 4 } },
{ "Viscious Fledgling", new CardData { ManaCost = 3 } },
{ "Voidlord", new CardData { ManaCost = 9 } },
{ "Voidwalker", new CardData { ManaCost = 1 } },
{ "Volcano", new CardData { ManaCost = 5, Aoe = true } },
{ "Vulgar Homunculus", new CardData { ManaCost = 2 } },
{ "Wandering Monster", new CardData { ManaCost = 2, IsSecret = true } },
{ "Wax Elemental", new CardData { ManaCost = 1 } },
{ "Whirlwind", new CardData { ManaCost = 1 , Aoe = true} },
{ "Wild Growth", new CardData { ManaCost = 2 } },
{ "Wild Pyromancer", new CardData { ManaCost = 2, Aoe = true } },
{ "Youthful Brewmaster", new CardData { ManaCost = 2 } },
{ "Ysera", new CardData { ManaCost = 9 } },
{ "Y'Shaarj Rage Unbound", new CardData { ManaCost = 10 } },
{ "Zola the Gorgon", new CardData { ManaCost = 3 } },
{"Acherus Veteran", new CardData { ManaCost = 1 } },
 {"Acidic Swap Ooze", new CardData { ManaCost = 2 } },
 {"Al'Akir the Windlord", new CardData { ManaCost = 8 } },
 {"Alexstraza", new CardData { ManaCost = 9 } },
 {"Amani Berserker", new CardData { ManaCost = 2 } },
 {"Arcane Keysmith", new CardData { ManaCost = 4 } },
 {"Arcane Missiles", new CardData { ManaCost = 1 } },
 {"Arcane Shot", new CardData { ManaCost = 1 } },
 {"Arcane Tyrant", new CardData { ManaCost = 5 } },
 {"Archbishop Benedictus", new CardData { ManaCost = 7 } },
 {"Argent Commander", new CardData { ManaCost = 6 } },
 {"Argent Protector", new CardData { ManaCost = 2 } },
 {"Armani Berserker", new CardData { ManaCost = 0 } },
 {"Avenging Wrath", new CardData { ManaCost = 6 } },
 {"Awaken the Makers", new CardData { ManaCost = 1 } },
 {"Baku the Mooneater", new CardData { ManaCost = 9 } },
 {"Baleful Banker", new CardData { ManaCost = 2 } },
 {"Baron Geddon", new CardData { ManaCost = 7 } },
 {"Blessing of Kings", new CardData { ManaCost = 4 } },
 {"Blessing of Might", new CardData { ManaCost = 1 } },
 {"Blink Fox", new CardData { ManaCost = 3 } },
 {"Bloodmage Thalnos", new CardData { ManaCost = 2 } },
 {"Bone Drake", new CardData { ManaCost = 6 } },
 {"Charged Devilsaur", new CardData { ManaCost = 8 } },
 {"Chillblade Champion", new CardData { ManaCost = 4 } },
 {"Cinderstorm", new CardData { ManaCost = 3 } },
 {"Circle of Healing", new CardData { ManaCost = 0 } },
 {"Cornered Sentry", new CardData { ManaCost = 2 } },
 {"Corpsetaker", new CardData { ManaCost = 4 } },
 {"Crypt Lord", new CardData { ManaCost = 3 } },
 {"Crystalline Oracle", new CardData { ManaCost = 1 } },
 {"Darius Crowley", new CardData { ManaCost = 5 } },
 {"Dark Iron Dwarf", new CardData { ManaCost = 4 } },
 {"Divine Hymn", new CardData { ManaCost = 2 } },
 {"Dread Infernal", new CardData { ManaCost = 6 } },
 {"Druid of the Scythe", new CardData { ManaCost = 3 } },
 {"Earthen Might", new CardData { ManaCost = 1 } },
 {"Evolving Spores", new CardData { ManaCost = 4 } },
 {"Far Sight", new CardData { ManaCost = 3 } },
 {"Ferocious Howl", new CardData { ManaCost = 3 } },
 {"Fire Elemental", new CardData { ManaCost = 6 } },
 {"Fire Plume's Heart", new CardData { ManaCost = 1 } },
 {"Forge Of Souls", new CardData { ManaCost = 2 } },
 {"Gather Your Party", new CardData { ManaCost = 6 } },
 {"Genn Greymane", new CardData { ManaCost = 6 } },
 {"Geosculptor Yip", new CardData { ManaCost = 8 } },
 {"Gluttonous Ooze", new CardData { ManaCost = 3 } },
 {"Gnomeferatu", new CardData { ManaCost = 2 } },
 {"Grievous Bite", new CardData { ManaCost = 2 } },
 {"Grommash Hellscream", new CardData { ManaCost = 8 } },
 {"Hadronox", new CardData { ManaCost = 9 } },
 {"Hagatha The Witch", new CardData { ManaCost = 8, Aoe = true } },
 {"Hallucination", new CardData { ManaCost = 1 } },
 {"Hammer of Wrath", new CardData { ManaCost = 4 } },
 {"Hench-Clan Thug", new CardData { ManaCost = 3 } },
 {"Holy Fire", new CardData { ManaCost = 6 } },
 {"Hooked Reaver", new CardData { ManaCost = 4 } },
 {"Injured Blademaster", new CardData { ManaCost = 3 } },
 {"Iron Hide", new CardData { ManaCost = 1 } },
 {"Ironbeak Owl", new CardData { ManaCost = 3 } },
 {"Ironwood Golem", new CardData { ManaCost = 4 } },
 {"Kalimos Primal Lord", new CardData { ManaCost = 8 } },
 {"Kathrena Winterwisp", new CardData { ManaCost = 8 } },
 {"King Krush", new CardData { ManaCost = 9 } },
 {"Knife Jugger", new CardData { ManaCost = 2 } },
 {"Lifedrinker", new CardData { ManaCost = 4 } },
 {"Lightning Bolt", new CardData { ManaCost = 1 } },
 {"Lightning Storm", new CardData { ManaCost = 3, Aoe = true } },
 {"Lord Godfrey", new CardData { ManaCost = 7 } },
 {"Lyra the Sunshard", new CardData { ManaCost = 5 } },
 {"Moonfire", new CardData { ManaCost = 0 } },
 {"Mossy Horror", new CardData { ManaCost = 6 } },
 {"Murkspark Eel", new CardData { ManaCost = 2 } },
 {"Naturalize", new CardData { ManaCost = 1 } },
 {"Nightmare Amalgam", new CardData { ManaCost = 4 } },
 {"Phantom Militia", new CardData { ManaCost = 3 } },
 {"Play Dead", new CardData { ManaCost = 1 } },
 {"Primalfin Totem", new CardData { ManaCost = 2 } },
 {"Rabid Worgen", new CardData { ManaCost = 3 } },
 {"Radient Elemental", new CardData { ManaCost = 2 } },
 {"Raid Leader", new CardData { ManaCost = 3 } },
 {"Reckless Flurry", new CardData { ManaCost = 3 } },
 {"Rotface", new CardData { ManaCost = 8 } },
 {"Rotten Applebaum", new CardData { ManaCost = 5 } },
 {"Sandbinder", new CardData { ManaCost = 4 } },
 {"Saronite Chain Gang", new CardData { ManaCost = 4 } },
 {"Savannah Highmane", new CardData { ManaCost = 6 } },
 {"Sea Giant", new CardData { ManaCost = 10 } },
 {"Shroom Brewer", new CardData { ManaCost = 4 } },
 {"Shudderwock", new CardData { ManaCost = 9 } },
 {"Silence", new CardData { ManaCost = 0 } },
 {"Silver Vanguard", new CardData { ManaCost = 7 } },
 {"Sindragosa", new CardData { ManaCost = 8 } },
 {"Snipe", new CardData { ManaCost = 2, IsSecret = true } },
 {"Soul of the Forest", new CardData { ManaCost = 4 } },
 {"Spiritsinger Umbra", new CardData { ManaCost = 4 } },
 {"Starfall", new CardData { ManaCost = 5, Aoe = true } },
 {"Stitched Tracker", new CardData { ManaCost = 3 } },
 {"Stormwind Champion", new CardData { ManaCost = 7 } },
 {"Sunfury Protector", new CardData { ManaCost = 2 } },
 {"The Glass Knight", new CardData { ManaCost = 4 } },
 {"Tinkmaster Overspark", new CardData { ManaCost = 3 } },
 {"To My Side!", new CardData { ManaCost = 6 } },
 {"Tortollan Shellraiser", new CardData { ManaCost = 4 } },
 {"Town Crier", new CardData { ManaCost = 1 } },
 {"Truesilver Champion", new CardData { ManaCost = 4 } },
 {"Twig Of The World Tree", new CardData { ManaCost = 4, IsWeapon = true } },
 {"Twillight's Call", new CardData { ManaCost = 3 } },
 {"Unpowered Steambot", new CardData { ManaCost = 4 } },
 {"Vicious Fledgling", new CardData { ManaCost = 3 } },
 {"Vicious Scalehide", new CardData { ManaCost = 2 } },
 {"Violet Teacher", new CardData { ManaCost = 4 } },
 {"Voodoo Doll", new CardData { ManaCost = 3 } },
 {"Warpath", new CardData { ManaCost = 2 } },
 {"Wing Blast", new CardData { ManaCost = 4 } },
 {"Wispering Woods", new CardData { ManaCost = 4 } },
 {"Witching Hour", new CardData { ManaCost = 3 } },
 {"Witch's Cauldron", new CardData { ManaCost = 3 } },
 {"Witchwood Piper", new CardData { ManaCost = 4 } },
 {"Woecleaver", new CardData { ManaCost = 8, IsWeapon = true } },
 {"Wolfrider", new CardData { ManaCost = 3 } },
 {"Woodcutter's Axe", new CardData { ManaCost = 2, IsWeapon = true } },
 {"Wrath", new CardData { ManaCost = 2 } },
{ "Academic Espionage", new CardData { ManaCost = 4 } },
 { "Arcane Dynamo", new CardData { ManaCost = 6 } },
 { "Arcane Intelect", new CardData { ManaCost = 3 } },
 { "Astromancer", new CardData { ManaCost = 7 } },
 { "Augmented Elekk", new CardData { ManaCost = 3 } },
 { "Azalina Soulthief", new CardData { ManaCost = 7 } },
 { "Barkskin", new CardData { ManaCost = 1 } },
 { "Beryllium Nullifier", new CardData { ManaCost = 7 } },
 { "Big Game Hunter", new CardData { ManaCost = 5 } },
 { "Binding Heal", new CardData { ManaCost = 1 } },
 { "Biology Project", new CardData { ManaCost = 1 } },
 { "Blade Flurry", new CardData { ManaCost = 2, Aoe = true } },
 { "Blightnozzle Crawler", new CardData { ManaCost = 4 } },
 { "Bloodbloom", new CardData { ManaCost = 2 } },
 { "Bull Dozer", new CardData { ManaCost = 9 } },
 { "Cataclysm", new CardData { ManaCost = 4 } },
 { "Celestial Emissary", new CardData { ManaCost = 2 } },
 { "Coffin Crasher", new CardData { ManaCost = 6 } },
 { "Colbalt Scalebane", new CardData { ManaCost = 5 } },
 { "Cosmic Anomaly", new CardData { ManaCost = 4 } },
 { "Damaged Stegotron", new CardData { ManaCost = 6 } },
 { "Dead Ringer", new CardData { ManaCost = 2 } },
 { "Demonic Project", new CardData { ManaCost = 2 } },
 { "Dendrologist", new CardData { ManaCost = 2 } },
 { "Devilsaur Egg", new CardData { ManaCost = 3 } },
 { "Direhorn Hatchling", new CardData { ManaCost = 5 } },
 { "Dr. Boom, Mad Genius", new CardData { ManaCost = 7 } },
 { "Dreampetal Florist", new CardData { ManaCost = 7 } },
 { "Dyn-o-matic", new CardData { ManaCost = 5 } },
 { "Earth Shock", new CardData { ManaCost = 1 } },
 { "Electra Stormsurge", new CardData { ManaCost = 3 } },
 { "Eternium Rover", new CardData { ManaCost = 1 } },
 { "Fireworks Tech", new CardData { ManaCost = 2 } },
 { "Flobbidinous Floop", new CardData { ManaCost = 4 } },
 { "Floop's Glorious Gloop", new CardData { ManaCost = 1 } },
 { "Fungal Enchanter", new CardData { ManaCost = 5 } },
 { "Galvanizer", new CardData { ManaCost = 2 } },
 { "Giggling Inventor", new CardData { ManaCost = 5 } },
 { "Gloop Sprayer", new CardData { ManaCost = 8 } },
 { "Glow-Tron", new CardData { ManaCost = 1 } },
 { "Gorehowl", new CardData { ManaCost = 7, IsWeapon = true } },
 { "Happy Ghoul", new CardData { ManaCost = 3 } },
 { "Houndmaster Shaw", new CardData { ManaCost = 4 } },
 { "Juicy Psychmelon", new CardData { ManaCost = 4 } },
 { "King Mosh", new CardData { ManaCost = 9 } },
 { "King Togwaggle", new CardData { ManaCost = 8 } },
 { "Lab Recruiter", new CardData { ManaCost = 2 } },
 { "Landscaping", new CardData { ManaCost = 3 } },
 { "Lightwarden", new CardData { ManaCost = 1 } },
 { "Lorewalker Cho", new CardData { ManaCost = 2 } },
 { "Luna's Pocket Galaxy", new CardData { ManaCost = 7 } },
 { "Mechanical Whelp", new CardData { ManaCost = 6 } },
 { "Mecharoo", new CardData { ManaCost = 1 } },
 { "Mecha'thun", new CardData { ManaCost = 10 } },
 { "Menacing Nimbus", new CardData { ManaCost = 2 } },
 { "Mirror Image", new CardData { ManaCost = 1 } },
 { "Mulchmuncher", new CardData { ManaCost = 10 } },
 { "Myra's Unstable Element", new CardData { ManaCost = 5 } },
 { "Necrium Blade", new CardData { ManaCost = 3, IsWeapon = true } },
 { "Necrium Vial", new CardData { ManaCost = 5 } },
 { "Omega Assembly", new CardData { ManaCost = 1 } },
 { "Pogo-Hopper", new CardData { ManaCost = 2 } },
 { "Professor Putricide", new CardData { ManaCost = 4 } },
 { "Rat Trap", new CardData { ManaCost = 2 } },
 { "Reckless Experimenter", new CardData { ManaCost = 5 } },
 { "Sacrificial Pact", new CardData { ManaCost = 0 } },
 { "Shadowflame", new CardData { ManaCost = 4 } },
 { "Shooting Star", new CardData { ManaCost = 1 } },
 { "Soul Infusion", new CardData { ManaCost = 1 } },
 { "Spider Bomb", new CardData { ManaCost = 3 } },
 { "Sprint", new CardData { ManaCost = 7 } },
 { "Stargazer Luna", new CardData { ManaCost = 3 } },
 { "Storm Chaser", new CardData { ManaCost = 4 } },
 { "Stormforged Axe", new CardData { ManaCost = 2 } },
 { "Subject 9", new CardData { ManaCost = 5 } },
 { "Terrorscale Stalker", new CardData { ManaCost = 3 } },
 { "Test Subject", new CardData { ManaCost = 1 } },
 { "The Black Knight", new CardData { ManaCost = 6 } },
 { "The Boomship", new CardData { ManaCost = 9 } },
 { "The Runespear", new CardData { ManaCost = 8 } },
 { "The Soularium", new CardData { ManaCost = 1 } },
 { "Thunderhead", new CardData { ManaCost = 4 } },
 { "Ticking Abomination", new CardData { ManaCost = 4 } },
 { "Topsy Turvy", new CardData { ManaCost = 0 } },
 { "Toxicologist", new CardData { ManaCost = 2 } },
 { "Twilight's Call", new CardData { ManaCost = 3 } },
 { "Tyrantus", new CardData { ManaCost = 10 } },
 { "Vivid Nightmare", new CardData { ManaCost = 3 } },
 { "Void Ripper", new CardData { ManaCost = 3 } },
 { "Voodoo Doctor", new CardData { ManaCost = 1 } },
 { "Wargear", new CardData { ManaCost = 5 } },
 { "Weapons Project", new CardData { ManaCost = 2 } },
 { "Zap!", new CardData { ManaCost = 0 } },
 { "Zilliax", new CardData { ManaCost = 5 } },


			};
        }

    }

    public class CardData
    {
        public int ManaCost { get; set; }
        public bool Aoe { get; set; }
		public bool IsSecret { get; set; }
		public bool IsWeapon { get; set; }
		public bool IsRemoval { get; set; }
		public bool IsBurn { get; set; }
	}
}