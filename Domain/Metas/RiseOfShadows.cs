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
				patchNo: 14.0M);

			//  TIER 1
			var tier1Decks = new List<Deck>
			{
				LackeyRogue(),
				TokenDruid(),
				MechPaladin(),
				BombWarrior()
			};
			meta.AddDecks(tier1Decks, 1);

			//  TIER 2
			var tier2Decks = new List<Deck>
			{
				MidrangeHunter(),
				ConjurerMage(),
				MechHunter(),
				MurlocShaman(),
				Zoolock(),
				DragonWarrior(),
				ControlWarrior()
			};
			meta.AddDecks(tier2Decks, 2);

			//  TIER 3
			var tier3Decks = new List<Deck>
			{
				SilencePriest()
			};
			meta.AddDecks(tier3Decks, 3);

			//  TIER 4
			var tier4Decks = new List<Deck>
			{
				MuckShaman(),
				DragonSecretPaladin(),
				SecretPaladin(),
				WallPriest(),
				MalygosHunter(),
				ThiefRogue()
			};
			meta.AddDecks(tier4Decks, 4);

			////  TIER 5
			var tier5Decks = new List<Deck>
			{
				TurtlePriest()
			};
			meta.AddDecks(tier5Decks, 5);

			return meta;
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

		private static Deck LackeyRogue()
		{
			return new Deck
			{
				Name = "Lackey Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Blink Fox" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Raiding Party" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Hench-Clan Burglar" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Waggle Pick" },
					new Card { Name = "Captain Greenskin" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Myra's Unstable Element" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Heistbaron Togwaggle" },
				}
			};
		}

		private static Deck BombWarrior()
		{
			return new Deck
			{
				Name = "Bomb Warrior",
				Prototype = "CONTROL",
				Tier = 3,
				Rank = 17,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Omega Assembly" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Upgrade!" },
					new Card { Name = "Execute" },
					new Card { Name = "Slam" },
					new Card { Name = "Warpath" },
					new Card { Name = "Weapons Project" },
					new Card { Name = "Clockwork Goblin" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Wrenchcalibur" },
					new Card { Name = "Brawl" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Blastmaster Boom" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Archivist Elysiana" },
				}
			};
		}

		private static Deck Zoolock()
		{
			return new Deck
			{
				Name = "Zoolock",
				Prototype = "AGGRO",
				Tier = 3,
				Rank = 18,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Abusive Sergeant" },
					new Card { Name = "Argent Squire" },
					new Card { Name = "Crystallizer" },
					new Card { Name = "Flame Imp" },
					new Card { Name = "Grim Rally" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Saronite Taskmaster" },
					new Card { Name = "The Soularium" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "Dire Wolf Alpha" },
					new Card { Name = "EVIL Genius" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "Scarab Egg" },
					new Card { Name = "Magic Carpet" },
					new Card { Name = "Arch-Villain Rafaam" },

					new Card { Name = "Sea Giant" },
				}
			};
		}

		private static Deck MurlocShaman()
		{
			return new Deck
			{
				Name = "Murloc Shaman",
				Prototype = "AGGRO",
				Tier = 3,
				Rank = 19,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Grimscale Oracle" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Murloc Tidecaller" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Toxfin" },
					new Card { Name = "Hench-Clan Hogsteed" },
					new Card { Name = "Likkim" },
					new Card { Name = "Murloc Tidehunter" },
					new Card { Name = "Soul of the Murloc" },
					new Card { Name = "Underbelly Angler" },
					new Card { Name = "Coldlight Seer" },
					new Card { Name = "Lava Burst" },
					new Card { Name = "Murloc Warleader" },
					new Card { Name = "Murloc Tastyfin" },
					new Card { Name = "Scargil" },
					new Card { Name = "Bloodlust" },
					new Card { Name = "Hagatha the Witch" },
				}
			};
		}

		private static Deck MuckShaman()
		{
			return new Deck
			{
				Name = "Muckmorpher Shaman",
				Prototype = "MIDRANGE",
				Tier = 3,
				Rank = 19,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Zap!" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Ancestral Spirit" },
					new Card { Name = "Big Bad Voodoo" },
					new Card { Name = "Likkim" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Hex" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Muckmorpher" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Cairne Bloodhoof" },
					new Card { Name = "Eureka!" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Al'Akir the Windlord" },
					new Card { Name = "Walking Fountain" },
					new Card { Name = "Ysera" },

				}
			};
		}

		private static Deck DragonSecretPaladin()
		{
			return new Deck
			{
				Name = "Dragon Secret Paladin",
				Prototype = "TEMPO",
				Tier = 3,
				Rank = 19,
				HeroClass = new Hero(""),
				Cards = new List<Card>
				{
					new Card { Name = "Autodefense Matrix" },
					new Card { Name = "Noble Sacrifice" },
					new Card { Name = "Redemption" },
					new Card { Name = "Secretkeeper" },
					new Card { Name = "Cathedral Gargoyle" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Mysterious Blade" },
					new Card { Name = "Sunreaver Spy" },
					new Card { Name = "Bronze Herald" },
					new Card { Name = "Nightmare Amalgam" },
					new Card { Name = "Bellringer Sentry" },
					new Card { Name = "Scaleworm" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Crowd Roaster" },
					new Card { Name = "Onyxia" },
					new Card { Name = "Ysera" },

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
					new Card { Name = "Autodefense Matrix" },
					new Card { Name = "Hidden Wisdom" },
					new Card { Name = "Never Surrender!" },
					new Card { Name = "Redemption" },
					new Card { Name = "Mysterious Blade" },
					new Card { Name = "Sunreaver Spy" },
					new Card { Name = "Bronze Gatekeeper" },
					new Card { Name = "Commander Rhyssa" },
					new Card { Name = "Annoy-o-Module" },
					new Card { Name = "Bellringer Sentry" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Consecration" },
					new Card { Name = "Mechano-Egg" },
					new Card { Name = "Wargear" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Countess Ashmore" },
					new Card { Name = "Kangor's Endless Army" },
					new Card { Name = "Tirion Fordring" },
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
					new Card { Name = "Dire Wolf Alpha" },
					new Card { Name = "Headhunter's Hatchet" },
					new Card { Name = "Hench-Clan Hogsteed" },
					new Card { Name = "Scavenging Hyena" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Master's Call" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Dire Frenzy" },
					new Card { Name = "Tundra Rhino" },
					new Card { Name = "Savannah Highmane" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Zul'jin" },
				}
			};
		}
		private static Deck ConjurerMage()
		{
			return new Deck
			{
				Name = "Conjurer Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Book of Specters" },
					new Card { Name = "Firetree Witchdoctor" },
					new Card { Name = "Khadgar" },
					new Card { Name = "Sunfury Protector" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Scaleworm" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Dragonmaw Scorcher" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mossy Horror" },
					new Card { Name = "Astromancer" },
					new Card { Name = "Crowd Roaster" },
					new Card { Name = "Rabble Bouncer" },
					new Card { Name = "Power of Creation" },
					new Card { Name = "Kalecgos" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}
		private static Deck MechHunter()
		{
			return new Deck
			{
				Name = "Mech Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Mecharoo" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Bomb Toss" },
					new Card { Name = "Dire Wolf Alpha" },
					new Card { Name = "Fireworks Tech" },
					new Card { Name = "Galvanizer" },
					new Card { Name = "Venomizer" },
					new Card { Name = "Spider Bomb" },
					new Card { Name = "Unleash the Hounds" },
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
					new Card { Name = "Weapons Project" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Hecklebot" },
					new Card { Name = "Militia Commander" },
					new Card { Name = "Omega Devastator" },
					new Card { Name = "Brawl" },
					new Card { Name = "Darius Crowley" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Archivist Elysiana" },
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

		private static Deck MalygosHunter()
		{
			return new Deck
			{
				Name = "Malygos Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Shot" },
					new Card { Name = "Rapid Fire" },
					new Card { Name = "Secret Plan" },
					new Card { Name = "Bomb Toss" },
					new Card { Name = "Hunter's Mark" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Master's Call" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Marked Shot" },
					new Card { Name = "Baited Arrow" },
					new Card { Name = "Unleash the Beast" },
					new Card { Name = "Vereesa Windrunner" },
					new Card { Name = "Jepetto Joybuzz" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Malygos" },
					new Card { Name = "Zul'jin" },
				}
			};
		}

		private static Deck WallPriest()
		{
			return new Deck
			{
				Name = "Wall Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Forbidden Words" },
					new Card { Name = "Inner Fire" },
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Divine Hymn" },
					new Card { Name = "Divine Spirit" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Hench-Clan Shadequill" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Witchwood Grizzly" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Damaged Stegotron" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mosh'Ogg Enforcer" },
					new Card { Name = "Mass Resurrection" },
				}
			};
		}
		private static Deck ThiefRogue()
		{
			return new Deck
			{
				Name = "Thief Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Pilfer" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Blink Fox" },
					new Card { Name = "Cutthroat Buccaneer" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Face Collector" },
					new Card { Name = "Raiding Party" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Hench-Clan Burglar" },
					new Card { Name = "Spectral Cutlass" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Walk the Plank" },
					new Card { Name = "Captain Greenskin" },
					new Card { Name = "Tess Greymane" },
				}
			};
		}

		private static Deck DragonWarrior()
		{
			return new Deck
			{
				Name = "Dragon Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Omega Assembly" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Dragon Roar" },
					new Card { Name = "Slam" },
					new Card { Name = "Warpath" },
					new Card { Name = "Weapons Project" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Smolderthorn Lancer" },
					new Card { Name = "Omega Devastator" },
					new Card { Name = "Brawl" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Emberscale Drake" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Crowd Roaster" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Archivist Elysiana" },
				}
			};
		}

		private static Deck TurtlePriest()
		{
			return new Deck
			{
				Name = "Turtle Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Circle of Healing" },
					new Card { Name = "Chameleos" },
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Auchenai Phantasm" },
					new Card { Name = "EVIL Conscripter" },
					new Card { Name = "Seance" },
					new Card { Name = "Shadow Word: Pain" },
					new Card { Name = "Madame Lazul" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Thoughtsteal" },
					new Card { Name = "Auchenai Soulpriest" },
					new Card { Name = "Hecklebot" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Holy Fire" },
					new Card { Name = "Unseen Saboteur" },
					new Card { Name = "Archivist Elysiana" },
					new Card { Name = "Mind Control" },
				}
			};
		}

		private static Deck Empty()
		{
			return new Deck
			{
				Name = "",
				Prototype = "AGGRO",
				Tier = 3,
				Rank = 19,
				HeroClass = new Hero(""),
				Cards = new List<Card>
				{
					new Card { Name = "" },

				}
			};
		}
	}
}
