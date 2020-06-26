using System;
using System.Collections.Generic;

namespace Domain.Metas
{
	public static class RiseOfShadows
	{
		public static Meta LoadMeta()
		{
			var meta = new Meta(
				code: "RS",
				name: "Rise of Shadows",
				patchNo: 14.4M,
				asOf: new DateTime(2019, 6, 10));

			//  TIER 1
			var tier1Decks = new List<Deck>
			{
				BombWarrior(),
				CycloneGiantsMage(),
				TempoRogue(),
				BombHunter(),
			};
			meta.AddDecks(tier1Decks, 1);

			//  TIER 2
			var tier2Decks = new List<Deck>
			{
				MidrangeHunter(),
				HolyWrathPaladin(),
				FreezeMage(),
				ControlWarrior(),
				MechPaladin(),
				AggroShaman(),
				MurlocShaman(),
			};
			meta.AddDecks(tier2Decks, 2);

			//  TIER 3
			var tier3Decks = new List<Deck>
			{
				TokenDruid(),
				PogoRogue(),
				DragonConjurerMage(),
				ZooWarlock(),
				SecretHunter(),
				DeathrattleMechHunter(),
				ControlShaman(),
				ComboMechPriest(),
			};
			meta.AddDecks(tier3Decks, 3);

			//  TIER 4
			var tier4Decks = new List<Deck>
			{
				ChefNomiPriest(),
				HealDruid(),
				MechathunWarrior(),
				ResurrectPriest(),
			};
			meta.AddDecks(tier4Decks, 4);

			////  TIER 5
			var tier5Decks = new List<Deck>
			{
				HooktuskRogue(),
				BigShaman(),
				MiracleDruid(),
			};
			meta.AddDecks(tier5Decks, 5);

			////  TIER 6 Nether Storm
			var tier6Decks = new List<Deck>
			{
				MindBlastPriest(),
				MiracleRogue(),
				SilencePriest(),
				SecretPaladin(),
				MalygosDruid(),
				ColdBrewMage()
			};
			meta.AddDecks(tier6Decks, 6);

			return meta;
		}

		private static Deck BigShaman()
		{
			return new Deck
			{
				Name = "Big Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Ancestral Healing" },
					new Card { Name = "Earth Shock" },
					new Card { Name = "Ancestral Spirit" },
					new Card { Name = "Big Bad Voodoo" },
					new Card { Name = "Witch's Brew" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Haunting Visions" },
					new Card { Name = "Spirit of the Frog" },
					new Card { Name = "Hex" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Muckmorpher" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Cairne Bloodhoof" },
					new Card { Name = "Eureka!" },
					new Card { Name = "Al'Akir the Windlord" },
					new Card { Name = "Hagatha the Witch" },
					new Card { Name = "Walking Fountain" },
					new Card { Name = "Ysera" },
					new Card { Name = "Big Bad Archmage" },
				}
			};
		}
		private static Deck ComboMechPriest()
		{
			return new Deck
			{
				Name = "Combo Mech Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Circle of Healing" },
					new Card { Name = "Silence" },
					new Card { Name = "Inner Fire" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Divine Spirit" },
					new Card { Name = "Extra Arms" },
					new Card { Name = "Upgradeable Framebot" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Bronze Gatekeeper" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Coppertail Imposter" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Unpowered Steambot" },
					new Card { Name = "Zilliax" },
				}
			};
		}

		private static Deck SilencePriest()
		{
			return new Deck
			{
				Name = "Silence Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Circle of Healing" },
					new Card { Name = "Silence" },
					new Card { Name = "Inner Fire" },
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Ancient Watcher" },
					new Card { Name = "Dalaran Librarian" },
					new Card { Name = "Divine Spirit" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Arcane Watcher" },
					new Card { Name = "Faceless Rager" },
					new Card { Name = "Hench-Clan Shadequill" },
					new Card { Name = "Unsleeping Soul" },
					new Card { Name = "Quartz Elemental" },
				}
			};
		}

		private static Deck SecretPaladin()
		{
			return new Deck
			{
				Name = "Secret Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Autodefense Matrix" },
					new Card { Name = "Desperate Measures" },
					new Card { Name = "Hidden Wisdom" },
					new Card { Name = "Never Surrender!" },
					new Card { Name = "Noble Sacrifice" },
					new Card { Name = "Redemption" },
					new Card { Name = "Secretkeeper" },
					new Card { Name = "Mysterious Blade" },
					new Card { Name = "Sunreaver Spy" },
					new Card { Name = "Commander Rhyssa" },
					new Card { Name = "Masked Contender" },
					new Card { Name = "Bellringer Sentry" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Captain Greenskin" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Subject 9" },
				}
			};
		}

		private static Deck MiracleDruid()
		{
			return new Deck
			{
				Name = "Miracle Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Pounce" },
					new Card { Name = "Biology Project" },
					new Card { Name = "Crystal Power" },
					new Card { Name = "Floop's Glorious Gloop" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Keeper Stalladris" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Wrath" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Marsh Drake" },
					new Card { Name = "Flobbidinous Floop" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Gadgetzan Auctioneer" },
					new Card { Name = "Chef Nomi" },
				}
			};
		}

		private static Deck MechathunWarrior()
		{
			return new Deck
			{
				Name = "Mechathun Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Inner Rage" },
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Whirlwind" },
					new Card { Name = "Slam" },
					new Card { Name = "Warpath" },
					new Card { Name = "Weapons Project" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Militia Commander" },
					new Card { Name = "Brawl" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Malygos" },
					new Card { Name = "The Boomship" },
					new Card { Name = "Mecha'thun" },
				}
			};
		}

		private static Deck BombHunter()
		{
			return new Deck
			{
				Name = "Bomb Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
	{
		new Card { Name = "Mecharoo" },
					new Card { Name = "Bomb Toss" },
					new Card { Name = "Fireworks Tech" },
					new Card { Name = "Galvanizer" },
					new Card { Name = "Upgradeable Framebot" },
					new Card { Name = "Venomizer" },
					new Card { Name = "Harvest Golem" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Spider Bomb" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Explodinator" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Replicating Menace" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Wargear" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Missile Launcher" },
					new Card { Name = "Boommaster Flark" },
				}
			};
		}
		private static Deck AggroShaman()
		{
			return new Deck
			{
				Name = "Aggro Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
	{
		new Card { Name = "Zap!" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Voltaic Burst" },
					new Card { Name = "Earthen Might" },
					new Card { Name = "Likkim" },
					new Card { Name = "Rockbiter Weapon" },
					new Card { Name = "Underbelly Angler" },
					new Card { Name = "Electra Stormsurge" },
					new Card { Name = "Feral Spirit" },
					new Card { Name = "Haunting Visions" },
					new Card { Name = "Lava Burst" },
					new Card { Name = "Spirit of the Frog" },
					new Card { Name = "Unbound Elemental" },
					new Card { Name = "Thunderhead" },
					new Card { Name = "Doomhammer" },
				}
			};
		}
		private static Deck BombWarrior()
		{
			return new Deck
			{
				Name = "Bomb Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
	{
		new Card { Name = "Eternium Rover" },
					new Card { Name = "Omega Assembly" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Warpath" },
					new Card { Name = "Weapons Project" },
					new Card { Name = "Augmented Elekk" },
					new Card { Name = "Clockwork Goblin" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Militia Commander" },
					new Card { Name = "Omega Devastator" },
					new Card { Name = "Wrenchcalibur" },
					new Card { Name = "Brawl" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blastmaster Boom" },
					new Card { Name = "Dr. Boom, Mad Genius" },
				}
			};
		}
		private static Deck ChefNomiPriest()
		{
			return new Deck
			{
				Name = "Chef Nomi Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
	{
		new Card { Name = "Circle of Healing" },
					new Card { Name = "Forbidden Words" },
					new Card { Name = "Lazul's Scheme" },
					new Card { Name = "Regenerate" },
					new Card { Name = "Silence" },
					new Card { Name = "Topsy Turvy" },
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Auchenai Phantasm" },
					new Card { Name = "Divine Hymn" },
					new Card { Name = "Seance" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Gadgetzan Auctioneer" },
					new Card { Name = "Chef Nomi" },
					new Card { Name = "Grave Horror" },
				}
			};
		}
		private static Deck ControlShaman()
		{
			return new Deck
			{
				Name = "Control Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
	{
		new Card { Name = "Earth Shock" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Witch's Brew" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Zentimo" },
					new Card { Name = "Hex" },
					new Card { Name = "Sandbinder" },
					new Card { Name = "Storm Chaser" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mojomaster Zihi" },
					new Card { Name = "Giggling Inventor" },
					new Card { Name = "Swampqueen Hagatha" },
					new Card { Name = "Hagatha the Witch" },
					new Card { Name = "Walking Fountain" },
					new Card { Name = "Archivist Elysiana" },
					new Card { Name = "Shudderwock" },
				}
			};
		}
		private static Deck ControlWarrior()
		{
			return new Deck
			{
				Name = "Control Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
	{
		new Card { Name = "Eternium Rover" },
					new Card { Name = "Omega Assembly" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Execute" },
					new Card { Name = "Warpath" },
					new Card { Name = "Weapons Project" },
					new Card { Name = "Youthful Brewmaster" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Militia Commander" },
					new Card { Name = "Omega Devastator" },
					new Card { Name = "Brawl" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Archivist Elysiana" },
				}
			};
		}
		private static Deck ColdBrewMage()
		{
			return new Deck
			{
				Name = "Coldbrew Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Fireball" },
					new Card { Name = "Polymorph" },
					new Card { Name = "Luna's Pocket Galaxy" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Archmage Antonidas" },
					new Card { Name = "Astromancer" },
					new Card { Name = "Jepeto Joybuzz" },
					new Card { Name = "Alexstraza" },
					new Card { Name = "Kalecgos" },
					new Card { Name = "Barista Lynchen" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck CycloneGiantsMage()
		{
			return new Deck
			{
				Name = "Cyclone Giants Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
	{
		new Card { Name = "Elemental Evocation" },
					new Card { Name = "Magic Trick" },
					new Card { Name = "Mirror Image" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Khadgar" },
					new Card { Name = "Mana Cyclone" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Stargazer Luna" },
					new Card { Name = "Sandbinder" },
					new Card { Name = "Vex Crow" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Sea Giant" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck DeathrattleMechHunter()
		{
			return new Deck
			{
				Name = "Deathrattle Mech Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
	{
		new Card { Name = "Mecharoo" },
					new Card { Name = "Fireworks Tech" },
					new Card { Name = "Galvanizer" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Nine Lives" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Spider Bomb" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Houndmaster Shaw" },
					new Card { Name = "Necromechanic" },
					new Card { Name = "Replicating Menace" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Oblivitron" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Zul'jin" },
				}
			};
		}
		private static Deck DragonConjurerMage()
		{
			return new Deck
			{
				Name = "Dragon Conjurer Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
	{
		new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Book of Specters" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Sunfury Protector" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Messenger Raven" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Voodoo Doll" },
					new Card { Name = "Scaleworm" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Dragonmaw Scorcher" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Astromancer" },
					new Card { Name = "Rabble Bouncer" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck FreezeMage()
		{
			return new Deck
			{
				Name = "Freeze Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
	{
		new Card { Name = "Ray of Frost" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Fireball" },
					new Card { Name = "Luna's Pocket Galaxy" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Archmage Antonidas" },
					new Card { Name = "Astromancer" },
					new Card { Name = "Jepetto Joybuzz" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Kalecgos" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck HealDruid()
		{
			return new Deck
			{
				Name = "Heal Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
	{
		new Card { Name = "Crystal Power" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Keeper Stalladris" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Wrath" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Healing Touch" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Witching Hour" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Flobbidinous Floop" },
					new Card { Name = "Juicy Psychmelon" },
					new Card { Name = "Predatory Instincts" },
					new Card { Name = "Swipe" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Starfall" },
					new Card { Name = "Witchwood Grizzly" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Ancient of Lore" },
					new Card { Name = "Gloop Sprayer" },
					new Card { Name = "Lucentbark" },
				}
			};
		}
		private static Deck HolyWrathPaladin()
		{
			return new Deck
			{
				Name = "Holy Wrath Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
	{
		new Card { Name = "Crystology" },
					new Card { Name = "Elven Archer" },
					new Card { Name = "Baleful Banker" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Crystalsmith Kangor" },
					new Card { Name = "Flash of Light" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Time Out!" },
					new Card { Name = "Consecration" },
					new Card { Name = "Hammer of Wrath" },
					new Card { Name = "Prismatic Lens" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Holy Wrath" },
					new Card { Name = "Shrink Ray" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Shirvallah, the Tiger" },
				}
			};
		}
		private static Deck MalygosDruid()
		{
			return new Deck
			{
				Name = "Malygos Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
	{
		new Card { Name = "Moonfire" },
					new Card { Name = "Wrath" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Witching Hour" },
					new Card { Name = "Predatory Instincts" },
					new Card { Name = "Swipe" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Starfall" },
					new Card { Name = "Witchwood Grizzly" },
					new Card { Name = "Nourish" },
					new Card { Name = "Starfire" },
					new Card { Name = "Dreampetal Florist" },
					new Card { Name = "Gloop Sprayer" },
					new Card { Name = "Jepetto Joybuzz" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Malygos" },
				}
			};
		}
		private static Deck MechPaladin()
		{
			return new Deck
			{
				Name = "Mech Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
	{
		new Card { Name = "Crystology" },
					new Card { Name = "Glow-Tron" },
					new Card { Name = "Skaterbot" },
					new Card { Name = "Galvanizer" },
					new Card { Name = "Lightforged Blessing" },
					new Card { Name = "Bronze Gatekeeper" },
					new Card { Name = "Call to Adventure" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Annoy-o-Module" },
					new Card { Name = "Prismatic Lens" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Glowstone Technician" },
					new Card { Name = "Mechano-Egg" },
					new Card { Name = "Wargear" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Missile Launcher" },
					new Card { Name = "Kangor's Endless Army" },
				}
			};
		}
		private static Deck MidrangeHunter()
		{
			return new Deck
			{
				Name = "Midrange Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
	{
		new Card { Name = "Shimmerfly" },
					new Card { Name = "Springpaw" },
					new Card { Name = "Timber Wolf" },
					new Card { Name = "Tracking" },
					new Card { Name = "Headhunter's Hatchet" },
					new Card { Name = "Hench-Clan Hogsteed" },
					new Card { Name = "Revenge of the Wild" },
					new Card { Name = "Scavenging Hyena" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Master's Call" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Dire Frenzy" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Wing Blast" },
					new Card { Name = "Tundra Rhino" },
					new Card { Name = "Savannah Highmane" },
				}
			};
		}
		private static Deck MindBlastPriest()
		{
			return new Deck
			{
				Name = "Mind Blast Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
	{
		new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Divine Hymn" },
					new Card { Name = "Mind Blast" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Sunreaver Warmage" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Holy Fire" },
					new Card { Name = "Alexstrasza" },
				}
			};
		}
		private static Deck HooktuskRogue()
		{
			return new Deck
			{
				Name = "Hoooktusk Rogue",
				Prototype = "TEMP",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
	{
		new Card { Name = "Backstab" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "Sap" },
					new Card { Name = "Crystalizer" },
					new Card { Name = "Nightmare Amalgam" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Blink Fox" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Sn1p-Sn4p" },
					new Card { Name = "Hench-Clan Thug" },
					new Card { Name = "Hench-Clan Burglar" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Ticket Scalper" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Captain Hooktusk" },
				}
			};
		}
		private static Deck MiracleRogue()
		{
			return new Deck
			{
				Name = "Miracle Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
	{
		new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Togwaggle's Scheme" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Shiv" },
					new Card { Name = "Blink Fox" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Hench-Clan Burglar" },
					new Card { Name = "Vendetta" },
					new Card { Name = "WANTED!" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Gadgetzan Auctioneer" },
					new Card { Name = "Heistbaron Togwaggle" },
				}
			};
		}
		private static Deck MurlocShaman()
		{
			return new Deck
			{
				Name = "Murloc Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
	{
		new Card { Name = "Earth Shock" },
					new Card { Name = "Grimscale Oracle" },
					new Card { Name = "Murloc Tidecaller" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Toxfin" },
					new Card { Name = "Murloc Tidehunter" },
					new Card { Name = "Soul of the Murloc" },
					new Card { Name = "Underbelly Angler" },
					new Card { Name = "Coldlight Seer" },
					new Card { Name = "Murloc Warleader" },
					new Card { Name = "Hench-Clan Hag" },
					new Card { Name = "Murloc Tastyfin" },
					new Card { Name = "Bloodlust" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Swampqueen Hagatha" },
					new Card { Name = "Hagatha the Witch" },
					new Card { Name = "Shudderwock" },
				}
			};
		}
		private static Deck PogoRogue()
		{
			return new Deck
			{
				Name = "Pogo Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
	{
		new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Daring Escape" },
					new Card { Name = "Pogo-Hopper" },
					new Card { Name = "Togwaggle's Scheme" },
					new Card { Name = "Lab Recruiter" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Sap" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Fan of Knives" },
					new Card { Name = "Spirit of the Shark" },
					new Card { Name = "Witchwood Piper" },
					new Card { Name = "Barista Lynchen" },
					new Card { Name = "Myra's Unstable Element" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Vanish" },
					new Card { Name = "Tak Nozwhisker" },
				}
			};
		}
		private static Deck ResurrectPriest()
		{
			return new Deck
			{
				Name = "Resurrect Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
	{
		new Card { Name = "Forbidden Words" },
					new Card { Name = "Inner Fire" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Divine Hymn" },
					new Card { Name = "Divine Spirit" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Hench-Clan Shadequill" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Witchwood Grizzly" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Damaged Stegotron" },
					new Card { Name = "Amani War Bear" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Oondasta" },
				}
			};
		}
		private static Deck SecretHunter()
		{
			return new Deck
			{
				Name = "Secret Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
	{
		new Card { Name = "Secretkeeper" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Fireworks Tech" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Rat Trap" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Snipe" },
					new Card { Name = "Sunreaver Spy" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Nine Lives" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Spider Bomb" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Houndmaster Shaw" },
					new Card { Name = "Marked Shot" },
					new Card { Name = "Necromechanic" },
					new Card { Name = "Subject 9" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Zul'jin" },
				}
			};
		}
		private static Deck TempoRogue()
		{
			return new Deck
			{
				Name = "Tempo Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
	{
		new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Hench-Clan Thug" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Raiding Party" },
					new Card { Name = "Waggle Pick" },
					new Card { Name = "Captain Greenskin" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Myra's Unstable Element" },
				}
			};
		}
		private static Deck TokenDruid()
		{
			return new Deck
			{
				Name = "Token Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
	{
		new Card { Name = "Acornbearer" },
					new Card { Name = "Crystallizer" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Dreamway Guardians" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Power of the Wild" },
					new Card { Name = "Blessing of the Ancients" },
					new Card { Name = "Microtech Controller" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Explodinator" },
					new Card { Name = "Replicating Menace" },
					new Card { Name = "Soul of the Forest" },
					new Card { Name = "Swipe" },
					new Card { Name = "Zilliax" },
					new Card { Name = "The Forest's Aid" },
				}
			};
		}
		private static Deck ZooWarlock()
		{
			return new Deck
			{
				Name = "Zoo Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
	{
		new Card { Name = "Abusive Sergeant" },
					new Card { Name = "Crystallizer" },
					new Card { Name = "Flame Imp" },
					new Card { Name = "Grim Rally" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "The Soularium" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "Witchwood Imp" },
					new Card { Name = "Dire Wolf Alpha" },
					new Card { Name = "EVIL Genius" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "Scarab Egg" },
					new Card { Name = "Magic Carpet" },
					new Card { Name = "Microtech Controller" },
					new Card { Name = "Defender of Argus" },
					new Card { Name = "Sea Giant" },
				}
			};
		}

	}
}
