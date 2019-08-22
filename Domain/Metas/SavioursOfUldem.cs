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
				name: "Saviours of Uldem",
				patchNo: 15.0M,
				asOf: new DateTime(2019, 8, 16));

			//  TIER 1
			var tier1Decks = new List<Deck>
			{
				CycloneGiantsMage(),
				ControlWarrior(),
				BombWarrior(),
				BigSpellMage(),
			};
			meta.AddDecks(tier1Decks, 1);

			//  TIER 2
			var tier2Decks = new List<Deck>
			{
				HighlanderMage(),
				MurlocPaladin(),
				AggroMechHunter(),
				HighlanderHunter(),
				SecretHunter(),
				AggroShaman(),
				ComboAggroPriest(),
				MurlocShaman(),
			};
			meta.AddDecks(tier2Decks, 2);

			//  TIER 3
			var tier3Decks = new List<Deck>
			{
				QuestShaman(),
				HolyWrathPaladin(),
				QuestDruid(),
				TempoRogue(),
				QuestRogue(),
				QuestPaladin(),
				ZooWarlock(),
				QuestControlPriest(),
				MidrangeHunter(),
				HighlanderPaladin(),
			};
			meta.AddDecks(tier3Decks, 3);

			//  TIER 4
			var tier4Decks = new List<Deck>
			{
				SecretMage(),
				TempoRogue(),
				TempoWarrior(),
				QuestWarrior(),
				ControlShaman(),

			};
			meta.AddDecks(tier4Decks, 4);

			////  TIER 5
			var tier5Decks = new List<Deck>
			{
				QuestWarlock(),
				QuestHunter(),
			};
			meta.AddDecks(tier5Decks, 5);

			////  TIER 6 Nether Storm
			var tier6Decks = new List<Deck>
			{
				AggroPirateRogue(),
				ComboPriest(),
				MuckShaman(),
				PsycopompWallPriest(),
				QuestPhaorisPriest(),
				QuestPriest(),
				QuestTirionPaladin(),
				TauntControlWarrior(),
				TessQuestRogue(),
			};
			meta.AddDecks(tier6Decks, 6);

			return meta;
		}

#region Decks
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
		private static Deck AggroMechHunter()
		{
			return new Deck
			{
				Name = "Aggro Mech Hunter",
				Prototype = "CONTROL",
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
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Grommash Hellscream" },
				}
			};
		}
		private static Deck ComboAggroPriest()
		{
			return new Deck
			{
				Name = "Combo Aggro Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Circle of Healing" },
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
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Warpath" },
					new Card { Name = "Shield Block" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Omega Devastator" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Brawl" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Plague of Wrath" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Armagedillo" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Tomb Warden" },
					new Card { Name = "Archivist Elysiana" },
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
					new Card { Name = "Secretkeeper" },
					new Card { Name = "Shimmerfly" },
					new Card { Name = "Springpaw" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Pressure Plate" },
					new Card { Name = "Rat Trap" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Snipe" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Hunter's Pack" },
					new Card { Name = "Masked Contender" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Houndmaster Shaw" },
					new Card { Name = "Hyena Alpha" },
					new Card { Name = "Marked Shot" },
					new Card { Name = "Sandbinder" },
					new Card { Name = "Baited Arrow" },
					new Card { Name = "Subject 9" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Savannah Highmane" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Wild Bloodstinger" },
					new Card { Name = "Dinotamer Brann" },
					new Card { Name = "Siamat" },
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
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Flame Ward" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Messenger Raven" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Vulpera Scoundrel" },
					new Card { Name = "Arcane Keysmith" },
					new Card { Name = "Polymorph" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Witchwood Piper" },
					new Card { Name = "Barista Lynchen" },
					new Card { Name = "Luna's Pocket Galaxy" },
					new Card { Name = "Sunreaver Warmage" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Meteorologist" },
					new Card { Name = "Reno the Relicologist" },
					new Card { Name = "Astromancer" },
					new Card { Name = "Flamestrike" },
					new Card { Name = "Siamat" },
					new Card { Name = "Power of Creation" },
					new Card { Name = "Tortollan Pilgrim" },
					new Card { Name = "Kalecgos" },
					new Card { Name = "Puzzle Box of Yogg-Saron" },
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
					new Card { Name = "Blessing of Wisdom" },
					new Card { Name = "Crystology" },
					new Card { Name = "Elven Archer" },
					new Card { Name = "Baleful Banker" },
					new Card { Name = "Crystalsmith Kangor" },
					new Card { Name = "Flash of Light" },
					new Card { Name = "Immortal Prelate" },
					new Card { Name = "Lightforged Blessing" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Sir Finley of the Sands" },
					new Card { Name = "Subdue" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Call to Adventure" },
					new Card { Name = "Time Out!" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Consecration" },
					new Card { Name = "Equality" },
					new Card { Name = "Hammer of Wrath" },
					new Card { Name = "Prismatic Lens" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Holy Wrath" },
					new Card { Name = "Mechano-Egg" },
					new Card { Name = "Shrink Ray" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Da Undatakah" },
					new Card { Name = "Lay on Hands" },
					new Card { Name = "Shirvallah, the Tiger" },
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
					new Card { Name = "Revenge of the Wild" },
					new Card { Name = "Scavenging Hyena" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Hunter's Pack" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Master's Call" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Dire Frenzy" },
					new Card { Name = "Tundra Rhino" },
					new Card { Name = "Savannah Highmane" },
					new Card { Name = "Scarlet Webweaver" },
					new Card { Name = "Zul'jin" },
				}
			};
		}
		private static Deck MuckShaman()
		{
			return new Deck
			{
				Name = "Muck Shaman",
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
				Prototype = "CONTROL",
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
					new Card { Name = "Grimscale Oracle" },
					new Card { Name = "Murloc Tidecaller" },
					new Card { Name = "Murmy" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Toxfin" },
					new Card { Name = "Bluegill Warrior" },
					new Card { Name = "Fishflinger" },
					new Card { Name = "Murloc Tidehunter" },
					new Card { Name = "Soul of the Murloc" },
					new Card { Name = "Underbelly Angler" },
					new Card { Name = "Coldlight Seer" },
					new Card { Name = "Murloc Warleader" },
					new Card { Name = "Nightmare Amalgam" },
					new Card { Name = "Murloc Tastyfin" },
					new Card { Name = "Scargil" },
					new Card { Name = "Bloodlust" },
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
					new Card { Name = "Wrath" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "BEEEES!!!" },
					new Card { Name = "Wardruid Loti" },
					new Card { Name = "Flobbidinous Floop" },
					new Card { Name = "Swipe" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Elise the Enlightened" },
					new Card { Name = "Oasis Surger" },
					new Card { Name = "Starfall" },
					new Card { Name = "Hidden Oasis" },
					new Card { Name = "Nourish" },
					new Card { Name = "Ancient of War" },
					new Card { Name = "Cenarius" },
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
					new Card { Name = "Bronze Gatekeeper" },
					new Card { Name = "Candletaker" },
					new Card { Name = "Ancestral Guardian" },
					new Card { Name = "Annoy-o-Module" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Mechano-Egg" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Kangor's Endless Army" },
					new Card { Name = "Da Undatakah" },
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
					new Card { Name = "Activate the Obelisk" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Penance" },
					new Card { Name = "Seance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Archmage Vargoth" },
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
				Prototype = "CONTROL",
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
					new Card { Name = "EVIL Genius" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "Serpent Egg" },
					new Card { Name = "Magic Carpet" },
					new Card { Name = "Neferset Thrasher" },
					new Card { Name = "SN1P-SN4P" },
					new Card { Name = "Defender of Argus" },
					new Card { Name = "Diseased Vulture" },
					new Card { Name = "Sea Giant" },
				}
			};
		}
		#endregion



	}
}
