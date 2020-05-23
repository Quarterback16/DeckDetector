using System;
using System.Collections.Generic;

namespace Domain.Metas
{
	public static class AshesOfOutland
	{
		public static Meta LoadMeta()
		{
			var meta = new Meta(
				code: "AO2",
				name: "Ashes of Outland",
				patchNo: 17.3M,
				asOf: new DateTime(2020, 5, 23));
			///
			///  TIER 1
			///  
			var tier1Decks = new List<Deck>
			{
				OutlandHighlanderHunter(),
				MurlocPaladin(),
			};
			meta.AddDecks(tier1Decks, 1);
			///
			///  Tier 2
			/// 
			var tier2Decks = new List<Deck>
			{
				PurePaladin(),
				PirateWarrior(),
				SecretGalakrondRogue(),
				DragonHunter(),
				SpellDruid(),
				HighlanderMage(),
				TempoDemonHunter(),
				FaceHunter(),
				TotemShaman(),
				EmbiggenDruid(),
				SpellMage(),
				GalakrondRogue(),
				BigDruid(),
			};
			meta.AddDecks(tier2Decks, 2);
			///
			///   Tier 3
			///   
			var tier3Decks = new List<Deck>
			{
				ResurrectPriest(),
				EnrageWarrior(),
				GalakrondShaman(),
				GalakrondPriest(),
				LibramPaladin(),
				GalakrondWarlock(),
				//NoMinionMage(),
				//EggWarrior(),
				HighlanderPriest(),
				HighlanderGalaRogue(),
			};
			meta.AddDecks(tier3Decks, 3);
			///
			///   Tier 3
			///   
			var tier4Decks = new List<Deck>
			{
				HighlanderDemonHunter(),
				QuestWarlock(),
				QuestResurrectPriest(),
				HighlanderShaman(),
				GalakrondQuestShaman(),
				GalakrondWarrior(),
				//SmallSpellMage()
			};
			meta.AddDecks(tier4Decks, 4);
			///
			///  The nether regions
			///  
			var tier5Decks = new List<Deck>
			{
				EvolveShaman(),
				BigDemonHandlock(),
				OTKDemonHunter(),
				BigDemonHunter(),
				TokenDruid(),
				Zoolock(),
				QuestPaladin(),
				MurlocDemonHunter(),
				TauntWarrior(),
				NomiDemonHunter(),
				KaelDemonHunter(),
				AggroDemonHunter(),
				OutcastDemonHunter(),
				EvolveGalaShaman(),
				AggroStealthRogue(),
				StealthAggroRogue(),
				BigFistShaman(),
				PhaorisPortalWarlock(),
				ElementalMage(),
				BombWarrior()
			};
			meta.AddDecks(tier5Decks, 5);
			return meta;
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
					new Card { Name = "Activate the Obelisk" },
					new Card { Name = "Reliquary of Souls" },
					new Card { Name = "Renew" },
					new Card { Name = "Penance" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Shadow Word: Ruin" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Skeletal Dragon" },
					new Card { Name = "Soul Mirror" },
					new Card { Name = "Batterhead" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
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
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "EVIL Totem" },
					new Card { Name = "Galakrond the Tempest" },
					new Card { Name = "Mutate" },
					new Card { Name = "Invocation of Frost" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "The Lurker Below" },
					new Card { Name = "Earthquake" },

					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Corrupt Elementalist" },
					new Card { Name = "Kronx Dragonhoof" },

					new Card { Name = "Vulpera Scoundrel" },
					new Card { Name = "Far Sight" },

					new Card { Name = "Sandstorm Elemental" },
					new Card { Name = "Swamqueen Hagatha" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Walking Fountain" },
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
					new Card { Name = "Renew" },
					new Card { Name = "Mo'arg Artificer" },
					new Card { Name = "Penance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Thoughtsteal" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Mindflayer Kaahrj" },
					new Card { Name = "Shadow Madness" },
					new Card { Name = "Vulpera Scoundrel" },
					new Card { Name = "Fate Weaver" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Time Rip" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Unspeakable" },
					new Card { Name = "Soul Mirror" },
					new Card { Name = "Murozond the Infinite" },
					new Card { Name = "Plague of Death" },
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
					new Card { Name = "Bloodsail Flybooter" },
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
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond, the Nightmare" },
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
					new Card { Name = "Wrath" },
					new Card { Name = "Archspore Msshi'fn" },
					new Card { Name = "Bogbeam" },
					new Card { Name = "Overconfident Orc" },
					new Card { Name = "Overgrowth" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Oasis Surger" },
					new Card { Name = "Emerald Explorer" },
					new Card { Name = "Evasive Wyrm" },
					new Card { Name = "Overflow" },
					new Card { Name = "Winged Guardian" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Ysera, Unleashed" },
					new Card { Name = "Scrapyard Colossus" },
				}
			};
		}

		private static Deck PirateWarrior()
		{
			return new Deck
			{
				Name = "Pirate Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Imprisoned Gan'arg" },
					new Card { Name = "Sky Raider" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Upgrade!" },
					new Card { Name = "Bloodsail Raider" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Heroic Strike" },
					new Card { Name = "Parachute Brigand" },
					new Card { Name = "Ancharrr" },
					new Card { Name = "Ironbeak Owl" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "Skybarge" },
					new Card { Name = "Southsea Captain" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Hoard Pillager" },
					new Card { Name = "Kor'kron Elite" },
					new Card { Name = "Mortal Strike" },
					new Card { Name = "Arcanite Reaper" },
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
					new Card { Name = "Tracking" },
					new Card { Name = "Stonetusk Boar" },
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Scavenger's Ingenuity" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Imprisoned Felmaw" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Corrosive Breath" },
					new Card { Name = "Stormhammer" },
					new Card { Name = "Primordial Explorer" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Evasive Feywing" },
					new Card { Name = "Rotnest Drake" },
				}
			};
		}

		private static Deck EnrageWarrior()
		{
			return new Deck
			{
				Name = "Enrage Warrior",
				Prototype = "TEMPO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Inner Rage" },
					new Card { Name = "Risky Skipper" },
					new Card { Name = "Sky Raider" },
					new Card { Name = "Armorsmith" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Injured Tol'vir" },
					new Card { Name = "Rampage" },
					new Card { Name = "Ancharrr" },
					new Card { Name = "Bloodsworn Mercenary" },
					new Card { Name = "Bomb Wrangler" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "Warmaul Challenger" },
					new Card { Name = "Kor'kron Elite" },
					new Card { Name = "Bloodboil Brute" },
					new Card { Name = "Grommash Hellscream" },
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
					new Card { Name = "Blastmaster Boom" },
					new Card { Name = "Dr. Boom Mad Genius" },
				}
			};
		}

		private static Deck EvolveShaman()
		{
			return new Deck
			{
				Name = "Evolve Shaman",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Mutate" },
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Worgen Infiltrator" },
					new Card { Name = "Imprisoned Vilefiend" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Bogstrok Clacker" },
					new Card { Name = "Desert Hare" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Burrowing Scorpid" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Gnomish Inventor" },
					new Card { Name = "Bloodlust" },
					new Card { Name = "Boggspine Knuckles" },
					new Card { Name = "Mad Summoner" },
					new Card { Name = "Mogu Fleshshaper" },
				}
			};
		}

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
					new Card { Name = "Innervate" },
					new Card { Name = "Fungal Fortunes" },
					new Card { Name = "Ironbark" },
					new Card { Name = "Power of the Wild" },
					new Card { Name = "Wrath" },
					new Card { Name = "Bogbeam" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "Overgrowth" },
					new Card { Name = "Soul of the Forest" },
					new Card { Name = "Aeroponics" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Force of Nature" },
					new Card { Name = "Glowfly Swarm" },
					new Card { Name = "Kael'thas Sunstrider" },
					new Card { Name = "Overflow" },
					new Card { Name = "Gift of the Wild" },
					new Card { Name = "The Forest's Aid" },
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
		private static Deck HighlanderDemonHunter()
		{
			return new Deck
			{
				Name = "Highlander Demon Hunter",
				Prototype = "SINGLETON",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Battlefiend" },
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Shadowhoof Slayer" },
					new Card { Name = "Ur'zul Horror" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Furious Felfin" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "Spectral Sight" },
					new Card { Name = "Umberwing" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Coordinated Strike" },
					new Card { Name = "Satyr Overseer" },
					new Card { Name = "Wrathscale Naga" },
					new Card { Name = "Escaped Manasaber" },
					new Card { Name = "Illidari Felblade" },
					new Card { Name = "Kayn Sunfury" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Raging Felscreamer" },
					new Card { Name = "Chaos Nova" },
					new Card { Name = "Command the Illidari" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Glaivebound Adept" },
					new Card { Name = "Imprisoned Antaen" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Skull of Gul'dan" },
					new Card { Name = "Wrathspike Brute" },
					new Card { Name = "Priestess of Fury" },
					new Card { Name = "Siamat" },
					new Card { Name = "Hulking Overfiend" },
					new Card { Name = "Dragonqueen Alexstrasza" },
				}
			};
		}


		private static Deck AggroDemonHunter()
		{
			return new Deck
			{
				Name = "Aggro Demon Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Twin Slice" },
					new Card { Name = "Consume Magic" },
					new Card { Name = "Crimson Sigil Runner" },
					new Card { Name = "Mana Burn" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Blade Dance" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Immolation Aura" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Spectral Sight" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Aldrachi Warblades" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Eye Beam" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Skull of Gul'dan" },
					new Card { Name = "Kael'thas Sunstrider" },
					new Card { Name = "Inner Demon" },
				}
			};
		}
		private static Deck AggroStealthRogue()
		{
			return new Deck
			{
				Name = "Aggro Stealth Rogue",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Spymistress" },
					new Card { Name = "Ashtongue Slayer" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Skyvateer" },
					new Card { Name = "Akama" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Greyheart Sage" },
					new Card { Name = "Hooked Scimitar" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Burrowing Scorpid" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Flik Skyshiv" },
				}
			};
		}
		private static Deck BigDruid()
		{
			return new Deck
			{
				Name = "Big Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Strength in Numbers" },
					new Card { Name = "Breath of Dreams" },
					new Card { Name = "Ironbark" },
					new Card { Name = "Wrath" },
					new Card { Name = "Bogbeam" },
					new Card { Name = "Frizz Kindleroost" },
					new Card { Name = "Overgrowth" },
					new Card { Name = "Swipe" },
					new Card { Name = "Emerald Explorer" },
					new Card { Name = "Evasive Drakonid" },
					new Card { Name = "Exotic Mountseller" },
					new Card { Name = "Winged Guardian" },
					new Card { Name = "Twin Tyrant" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Scrapyard Colossus" },
				}
			};
		}
		private static Deck BigFistShaman()
		{
			return new Deck
			{
				Name = "Big Fist Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Ancestral Healing" },
					new Card { Name = "Mutate" },
					new Card { Name = "Earth Shock" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Ancestral Spirit" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Serpentshrine Portal" },
					new Card { Name = "Hex" },
					new Card { Name = "The Fist of Ra-den" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Muckmorpher" },
					new Card { Name = "Kael'thas Sunstrider" },
					new Card { Name = "Earthquake" },
					new Card { Name = "Walking Fountain" },
					new Card { Name = "Eye of the Storm" },
					new Card { Name = "Scrapyard Colossus" },
				}
			};
		}
		private static Deck DragonTauntHunter()
		{
			return new Deck
			{
				Name = "Dragon Taunt Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Guardian Augmerchant" },
					new Card { Name = "Tracking" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Bonechewer Brawler" },
					new Card { Name = "Corrosive Breath" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Overconfident Orc" },
					new Card { Name = "Primordial Explorer" },
					new Card { Name = "Scalerider" },
					new Card { Name = "Stormhammer" },
					new Card { Name = "Dragonbane" },
					new Card { Name = "Evasive Feywing" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Rotnest Drake" },
				}
			};
		}
		private static Deck GalakrondShaman()
		{
			return new Deck
			{
				Name = "Galakrond Shaman",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Storm's Wrath" },
					new Card { Name = "Surging Tempest" },
					new Card { Name = "Invocation of Frost" },
					new Card { Name = "Sandstorm Elemental" },
					new Card { Name = "Desert Hare" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Marshspawn" },
					new Card { Name = "Serpentshrine Portal" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Hex" },
					new Card { Name = "Boggspine Knuckles" },
					new Card { Name = "Dragon's Pack" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Corrupt Elementalist" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Tempest" },
				}
			};
		}
		private static Deck GalakrondWarlock()
		{
			return new Deck
			{
				Name = "Galakrond Warlock",
				Prototype = "MIDRANGE",
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
					new Card { Name = "Bad Luck Albatross" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Dragonblight Cultist" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Fiendish Rites" },
					new Card { Name = "Veiled Worshipper" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Wretched" },
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
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Inner Rage" },
					new Card { Name = "Risky Skipper" },
					new Card { Name = "Armorsmith" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Ritual Chopper" },
					new Card { Name = "Ancharrr" },
					new Card { Name = "Awaken!" },
					new Card { Name = "Bloodsworn Mercenary" },
					new Card { Name = "Bomb Wrangler" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Kor'kron Elite" },
					new Card { Name = "Scion of Ruin" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Bloodboil Brute" },
					new Card { Name = "Galakrond the Unbreakable" },
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
					new Card { Name = "Unstable Felbolt" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Mo'arg Artificer" },
					new Card { Name = "Nether Breath" },
					new Card { Name = "Plot Twist" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Sense Demons" },
					new Card { Name = "Frizz Kindleroost" },
					new Card { Name = "Crazed Netherwing" },
					new Card { Name = "Aranasi Broodmother" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Malygos" },
				}
			};
		}

		private static Deck HighlanderGalaRogue()
		{
			return new Deck
			{
				Name = "Highlander Galakrond Rogue",
				Prototype = "SINGLETON",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Praise Galakrond!" },
					new Card { Name = "Spymistress" },
					new Card { Name = "Ashtongue Slayer" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Skyvateer" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Akama" },
					new Card { Name = "Bad Luck Albatross" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Greyheart Sage" },
					new Card { Name = "Seal Fate" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Burrowing Scorpid" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Escaped Manasaber" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Boompistol Bully" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Nightmare" },
					new Card { Name = "Siamat" },
					new Card { Name = "Dragonqueen Alexstrasza" },
				}
			};
		}
		private static Deck KaelDemonHunter()
		{
			return new Deck
			{
				Name = "Kael Demon Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Twin Slice" },
					new Card { Name = "Consume Magic" },
					new Card { Name = "Crimson Sigil Runner" },
					new Card { Name = "Mana Burn" },
					new Card { Name = "Blade Dance" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Spectral Sight" },
					new Card { Name = "Umberwing" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Aldrachi Warblades" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Eye Beam" },
					new Card { Name = "Kayn Sunfury" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Skull of Gul'dan" },
					new Card { Name = "Kael'thas Sunstrider" },
					new Card { Name = "Inner Demon" },
				}
			};
		}
		private static Deck NomiDemonHunter()
		{
			return new Deck
			{
				Name = "Nomi Demon Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Battlefiend" },
					new Card { Name = "Consume Magic" },
					new Card { Name = "Crimson Sigil Runner" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Feast of Souls" },
					new Card { Name = "Immolation Aura" },
					new Card { Name = "Spectral Sight" },
					new Card { Name = "Aldrachi Warblades" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Coordinated Strike" },
					new Card { Name = "Satyr Overseer" },
					new Card { Name = "Wrathscale Naga" },
					new Card { Name = "Illidari Felblade" },
					new Card { Name = "Command the Illidari" },
					new Card { Name = "Skull of Gul'dan" },
					new Card { Name = "Chef Nomi" },
				}
			};
		}
		private static Deck OutcastDemonHunter()
		{
			return new Deck
			{
				Name = "Outcast Demon Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Twin Slice" },
					new Card { Name = "Battlefiend" },
					new Card { Name = "Crimson Sigil Runner" },
					new Card { Name = "Blade Dance" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Furious Felfin" },
					new Card { Name = "Umberwing" },
					new Card { Name = "Aldrachi Warblades" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Eye Beam" },
					new Card { Name = "Kayn Sunfury" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Glaivebound Adept" },
					new Card { Name = "Imprisoned Antaen" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Skull of Gul'dan" },
					new Card { Name = "Priestess of Fury" },
				}
			};
		}
		private static Deck PhaorisPortalWarlock()
		{
			return new Deck
			{
				Name = "Phaoris Portal Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Rain of Fire" },
					new Card { Name = "Shadow Council" },
					new Card { Name = "Sinister Deal" },
					new Card { Name = "Unstable Felbolt" },
					new Card { Name = "Plot Twist" },
					new Card { Name = "Twisted Knowledge" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Shadow Bolt" },
					new Card { Name = "Hellfire" },
					new Card { Name = "The Dark Portal" },
					new Card { Name = "Bane of Doom" },
					new Card { Name = "Hand of Gul'dan" },
					new Card { Name = "Siphon Soul" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "King Phaoris" },
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
					new Card { Name = "Air Raid" },
					new Card { Name = "Aldor Attendant" },
					new Card { Name = "Hand of A'dal" },
					new Card { Name = "Libram of Wisdom" },
					new Card { Name = "Lightforged Blessing" },
					new Card { Name = "Murgur Murgurgle" },
					new Card { Name = "Sanctuary" },
					new Card { Name = "Subdue" },
					new Card { Name = "Aldor Peacekeeper" },
					new Card { Name = "Consecration" },
					new Card { Name = "Lightforged Zealot" },
					new Card { Name = "Aldor Truthseeker" },
					new Card { Name = "Amber Watcher" },
					new Card { Name = "Libram of Justice" },
					new Card { Name = "Pharaoh's Blessing" },
					new Card { Name = "Lady Liadrin" },
					new Card { Name = "Lightforged Crusader" },
					new Card { Name = "Tirion Fordring" },
					new Card { Name = "Libram of Hope" },
				}
			};
		}
		#endregion

		#region Decks
		private static Deck Zoolock()
		{
			return new Deck
			{
				Name = "Zoolock",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Argent Squire" },
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Fiendish Servant" },
					new Card { Name = "Flame Imp" },
					new Card { Name = "Guardian Augmerchant" },
					new Card { Name = "Soulfire" },
					new Card { Name = "Stonetusk Boar" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "Expired Merchant" },
					new Card { Name = "Imprisoned Scrap Imp" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Magic Carpet" },
					new Card { Name = "Frenzied Felwing" },
					new Card { Name = "Nightshade Matron" },
					new Card { Name = "Hand of Gul'dan" },
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
					new Card { Name = "Elven Archer" },
					new Card { Name = "Leper Gnome" },
					new Card { Name = "Rapid Fire" },
					new Card { Name = "Stonetusk Boar" },
					new Card { Name = "Toxic Reinforcements" },
					new Card { Name = "Tracking" },
					new Card { Name = "Corrosive Breath" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Hunter's Mark" },
					new Card { Name = "Kobold Sandtrooper" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Scavenger's Ingenuity" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Primordial Explorer" },
				}
			};
		}
		private static Deck SpellMage()
		{
			return new Deck
			{
				Name = "Spell Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Evocation" },
					new Card { Name = "Font of Power" },
					new Card { Name = "Learn Draconic" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Ancient Mysteries" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Incanter's Flow" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Flame Ward" },
					new Card { Name = "Ice Barrier" },
					new Card { Name = "Netherwind Portal" },
					new Card { Name = "Fireball" },
					new Card { Name = "Apexis Blast" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Deep Freeze" },
					new Card { Name = "Power of Creation" },
					new Card { Name = "The Amazing Reno" },
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
					new Card { Name = "Renew" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Penance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Bad Luck Albatross" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Grave Rune" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Shadow Word: Ruin" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Skeletal Dragon" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
				}
			};
		}
		private static Deck BigDemonHunter()
		{
			return new Deck
			{
				Name = "Big Demon Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Twin Slice" },
					new Card { Name = "Blade Dance" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Overconfident Orc" },
					new Card { Name = "Umberwing" },
					new Card { Name = "Aldrachi Warblades" },
					new Card { Name = "Ashtongue Battlelord" },
					new Card { Name = "Kayn Sunfury" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Raging Felscreamer" },
					new Card { Name = "Wrathspike Brute" },
					new Card { Name = "Fel Summoner" },
					new Card { Name = "Imprisoned Antaen" },
					new Card { Name = "Priestess of Fury" },
					new Card { Name = "Coilfang Warlord" },
					new Card { Name = "Hulking Overfiend" },
					new Card { Name = "Pit Commander" },
				}
			};
		}
		private static Deck EvolveGalaShaman()
		{
			return new Deck
			{
				Name = "Evolve Gala Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Mutate" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "EVIL Totem" },
					new Card { Name = "Invocation of Frost" },
					new Card { Name = "Bogstrok Clacker" },
					new Card { Name = "Desert Hare" },
					new Card { Name = "Serpentshrine Portal" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Boggspine Knuckles" },
					new Card { Name = "Dragon's Pack" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Corrupt Elementalist" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Tempest" },
					new Card { Name = "Mogu Fleshshaper" },
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
					new Card { Name = "Imprisoned Homunculus" },
					new Card { Name = "Reliquary of Souls" },
					new Card { Name = "Dragonmaw Sentinel" },
					new Card { Name = "Sethekk Vielwever" },
					new Card { Name = "Disciple of Galakrond" },
					new Card { Name = "Renew" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "EVIL Conscripter" },
					new Card { Name = "Kul Tiran Chaplain" },
					new Card { Name = "Penance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Shadow Word: Pain" },
					new Card { Name = "Shadow Word: Ruin" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Big Ol'Whelp" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Shadowy Figure" },
					new Card { Name = "Thoughtsteal" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Apotheosis" },
					new Card { Name = "Madame Lazul" },
					new Card { Name = "Mindflayer Kaahrj" },
					new Card { Name = "Bad Luck Albatross" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Shadow Madness" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Power Infusion" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Chronobreaker" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Psyche Split" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Time Rip" },
					new Card { Name = "Aeon Reaver" },
					new Card { Name = "Galakrond the Unspeakable" },
					new Card { Name = "Soul Mirror" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Plague of Death" },
				}
			};
		}
		private static Deck HighlanderShaman()
		{
			return new Deck
			{
				Name = "Highlander Shaman",
				Prototype = "SINGLETON",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Earth Shock" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Surging Tempest" },
					new Card { Name = "Sandstorm Elemental" },
					new Card { Name = "Witch's Brew" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Frozen Shadoweaver" },
					new Card { Name = "Lady Vashj" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Mana Tide Totem" },
					new Card { Name = "Marshspawn" },
					new Card { Name = "Plague of Murlocs" },
					new Card { Name = "Serpentshrine Portal" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Escaped Manasaber" },
					new Card { Name = "Hex" },
					new Card { Name = "The Fist of Ra-den" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Hagatha's Scheme" },
					new Card { Name = "Shattered Rumbler" },
					new Card { Name = "Torrent" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Earthquake" },
					new Card { Name = "Siamat" },
					new Card { Name = "Walking Fountain" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Ysera" },
					new Card { Name = "Eye of the Storm" },
					new Card { Name = "King Phaoris" },
				}
			};
		}
		private static Deck OTKDemonHunter()
		{
			return new Deck
			{
				Name = "OTK Demon Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Twin Slice" },
					new Card { Name = "Consume Magic" },
					new Card { Name = "Crimson Sigil Runner" },
					new Card { Name = "Mana Burn" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Immolation Aura" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Spectral Sight" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Aldrachi Warblades" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Eye Beam" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Kael'thas Sunstrider" },
					new Card { Name = "Skull of Gul'dan" },
					new Card { Name = "Inner Demon" },
				}
			};
		}
		private static Deck OutlandHighlanderHunter()
		{
			return new Deck
			{
				Name = "Outland Highlander Hunter",
				Prototype = "SINGLETON",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Blazing Battlemage" },
					new Card { Name = "Dwarven Sharpshooter" },
					new Card { Name = "Guardian Augmerchant" },
					new Card { Name = "Tracking" },
					new Card { Name = "Bonechewer Brawler" },
					new Card { Name = "Corrosive Breath" },
					new Card { Name = "Faerie Dragon" },
					new Card { Name = "Scavenger's Ingenuity" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Desert Spear" },
					new Card { Name = "Diving Gryphon" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Overconfident Orc" },
					new Card { Name = "Primordial Explorer" },
					new Card { Name = "Stormhammer" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Zixor, Apex Predator" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Dragonbane" },
					new Card { Name = "Evasive Feywing" },
					new Card { Name = "Frenzied Felwing" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Big Ol' Whelp" },
					new Card { Name = "Rotnest Drake" },
					new Card { Name = "Veranus" },
					new Card { Name = "Dinotamer Brann" },
					new Card { Name = "Siamat" },
					new Card { Name = "Dragonqueen Alexstrasza" },
					new Card { Name = "Nagrand Slam" },
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
					new Card { Name = "Reliquary of Souls" },
					new Card { Name = "Renew" },
					new Card { Name = "Penance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Grave Rune" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Psychopomp" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Psyche Split" },
					new Card { Name = "Sandhoof Waterbearer" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Skeletal Dragon" },
					new Card { Name = "Soul Mirror" },
					new Card { Name = "Batterhead" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
				}
			};
		}
		private static Deck SecretGalakrondRogue()
		{
			return new Deck
			{
				Name = "Secret Galakrond Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Praise Galakrond!" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Blackjack Stunner" },
					new Card { Name = "Shadowjeweler Hanar" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Dirty Tricks" },
					new Card { Name = "Bamboozle" },
					new Card { Name = "Ambush" },
					new Card { Name = "Seal Fate" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Galakrond, the Nightmare" },
				}
			};
		}

		private static Deck SecretRogue()
		{
			return new Deck
			{
				Name = "Secret Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Blackjack Stunner" },
					new Card { Name = "Dragon's Hoard" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Praise Galakrond!" },
					new Card { Name = "Spymistress" },
					new Card { Name = "Ambush" },
					new Card { Name = "Bamboozle" },
					new Card { Name = "Dirty Tricks" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Shadowjeweler Hanar" },
					new Card { Name = "Underbelly Fence" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Akama" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Seal Fate" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Vendetta" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Nightmare" },
					new Card { Name = "Siamat" },
					new Card { Name = "Dragonqueen Alexstrasza" },
				}
			};
		}
		private static Deck SpellDruid()
		{
			return new Deck
			{
				Name = "Spell Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Crystal Power" },
					new Card { Name = "Fungal Fortunes" },
					new Card { Name = "Ironbark" },
					new Card { Name = "Power of the Wild" },
					new Card { Name = "Rising Winds" },
					new Card { Name = "Wrath" },
					new Card { Name = "Bogbeam" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "Overgrowth" },
					new Card { Name = "Soul of the Forest" },
					new Card { Name = "Glowfly Swarm" },
					new Card { Name = "Kael'thas Sunstrider" },
					new Card { Name = "Exotic Mountseller" },
					new Card { Name = "Overflow" },
					new Card { Name = "The Forest's Aid" },
				}
			};
		}
		private static Deck StealthAggroRogue()
		{
			return new Deck
			{
				Name = "Stealth Aggro Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Spymistress" },
					new Card { Name = "Worgen Infiltrator" },
					new Card { Name = "Ashtongue Slayer" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Skyvateer" },
					new Card { Name = "Akama" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Greyheart Sage" },
					new Card { Name = "Hench-Clan Sneak" },
					new Card { Name = "Hooked Scimitar" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Frenzied Felwing" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Waggle Pick" },
					new Card { Name = "Captain Greenskin" },
				}
			};
		}
		private static Deck StealthGalaRogue()
		{
			return new Deck
			{
				Name = "Stealth Gala Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Praise Galakrond!" },
					new Card { Name = "Spymistress" },
					new Card { Name = "Skyvateer" },
					new Card { Name = "Akama" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Greyheart Sage" },
					new Card { Name = "Seal Fate" },
					new Card { Name = "Devoted Maniac" },
					new Card { Name = "Escaped Manasaber" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Shield of Galakrond" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Kronx Dragonhoof" },
					new Card { Name = "Galakrond the Nightmare" },
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
					new Card { Name = "Totemic Might" },
					new Card { Name = "Totemic Surge" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Storm's Wrath" },
					new Card { Name = "Surging Tempest" },
					new Card { Name = "EVIL Totem" },
					new Card { Name = "Sandstorm Elemental" },
					new Card { Name = "Flametongue Totem" },
					new Card { Name = "Lava Burst" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Mana Tide Totem" },
					new Card { Name = "Marshspawn" },
					new Card { Name = "Serpentshrine Portal" },
					new Card { Name = "Totemic Reflection" },
					new Card { Name = "Unbound Elemental" },
					new Card { Name = "Splitting Axe" },
					new Card { Name = "Vessina" },
				}
			};
		}
		#endregion

#region Decks
		private static Deck BigDemonHandlock()
		{
			return new Deck
			{
				Name = "Big Demon Handlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Sacrificial Pact" },
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Supreme Archaeology" },
					new Card { Name = "Kanrethad Ebonlocke" },
					new Card { Name = "Plot Twist" },
					new Card { Name = "Twisted Knowledge" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Shadow Bolt" },
					new Card { Name = "Hellfire" },
					new Card { Name = "The Dark Portal" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Abyssal Summoner" },
					new Card { Name = "Aranasi Broodmother" },
					new Card { Name = "Keli'dan the Breaker" },
					new Card { Name = "Arch-Villain Rafaam" },
					new Card { Name = "Valdris Felgorge" },
					new Card { Name = "Enhanced Dreadlord" },
					new Card { Name = "Fel Lord Betrug" },
				}
			};
		}
		private static Deck LibramPaladin()
		{
			return new Deck
			{
				Name = "Libram Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Air Raid" },
					new Card { Name = "Aldor Attendant" },
					new Card { Name = "Hand of A'dal" },
					new Card { Name = "Libram of Wisdom" },
					new Card { Name = "Lightforged Blessing" },
					new Card { Name = "Murgur Murgurgle" },
					new Card { Name = "Shotbot" },
					new Card { Name = "Aldor Peacekeeper" },
					new Card { Name = "Bronze Explorer" },
					new Card { Name = "Underlight Angling Rod" },
					new Card { Name = "Consecration" },
					new Card { Name = "Lightforged Zealot" },
					new Card { Name = "Aldor Truthseeker" },
					new Card { Name = "Amber Watcher" },
					new Card { Name = "Libram of Justice" },
					new Card { Name = "Lady Liadrin" },
					new Card { Name = "Lightforged Crusader" },
					new Card { Name = "Libram of Hope" },
				}
			};
		}
		private static Deck MurlocDemonHunter()
		{
			return new Deck
			{
				Name = "Murloc Demon Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Twin Slice" },
					new Card { Name = "Grimscale Oracle" },
					new Card { Name = "Murloc Tidecaller" },
					new Card { Name = "Murmy" },
					new Card { Name = "Toxfin" },
					new Card { Name = "Bluegill Warrior" },
					new Card { Name = "Fishflinger" },
					new Card { Name = "Furious Felfin" },
					new Card { Name = "Hench-Clan Hogsteed" },
					new Card { Name = "Murloc Tidehunter" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Coldlight Seer" },
					new Card { Name = "Murloc Warleader" },
					new Card { Name = "Felfin Navigator" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Skull of Gul'dan" },
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
					new Card { Name = "Blessing of Wisdom" },
					new Card { Name = "Making Mummies" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Lightforged Blessing" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Micro Mummy" },
					new Card { Name = "Murgur Murgurgle" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Shotbot" },
					new Card { Name = "Temple Berserker" },
					new Card { Name = "Candletaker" },
					new Card { Name = "Salhet's Pride" },
					new Card { Name = "Teron Gorefiend" },
					new Card { Name = "Ancestral Guardian" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Consecration" },
					new Card { Name = "Al'ar" },
					new Card { Name = "Chromatic Egg" },
					new Card { Name = "Khartut Defender" },
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
					new Card { Name = "Imprisoned Gan'arg" },
					new Card { Name = "Into the Fray" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Bladestorm" },
					new Card { Name = "Infested Goblin" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "Overconfident Orc" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Hippogryph" },
					new Card { Name = "Ruststeed Raider" },
					new Card { Name = "Scrap Golem" },
					new Card { Name = "Armagedillo" },
					new Card { Name = "Evasive Drakonid" },
					new Card { Name = "Deathwing Mad Aspect" },
					new Card { Name = "Grommash Hellscream" },
					new Card { Name = "Tomb Warden" },
				}
			};
		}
		private static Deck TempoDemonHunter()
		{
			return new Deck
			{
				Name = "Tempo Demon Hunter",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Twin Slice" },
					new Card { Name = "Battlefiend" },
					new Card { Name = "Crimson Sigil Runner" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Sightless Watcher" },
					new Card { Name = "Spectral Sight" },
					new Card { Name = "Umberwing" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Eye Beam" },
					new Card { Name = "Frozen Shadoweaver" },
					new Card { Name = "Satyr Overseer" },
					new Card { Name = "Frenzied Felwing" },
					new Card { Name = "Kayn Sunfury" },
					new Card { Name = "Glaivebound Adept" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Warglaives of Azzinoth" },
					new Card { Name = "Skull of Gul'dan" },
				}
			};
		}
		#endregion



	}
}
