using System;
using System.Collections.Generic;

namespace Domain.Metas
{
	public static class ScholomanceAcademy
	{

		public static Meta LoadMeta()
		{
			//  Use Diamond HSR list (my league)
			var meta = new Meta(
				code: "SA",
				name: "Scholomance Academy",
				patchNo: 18.3M,
				asOf: new DateTime(2020, 9, 29));
 
			var tier1Decks = new List<Deck>
			{
				HighlanderHunter(),
				PenFlingerPaladin(),
				LibramPaladin(),
				FaceHunter(),
			};
			meta.AddDecks(
				tier1Decks,
				tier: 1);
			///  Tier 2
			var tier2Decks = new List<Deck>
			{
				SoulDemonHunter(),
				SmallSpellMage(),
				BombWarrior(),
				AggroDemonHunter(),
				SecretRogue(),
				GalakrondRogue(),
				WeaponRogue(),
				BigWarrior(),
			};
			meta.AddDecks(
				tier2Decks,
				tier: 2);

			var tier3Decks = new List<Deck>
			{
				HighlanderRogue(),
				StealthRogue(),
				TotemShaman(),
				ControlPriest(),
				SkipperBombWarrior(),
				ControlWarrior(),
				EnrageWarrior(),
			};
			meta.AddDecks(
				tier3Decks,
				tier: 3);
			///   Tier 4
			var tier4Decks = new List<Deck>
			{
				GuardianDruid(),
				HighlanderMage(),
				HighlanderPriest(),
				ResurrectPriest(),
				GalakrondWarlock(),
				QuestDruid(),
				ZooWarlock(),
				ControlShaman(),
				GalakrondPriest(),
				MalygosDruid(),

			};
			meta.AddDecks(tier4Decks, 4);

			///  The nether regions
			var tier5Decks = new List<Deck>
			{
				QuestRogue(),
				NoMinionMage(),
				QuestWarlock(),
				DragonHunter(),
				GalakrondDragonPriest(),
				MurlocPaladin(),
				GibberlingDruid(),
				ControlDemonHunter(),
				FreezeMage(),
				QuestResurrectPriest(),
				SpellDamageShaman(),
				QuestShaman(),
				TortollanMage(),
			};
			meta.AddDecks(tier5Decks, 5);
			return meta;
		}

		#region Decks

		private static Deck ControlShaman()
		{
			var deck = new Deck
			{
				Name = "Control Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Devolving Missiles" },
					new Card { Name = "Primordial Studies" },
					new Card { Name = "Diligent Notetaker" },
					new Card { Name = "Rune Dagger" },
					new Card { Name = "Witch's Brew" },
					new Card { Name = "Instructor Fireheart" },
					new Card { Name = "Marshspawn" },
					new Card { Name = "Molten Blast" },
					new Card { Name = "Serpentshrine Portal" },
					new Card { Name = "Speaker Gidra" },
					new Card { Name = "Groundskeeper" },
					new Card { Name = "Torrent" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Ras Frostwhisper" },
					new Card { Name = "Shattered Rumbler" },
					new Card { Name = "Sorcerous Substitute" },
					new Card { Name = "The Lurker Below" },
					new Card { Name = "Tidal Wave" },
				}
			};
			return deck;
		}

		private static Deck HighlanderRogue()
		{
			var deck = new Deck
			{
				Name = "Highlander Rogue",
				Prototype = "SINGLETON",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Blackjack Stunner" },
					new Card { Name = "Brain Freeze" },
					new Card { Name = "Dragon's Hoard" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Praise Galakrond!" },
					new Card { Name = "Spymistress" },
					new Card { Name = "Wand Thief" },
					new Card { Name = "Ambush" },
					new Card { Name = "Cult Neophyte" },
					new Card { Name = "Dirty Tricks" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Plagiarize" },
					new Card { Name = "Shadowjeweler Hanar" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Seal Fate" },
					new Card { Name = "Infiltrator Lilian" },
					new Card { Name = "Lorekeeper Polkelt" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Jandice Barov" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond, the Nightmare" },
					new Card { Name = "Dragonqueen Alexstrasza" },
				}
			};
			return deck;
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
					new Card { Name = "Crystal Power" },
					new Card { Name = "Nature Studies" },
					new Card { Name = "Untapped Potential" },
					new Card { Name = "Worthy Expedition" },
					new Card { Name = "Crystal Merchant" },
					new Card { Name = "Rising Winds" },
					new Card { Name = "Steel Beetle" },
					new Card { Name = "Wrath" },
					new Card { Name = "Speaker Gidra" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Headmaster Kel'Thuzad" },
					new Card { Name = "Oasis Surger" },
					new Card { Name = "Starfall" },
					new Card { Name = "Hidden Oasis" },
					new Card { Name = "Nourish" },
					new Card { Name = "Cenarius" },
					new Card { Name = "Ysera, Unleashed" },
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
					new Card { Name = "Rain of Fire" },
					new Card { Name = "Soulfire" },
					new Card { Name = "Supreme Archaeology" },
					new Card { Name = "Mo'arg Artificer" },
					new Card { Name = "Nether Breath" },
					new Card { Name = "Plot Twist" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "School Spirits" },
					new Card { Name = "Sense Demons" },
					new Card { Name = "Lorekeeper Polkelt" },
					new Card { Name = "Sky Gen'ral Kragg" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Aranasi Broodmother" },
					new Card { Name = "Keli'dan the Breaker" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Malygos" },
				}
			};
		}

		private static Deck NoMinionMage()
		{
			return new Deck
			{
				Name = "No Minion Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Evocation" },
					new Card { Name = "Font of Power" },
					new Card { Name = "Learn Draconic" },
					new Card { Name = "Magic Trick" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Ancient Mysteries" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Incanter's Flow" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Flame Ward" },
					new Card { Name = "Netherwind Portal" },
					new Card { Name = "Fireball" },
					new Card { Name = "Apexis Blast" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Deep Freeze" },
					new Card { Name = "Power of Creation" },
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
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Grave Rune" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Psyche Split" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
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
					new Card { Name = "Athletic Studies" },
					new Card { Name = "Risky Skipper" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Sky Raider" },
					new Card { Name = "Armorsmith" },
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Coerce" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Ancharrr" },
					new Card { Name = "Bladestorm" },
					new Card { Name = "Bloodsworn Mercenary" },
					new Card { Name = "EVIL Quartermaster" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "Lord Barov" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Kargath Bladefist" },
					new Card { Name = "Brawl" },
					new Card { Name = "Armored Goon" },
					new Card { Name = "Troublemaker" },
					new Card { Name = "Kobold Stickyfinger" },
					new Card { Name = "Plague of Wrath" },
					new Card { Name = "Bloodboil Brute" },
					new Card { Name = "Deathwing, Mad Aspect" },
					new Card { Name = "Rattlegore" },
				}
			};
		}

		private static Deck SpellDamageShaman()
		{
			return new Deck
			{
				Name = "Spell Damage Shaman",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Devolving Missiles" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Primordial Studies" },
					new Card { Name = "Rune Dagger" },
					new Card { Name = "Arcane Watcher" },
					new Card { Name = "Instructor Fireheart" },
					new Card { Name = "Lady Vashj" },
					new Card { Name = "Lightning Breath" },
					new Card { Name = "Marshspawn" },
					new Card { Name = "Molten Blast" },
					new Card { Name = "Serpentshrine Portal" },
					new Card { Name = "Squallhunter" },
					new Card { Name = "Cobalt Spellkin" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Ras Frostwhisper" },
					new Card { Name = "Sorcerous Substitute" },
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
					new Card { Name = "Shadowstep" },
					new Card { Name = "Bazaar Burglary" },
					new Card { Name = "Blackjack Stunner" },
					new Card { Name = "Dragon's Hoard" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Secret Passage" },
					new Card { Name = "Wand Thief" },
					new Card { Name = "Clever Disguise" },
					new Card { Name = "Dirty Tricks" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Plagiarize" },
					new Card { Name = "Shadowjeweler Hanar" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Jandice Barov" },
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
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Corrupt the Waters" },
					new Card { Name = "Devolving Missiles" },
					new Card { Name = "Pen Flinger" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Tour Guide" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Cult Neophyte" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "Manafeeder Panthara" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Sandstorm Elemental" },
					new Card { Name = "Wandmaker" },
					new Card { Name = "Instructor Fireheart" },
					new Card { Name = "Sky Gen'ral Kragg" },
					new Card { Name = "Barista Lynchen" },
					new Card { Name = "Cumulo-Maximus" },
					new Card { Name = "The Lurker Below" },
				}
			};
		}
		private static Deck QuestResurrectPriest()
		{
			return new Deck
			{
				Name = "Quest Resurrect Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Forbidden Words" },
					new Card { Name = "Raise Dead" },
					new Card { Name = "Activate the Obelisk" },
					new Card { Name = "Penance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Gift of Luminance" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Grave Rune" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Psyche Split" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Batterhead" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
				}
			};
		}

		private static Deck AggroDemonHunter()
		{
			var deck = new Deck
			{
				Name = "Aggro Demon Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Battlefiend" },
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Demon Companion" },
					new Card { Name = "Guardian Augmerchant" },
					new Card { Name = "Intrepid Initiate" },
					new Card { Name = "Mana Burn" },
					new Card { Name = "Twin Slice" },
					new Card { Name = "Bonechewer Brawler" },
					new Card { Name = "Umberwing" },
					new Card { Name = "Voracious Reader" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Kayn Sunfury" },
					new Card { Name = "Marrowslicer" },
					new Card { Name = "Glaivebound Adept" },
					new Card { Name = "Skull of Gul'dan" },
				}
			};
			deck.AddKeyPlays(
				"Board flood, dont hold back ur AOE");
			return deck;
		}
		private static Deck BigWarrior()
		{
			return new Deck
			{
				Name = "Big Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Athletic Studies" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Sword and Board" },
					new Card { Name = "Whirlwind" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Execute" },
					new Card { Name = "Bladestorm" },
					new Card { Name = "Bulwark of Azzinoth" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Kargath Bladefist" },
					new Card { Name = "Reaper's Scythe" },
					new Card { Name = "Brawl" },
					new Card { Name = "Commencement" },
					new Card { Name = "Deathwing, Mad Aspect" },
					new Card { Name = "Troublemaker" },
					new Card { Name = "Rattlegore" },
					new Card { Name = "Dimensional Ripper" },
					new Card { Name = "Scrapyard Colossus" },
				}
			};
		}
		private static Deck SkipperBombWarrior()
		{
			return new Deck
			{
				Name = "Skipper Bomb Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Risky Skipper" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Upgrade!" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Armorsmith" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Ancharr" },
					new Card { Name = "Bladestorm" },
					new Card { Name = "Lord Barov" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Hoard Pillager" },
					new Card { Name = "Wrenchcalibur" },
					new Card { Name = "Brawl" },
					new Card { Name = "Cutting Class" },
					new Card { Name = "Doctor Krastinov" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Blastmaster Boom" },
					new Card { Name = "Galakrond, the Unbreakable" },
					new Card { Name = "Deathwing, Mad Aspect" },
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
					new Card { Name = "Shield Slam" },
					new Card { Name = "Sword and Board" },
					new Card { Name = "Upgrade!" },
					new Card { Name = "Whirlwind" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Bladestorm" },
					new Card { Name = "Coerce" },
					new Card { Name = "Lord Barov" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Hoard Pillager" },
					new Card { Name = "Kargath Bladefist" },
					new Card { Name = "Wrenchcalibur" },
					new Card { Name = "Brawl" },
					new Card { Name = "Cutting Class" },
					new Card { Name = "Doctor Krastinov" },
					new Card { Name = "Plague of Wrath" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Blastmaster Boom" },
					new Card { Name = "Galakrond, the Unbreakable" },
					new Card { Name = "Deathwing, Mad Aspect" },
				}
			};
		}
		private static Deck ControlDemonHunter()
		{
			return new Deck
			{
				Name = "Control Demon Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Crimson Sigil Runner" },
					new Card { Name = "Double Jump" },
					new Card { Name = "Spirit Jailer" },
					new Card { Name = "Soul Shear" },
					new Card { Name = "Umberwing" },
					new Card { Name = "Magehunter" },
					new Card { Name = "Shardshatter Mystic" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Ashtongue Battlelord" },
					new Card { Name = "Marrowslicer" },
					new Card { Name = "Chaos Nova" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Soulshard Lapidary" },
					new Card { Name = "Skull of Gul'dan" },
					new Card { Name = "Soulciologist Malicia" },
					new Card { Name = "Coilfang Warlord" },
					new Card { Name = "Nethrandamus" },
				}
			};
		}
		private static Deck DragonHunter()
		{
			return new Deck
			{
				Name = "Dragon Hunter",
				Prototype = "TEMPO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Guardian Augmerchant" },
					new Card { Name = "Tracking" },
					new Card { Name = "Corrosive Breath" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Hench-Clan Hogsteed" },
					new Card { Name = "Imprisoned Felmaw" },
					new Card { Name = "Scavenger's Ingenuity" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Desert Spear" },
					new Card { Name = "Diving Gryphon" },
					new Card { Name = "Frozen Shadoweaver" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Primordial Explorer" },
					new Card { Name = "Scalerider" },
					new Card { Name = "Stormhammer" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Evasive Feywing" },
					new Card { Name = "Marked Shot" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Cobalt Spellkin" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Evasive Wyrm" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Dinotamer Brann" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Nagrand Slam" },
				}
			};
		}
		private static Deck EnrageWarrior()
		{
			return new Deck
			{
				Name = "Enrage Warrior",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Inner Rage" },
					new Card { Name = "Risky Skipper" },
					new Card { Name = "Shield of Honor" },
					new Card { Name = "Sky Raider" },
					new Card { Name = "Armorsmith" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Serpent Egg" },
					new Card { Name = "Ancharrr" },
					new Card { Name = "Bloodsworn Mercenary" },
					new Card { Name = "Bomb Wrangler" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "Lord Barov" },
					new Card { Name = "Teron Gorefiend" },
					new Card { Name = "Warmaul Challenger" },
					new Card { Name = "Kor'kron Elite" },
					new Card { Name = "Bloodboil Brute" },
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
					new Card { Name = "Adorable Infestation" },
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Leper Gnome" },
					new Card { Name = "Tour Guide" },
					new Card { Name = "Demon Companion" },
					new Card { Name = "Toxic Reinforcements" },
					new Card { Name = "Pressure Plate" },
					new Card { Name = "Wolpertinger" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Intrepid Initiate" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Pressure Plate" },
					new Card { Name = "Pack Tactics" },
					new Card { Name = "Imprisoned Felmaw" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Scavenger's Ingenuity" },
					new Card { Name = "Voracious Reader" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Dragonbane" },
					new Card { Name = "Lorekeeper Polkelt" },
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
					new Card { Name = "Arcane Missiles" },
					new Card { Name = "Brain Freeze" },
					new Card { Name = "Devolving Missiles" },
					new Card { Name = "Evocation" },
					new Card { Name = "Magic Trick" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Sphere of Sapience" },
					new Card { Name = "Cram Session" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Icicle" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Lorekeeper Polkelt" },
					new Card { Name = "Mozaki, Master Duelist" },
					new Card { Name = "Blizzard" },
				}
			};
		}

		private static Deck ControlPriest()
		{
			var deck =  new Deck
			{
				Name = "Control Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Raise Dead" },
					new Card { Name = "Cleric of Scales" },
					new Card { Name = "Draconic Studies" },
					new Card { Name = "Renew" },
					new Card { Name = "Holy Smite" },
					new Card { Name = "Wave of Apathy" },
					new Card { Name = "Sethekk Veilweaver" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Wild Pyromancer" },

					new Card { Name = "Apotheosis" },
					new Card { Name = "Mindflayer Kaahrj" },
					new Card { Name = "Madame Lazul" },
					new Card { Name = "Cabal Acolyte" },
					new Card { Name = "Twilight Drake" },

					new Card { Name = "Cabal Shadow Priest" },
					new Card { Name = "Cobalt Spellkin" },
					new Card { Name = "Galakrond, the Unspeakable" },
					new Card { Name = "Soul Mirror" },
				}
			};
			deck.AddKeyPlays(
				"P will buff board with Apotheosis");
			return deck;
		}
		private static Deck GalakrondDragonPriest()
		{
			return new Deck
			{
				Name = "Galakrond Dragon Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Raise Dead" },
					new Card { Name = "Cleric of Scales" },
					new Card { Name = "Disciple of Galakrond" },
					new Card { Name = "Draconic Studies" },
					new Card { Name = "Renew" },
					new Card { Name = "Wave of Apathy" },
					new Card { Name = "Sethekk Veilweaver" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Apotheosis" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Mindflayer Kaahrj" },
					new Card { Name = "Mindrender Illucia" },
					new Card { Name = "Cabal Acolyte" },
					new Card { Name = "Fate Weaver" },
					new Card { Name = "Cobalt Spellkin" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Galakrond, the Unspeakable" },
					new Card { Name = "Soul Mirror" },
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
					new Card { Name = "Imprisoned Sungill" },
					new Card { Name = "Murloc Tidecaller" },
					new Card { Name = "Murmy" },
					new Card { Name = "Toxfin" },
					new Card { Name = "Fishflinger" },
					new Card { Name = "Hand of A'dal" },
					new Card { Name = "Hench-Clan Hogsteed" },
					new Card { Name = "Murgur Murgurgle" },
					new Card { Name = "Murloc Tidehunter" },
					new Card { Name = "Coldlight Seer" },
					new Card { Name = "Murloc Warleader" },
					new Card { Name = "Underlight Angling Rod" },
					new Card { Name = "Felfin Navigator" },
					new Card { Name = "Hoard Pillager" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Scalelord" },
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
					new Card { Name = "Holy Smite" },
					new Card { Name = "Renew" },
					new Card { Name = "Wave of Apathy" },
					new Card { Name = "Sethekk Veilweaver" },
					new Card { Name = "Thoughtsteal" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Cabal Acolyte" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Shadow Word: Ruin" },
					new Card { Name = "Headmaster Kel'Thuzad" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Time Rip" },
					new Card { Name = "Cabal Shadow Priest" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond, the Unspeakable" },
					new Card { Name = "Soul Mirror" },
					new Card { Name = "Murozond the Infinite" },
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
					new Card { Name = "Blackjack Stunner" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Praise Galakrond!" },
					new Card { Name = "Ambush" },
					new Card { Name = "Bamboozle" },
					new Card { Name = "Dirty Tricks" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Shadowjeweler Hanar" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Seal Fate" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond, the Nightmare" },
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
					new Card { Name = "Plague of Flames" },
					new Card { Name = "Spirit Jailer" },
					new Card { Name = "Tour Guide" },
					new Card { Name = "Mo'arg Artificer" },
					new Card { Name = "Nether Breath" },
					new Card { Name = "Soul Shear" },
					new Card { Name = "Dragonblight Cultist" },
					new Card { Name = "School Spirits" },
					new Card { Name = "Brittlebone Destroyer" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Veiled Worshipper" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond, the Wretched" },
					new Card { Name = "Soulciologist Malicia" },
					new Card { Name = "Alexstrasza" },
				}
			};
		}
		private static Deck GibberlingDruid()
		{
			return new Deck
			{
				Name = "Gibberling Druid",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Acornbearer" },
					new Card { Name = "Adorable Infestation" },
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Gibberling" },
					new Card { Name = "Intrepid Initiate" },
					new Card { Name = "Nature Studies" },
					new Card { Name = "Shieldbearer" },
					new Card { Name = "Treenforcements" },
					new Card { Name = "Dreamway Guardians" },
					new Card { Name = "Power of the Wild" },
					new Card { Name = "Voracious Reader" },
					new Card { Name = "Blessing of the Ancients" },
					new Card { Name = "Savage Roar" },
				}
			};
		}
		private static Deck GuardianDruid()
		{
			return new Deck
			{
				Name = "Guardian Druid",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Crystal Power" },
					new Card { Name = "Nature Studies" },
					new Card { Name = "Ironbark" },
					new Card { Name = "Bogbeam" },
					new Card { Name = "Speaker Gidra" },
					new Card { Name = "Overgrowth" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Lake Thresher" },
					new Card { Name = "Teacher's Pet" },
					new Card { Name = "Twilight Runner" },
					new Card { Name = "Guardian Animals" },
					new Card { Name = "Kael'thas Sunstrider" },
					new Card { Name = "Overflow" },
					new Card { Name = "Ysera, Unleashed" },
					new Card { Name = "Survival of the Fittest" },
				}
			};
		}
		private static Deck HighlanderHunter()
		{
			var deck = new Deck
			{
				Name = "Highlander Hunter",
				Prototype = "SINGLETON",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Adorable Infestation" },
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Demon Companion" },
					new Card { Name = "Guardian Augmerchant" },
					new Card { Name = "Tracking" },
					new Card { Name = "Corrosive Breath" },
					new Card { Name = "Intrepid Initiate" },
					new Card { Name = "Tour Guide" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Trueaim Crescent" },
					new Card { Name = "Bonechewer Brawler" },
					new Card { Name = "Wolpertinger" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Imprisoned Felmaw" },
					new Card { Name = "Scavenger's Ingenuity" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Transfer Student" },
					new Card { Name = "Voracious Reader" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Desert Spear" },
					new Card { Name = "Diving Gryphon" },
					new Card { Name = "Primordial Explorer" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Pressure Plate" },
					new Card { Name = "Stormhammer" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Zixor, Apex Predator" },
					new Card { Name = "Dragonbane" },
					new Card { Name = "Evasive Feywing" },
					new Card { Name = "Frizz Kindleroost" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Rotnest Drake" },
					new Card { Name = "Evasive Wyrm" },
					new Card { Name = "Veranus" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Dinotamer Brann" },
					new Card { Name = "Siamat" },
					new Card { Name = "Ace Hunter Kreen" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Nagrand Slam" },
				}
			};
			deck.AddKeyPlays("H will Polkhet to draw Bran");
			return deck;
		}
		private static Deck HighlanderMage()
		{
			return new Deck
			{
				Name = "Highlander Mage",
				Prototype = "SINGLETON",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Sphere of Sapience" },
					new Card { Name = "Arcane Breath" },
					new Card { Name = "Devolving Missiles" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Astromancer Solarian" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Transfer Student" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Combustion" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Ice Barrier" },
					new Card { Name = "Imprisoned Observer" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Escaped Manasaber" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Jandice Barov" },
					new Card { Name = "Malygos, Aspect of Magic" },
					new Card { Name = "Rolling Fireball" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Reno the Relicologist" },
					new Card { Name = "Dragoncaster" },
					new Card { Name = "Deep Freeze" },
					new Card { Name = "Power of Creation" },
					new Card { Name = "Tortollan Pilgrim" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Kalecgos" },
					new Card { Name = "Puzzle Box of Yogg-Saron" },
					new Card { Name = "The Amazing Reno" },
				}
			};
		}
		private static Deck HighlanderPriest()
		{
			return new Deck
			{
				Name = "Highlander Priest",
				Prototype = "SINGLETON",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Forbidden Words" },
					new Card { Name = "Lazul's Scheme" },
					new Card { Name = "Disciple of Galakrond" },
					new Card { Name = "Renew" },
					new Card { Name = "Wave of Apathy" },
					new Card { Name = "Imprisoned Vilefiend" },
					new Card { Name = "Penance" },
					new Card { Name = "Sethekk Veilweaver" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Thoughtsteal" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Apotheosis" },
					new Card { Name = "Madame Lazul" },
					new Card { Name = "Mindflayer Kaahrj" },
					new Card { Name = "Mindrender Illucia" },
					new Card { Name = "Shadow Madness" },
					new Card { Name = "Cabal Acolyte" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Shadow Word: Ruin" },
					new Card { Name = "Wretched Tutor" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Headmaster Kel'Thuzad" },
					new Card { Name = "Time Rip" },
					new Card { Name = "Cabal Shadow Priest" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Onyx Magescribe" },
					new Card { Name = "Galakrond, the Unspeakable" },
					new Card { Name = "Soul Mirror" },
					new Card { Name = "Murozond the Infinite" },
					new Card { Name = "Dragonqueen Alexstrasza" },
				}
			};
		}
		private static Deck LibramPaladin()
		{
			var deck = new Deck
			{
				Name = "Libram Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "First Day of School" },
					new Card { Name = "Aldor Attendant" },
					new Card { Name = "Argent Braggart" },
					new Card { Name = "Hand of A'dal" },
					new Card { Name = "Libram of Wisdom" },
					new Card { Name = "Gift of Luminance" },
					new Card { Name = "Goody Two-Shields" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "High Abbess Alura" },
					new Card { Name = "Lightforged Zealot" },
					new Card { Name = "Aldor Truthseeker" },
					new Card { Name = "Blessing of Authority" },
					new Card { Name = "Libram of Justice" },
					new Card { Name = "Devout Pupil" },
					new Card { Name = "Lady Liadrin" },
					new Card { Name = "Lightforged Crusader" },
					new Card { Name = "Libram of Hope" },
				}
			};
			deck.AddAdvice(
				"Pen Flinger Paladin",
				"dont let them get the board");
			deck.AddAdvice(
				"Priest",
				"buff doods to max 4 attack to play around Death");
			deck.AddAdvice(
				"Resurrect Priest",
				"save board clear for Vargoth double res");
			deck.AddAdvice(
				"Small Spell Mage",
				"go wide to spread the devolving missiles out");
			return deck;
		}
		private static Deck MalygosDruid()
		{
			return new Deck
			{
				Name = "Malygos Druid",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Nature Studies" },
					new Card { Name = "Breath of Dreams" },
					new Card { Name = "Bogbeam" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Germination" },
					new Card { Name = "Overgrowth" },
					new Card { Name = "Swipe" },
					new Card { Name = "Teacher's Pet" },
					new Card { Name = "Twilight Runner" },
					new Card { Name = "Forest Warden Omu" },
					new Card { Name = "Guardian Animals" },
					new Card { Name = "Kael'thas Sunstrider" },
					new Card { Name = "Overflow" },
					new Card { Name = "Jepetto Joybuzz" },
					new Card { Name = "Malygos" },
					new Card { Name = "Ysera, Unleashed" },
				}
			};
		}
		private static Deck SecretRogue()
		{
			return new Deck
			{
				Name = "Secret Rogue",
				Prototype = "TEMPO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Blackjack Stunner" },
					new Card { Name = "Dragon's Hoard" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Secret Passage" },
					new Card { Name = "Wand Thief" },
					new Card { Name = "Cult Neophyte" },
					new Card { Name = "Dirty Tricks" },
					new Card { Name = "Plagiarize" },
					new Card { Name = "Shadowjeweler Hanar" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Questing Adventurer" },
					new Card { Name = "Vendetta" },
				}
			};
		}
		private static Deck SmallSpellMage()
		{
			return new Deck
			{
				Name = "Small Spell Mage",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Missiles" },
					new Card { Name = "Evocation" },
					new Card { Name = "Lab Partner" },
					new Card { Name = "Magic Trick" },
					new Card { Name = "Primordial Studies" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Violet Spellwing" },
					new Card { Name = "Wand Thief" },
					new Card { Name = "Astromancer Solarian" },
					new Card { Name = "Cram Session" },
					new Card { Name = "Mana Cyclone" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Chenvaala" },
					new Card { Name = "Firebrand" },
					new Card { Name = "Mozaki, Master Duelist" },
					new Card { Name = "Mana Giant" },
				}
			};
		}
		private static Deck SoulDemonHunter()
		{
			var deck = new Deck
			{
				Name = "Soul Demon Hunter",
				Prototype = "TEMPO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Crimson Sigil Runner" },
					new Card { Name = "Double Jump" },
					new Card { Name = "Spirit Jailer" },
					new Card { Name = "Twin Slice" },
					new Card { Name = "Consume Magic" },
					new Card { Name = "Wandmaker" },
					new Card { Name = "Blade Dance" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Manafeeder Panthara" },
					new Card { Name = "Soul Shear" },
					new Card { Name = "Spectral Sight" },
					new Card { Name = "Shardshatter Mystic" },
					new Card { Name = "Hoard Pillager" },
					new Card { Name = "Magtheridon" },
					new Card { Name = "Raging Felscreamer" },
					new Card { Name = "Hulking Overfiend" },
					new Card { Name = "Lorekeeper Polkelt" },
					new Card { Name = "Aldrachi Warblades" },
					new Card { Name = "Marrowslicer" },
					new Card { Name = "Glaivebound Adept" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Soulshard Lapidary" },
					new Card { Name = "Soulciologist Malicia" },
				}
			};
			deck.AddAdvice(
				"Libram Paladin",
				"Keep Consume for buffed boys");
			deck.AddAdvice(
				"Pen Flinger Paladin",
				"Keep Consume for buffed boys");
			deck.AddAdvice(
				"Pen Flinger Paladin",
				"Play fast to get under the Hopes");
			deck.AddAdvice(
				"Small Spell Mage",
				"Bladedance the T8 Mana Giant into conjuring");
			deck.AddAdvice(
				"Bomb Warrior",
				"Hammer him down before the bombs go off");
			deck.AddAdvice(
				"Small Spell Mage",
				"Hold back some weapon damage for the fatal blow");

			return deck;
		}
		private static Deck StealthRogue()
		{
			return new Deck
			{
				Name = "Stealth Rogue",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Plague of Madness" },
					new Card { Name = "Secret Passage" },
					new Card { Name = "Sinister Strike" },
					new Card { Name = "Spymistress" },
					new Card { Name = "Worgen Infiltrator" },
					new Card { Name = "Ashtongue Slayer" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Sneaky Delinquent" },
					new Card { Name = "Akama" },
					new Card { Name = "Greyheart Sage" },
					new Card { Name = "Hooked Scimitar" },
					new Card { Name = "Wolfrider" },
					new Card { Name = "Burrowing Scorpid" },
				}
			};
		}

		private static Deck PenFlingerPaladin()
		{
			return new Deck
			{
				Name = "Pen Flinger Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "First Day of School" },
					new Card { Name = "Aldor Attendant" },
					new Card { Name = "Animated Broomstick" },
					new Card { Name = "Pen Flinger" },
					new Card { Name = "Hand of A'dal" },
					new Card { Name = "Libram of Wisdom" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Lord Barov" },
					new Card { Name = "Lightforged Blessing" },
					new Card { Name = "Murgur Murgurgle" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Gift of Luminance" },
					new Card { Name = "Goody Two-Shields" },
					new Card { Name = "Salhet's Pride" },
					new Card { Name = "High Abbess Alura" },
					new Card { Name = "Aldor Truthseeker" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Libram of Justice" },
					new Card { Name = "Devout Pupil" },
					new Card { Name = "Lady Liadrin" },
					new Card { Name = "Libram of Hope" },
				}
			};
		}

		private static Deck TortollanMage()
		{
			return new Deck
			{
				Name = "Tortollan Mage",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Animated Broomstick" },
					new Card { Name = "Depth Charge" },
					new Card { Name = "Sphere of Sapience" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Astromancer Solarian" },
					new Card { Name = "Cult Neophyte" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Earthen Ring Farseer" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Frozen Shadoweaver" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Escaped Manasaber" },
					new Card { Name = "Lorekeeper Polkelt" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Potion of Illusion" },
					new Card { Name = "Boompistol Bully" },
					new Card { Name = "Nightblade" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Tortollan Pilgrim" },
				}
			};
		}
		private static Deck TotemShaman()
		{
			return new Deck
			{
				Name = "Totem Shaman",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Totemic Might" },
					new Card { Name = "Totemic Surge" },
					new Card { Name = "Storm's Wrath" },
					new Card { Name = "Surging Tempest" },
					new Card { Name = "Tour Guide" },
					new Card { Name = "EVIL Totem" },
					new Card { Name = "Trick Totem" },
					new Card { Name = "Mana Tide Totem" },
					new Card { Name = "Serpentshrine Portal" },
					new Card { Name = "Totemic Reflection" },
					new Card { Name = "Splitting Axe" },
					new Card { Name = "Bloodlust" },
					new Card { Name = "Totem Goliath" },
					new Card { Name = "Runic Carvings" },
				}
			};
		}
		private static Deck WeaponRogue()
		{
			return new Deck
			{
				Name = "Weapon Rogue",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Preparation" },
					new Card { Name = "Sap" },
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Intrepid Initiate" },
					new Card { Name = "Secret Passage" },
					new Card { Name = "Sinister Strike" },
					new Card { Name = "Self-Sharpening Sword" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Spymistress" },
					new Card { Name = "Worgen Infiltrator" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Voracious Reader" },
					new Card { Name = "Hooked Scimitar" },
					new Card { Name = "Vulpera Toxinblade" },
					new Card { Name = "Cutting Class" },
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
					new Card { Name = "Raise Dead" },
					new Card { Name = "Flame Imp" },
					new Card { Name = "Soulfire" },
					new Card { Name = "Spirit Jailer" },
					new Card { Name = "Tour Guide" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "Expired Merchant" },
					new Card { Name = "Soul Shear" },
					new Card { Name = "Darkglare" },
					new Card { Name = "Nether Breath" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Neferset Thrasher" },
					new Card { Name = "Shadowlight Scholar" },
					new Card { Name = "Diseased Vulture" },
					new Card { Name = "Void Drinker" },
					new Card { Name = "Nightshade Matron" },
					new Card { Name = "Shadowflame" },
					new Card { Name = "Hand of Gul'dan" },
					new Card { Name = "Flesh Giant" },
				}
			};
		}
		#endregion


	}
}
