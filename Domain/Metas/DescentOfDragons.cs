using System;
using System.Collections.Generic;

namespace Domain.Metas
{
	public static class DescentOfDragons
	{
		public static Meta LoadMeta()
		{
			var meta = new Meta(
				code: "DD",
				name: "Descent of Dragons",
				patchNo: 16.5M,
				asOf: new DateTime(2020, 2, 22));

			//  TIER 1
			var tier1Decks = new List<Deck>
			{
				DragonHunter(),
				MechPaladin(),
				HighlanderHunter(),
				GalakrondWarrior(),
				QuestHunter(),
			};
			meta.AddDecks(tier1Decks, 1);

			var tier2Decks = new List<Deck>
			{
				TokenDruid(),
				ResurrectPriest(),
				EmbiggenDruid(),
				GalakrondZooWarlock(),
				HighlanderMage(),
				HighlanderRogue(),
			};
			meta.AddDecks(tier2Decks, 2);

			var tier3Decks = new List<Deck>
			{
				QuestDruid(),
				GalakrondWarlock(),
				GalakrondRogue(),
			};
			meta.AddDecks(tier3Decks, 3);

			var tier4Decks = new List<Deck>
			{
				ComboPriest(),
				FaceHunter(),
			};
			meta.AddDecks(tier4Decks, 4);

			var tier5Decks = new List<Deck>
			{
				AmplifierOtkMage(),
				RaDenGalakrondShaman(),
				ElementalMage(),
				BuffHunter(),
				ControlShaman(),
				DragonWarlock(),
				HighlanderPriest(),
				HighlanderWarlock(),
				AlbatrossPriest(),
				AlbatrossRogue(),
				EmbiggenDragonDruid(),
				HighlanderGalakrondRogue(),
				DeathrattleRogue(),
				PirateWarrior(),
				QuestPriest(),
				TreantTokenDruid(),
				SecretHighlanderHunter(),
				HandWarlock(),
				AnubisathRogue(),
				ControlWarrior(),
				TempoRogue(),
				GalakrondQuestShaman(),
				GalakrondShaman(),
				AggroShaman(),
				CycloneMage(),
				GalakrondControlWarlock(),
				GalakrondPriest(),
				HighlanderPaladin(),
				HighlanderWarrior(),
				HolyWrathPaladin(),
				PurePaladin(),
				TauntBeastDruid()

			};
			meta.AddDecks(tier5Decks, 5);
			return meta;
		}

#region Decks
		private static Deck ComboPriest()
		{
			return new Deck
			{
				Name = "Combo Priest",
				Prototype = "CONTROL",
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
		private static Deck DragonHunter()
		{
			return new Deck
			{
				Name = "Dragon Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Tracking" },
					new Card { Name = "Corrosive Breath" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Primordial Explorer" },
					new Card { Name = "Scalerider" },
					new Card { Name = "Stormhammer" },
					new Card { Name = "Dragonbane" },
					new Card { Name = "Evasive Feywing" },
					new Card { Name = "Frenzied Felwing" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Rotnest Drake" },
				}
			};
		}
		private static Deck EmbiggenDruid()
		{
			return new Deck
			{
				Name = "Embiggen Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Embiggen" },
					new Card { Name = "Strength in Numbers" },
					new Card { Name = "Breath of Dreams" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Injured Tol'vir" },
					new Card { Name = "Bad Luck Albatross" },
					new Card { Name = "Scalerider" },
					new Card { Name = "Evasive Feywing" },
					new Card { Name = "Frizz Kindleroost" },
					new Card { Name = "Swipe" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Oasis Surger" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Emerald Explorer" },
					new Card { Name = "Evasive Wyrm" },
					new Card { Name = "Winged Guardian" },
				}
			};
		}
		private static Deck GalakrondRogue()
		{
			return new Deck
			{
				Name = "Galakrond Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Praise Galakrond!" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Seal Fate" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Nightmare" },
				}
			};
		}
		private static Deck GalakrondWarlock()
		{
			return new Deck
			{
				Name = "Galakrond Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Sacrificial Pact" },
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Plague of Flames" },
					new Card { Name = "Nether Breath" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Bad Luck Albatross" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Dragonblight Cultist" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Veiled Worshipper" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Wretched" },
					new Card { Name = "Lord Godfrey" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Dragonqueen Alexstrasza" },
				}
			};
		}
		private static Deck GalakrondWarrior()
		{
			return new Deck
			{
				Name = "Galakrond Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Inner Rage" },
					new Card { Name = "Risky Skipper" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Armorsmith" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Ritual Chopper" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Awaken!" },
					new Card { Name = "Bloodsworn Mercenary" },
					new Card { Name = "Bomb Wrangler" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Kor'kron Elite" },
					new Card { Name = "Scion of Ruin" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Unbreakable" },
				}
			};
		}
		private static Deck GalakrondZooWarlock()
		{
			return new Deck
			{
				Name = "Galakrond Zoo Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Flame Imp" },
					new Card { Name = "Grim Rally" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "EVIL Genius" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "Scarab Egg" },
					new Card { Name = "Dragonblight Cultist" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Fiendish Rites" },
					new Card { Name = "Veiled Worshipper" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Wretched" },
					new Card { Name = "Sea Giant" },
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
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Springpaw" },
					new Card { Name = "Tracking" },
					new Card { Name = "Corrosive Breath" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Desert Spear" },
					new Card { Name = "Diving Gryphon" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Primordial Explorer" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Stormhammer" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Dragonbane" },
					new Card { Name = "Escaped Manasaber" },
					new Card { Name = "Evasive Feywing" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Rotnest Drake" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Veranus" },
					new Card { Name = "Dinotamer Brann" },
					new Card { Name = "Siamat" },
					new Card { Name = "Dragonqueen Alexstrasza" },
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
					new Card { Name = "Arcane Breath" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Book of Specters" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Stargazer Luna" },
					new Card { Name = "Arcane Keysmith" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Escaped Manasaber" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Malygos Aspect of Magic" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Dragoncaster" },
					new Card { Name = "Reno the Relicologist" },
					new Card { Name = "Flamestrike" },
					new Card { Name = "Luna's Pocket Galaxy" },
					new Card { Name = "Siamat" },
					new Card { Name = "Power of Creation" },
					new Card { Name = "Tortollan Pilgrim" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Kalecgos" },
					new Card { Name = "The Amazing Reno" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck HighlanderRogue()
		{
			return new Deck
			{
				Name = "Highlander Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Dragon's Hoard" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Praise Galakrond!" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Skyvateer" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Seal Fate" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Dragonmaw Poacher" },
					new Card { Name = "Escaped Manasaber" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Boompistol Bully" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Nightmare" },
					new Card { Name = "Siamat" },
					new Card { Name = "Dragonqueen Alexstrasza" },
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
					new Card { Name = "Hot Air Balloon" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Galvanizer" },
					new Card { Name = "Micro Mummy" },
					new Card { Name = "Shotbot" },
					new Card { Name = "Goboglide Tech" },
					new Card { Name = "Sky Claw" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Annoy-o-Module" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Replicating Menace" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Wargear" },
					new Card { Name = "Zilliax" },
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
					new Card { Name = "Untapped Potential" },
					new Card { Name = "Worthy Expedition" },
					new Card { Name = "Crystal Merchant" },
					new Card { Name = "Rising Winds" },
					new Card { Name = "Wrath" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Wardruid Loti" },
					new Card { Name = "Flobbidinous Floop" },
					new Card { Name = "Swipe" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Oasis Surger" },
					new Card { Name = "Starfall" },
					new Card { Name = "Hidden Oasis" },
					new Card { Name = "Nourish" },
					new Card { Name = "Cenarius" },
					new Card { Name = "Ysera Unleashed" },
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
					new Card { Name = "Clear the Way" },
					new Card { Name = "Springpaw" },
					new Card { Name = "Tracking" },
					new Card { Name = "Unseal the Vault" },
					new Card { Name = "Hench-Clan Hogsteed" },
					new Card { Name = "Licensed Adventurer" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Desert Spear" },
					new Card { Name = "Diving Gryphon" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Sky Gen'ral Kragg" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Halazzi the Lynx" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Swarm of Locusts" },
					new Card { Name = "Veranus" },
					new Card { Name = "Boommaster Flark" },
					new Card { Name = "Shu'ma" },
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
					new Card { Name = "Bad Luck Albatross" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Grave Rune" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Time Rip" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Galakrond the Unspeakable" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
					new Card { Name = "Zerek's Cloning Gallery" },
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
					new Card { Name = "Treenforcements" },
					new Card { Name = "Dendrologist" },
					new Card { Name = "Rising Winds" },
					new Card { Name = "Shrubadier" },
					new Card { Name = "Blessing of the Ancients" },
					new Card { Name = "Landscaping" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "Garden Gnome" },
					new Card { Name = "Soul of the Forest" },
					new Card { Name = "Aeroponics" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Force of Nature" },
					new Card { Name = "Goru the Mightree" },
					new Card { Name = "The Forest's Aid" },
					new Card { Name = "Mulchmuncher" },
				}
			};
		}
		#endregion

		#region Decks

		private static Deck AmplifierOtkMage()
		{
			return new Deck
			{
				Name = "Amplifier OTK Mage",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Daring Fire-Eater" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Research Project" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Arcane Amplifier" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Polymorph" },
					new Card { Name = "Clockwork Automaton" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Luna's Pocket Galaxy" },
					new Card { Name = "Jepetto Joybuzz" },
					new Card { Name = "Tortollan Pilgrim" },
				}
			};
		}

		private static Deck RaDenGalakrondShaman()
		{
			return new Deck
			{
				Name = "Ra-Den Galakrond Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Invocation of Frost" },
					new Card { Name = "Electra Stormsurge" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Haunting Visions" },
					new Card { Name = "Vulpera Scoundrel" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Hex" },
					new Card { Name = "Hoard Pillager" },
					new Card { Name = "Storm Chaser" },
					new Card { Name = "The Fist of Ra-den" },
					new Card { Name = "Dragon's Pack" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Corrupt Elementalist" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Earthquake" },
					new Card { Name = "Galakrond the Tempest" },
					new Card { Name = "Hagatha the Witch" },
					new Card { Name = "Shudderwock" },
				}
			};
		}

		private static Deck ElementalMage()
		{
			return new Deck
			{
				Name = "Elemental Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Elemental Evocation" },
					new Card { Name = "Elemental Allies" },
					new Card { Name = "Violet Spellwing" },
					new Card { Name = "Arcane Servant" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Quicksand Elemental" },
					new Card { Name = "Arcane Amplifier" },
					new Card { Name = "Chenvaala" },
					new Card { Name = "Fire Hawk" },
					new Card { Name = "Cosmic Anomaly" },
					new Card { Name = "Fireball" },
					new Card { Name = "Scorch" },
					new Card { Name = "Water Elemental" },
					new Card { Name = "Bonfire Elemental" },
					new Card { Name = "Hailbringer" },
					new Card { Name = "Animated Avalanche" },
				}
			};
		}

		private static Deck BuffHunter()
		{
			return new Deck
			{
				Name = "Buff Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Bestial Wrath" },
					new Card { Name = "Springpaw" },
					new Card { Name = "The Beast Within" },
					new Card { Name = "Tracking" },
					new Card { Name = "Flare" },
					new Card { Name = "Fresh Scent" },
					new Card { Name = "Goblin Prank" },
					new Card { Name = "Hunting Mastiff" },
					new Card { Name = "Pressure Plate" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Diving Gryphon" },
					new Card { Name = "Master's Call" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Dire Frenzy" },
					new Card { Name = "Tundra Rhino" },
					new Card { Name = "Scarlet Webweaver" },
					new Card { Name = "Zul'jin" },
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
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Witch's Brew" },
					new Card { Name = "Electra Stormsurge" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Plague of Murlocs" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Zentimo" },
					new Card { Name = "Hex" },
					new Card { Name = "Storm Chaser" },
					new Card { Name = "The Fist of Ra-den" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Earthquake" },
					new Card { Name = "Hagatha the Witch" },
					new Card { Name = "Walking Fountain" },
					new Card { Name = "Sathrovarr" },
					new Card { Name = "Eye of the Storm" },
					new Card { Name = "King Phaoris" },
				}
			};
		}
		private static Deck DragonWarlock()
		{
			return new Deck
			{
				Name = "Dragon Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Plague of Flames" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "Expired Merchant" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Nether Breath" },
					new Card { Name = "Dragonblight Cultist" },
					new Card { Name = "Rafaam's Scheme" },
					new Card { Name = "Fiendish Rites" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Veiled Worshipper" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Wretched" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "Zzeraku the Warped" },
				}
			};
		}

		private static Deck HighlanderPriest()
		{
			return new Deck
			{
				Name = "Highlander Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Forbidden Words" },
					new Card { Name = "Disciple of Galakrond" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Penance" },
					new Card { Name = "Seance" },
					new Card { Name = "Shadow Word: Pain" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Mindflayer Kaahrj" },
					new Card { Name = "Scalerider" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Fate Weaver" },
					new Card { Name = "Sandbinder" },
					new Card { Name = "Scaleworm" },
					new Card { Name = "Troll Batrider" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Chronobreaker" },
					new Card { Name = "Cobalt Spellkin" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Time Rip" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Evasive Wyrm" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Evasive Drakonid" },
					new Card { Name = "Galakrond the Unspeakable" },
					new Card { Name = "Siamat" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Plague of Death" },
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
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Nether Breath" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Brightwing" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Scalerider" },
					new Card { Name = "Shadow Bolt" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Hellfire" },
					new Card { Name = "Scaleworm" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Abyssal Summoner" },
					new Card { Name = "Evasive Wyrm" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Siphon Soul" },
					new Card { Name = "Crowd Roaster" },
					new Card { Name = "Siamat" },
					new Card { Name = "Valdris Felgorge" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Sathrovarr" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}

		private static Deck AlbatrossPriest()
		{
			return new Deck
			{
				Name = "Albatross Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Forbidden Words" },
					new Card { Name = "Activate the Obelisk" },
					new Card { Name = "Penance" },
					new Card { Name = "Bad Luck Albatross" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Vivid Nightmare" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Grave Rune" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Batterhead" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
					new Card { Name = "Zerek's Cloning Gallery" },
				}
			};
		}
		private static Deck AlbatrossRogue()
		{
			return new Deck
			{
				Name = "Albatross Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Depth Charge" },
					new Card { Name = "Togwaggle's Scheme" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Lab Recruiter" },
					new Card { Name = "Sap" },
					new Card { Name = "Transmogrifier" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Augmented Elekk" },
					new Card { Name = "Bad Luck Albatross" },
					new Card { Name = "Academic Espionage" },
					new Card { Name = "Conjured Mirage" },
					new Card { Name = "Dragonmaw Poacher" },
					new Card { Name = "Necrium Apothecary" },
					new Card { Name = "Walk the Plank" },
					new Card { Name = "Stowaway" },
					new Card { Name = "Flik Skyshiv" },
				}
			};
		}
		private static Deck EmbiggenDragonDruid()
		{
			return new Deck
			{
				Name = "Embiggen Dragon Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Embiggen" },
					new Card { Name = "Breath of Dreams" },
					new Card { Name = "Crystal Merchant" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Tasty Flyfish" },
					new Card { Name = "Nightmare Amalgam" },
					new Card { Name = "Scalerider" },
					new Card { Name = "Evasive Feywing" },
					new Card { Name = "Frizz Kindleroost" },
					new Card { Name = "Scaleworm" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Oasis Surger" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Emerald Explorer" },
					new Card { Name = "Evasive Wyrm" },
				}
			};
		}

		private static Deck HighlanderGalakrondRogue()
		{
			return new Deck
			{
				Name = "Highlander Galakrond Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Bloodsail Flybooter" },
					new Card { Name = "Dragon's Hoard" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Praise Galakrond!" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Blink Fox" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Necrium Blade" },
					new Card { Name = "Seal Fate" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Hench-Clan Burglar" },
					new Card { Name = "Necrium Apothecary" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Galakrond the Nightmare" },
					new Card { Name = "Anubisath Warbringer" },
					new Card { Name = "Dragonqueen Alexstrasza" },
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
					new Card { Name = "Wisp" },
					new Card { Name = "Bloodsail Flybooter" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Stonetusk Boar" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Vicious Scalehide" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Magic Carpet" },
					new Card { Name = "Necrium Blade" },
					new Card { Name = "Necrium Apothecary" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Necrium Vial" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Anubisath Warbringer" },
				}
			};
		}
		private static Deck PirateWarrior()
		{
			return new Deck
			{
				Name = "Pirate Warrior",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Sky Raider" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Upgrade!" },
					new Card { Name = "Bloodsail Raider" },
					new Card { Name = "Parachute Brigand" },
					new Card { Name = "Ancharrr" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "Skybarge" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Hoard Pillager" },
					new Card { Name = "Kor'kron Elite" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Arcanite Reaper" },
					new Card { Name = "Captain Greenskin" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Leeroy Jenkins" },
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
					new Card { Name = "Penance" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Batterhead" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
					new Card { Name = "Zerek's Cloning Gallery" },
				}
			};
		}

		private static Deck TreantTokenDruid()
		{
			return new Deck
			{
				Name = "Treant Token Druid",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Acornbearer" },
					new Card { Name = "Treenforcements" },
					new Card { Name = "Dendrologist" },
					new Card { Name = "Power of the Wild" },
					new Card { Name = "Shrubadier" },
					new Card { Name = "Landscaping" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "Garden Gnome" },
					new Card { Name = "Aeroponics" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Force of Nature" },
					new Card { Name = "Goru the Mightree" },
					new Card { Name = "Shu'ma" },
					new Card { Name = "The Forest's Aid" },
					new Card { Name = "Mulchmuncher" },
				}
			};
		}

		private static Deck SecretHighlanderHunter()
		{
			return new Deck
			{
				Name = "Secret Highlander Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Secretkeeper" },
					new Card { Name = "Springpaw" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Rat Trap" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Snipe" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Desert Spear" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Primordial Explorer" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Dragonmaw Poacher" },
					new Card { Name = "Hyena Alpha" },
					new Card { Name = "Marked Shot" },
					new Card { Name = "Sandbinder" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Veranus" },
					new Card { Name = "Dinotamer Brann" },
					new Card { Name = "Siamat" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Zul'jin" },
				}
			};
		}

		private static Deck FaceHunter()
		{
			return new Deck
			{
				Name = "Face Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Shot" },
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Rapid Fire" },
					new Card { Name = "Timber Wolf" },
					new Card { Name = "Toxic Reinforcements" },
					new Card { Name = "Tracking" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Misdirection" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Spellzerker" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Lifedrinker" },
				}
			};
		}
		private static Deck HandWarlock()
		{
			return new Deck
			{
				Name = "Hand Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Soulfire" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Nether Breath" },
					new Card { Name = "Sunfury Protector" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Scalerider" },
					new Card { Name = "Frizz Kindleroost" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Abyssal Summoner" },
					new Card { Name = "Aranasi Broodmother" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Lord Godfrey" },
					new Card { Name = "Valdris Felgorge" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "Zzeraku the Warped" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Malygos" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}


		private static Deck AnubisathRogue()
		{
			return new Deck
			{
				Name = "Anubisath Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Wisp" },
					new Card { Name = "Bloodsail Flybooter" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Stonetusk Boar" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Vicious Scalehide" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Necrium Blade" },
					new Card { Name = "Necrium Apothecary" },
					new Card { Name = "Anka, the Buried" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Necrium Vial" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Anubisath Warbringer" },
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
					new Card { Name = "Shield Slam" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Warpath" },
					new Card { Name = "Weapons Project" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Omega Devastator" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Brawl" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Plague of Wrath" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Deathwing Mad Aspect" },
					new Card { Name = "Archivist Elysiana" },
					new Card { Name = "Dr. Boom, Mad Genius" },
				}
			};
		}

		private static Deck TempoRogue()
		{
			return new Deck
			{
				Name = "Tempo Rogue",
				Prototype = "TEMPO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Bloodsail Flybooter" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "Necrium Blade" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Necrium Apothecary" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Mechanical Whelp" },
				}
			};
		}

		private static Deck GalakrondQuestShaman()
		{
			return new Deck
			{
				Name = "Galakrond Quest Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Corrupt the Waters"},
					new Card { Name = "Mutate" },
					new Card { Name = "Earth Shock" },
					new Card { Name = "Invocation of Frost" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Witch's Brew" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Mana Tide Totem" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Dragon's Pack" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Corrupt Elementalist" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Tempest" },
					new Card { Name = "Mogu Fleshshaper" },
					new Card { Name = "Shudderwock" },
				}
			};
		}

		private static Deck GalakrondShaman()
		{
			return new Deck
			{
				Name = "Galakrond Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Mutate" },
					new Card { Name = "Earth Shock" },
					new Card { Name = "Invocation of Frost" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Witch's Brew" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Mana Tide Totem" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Electra Stormsurge" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Dragon's Pack" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Corrupt Elementalist" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Tempest" },
					new Card { Name = "Mogu Fleshshaper" },
					new Card { Name = "Shudderwock" },
				}
			};
		}
		#endregion

		#region Decks 2020-01-27

		private static Deck AggroShaman()
		{
			return new Deck
			{
				Name = "Aggro Shaman",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Zap!" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Storm's Wrath" },
					new Card { Name = "Voltaic Burst" },
					new Card { Name = "EVIL Totem" },
					new Card { Name = "Earthen Might" },
					new Card { Name = "Likkim" },
					new Card { Name = "Soul of the Murloc" },
					new Card { Name = "Haunting Visions" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Spirit of the Frog" },
					new Card { Name = "Hex" },
					new Card { Name = "Thunderhead" },
					new Card { Name = "Vessina" },
					new Card { Name = "Bloodlust" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Sea Giant" },
				}
			};
		}

		private static Deck CycloneMage()
		{
			return new Deck
			{
				Name = "Cyclone Mage",
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
					new Card { Name = "Shooting Star" },
					new Card { Name = "Khadgar" },
					new Card { Name = "Mana Cyclone" },
					new Card { Name = "Research Project" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Banana Buffoon" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Stargazer Luna" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Mana Giant" },
					new Card { Name = "Sea Giant" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck GalakrondControlWarlock()
		{
			return new Deck
			{
				Name = "Galakrond Control Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Sacrificial Pact" },
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Plague of Flames" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Nether Breath" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Dragonblight Cultist" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Fiendish Rites" },
					new Card { Name = "Veiled Worshipper" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Wretched" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Dragonqueen Alexstrasza" },
				}
			};
		}
		private static Deck GalakrondPriest()
		{
			return new Deck
			{
				Name = "Galakrond Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Disciple of Galakrond" },
					new Card { Name = "Embalming Ritual" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Dead Ringer" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Shadowy Figure" },
					new Card { Name = "Omega Medic" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Fate Weaver" },
					new Card { Name = "Grave Rune" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Time Rip" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Unspeakable" },
					new Card { Name = "Plague of Death" },
				}
			};
		}
		private static Deck HighlanderPaladin()
		{
			return new Deck
			{
				Name = "Highlander Paladin",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Argent Protector" },
					new Card { Name = "Crystalsmith Kangor" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Flash of Light" },
					new Card { Name = "Sir Finley of the Sands" },
					new Card { Name = "Subdue" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Aldor Peacekeeper" },
					new Card { Name = "Bronze Explorer" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Consecration" },
					new Card { Name = "Equality" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Amber Watcher" },
					new Card { Name = "Dragonmaw Scorcher" },
					new Card { Name = "Shrink Ray" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Pharaoh's Blessing" },
					new Card { Name = "A New Challenger..." },
					new Card { Name = "Countess Ashmore" },
					new Card { Name = "Siamat" },
					new Card { Name = "Lay on Hands" },
					new Card { Name = "Tirion Fordring" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Shirvallah, the Tiger" },
				}
			};
		}

		private static Deck HighlanderWarrior()
		{
			return new Deck
			{
				Name = "Highlander Warrior",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Dragon Breeder" },
					new Card { Name = "Dragon Roar" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Slam" },
					new Card { Name = "Warpath" },
					new Card { Name = "Weapons Project" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Ramming Speed" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Smolderthorn Lancer" },
					new Card { Name = "Molten Breath" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "War Master Voone" },
					new Card { Name = "Brawl" },
					new Card { Name = "Cobalt Spellkin" },
					new Card { Name = "Dragonmaw Scorcher" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Emberscale Drake" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Plague of Wrath" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Deathwing Mad Aspect" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Dragonqueen Alexstrasza" },
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
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Time Out!" },
					new Card { Name = "Consecration" },
					new Card { Name = "Equality" },
					new Card { Name = "Hammer of Wrath" },
					new Card { Name = "Prismatic Lens" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Holy Wrath" },
					new Card { Name = "Shrink Ray" },
					new Card { Name = "Sathrovarr" },
					new Card { Name = "Shirvallah, the Tiger" },
				}
			};
		}
		private static Deck PurePaladin()
		{
			return new Deck
			{
				Name = "Pure Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Brazen Zealot" },
					new Card { Name = "Crystology" },
					new Card { Name = "Glow-Tron" },
					new Card { Name = "Micro Mummy" },
					new Card { Name = "Sanctuary" },
					new Card { Name = "Sandwasp Queen" },
					new Card { Name = "Aldor Peacekeeper" },
					new Card { Name = "Sky Claw" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Consecration" },
					new Card { Name = "Lightforged Zealot" },
					new Card { Name = "Amber Watcher" },
					new Card { Name = "Glowstone Technician" },
					new Card { Name = "Pharaoh's Blessing" },
					new Card { Name = "Lightforged Crusader" },
					new Card { Name = "Tirion Fordring" },
				}
			};
		}

		private static Deck TauntBeastDruid()
		{
			return new Deck
			{
				Name = "Taunt Beast Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Strength in Numbers" },
					new Card { Name = "Breath of Dreams" },
					new Card { Name = "Crystal Merchant" },
					new Card { Name = "Wrath" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Healing Touch" },
					new Card { Name = "Witching Hour" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Predatory Instincts" },
					new Card { Name = "Swipe" },
					new Card { Name = "Witchwood Grizzly" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Emerald Explorer" },
					new Card { Name = "Stampeding Roar" },
					new Card { Name = "Evasive Drakonid" },
					new Card { Name = "Gloop Sprayer" },
					new Card { Name = "Winged Guardian" },
					new Card { Name = "Oondasta" },
				}
			};
		}
		#endregion


	}
}

