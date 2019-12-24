using System;
using System.Collections.Generic;

namespace Domain.Metas
{
	public static class SavioursOfUldem
	{
		public static Meta LoadMeta()
		{
			var meta = new Meta(
				code: "SU",
				name: "Tomb of Doom",
				patchNo: 15.5M,
				asOf: new DateTime(2019, 10, 13));

			//  TIER 1
			var tier1Decks = new List<Deck>
			{
				EvolveShaman(),
				QuestShaman(),
				ComboAggroPriest(),
			};
			meta.AddDecks(tier1Decks, 1);

			//  TIER 2
			var tier2Decks = new List<Deck>
			{
				ControlWarrior(),
				HighlanderPaladin(),
				HighlanderWarrior(),
				TempoRogue(),
				QuestDruid(),
				TempoWarrior(),
				MurlocShaman(),
				HolyWrathPaladin(),
			};
			meta.AddDecks(tier2Decks, 2);

			//  TIER 3
			var tier3Decks = new List<Deck>
			{
				ResurrectPriest(),
				MurlocPaladin(),
				HighlanderMage(),
				ZooWarlock(),
				SecretPaladin(),
				HighlanderWarlock(),
				BombWarrior(),
				AggroMechHunter(),
				DeathrattleRogue(),
				ControlWarlock(),
				QuestMalygosDruid(),
			};
			meta.AddDecks(tier3Decks, 3);

			//  TIER 4
			var tier4Decks = new List<Deck>
			{
				TempoMage(),
				QuestRogue(),
				MidrangeHunter(),
				QuestPaladin(),
				NZothWarlock(),
			};
			meta.AddDecks(tier4Decks, 4);

			////  TIER 5
			var tier5Decks = new List<Deck>
			{
				QuestPriest(),
				QuestWarlock(),
			};
			meta.AddDecks(tier5Decks, 5);

			////  TIER 6 Nether Storm
			var tier6Decks = new List<Deck>
			{
				TauntWarrior(),
				AggroShaman(),
				QuestHunter(),
				MechathunDruid(),
				HandPaladin(),
				QuestWarrior(),
				ComboAggroPriest(),
				SecretHunter(),
				CycloneGiantsMage(),
				ChefNomiPriest(),
				ControlShaman(),
				SecretMage(),
				QuestControlPriest(),
				BigSpellMage(),
				TokenDruid(),
				AggroPirateRogue(),
				MuckShaman(),
				PsycopompWallPriest(),
				QuestPhaorisPriest(),
				QuestTirionPaladin(),
				TauntControlWarrior(),
				TessQuestRogue(),
				HighlanderHunter(),
				QuestMage(),
				DragonMage()
			};
			meta.AddDecks(tier6Decks, 6);

			return meta;
		}

		#region Tomb of Doom Decks

		private static Deck AggroMechHunter()
		{
			return new Deck
			{
				Name = "Aggro Mech Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Mecharoo" },
					new Card { Name = "Tracking" },
					new Card { Name = "Bomb Toss" },
					new Card { Name = "Fireworks Tech" },
					new Card { Name = "Galvanizer" },
					new Card { Name = "Upgradeable Framebot" },
					new Card { Name = "Venomizer" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Spider Bomb" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Explodinator" },
					new Card { Name = "Replicating Menace" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Wargear" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Missile Launcher" },
					new Card { Name = "Boommaster Flark" },
				}
			};
		}
		private static Deck BombWarrior()
		{
			return new Deck
			{
				Name = "Bomb Warrior",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Inner Rage" },
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Armorsmith" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Execute" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Bloodsworn Mercenary" },
					new Card { Name = "Clockwork Goblin" },
					new Card { Name = "Frothing Berserker" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Militia Commander" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Wrenchcalibur" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blastmaster Boom" },
					new Card { Name = "Grommash Hellscream" },
					new Card { Name = "Dr. Boom, Mad Genius" },
				}
			};
		}
		private static Deck DeathrattleRogue()
		{
			return new Deck
			{
				Name = "Deathrattle Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Swashburglar" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Necrium Blade" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Blightnozzle Crawler" },
					new Card { Name = "Anka, the Buried" },
					new Card { Name = "Necrium Vial" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Cairne Bloodhoof" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Ragnaros the Firelord" },
					new Card { Name = "N'Zoth, the Corruptor" },
				}
			};
		}
		private static Deck HighlanderHunter()
		{
			return new Deck
			{
				Name = "Highlander Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Hungry Crab" },
					new Card { Name = "Secretkeeper" },
					new Card { Name = "Springpaw" },
					new Card { Name = "Tracking" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Pressure Plate" },
					new Card { Name = "Rat Trap" },
					new Card { Name = "Scavenging Hyena" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Snipe" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Desert Spear" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Kill Command" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Houndmaster" },
					new Card { Name = "Hyena Alpha" },
					new Card { Name = "Marked Shot" },
					new Card { Name = "Subject 9" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Dinotamer Brann" },
					new Card { Name = "Siamat" },
					new Card { Name = "Call of the Wild" },
					new Card { Name = "Zul'jin" },
				}
			};
		}
		private static Deck HighlanderMage()
		{
			return new Deck
			{
				Name = "Highlander Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Elemental Evocation" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Book of Specters" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Flame Ward" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Arcane Keysmith" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Polymorph" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Emperor Thaurissan" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Reno the Relicologist" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Flamestrike" },
					new Card { Name = "Siamat" },
					new Card { Name = "Power of Creation" },
					new Card { Name = "Tortollan Pilgrim" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Kalecgos" },
					new Card { Name = "N'Zoth, the Corruptor" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck HighlanderPaladin()
		{
			return new Deck
			{
				Name = "Highlander Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Autodefense Matrix" },
					new Card { Name = "Avenge" },
					new Card { Name = "Crystology" },
					new Card { Name = "Glow-Tron" },
					new Card { Name = "Hidden Wisdom" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Murmy" },
					new Card { Name = "Never Surrender!" },
					new Card { Name = "Noble Sacrifice" },
					new Card { Name = "Redemption" },
					new Card { Name = "Secretkeeper" },
					new Card { Name = "Mysterious Blade" },
					new Card { Name = "Sir Finley of the Sands" },
					new Card { Name = "Sunreaver Spy" },
					new Card { Name = "Temple Berserker" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Aldor Peacekeeper" },
					new Card { Name = "Commander Rhyssa" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Mysterious Challenger" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Siamat" },
					new Card { Name = "Ragnaros the Firelord" },
					new Card { Name = "Tirion Fordring" },
					new Card { Name = "N'Zoth, the Corruptor" },
				}
			};
		}
		private static Deck HighlanderWarlock()
		{
			return new Deck
			{
				Name = "Highlander Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Abusive Sergeant" },
					new Card { Name = "Argent Squire" },
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Crystallizer" },
					new Card { Name = "Flame Imp" },
					new Card { Name = "Grim Rally" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Murmy" },
					new Card { Name = "Sinister Deal" },
					new Card { Name = "Soulfire" },
					new Card { Name = "Spirit Bomb" },
					new Card { Name = "The Soularium" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "Crazed Alchemist" },
					new Card { Name = "Dire Wolf Alpha" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "EVIL Genius" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "Temple Berserker" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "EVIL Recruiter" },
					new Card { Name = "History Buff" },
					new Card { Name = "Imp Gang Boss" },
					new Card { Name = "Magic Carpet" },
					new Card { Name = "Neferset Thrasher" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Defender of Argus" },
					new Card { Name = "Diseased Vulture" },
					new Card { Name = "Sandbinder" },
					new Card { Name = "Leeroy Jenkins" },
				}
			};
		}
		private static Deck HighlanderWarrior()
		{
			return new Deck
			{
				Name = "Highlander Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Inner Rage" },
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Improve Morale" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Upgrade!" },
					new Card { Name = "Amani Berserker" },
					new Card { Name = "Cruel Taskmaster" },
					new Card { Name = "Execute" },
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Injured Tol'vir" },
					new Card { Name = "Temple Berserker" },
					new Card { Name = "Warpath" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Bloodsworn Mercenary" },
					new Card { Name = "Frothing Berserker" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "Rabid Worgen" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Kor'kron Elite" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Sandbinder" },
					new Card { Name = "Wrenchcalibur" },
					new Card { Name = "Darius Crowley" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Emperor Thaurissan" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Siamat" },
					new Card { Name = "Grommash Hellscream" },
					new Card { Name = "Ragnaros the Firelord" },
				}
			};
		}
		private static Deck MidrangeHunter()
		{
			return new Deck
			{
				Name = "Midrange Hunter",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Springpaw" },
					new Card { Name = "Timber Wolf" },
					new Card { Name = "Tracking" },
					new Card { Name = "Hench-Clan Hogsteed" },
					new Card { Name = "Scavenging Hyena" },
					new Card { Name = "Vicious Scalehide" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Desert Spear" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Master's Call" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Dire Frenzy" },
					new Card { Name = "Marked Shot" },
					new Card { Name = "Tundra Rhino" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Zul'jin" },
				}
			};
		}
		private static Deck MurlocShaman()
		{
			return new Deck
			{
				Name = "Murloc Shaman",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Mutate" },
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Grimscale Oracle" },
					new Card { Name = "Murloc Tidecaller" },
					new Card { Name = "Murmy" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Toxfin" },
					new Card { Name = "Fishflinger" },
					new Card { Name = "Murloc Tidehunter" },
					new Card { Name = "Underbelly Angler" },
					new Card { Name = "Coldlight Seer" },
					new Card { Name = "Murloc Warleader" },
					new Card { Name = "Murloc Tastyfin" },
					new Card { Name = "Bloodlust" },
					new Card { Name = "Mogu Fleshshaper" },
				}
			};
		}
		private static Deck NZothWarlock()
		{
			return new Deck
			{
				Name = "N'Zoth Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Flame Imp" },
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Murmy" },
					new Card { Name = "Plague of Flames" },
					new Card { Name = "Sinister Deal" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "EVIL Genius" },
					new Card { Name = "Expired Merchant" },
					new Card { Name = "Imp Gang Boss" },
					new Card { Name = "Diseased Vulture" },
					new Card { Name = "Dark Pharaoh Tekahn" },
					new Card { Name = "Rotten Applebaum" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Emperor Thaurissan" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Lord Godfrey" },
					new Card { Name = "N'Zoth, the Corruptor" },
				}
			};
		}
		private static Deck QuestDruid()
{
	return new Deck
	{
		Name = "Quest Druid",
		Prototype = "CONTROL",
		Tier = 5,
		Rank = 25,
		HeroClass = new Hero("Druid"),
		Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Untapped Potential" },
					new Card { Name = "Crystal Merchant" },
					new Card { Name = "Wrath" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Wardruid Loti" },
					new Card { Name = "Flobbidinous Floop" },
					new Card { Name = "Swipe" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Elise the Enlightened" },
					new Card { Name = "Oasis Surger" },
					new Card { Name = "Starfall" },
					new Card { Name = "Emperor Thaurissan" },
					new Card { Name = "Hidden Oasis" },
					new Card { Name = "Nourish" },
					new Card { Name = "Dreampetal Florist" },
					new Card { Name = "Jepetto Joybuzz" },
					new Card { Name = "Malygos" },
					new Card { Name = "Kun the Forgotten King" },
				}
	};
}
		private static Deck MechathunDruid()
		{
			return new Deck
			{
				Name = "Mecha'thun Druid",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Untapped Potential" },
					new Card { Name = "Crystal Merchant" },
					new Card { Name = "Wrath" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "BEEEES!!!" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Wardruid Loti" },
					new Card { Name = "Flobbidinous Floop" },
					new Card { Name = "Swipe" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Elise the Enlightened" },
					new Card { Name = "Oasis Surger" },
					new Card { Name = "Starfall" },
					new Card { Name = "Voodoo Doll" },
					new Card { Name = "Hidden Oasis" },
					new Card { Name = "Nourish" },
					new Card { Name = "Dreampetal Florist" },
					new Card { Name = "Siamat" },
					new Card { Name = "Mecha'thun" },
					new Card { Name = "Kun the Forgotten King" },
				}
			};
		}
		private static Deck QuestPaladin()
{
	return new Deck
	{
		Name = "Quest Paladin",
		Prototype = "CONTROL",
		Tier = 5,
		Rank = 25,
		HeroClass = new Hero("Paladin"),
		Cards = new List<Card>
				{
					new Card { Name = "Crystology" },
					new Card { Name = "Making Mummies" },
					new Card { Name = "Murmy" },
					new Card { Name = "Micro Mummy" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Temple Berserker" },
					new Card { Name = "Ancestral Guardian" },
					new Card { Name = "Annoy-o-Module" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Consecration" },
					new Card { Name = "Rotten Applebaum" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Kangor's Endless Army" },
					new Card { Name = "Ragnaros the Firelord" },
					new Card { Name = "Tirion Fordring" },
					new Card { Name = "N'Zoth, the Corruptor" },
				}
	};
}
private static Deck QuestPriest()
{
	return new Deck
	{
		Name = "Quest Priest",
		Prototype = "CONTROL",
		Tier = 5,
		Rank = 25,
		HeroClass = new Hero("Priest"),
		Cards = new List<Card>
				{
					new Card { Name = "Forbidden Words" },
					new Card { Name = "Activate the Obelisk" },
					new Card { Name = "Divine Hymn" },
					new Card { Name = "Penance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Batterhead" },
					new Card { Name = "Ragnaros the Firelord" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
					new Card { Name = "N'Zoth, the Corruptor" },
				}
	};
}
private static Deck QuestRogue()
{
	return new Deck
	{
		Name = "Quest Rogue",
		Prototype = "CONTROL",
		Tier = 5,
		Rank = 25,
		HeroClass = new Hero("Rogue"),
		Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Bazaar Burglary" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Pilfer" },
					new Card { Name = "Togwaggle's Scheme" },
					new Card { Name = "Clever Disguise" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Blink Fox" },
					new Card { Name = "Brightwing" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Blade Flurry" },
					new Card { Name = "Hench-Clan Burglar" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Bazaar Mugger" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Tess Greymane" },
				}
	};
}
private static Deck QuestShaman()
{
	return new Deck
	{
		Name = "Quest Shaman",
		Prototype = "CONTROL",
		Tier = 5,
		Rank = 25,
		HeroClass = new Hero("Shaman"),
		Cards = new List<Card>
				{
					new Card { Name = "Corrupt the Waters" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "EVIL Totem" },
					new Card { Name = "Menacing Nimbus" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Sandstorm Elemental" },
					new Card { Name = "Bog Slosher" },
					new Card { Name = "Weaponized Wasp" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Barista Lynchen" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Giggling Inventor" },
					new Card { Name = "Mogu Fleshshaper" },
					new Card { Name = "Siamat" },
					new Card { Name = "Swampqueen Hagatha" },
					new Card { Name = "Shudderwock" },
				}
	};
}
private static Deck QuestWarlock()
{
	return new Deck
	{
		Name = "Quest Warlock",
		Prototype = "CONTROL",
		Tier = 5,
		Rank = 25,
		HeroClass = new Hero("Warlock"),
		Cards = new List<Card>
				{
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Plague of Flames" },
					new Card { Name = "Supreme Archaeology" },
					new Card { Name = "Plot Twist" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Augmented Elekk" },
					new Card { Name = "Rafaam's Scheme" },
					new Card { Name = "Fiendish Circle" },
					new Card { Name = "Hellfire" },
					new Card { Name = "Dollmaster Dorian" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Aranasi Broodmother" },
					new Card { Name = "Darkest Hour" },
					new Card { Name = "Dr. Morrigan" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Safeguard" },
					new Card { Name = "Arch-Villain Rafaam" },
					new Card { Name = "Lord Godfrey" },
					new Card { Name = "Fel Lord Betrug" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "Colossus of the Moon" },
					new Card { Name = "Mountain Giant" },
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
					new Card { Name = "Penance" },
					new Card { Name = "Shadow Word: Pain" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "High Priest Amet" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Lightbomb" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Ragnaros the Firelord" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
					new Card { Name = "Zerek's Cloning Gallery" },
					new Card { Name = "N'Zoth, the Corruptor" },
				}
	};
}
private static Deck SecretPaladin()
{
	return new Deck
	{
		Name = "Secret Paladin",
		Prototype = "MIDRANGE",
		Tier = 5,
		Rank = 25,
		HeroClass = new Hero("Paladin"),
		Cards = new List<Card>
				{
					new Card { Name = "Avenge" },
					new Card { Name = "Brazen Zealot" },
					new Card { Name = "Crystology" },
					new Card { Name = "Desperate Measures" },
					new Card { Name = "Never Surrender!" },
					new Card { Name = "Noble Sacrifice" },
					new Card { Name = "Redemption" },
					new Card { Name = "Secretkeeper" },
					new Card { Name = "Mysterious Blade" },
					new Card { Name = "Sunreaver Spy" },
					new Card { Name = "Temple Berserker" },
					new Card { Name = "Commander Rhyssa" },
					new Card { Name = "Masked Contender" },
					new Card { Name = "Bellringer Sentry" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Mysterious Challenger" },
				}
	};
}
		private static Deck TempoMage()
		{
			return new Deck
			{
				Name = "Tempo Mage",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Elemental Evocation" },
					new Card { Name = "Arcane Missiles" },
					new Card { Name = "Babbling Book" },
					new Card { Name = "Magic Trick" },
					new Card { Name = "Mirror Image" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Mana Cyclone" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Banana Buffoon" },
					new Card { Name = "Flamewaker" },
					new Card { Name = "Stargazer Luna" },
					new Card { Name = "Sandbinder" },
					new Card { Name = "Emperor Thaurissan" },
					new Card { Name = "Archmage Antonidas" },
					new Card { Name = "Siamat" },
					new Card { Name = "Ragnaros the Firelord" },
				}
			};
		}

		private static Deck ControlWarlock()
		{
			return new Deck
			{
				Name = "Control Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Murmy" },
					new Card { Name = "Plague of Flames" },
					new Card { Name = "Sinister Deal" },
					new Card { Name = "EVIL Genius" },
					new Card { Name = "Expired Merchant" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Imp Gang Boss" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Hellfire" },
					new Card { Name = "Dark Pharaoh Tekahn" },
					new Card { Name = "Rotten Applebaum" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Cairne Bloodhoof" },
					new Card { Name = "Emperor Thaurissan" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Ragnaros the Firelord" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "N'Zoth, the Corruptor" },
				}
			};
		}
		private static Deck EvolveShaman()
		{
			return new Deck
			{
				Name = "Evolve Shaman",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Mutate" },
					new Card { Name = "Zap!" },
					new Card { Name = "Evolve" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Voltaic Burst" },
					new Card { Name = "EVIL Totem" },
					new Card { Name = "Likkim" },
					new Card { Name = "Underbelly Angler" },
					new Card { Name = "Sandstorm Elemental" },
					new Card { Name = "Desert Hare" },
					new Card { Name = "Mana Tide Totem" },
					new Card { Name = "Flametongue Totem" },
					new Card { Name = "Thunderhead" },
					new Card { Name = "Vessina" },
					new Card { Name = "Bloodlust" },
					new Card { Name = "Thing from Below" },
					new Card { Name = "Mogu Fleshshaper" },
					new Card { Name = "Sea Giant" },
				}
			};
		}
		private static Deck LackeyTempoRogue()
		{
			return new Deck
			{
				Name = "Lackey Tempo Rogue",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Swashburglar" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Blink Fox" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Shaku, the Collector" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Hench-Clan Burglar" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Waggle Pick" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Ragnaros the Firelord" },
				}
			};
		}
		private static Deck QuestMalygosDruid()
		{
			return new Deck
			{
				Name = "Quest Malygos Druid",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Untapped Potential" },
					new Card { Name = "Worthy Expedition" },
					new Card { Name = "Crystal Merchant" },
					new Card { Name = "Wrath" },
					new Card { Name = "BEEEES!!!" },
					new Card { Name = "Wardruid Loti" },
					new Card { Name = "Flobbidinous Floop" },
					new Card { Name = "Swipe" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Oasis Surger" },
					new Card { Name = "Starfall" },
					new Card { Name = "Hidden Oasis" },
					new Card { Name = "Nourish" },
					new Card { Name = "Dreampetal Florist" },
					new Card { Name = "Jepetto Joybuzz" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Malygos" },
				}
			};
		}
		private static Deck TauntWarrior()
		{
			return new Deck
			{
				Name = "Taunt Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Into the Fray" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Warpath" },
					new Card { Name = "Bronze Gatekeeper" },
					new Card { Name = "Infested Goblin" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Bloodhoof Brave" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Brawl" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Armagedillo" },
					new Card { Name = "Grommash Hellscream" },
					new Card { Name = "Ragnaros the Firelord" },
					new Card { Name = "Tomb Warden" },
					new Card { Name = "Varian Wrynn" },
				}
			};
		}
		private static Deck ZooWarlock()
		{
			return new Deck
			{
				Name = "Zoo Warlock",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Abusive Sergeant" },
					new Card { Name = "Flame Imp" },
					new Card { Name = "Grim Rally" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Murmy" },
					new Card { Name = "Sinister Deal" },
					new Card { Name = "The Soularium" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "EVIL Genius" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "EVIL Recruiter" },
					new Card { Name = "Imp Gang Boss" },
					new Card { Name = "Magic Carpet" },
					new Card { Name = "Dark Pharaoh Tekahn" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Sea Giant" },
				}
			};
		}
		#endregion


		#region Decks
		private static Deck TokenDruid()
		{
			return new Deck
			{
				Name = "Token Druid",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Acornbearer" },
					new Card { Name = "Crystalsong Portal" },
					new Card { Name = "Dreamway Guardians" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "Keeper Stalladris" },
					new Card { Name = "Power of the Wild" },
					new Card { Name = "Wrath" },
					new Card { Name = "Blessing of the Ancients" },
					new Card { Name = "Landscaping" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Mark of the Loa" },
					new Card { Name = "Soul of the Forest" },
					new Card { Name = "Swipe" },
					new Card { Name = "Wispering Woods" },
					new Card { Name = "The Forest's Aid" },
				}
			};
		}

		private static Deck AggroPirateRogue()
		{
			return new Deck
			{
				Name = "Aggro Pirate Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Sap" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Hooked Scimitar" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Waggle Pick" },
					new Card { Name = "Captain Greenskin" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Myra's Unstable Element" },
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
					new Card { Name = "Murloc Tidecaller" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Voltaic Burst" },
					new Card { Name = "Earthen Might" },
					new Card { Name = "Likkim" },
					new Card { Name = "Sandstorm Elemental" },
					new Card { Name = "Soul of the Murloc" },
					new Card { Name = "Underbelly Angler" },
					new Card { Name = "Feral Spirit" },
					new Card { Name = "Haunting Visions" },
					new Card { Name = "Spirit of the Frog" },
					new Card { Name = "Thunderhead" },
					new Card { Name = "Vessina" },
					new Card { Name = "Bloodlust" },
					new Card { Name = "Mogu Fleshshaper" },
				}
			};
		}
		private static Deck BigSpellMage()
		{
			return new Deck
			{
				Name = "Big Spell Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Khadgar" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Arcane Keysmith" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Luna's Pocket Galaxy" },
					new Card { Name = "Naga Sand Witch" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Power of Creation" },
					new Card { Name = "Tortollan Pilgrim" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Kalecgos" },
					new Card { Name = "King Phaoris" },
					new Card { Name = "Puzzle Box of Yogg-Saron" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck ComboAggroPriest()
		{
			return new Deck
			{
				Name = "Combo Aggro Priest",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Circle of Healing" },
					new Card { Name = "Silence" },
					new Card { Name = "Topsy Turvy" },
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Inner Fire" },
					new Card { Name = "Lightwarden" },
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Divine Spirit" },
					new Card { Name = "Extra Arms" },
					new Card { Name = "Injured Tol'vir" },
					new Card { Name = "Neferset Ritualist" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Injured Blademaster" },
					new Card { Name = "High Priest Amet" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Bwonsamdi the Dead" },
				}
			};
		}
		private static Deck ComboPriest()
		{
			return new Deck
			{
				Name = "Combo Aggro Priest",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Circle of Healing" },
					new Card { Name = "Silence" },
					new Card { Name = "Inner Fire" },
					new Card { Name = "Lightwarden" },
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Divine Spirit" },
					new Card { Name = "Extra Arms" },
					new Card { Name = "Holy Ripple" },
					new Card { Name = "Injured Tol'vir" },
					new Card { Name = "Neferset Ritualist" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Injured Blademaster" },
					new Card { Name = "High Priest Amet" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
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
					new Card { Name = "Corrupt the Waters" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "EVIL Totem" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Sandstorm Elemental" },
					new Card { Name = "Plague of Murlocs" },
					new Card { Name = "Weaponized Wasp" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Storm Chaser" },
					new Card { Name = "Barista Lynchen" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Earthquake" },
					new Card { Name = "Giggling Inventor" },
					new Card { Name = "Siamat" },
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
					new Card { Name = "Warpath" },
					new Card { Name = "Fiery War Axe" },
					new Card { Name = "Weapons Project" },
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Shield Block" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Omega Devastator" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Brawl" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Plague of Wrath" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Sylvanas Windrunner" },
					new Card { Name = "Ragnaros the Firelord" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Armagedillo" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Tomb Warden" },
					new Card { Name = "Archivist Elysiana" },
					new Card { Name = "N'Zoth the Corruptor" },
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
					new Card { Name = "Khadgar" },
					new Card { Name = "Mana Cyclone" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Banana Buffoon" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Stargazer Luna" },
					new Card { Name = "Luna's Pocket Galaxy" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Archmage Antonidas" },
					new Card { Name = "Siamat" },
					new Card { Name = "Sea Giant" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck HolyWrathPaladin()
		{
			return new Deck
			{
				Name = "Holy Wrath Paladin",
				Prototype = "COMBO",
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
		private static Deck MuckShaman()
		{
			return new Deck
			{
				Name = "Muck Shaman",
				Prototype = "MIDRANGE",
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
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Spirit of the Frog" },
					new Card { Name = "Hex" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Muckmorpher" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Eureka!" },
					new Card { Name = "Earthquake" },
					new Card { Name = "Al'Akir the Windlord" },
					new Card { Name = "Hagatha the Witch" },
					new Card { Name = "Walking Fountain" },
					new Card { Name = "Ysera" },
				}
			};
		}
		private static Deck MurlocPaladin()
		{
			return new Deck
			{
				Name = "Murloc Paladin",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Grimscale Oracle" },
					new Card { Name = "Murloc Tidecaller" },
					new Card { Name = "Murmy" },
					new Card { Name = "Toxfin" },
					new Card { Name = "Bluegill Warrior" },
					new Card { Name = "Fishflinger" },
					new Card { Name = "Sir Finley of the Sands" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Coldlight Seer" },
					new Card { Name = "Murloc Warleader" },
					new Card { Name = "Nightmare Amalgam" },
					new Card { Name = "Murloc Tastyfin" },
					new Card { Name = "Prismatic Lens" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Chef Nomi" },
					new Card { Name = "Tip the Scales" },
				}
			};
		}
		private static Deck PsycopompWallPriest()
		{
			return new Deck
			{
				Name = "Psycopomp Wall  Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Forbidden Words" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Divine Hymn" },
					new Card { Name = "Injured Tol'vir" },
					new Card { Name = "Penance" },
					new Card { Name = "Injured Blademaster" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Damaged Stegotron" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
				}
			};
		}
		private static Deck QuestControlPriest()
		{
			return new Deck
			{
				Name = "Quest Control Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Forbidden Words" },
					new Card { Name = "Activate the Obelisk" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Penance" },
					new Card { Name = "Seance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "High Priest Amet" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
				}
			};
		}
		private static Deck QuestHunter()
		{
			return new Deck
			{
				Name = "Quest Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Tracking" },
					new Card { Name = "Unseal the Vault" },
					new Card { Name = "Fireworks Tech" },
					new Card { Name = "Galvanizer" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Nine Lives" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Spider Bomb" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Necromechanic" },
					new Card { Name = "Replicating Menace" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Oblivitron" },
					new Card { Name = "Swarm of Locusts" },
				}
			};
		}
		private static Deck QuestPhaorisPriest()
		{
			return new Deck
			{
				Name = "Quest Phaoris Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Activate the Obelisk" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Extra Arms" },
					new Card { Name = "Penance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "High Priest Amet" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
					new Card { Name = "King Phaoris" },
					new Card { Name = "Grave Horror" },
				}
			};
		}
		private static Deck QuestTirionPaladin()
		{
			return new Deck
			{
				Name = "Quest Tirion Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Crystology" },
					new Card { Name = "Making Mummies" },
					new Card { Name = "Murmy" },
					new Card { Name = "Micro Mummy" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Temple Berserker" },
					new Card { Name = "Candletaker" },
					new Card { Name = "Ancestral Guardian" },
					new Card { Name = "Annoy-o-Module" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Consecration" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Mechano-Egg" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Kangor's Endless Army" },
					new Card { Name = "Tirion Fordring" },
				}
			};
		}
		private static Deck QuestWarrior()
		{
			return new Deck
			{
				Name = "Quest Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Hack the System" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Upgrade!" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Execute" },
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Warpath" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Frothing Berserker" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "Arathi Weaponsmith" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Armored Goon" },
					new Card { Name = "Sul'thraze" },
					new Card { Name = "Siamat" },
					new Card { Name = "Archivist Elysiana" },
				}
			};
		}
		private static Deck SecretHunter()
		{
			return new Deck
			{
				Name = "Secret Hunter",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Secretkeeper" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Pressure Plate" },
					new Card { Name = "Rat Trap" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Snipe" },
					new Card { Name = "Sunreaver Spy" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Hunter's Pack" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Masked Contender" },
					new Card { Name = "Hyena Alpha" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Subject 9" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Zul'jin" },
				}
			};
		}
		private static Deck SecretMage()
		{
			return new Deck
			{
				Name = "Secret Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Elemental Evocation" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Ancient Mysteries" },
					new Card { Name = "Arcane Flakmage" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Mana Cyclone" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Counterspell" },
					new Card { Name = "Dune Sculptor" },
					new Card { Name = "Flame Ward" },
					new Card { Name = "Kirin Tor Mage" },
					new Card { Name = "Mirror Entity" },
					new Card { Name = "Stargazer Luna" },
					new Card { Name = "Ethereal Arcanist" },
					new Card { Name = "Fireball" },
					new Card { Name = "Cloud Prince" },
				}
			};
		}
		private static Deck TauntControlWarrior()
		{
			return new Deck
			{
				Name = "Taunt Control Warrior",
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
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Warpath" },
					new Card { Name = "Shield Block" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Militia Commander" },
					new Card { Name = "Omega Devastator" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Brawl" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Armagedillo" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Tomb Warden" },
					new Card { Name = "Archivist Elysiana" },
				}
			};
		}
		private static Deck TempoRogue()
		{
			return new Deck
			{
				Name = "Tempo Rogue",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Vulpera Scoundrel" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Raiding Party" },
					new Card { Name = "Waggle Pick" },
					new Card { Name = "Captain Greenskin" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Myra's Unstable Element" },
					new Card { Name = "Chef Nomi" },
				}
			};
		}
		private static Deck TempoWarrior()
		{
			return new Deck
			{
				Name = "Tempo Warrior",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Inner Rage" },
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Improve Morale" },
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Cruel Taskmaster" },
					new Card { Name = "Rampage" },
					new Card { Name = "Temple Berserker" },
					new Card { Name = "Bloodsworn Mercenary" },
					new Card { Name = "Frothing Berserker" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Kor'kron Elite" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Wasteland Assassin" },
					new Card { Name = "Grommash Hellscream" },
				}
			};
		}
		private static Deck TessQuestRogue()
		{
			return new Deck
			{
				Name = "Tess Quest Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Bazaar Burglary" },
					new Card { Name = "Togwaggle's Scheme" },
					new Card { Name = "Clever Disguise" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Sap" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Blink Fox" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Fan of Knives" },
					new Card { Name = "Hench-Clan Burglar" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Witchwood Piper" },
					new Card { Name = "Bazaar Mugger" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Jepetto Joybuzz" },
					new Card { Name = "Tess Greymane" },
				}
			};
		}
		#endregion


		#region Decks 2
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
					new Card { Name = "Divine Hymn" },
					new Card { Name = "Holy Ripple" },
					new Card { Name = "Seance" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Witchwood Piper" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Gadgetzan Auctioneer" },
					new Card { Name = "Chef Nomi" },
					new Card { Name = "Grave Horror" },
				}
			};
		}
		private static Deck HandPaladin()
		{
			return new Deck
			{
				Name = "Hand Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Brazen Zealot" },
					new Card { Name = "Crystology" },
					new Card { Name = "Jar Dealer" },
					new Card { Name = "Sandwasp Queen" },
					new Card { Name = "Faceless Rager" },
					new Card { Name = "Magic Carpet" },
					new Card { Name = "Ravencaller" },
					new Card { Name = "Salhet's Pride" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Glowstone Technician" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		#endregion

		private static Deck QuestMage()
		{
			return new Deck
			{
				Name = "Quest Mage",
				Prototype = "COMBO",
				Tier = 3,
				Rank = 24,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Artificer" },
					new Card { Name = "Open the Waygate" },
					new Card { Name = "Arcane Flakmage" },
					new Card { Name = "Arcanologist" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Primordial Glyph" },
					new Card { Name = "Research Project" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Banana Buffoon" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Ice Barrier" },
					new Card { Name = "Molten Reflection" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Archmage Antonidas" },
				}
			};
		}

		private static Deck DragonMage()
		{
			return new Deck
			{
				Name = "Dragon Mage",
				Prototype = "MIDRANGE",
				Tier = 3,
				Rank = 24,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Archmage Arugal" },
					new Card { Name = "Book of Specters" },
					new Card { Name = "Arcane Keysmith" },
					new Card { Name = "Conjurers Calling" },
					new Card { Name = "Luna's Pocket Galaxy" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Astromancer" },
					new Card { Name = "Kalegos" },

					new Card { Name = "Doomsayer" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Sunfury Protector" },
					new Card { Name = "Brightwing" },
					new Card { Name = "Voodoo Doll" },
					new Card { Name = "Scaleworm" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Dragonmaw Scorcher" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Crowd Roaster" },
					new Card { Name = "Siamat" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}

	}
}
