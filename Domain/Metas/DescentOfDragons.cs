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
				asOf: new DateTime(2019, 12, 27));

			//  TIER 1
			var tier1Decks = new List<Deck>
			{
				AnubisathRogue(),
				PirateWarrior(),
				FaceHunter(),
				QuestPriest(),
				TempoRogue(),
				SecretHighlanderHunter(),
				HighlanderHunter(),
				GalakrondZooWarlock(),
				ControlWarrior(),
				MechPaladin(),
				GalakrondWarrior(),
			};
			meta.AddDecks(tier1Decks, 1);

			var tier2Decks = new List<Deck>
			{
				TreantTokenDruid(),
				HighlanderGalakrondRogue(),
				EmbiggenDragonDruid(),
				HandWarlock(),
				DeathrattleRogue()
			};
			meta.AddDecks(tier2Decks, 2);

			var tier3Decks = new List<Deck>
			{
				HighlanderMage()
			};
			meta.AddDecks(tier3Decks, 3);

			var tier5Decks = new List<Deck>
			{
				ResurrectPriest(),
				AlbatrossPriest(),
				AlbatrossRogue()
			};
			meta.AddDecks(tier5Decks, 5);

			return meta;
		}


		#region Decks

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
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Ritual Chopper" },
					new Card { Name = "Warpath" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Awaken!" },
					new Card { Name = "Scion of Ruin" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Brawl" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Plague of Wrath" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond, the Unbreakable" },
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
					new Card { Name = "Galakrond, the Nightmare" },
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
					new Card { Name = "Silence" },
					new Card { Name = "Penance" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Grave Rune" },
					new Card { Name = "High Priest Amet" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Witchwood Grizzly" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
					new Card { Name = "Zerek's Cloning Gallery" },
					new Card { Name = "Mind Control" },
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

		private static Deck GalakrondZooWarlock()
		{
			return new Deck
			{
				Name = "Galakrond Zoo Warlock",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Flame Imp" },
					new Card { Name = "Grim Rally" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Murmy" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "Dire Wolf Alpha" },
					new Card { Name = "EVIL Genius" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "Dragonblight Cultist" },
					new Card { Name = "Fiendish Rites" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Veiled Worshipper" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond, the Wretched" },
					new Card { Name = "Valdris Felgorge" },
				}
			};
		}
		private static Deck MechPaladin()
		{
			return new Deck
			{
				Name = "Mech Paladin",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Crystology" },
					new Card { Name = "Glow-Tron" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Galvanizer" },
					new Card { Name = "Micro Mummy" },
					new Card { Name = "Goboglide Tech" },
					new Card { Name = "Sky Claw" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Annoy-o-Module" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Explodinator" },
					new Card { Name = "Replicating Menace" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Wargear" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Gyrocopter" },
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
				Prototype = "CONTROL",
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
					new Card { Name = "Learn Draconic" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Scalerider" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Frizz Kindleroost" },
					new Card { Name = "Polymorph" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Cobalt Spellkin" },
					new Card { Name = "Malygos, Aspect of Magic" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Dragoncaster" },
					new Card { Name = "Reno the Relicologist" },
					new Card { Name = "Crowd Roaster" },
					new Card { Name = "Flamestrike" },
					new Card { Name = "Siamat" },
					new Card { Name = "Power of Creation" },
					new Card { Name = "Tortollan Pilgrim" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Kalecgos" },
					new Card { Name = "Puzzle Box of Yogg-Saron" },
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
					new Card { Name = "Deathwing, Mad Aspect" },
					new Card { Name = "Archivist Elysiana" },
					new Card { Name = "Dr. Boom, Mad Genius" },
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
					new Card { Name = "Shimmerfly" },
					new Card { Name = "Springpaw" },
					new Card { Name = "Tracking" },
					new Card { Name = "Corrosive Breath" },
					new Card { Name = "Headhunter's Hatchet" },
					new Card { Name = "Hench-Clan Hogsteed" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Desert Spear" },
					new Card { Name = "Diving Gryphon" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Primordial Explorer" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Dragonbane" },
					new Card { Name = "Houndmaster Shaw" },
					new Card { Name = "Marked Shot" },
					new Card { Name = "Wing Blast" },
					new Card { Name = "Faceless Corruptor" },
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

		#endregion

	}
}
