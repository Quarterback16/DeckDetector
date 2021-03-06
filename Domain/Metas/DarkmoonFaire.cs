﻿using System;
using System.Collections.Generic;

namespace Domain.Metas
{
	public static class DarkmoonFaire
	{
		public static Meta LoadMeta()
		{
			//  Use *_Diamond_* HSR list (my league)
			//  Focus on T1 and T2 decks

			var meta = new Meta(
				code: "DF",
				name: "Darkmoon Faire",
				patchNo: 19.2M,
				asOf: new DateTime(2021, 01, 22));

			var tier1Decks = new List<Deck>
			{
				RampPaladin(),
				HighlanderHunter(),  
				TreantDruid(),
			};
			meta.AddDecks(
				tier1Decks,
				tier: 1);
			///  Tier 2
			var tier2Decks = new List<Deck>
			{
				PurePaladin(),
				WeaponRogue(),
				ZooWarlock(), 
				EtcOtkWarrior(),
				StealthRogue(),
				MozakiOTKMage(),
				SecretMage(),
				BroomPaladin(), 
				DuelPaladin(),
				MurlocPaladin(),
				WhirlkickRogue(),
				EnrageWarrior(),
				AggroShaman(),
				AggroDemonHunter(), 
				BigWarrior(),
				FaceHunter(), 
				TotemShaman(),
				GuardianDruid(), 
				SoulDemonHunter(),
				BombWarrior(),
				GibberlingDruid(),              
				EvolveShaman(),
				HighlanderMage(),  
			};
			meta.AddDecks(
				tier2Decks,
				tier: 2);

			var tier3Decks = new List<Deck>
			{
				FelDemonHunter(),
				SecretRogue(), 
				BigPriest(),
				SpellDruid(),
				LifestealDemonHunter(),
				ClownDruid(),
				ControlWarlock(),
			};
				meta.AddDecks(
					tier3Decks,
					tier: 3);
				///   Tier 4
				var tier4Decks = new List<Deck>
			{
				HighlanderPriest(),  
				SmallSpellMage(), 
				GalakrondWarlock(),   
				NoMinionMage(),
				QuestControlWarlock(),
			};
			meta.AddDecks(tier4Decks, 4);

			///  The nether regions
			var tier5Decks = new List<Deck>
			{
				FenoQuestWarlock(),
				GalakrondRogue(),
				PirateWarrior(),
				CThunRogue(),
				ElementalMage(),
				ControlPriest(),
				MalygosDruid(),
				QuestShaman(),
				SecretFaceHunter(),
				EnhancementShaman(),
				SilverHandPaladin(),
				AggroRogue(),
				MenagerieWarrior(),
				ControlWarrior(),
				DeathrattleHunter(),
				LibramPaladin(),
				VargothOTKMage(),
				ResurrectPriest(),
				TokenDemonHunter(),
				QuestResurrectPriest(),
				ControlDemonHunter(),
				DragonHunter(),
				BigWarrior(),
				QuestWarlock(),
				HighlanderDemonHunter(),
				SpellDamageShaman(),
				TortollanMage(),
				StowawayRogue(),
				BigDruid(),
				HighlanderRogue(),
				ControlShaman(),
				MurlocPaladin(),
				GalakrondShaman(),
				GalakrondPriest(),
				QuestDruid(),
				QuestRogue(),
				AggroShaman(),
				MiracleRogue(),
				ControlPaladin(),
				HighlanderWarrior(),
				BeastHunter()
			};
			meta.AddDecks(tier5Decks, 5);
			return meta;
		}

		#region Decks

		private static Deck MozakiOTKMage()
		{
			var deck = new Deck
			{
				Name = "Mozaki OTK Mage",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Mirror Image" },
					new Card { Name = "Magic Trick" },
					new Card { Name = "Devolving Missiles" },
					new Card { Name = "Brain Freeze" },
					new Card { Name = "Arcane Missiles" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Incanter's Flow" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Evocation" },
					new Card { Name = "Cram Session" },
					new Card { Name = "Conjure Mana Biscuit" },
					new Card { Name = "Arcane Explosion" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Mozaki, Master Duelist" },
					new Card { Name = "Gadgetzan Auctioneer" },
				}
			};
			return deck;
		}
		private static Deck FenoQuestWarlock()
		{
			var deck = new Deck
			{
				Name = "Feno Quest Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Demonic Studies" },
					new Card { Name = "Felosophy" },
					new Card { Name = "Spirit Jailer" },
					new Card { Name = "Supreme Archaeology" },
					new Card { Name = "Midway Maniac" },
					new Card { Name = "Plot Twist" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Free Admission" },
					new Card { Name = "Hysteria" },
					new Card { Name = "Man'ari Mosher" },
					new Card { Name = "School Spirits" },
					new Card { Name = "Cascading Disaster" },
					new Card { Name = "Fire Breather" },
					new Card { Name = "Envoy Rustwix" },
					new Card { Name = "Aranasi Broodmother" },
					new Card { Name = "Tickatus" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "C'Thun, the Shattered" },
				}
			};
			return deck;
		}
		private static Deck QuestControlWarlock()
		{
			var deck = new Deck
			{
				Name = "Quest Control Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Armor Vendor" },
					new Card { Name = "Felosophy" },
					new Card { Name = "Mortal Coil" },
					new Card { Name = "Plague of Flames" },
					new Card { Name = "Supreme Archaeology" },
					new Card { Name = "Tour Guide" },
					new Card { Name = "Unstable Felbolt" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Kanrethad Ebonlocke" },
					new Card { Name = "Plot Twist" },
					new Card { Name = "Questing Explorer" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Hysteria" },
					new Card { Name = "Sense Demons" },
					new Card { Name = "Sky Gen'ral Kragg" },
					new Card { Name = "Envoy Rustwix" },
					new Card { Name = "Vectus" },
					new Card { Name = "Aranasi Broodmother" },
					new Card { Name = "Keli'dan the Breaker" },
					new Card { Name = "Khartut Defender" },
				}
			};
			return deck;
		}
		private static Deck FelDemonHunter()
		{
			var deck = new Deck
			{
				Name = "Fel Demon Hunter",
				Prototype = "MIDRANGE",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Illidari Studies" },
					new Card { Name = "Pen Flinger" },
					new Card { Name = "Twin Slice" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Felfire Deadeye" },  //  mini set
					new Card { Name = "Manafeeder Panthara" },
					new Card { Name = "Wandmaker" },
					new Card { Name = "Aldrachi Warblades" },
					new Card { Name = "Blade Dance" },
					new Card { Name = "Felsteel Executioner" },
					new Card { Name = "Relentless Pursuit" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Felsaber" },
					new Card { Name = "Il'gynoth" },
					new Card { Name = "Kayn Sunfury" },
					new Card { Name = "Bladed Lady" },
					new Card { Name = "Skull of Gul'dan" },
				}
			};
			return deck;
		}
		private static Deck SpellDruid()
		{
			var deck = new Deck
			{
				Name = "Spell Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Adorable Infestation" },
					new Card { Name = "Nature Studies" },
					new Card { Name = "Treenforcements" },
					new Card { Name = "Dreamway Guardians" },
					new Card { Name = "Power of the Wild" },
					new Card { Name = "Rising Winds" },
					new Card { Name = "Solar Eclipse" },
					new Card { Name = "BEEEES!!!" },
					new Card { Name = "Blessing of the Ancients" },
					new Card { Name = "Fungal Fortunes" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "Soul of the Forest" },
					new Card { Name = "Arbor Up" },  // mini-set
					new Card { Name = "Glowfly Swarm" },
				}
			};
			return deck;
		}
		private static Deck HighlanderWarrior()
		{
			var deck = new Deck
			{
				Name = "Highlander Warrior",
				Prototype = "SINGLETON",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Athletic Studies" },
					new Card { Name = "Risky Skipper" },
					new Card { Name = "Sky Raider" },
					new Card { Name = "Sword and Board" },
					new Card { Name = "Armorsmith" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "Bumper Car" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Frightened Flunky" },
					new Card { Name = "Minefield" },
					new Card { Name = "Slam" },
					new Card { Name = "Zephrys the Great" },
					new Card { Name = "Bladestorm" },
					new Card { Name = "Bomb Wrangler" },
					new Card { Name = "Bulwark of Azzinoth" },
					new Card { Name = "Coerce" },
					new Card { Name = "EVIL Quartermaster" },
					new Card { Name = "Livewire Lance" },
					new Card { Name = "Lord Barov" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Kargath Bladefist" },
					new Card { Name = "Reaper's Scythe" },
					new Card { Name = "Restless Mummy" },
					new Card { Name = "Sword Eater" },
					new Card { Name = "Brawl" },
					new Card { Name = "Kobold Stickyfinger" },
					new Card { Name = "Plague of Wrath" },
					new Card { Name = "Deathwing, Mad Aspect" },
					new Card { Name = "Troublemaker" },
					new Card { Name = "Dragonqueen Alexstrasza" },
				}
			};
			return deck;
		}
		private static Deck ControlPaladin()
		{
			var deck = new Deck
			{
				Name = "Control Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "First Day of School" },
					new Card { Name = "Aldor Attendant" },
					new Card { Name = "Hand of A'dal" },
					new Card { Name = "Libram of Wisdom" },
					new Card { Name = "Lightforged Blessing" },
					new Card { Name = "Murgur Murgurgle" },
					new Card { Name = "Redscale Dragontamer" },
					new Card { Name = "Snack Run" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Bronze Explorer" },
					new Card { Name = "Lord Barov" },
					new Card { Name = "Underlight Angling Rod" },
					new Card { Name = "Consecration" },
					new Card { Name = "Aldor Truthseeker" },
					new Card { Name = "Cobalt Spellkin" },
					new Card { Name = "Libram of Justice" },
					new Card { Name = "Lady Liadrin" },
					new Card { Name = "Libram of Hope" },
					new Card { Name = "Yogg-Saron, Master of Fate" },
				}
			};
			return deck;
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

		private static Deck RampPaladin()
		{
			var deck = new Deck
			{
				Name = "Ramp Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Animated Broomstick" },
					new Card { Name = "Armor Vendor" },
					new Card { Name = "Sphere of Sapience" },
					new Card { Name = "Crabrider" },
					new Card { Name = "Murgur Murgurgle" },
					new Card { Name = "Redscale Dragontamer" },
					new Card { Name = "Wandmaker" },
					new Card { Name = "Lord Barov" },
					new Card { Name = "Murloc Warleader" },
					new Card { Name = "Underlight Angling Rod" },
					new Card { Name = "Circus Amalgam" },
					new Card { Name = "Fishy Flyer" },
					new Card { Name = "High Abbess Alura" },
					new Card { Name = "Nozdormu the Timeless" },
					new Card { Name = "Tip the Scales" },
					new Card { Name = "Carnival Clown" },
					new Card { Name = "Darkmoon Rabbit" },
					new Card { Name = "N'Zoth, God of the Deep" },
					new Card { Name = "Scrapyard Colossus" },
					new Card { Name = "Y'Shaarj, the Defiler" },
				}
			};
			return deck;
		}

		private static Deck MiracleRogue()
		{
			return new Deck
			{
				Name = "Miracle Rogue",
				Tier = 3,
				Prototype = "COMBO",
				Rank = 20,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Counterfeit Coin" },
					new Card { Name = "Preparation" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Shiv" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "Fan of Knives" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Elven Minstrel" },
					new Card { Name = "Fal'dorei Strider" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Vilespine Slayer" },
					new Card { Name = "Gadgetzan Auctioneer" },
				}
			};
		}

		private static Deck DuelPaladin()
		{
			var deck = new Deck
			{
				Name = "Duel Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "First Day of School" },
					new Card { Name = "Desperate Measures" },
					new Card { Name = "Air Raid" },
					new Card { Name = "Hand of A'dal" },
					new Card { Name = "Sanctuary" },
					new Card { Name = "Snack Run" },
					new Card { Name = "Subdue" },
					new Card { Name = "Ceremonial Maul" },
					new Card { Name = "Underlight Angling Rod" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Consecration" },
					new Card { Name = "Duel!" },
					new Card { Name = "Avenging Wrath" },
					new Card { Name = "Commencement" },
					new Card { Name = "Plagued Protodrake" },
					new Card { Name = "Tirion Fordring" },
					new Card { Name = "Colossus of the Moon" },
					new Card { Name = "Scrapyard Colossus" },
				}
			};
			return deck;
		}
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
				new Card { Name = "Font of Power" },
				new Card { Name = "Learn Draconic" },
				new Card { Name = "Magic Trick" },
				new Card { Name = "Ray of Frost" },
				new Card { Name = "Ancient Mysteries" },
				new Card { Name = "Deck of Lunacy" }, // new
				new Card { Name = "Frostbolt" },
				new Card { Name = "Incanter's Flow" },
				new Card { Name = "Arcane Intellect" },
				new Card { Name = "Flame Ward" },
				new Card { Name = "Netherwind Portal" },
				new Card { Name = "Fireball" },
				new Card { Name = "Apexis Blast" },
				new Card { Name = "Rolling Fireball" }, // new
				new Card { Name = "Blizzard" },
				new Card { Name = "Power of Creation" },
				new Card { Name = "Rigged Faire Game" }, // new

				//new Card { Name = "Deep Freeze" },
				//new Card { Name = "Evocation" },
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
				new Card { Name = "Risky Skipper" },
				new Card { Name = "Shield Slam" },
				new Card { Name = "Armorsmith" },
				new Card { Name = "Battle Rage" },
				new Card { Name = "Minefield" }, // new
				new Card { Name = "Ancharrr" },
				new Card { Name = "Bladestorm" },
				new Card { Name = "Bloodsworn Mercenary" },
				new Card { Name = "EVIL Quartermaster" },
				new Card { Name = "Lord Barov" },
				new Card { Name = "Shield Block" },
				new Card { Name = "Brawl" },
				new Card { Name = "Deathwing, Mad Aspect" },
				new Card { Name = "C'Thun, the Shattered" }, // new
				new Card { Name = "Corsair Cache" },
				new Card { Name = "Zephrys the Great" }, // new
				new Card { Name = "Bulwark of Azzinoth" }, // new
				new Card { Name = "Coerce" },
				new Card { Name = "Kargath Bladefist" },
				new Card { Name = "Rattlegore" },
				new Card { Name = "Sword Eater" }, // new

				//new Card { Name = "Athletic Studies" },
				//new Card { Name = "Sky Raider" },
				//new Card { Name = "Frightened Flunky" },
				//new Card { Name = "Livewire Lance" },
				//new Card { Name = "Armored Goon" },
				//new Card { Name = "Troublemaker" },
				//new Card { Name = "Kobold Stickyfinger" },
				//new Card { Name = "Plague of Wrath" },
				//new Card { Name = "Bloodboil Brute" },
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
				new Card { Name = "Corrupt the Waters" },
				new Card { Name = "Lightning Bloom" },
				new Card { Name = "Tour Guide" },
				new Card { Name = "EVIL Cable Rat" },
				new Card { Name = "Manafeeder Panthara" },
				new Card { Name = "Novice Engineer" },
				new Card { Name = "Questing Explorer" },
				new Card { Name = "Wandmaker" },
				new Card { Name = "Instructor Fireheart" },
				new Card { Name = "Circus Medic" }, // new
				new Card { Name = "Barista Lynchen" },
				new Card { Name = "The Lurker Below" },
				new Card { Name = "Y'Shaarj, the Defiler" }, // new
				new Card { Name = "Sandstorm Elemental" },
				new Card { Name = "Sky Gen'ral Kragg" },
				new Card { Name = "Cumulo-Maximus" },
				new Card { Name = "Dunk Tank" }, // new

				//new Card { Name = "Pen Flinger" },
				//new Card { Name = "Sludge Slurper" },
				//new Card { Name = "Acidic Swamp Ooze" },
				//new Card { Name = "Cult Neophyte" },
				//new Card { Name = "Devolving Missiles" },
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
				new Card { Name = "Wriggling Horror" },
				new Card { Name = "Acrobatics" },
				new Card { Name = "Dreadlord's Bite" },
				new Card { Name = "Stiltstepper" },

				//new Card { Name = "Altruis the Outcast" },
				//new Card { Name = "Kayn Sunfury" },
				//new Card { Name = "Marrowslicer" },
				//new Card { Name = "Glaivebound Adept" },
				//new Card { Name = "Skull of Gul'dan" },
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
				new Card { Name = "EVIL Quartermaster" },

				new Card { Name = "Coerce" },
				new Card { Name = "Lord Barov" },
				new Card { Name = "Shield Block" },
				new Card { Name = "Hoard Pillager" },

				//new Card { Name = "Kargath Bladefist" },
				new Card { Name = "Wrenchcalibur" },
				new Card { Name = "Brawl" },
				new Card { Name = "Cutting Class" },
				new Card { Name = "Doctor Krastinov" },
				//new Card { Name = "Plague of Wrath" },
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
				new Card { Name = "Demon Companion" },
				new Card { Name = "Dwarven Sharpshooter" },
				new Card { Name = "Intrepid Initiate" },
				new Card { Name = "Tour Guide" },
				new Card { Name = "Wolpertinger" },
				new Card { Name = "Freezing Trap" },
				new Card { Name = "Phase Stalker" },
				new Card { Name = "Pressure Plate" },
				new Card { Name = "Scavenger's Ingenuity" },
				new Card { Name = "Voracious Reader" },
				new Card { Name = "Eaglehorn Bow" },
				new Card { Name = "Kill Command" },
				new Card { Name = "Dragonbane" },
				new Card { Name = "Toxic Reinforcements" },
				new Card { Name = "Explosive Trap" },
				new Card { Name = "Pack Tactics" },
				new Card { Name = "Lorekeeper Polkelt" },
				new Card { Name = "Imprisoned Felmaw" },
				new Card { Name = "Leper Gnome" },
				new Card { Name = "Unleash the Hounds" },
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
			var deck = new Deck
			{
				Name = "Control Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
			{
				new Card { Name = "Raise Dead" },
				new Card { Name = "Draconic Studies" },
				new Card { Name = "Renew" },
				new Card { Name = "Cleric of Scales" },
				new Card { Name = "Holy Smite" },
				new Card { Name = "Wave of Apathy" },
				new Card { Name = "Sethekk Veilweaver" },
				new Card { Name = "Shadow Word: Death" },
				new Card { Name = "Wild Pyromancer" },
				new Card { Name = "Apotheosis" },
				new Card { Name = "Mindflayer Kaahrj" },
				new Card { Name = "Cabal Acolyte" },
				new Card { Name = "Cobalt Spellkin" },
				new Card { Name = "Soul Mirror" },
				new Card { Name = "Murozond the Infinite" }, // new
				new Card { Name = "Holy Smite" }, // new
				new Card { Name = "Insight" }, // new
				new Card { Name = "Nazmani Bloodweaver" }, // new
				new Card { Name = "Palm Reading" }, // new
				new Card { Name = "Cabal Shadow Priest" },
				new Card { Name = "Yogg-Saron, Master of Fate" }, // new

				//new Card { Name = "Madame Lazul" },
				//new Card { Name = "Twilight Drake" },
				//new Card { Name = "Galakrond, the Unspeakable" },
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
				new Card { Name = "Shadowstep" }, // new
				new Card { Name = "Pharaoh Cat" },
				new Card { Name = "Praise Galakrond!" },
				new Card { Name = "Edwin VanCleef" },
				new Card { Name = "EVIL Miscreant" },
				new Card { Name = "Seal Fate" },
				new Card { Name = "Shield of Galakrond" },
				new Card { Name = "Flik Skyshiv" },
				new Card { Name = "Heistbaron Togwaggle" },
				new Card { Name = "Kronx Dragonhoof" },
				new Card { Name = "Galakrond, the Nightmare" },
				new Card { Name = "Preparation" }, // new
				new Card { Name = "Wand Thief" }, // new
				new Card { Name = "Eviscerate" },
				new Card { Name = "Foxy Fraud" }, // new
				new Card { Name = "Swindle" }, // new
				new Card { Name = "Tenwu of the Red Smoke" }, // new
				new Card { Name = "Lorekeeper Polkelt" }, // new
				new Card { Name = "Jandice Barov" }, // new
				new Card { Name = "Stowaway" }, // new
				new Card { Name = "C'Thun, the Shattered" }, // new

				//new Card { Name = "Blackjack Stunner" },
				//new Card { Name = "Ambush" },
				//new Card { Name = "Bamboozle" },
				//new Card { Name = "Dirty Tricks" },
				//new Card { Name = "Shadowjeweler Hanar" },
				//new Card { Name = "Devoted Maniac" },
				//new Card { Name = "Faceless Corruptor" },
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
				new Card { Name = "Plague of Flames" },
				new Card { Name = "Mo'arg Artificer" },
				new Card { Name = "Spirit Jailer" },
				new Card { Name = "Nether Breath" },
				new Card { Name = "Soul Shear" },
				new Card { Name = "Dragonblight Cultist" },
				new Card { Name = "School Spirits" },
				new Card { Name = "Cascading Disaster" }, // new
				new Card { Name = "Devoted Maniac" },
				new Card { Name = "Veiled Worshipper" },
				new Card { Name = "Crazed Netherwing" },
				new Card { Name = "Shield of Galakrond" },
				new Card { Name = "Kronx Dragonhoof" },
				new Card { Name = "Tickatus" }, // new
				new Card { Name = "Galakrond, the Wretched" },
				new Card { Name = "Alexstrasza" },
				new Card { Name = "Y'Shaarj, the Defiler" }, // new
				new Card { Name = "Dark Skies" }, // new
				new Card { Name = "Soulciologist Malicia" },
				new Card { Name = "Twisting Nether" }, // new

				//new Card { Name = "Tour Guide" },
				//new Card { Name = "Brittlebone Destroyer" },
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
				new Card { Name = "Nature Studies" },
				new Card { Name = "Gibberling" },
				new Card { Name = "Guess the Weight" },
				new Card { Name = "Lunar Eclipse" },
				new Card { Name = "Power of the Wild" },
				new Card { Name = "Rising Winds" },
				new Card { Name = "Dreamway Guardians" },
				new Card { Name = "BEEEES!!!" },
				new Card { Name = "Fungle Fortunes" },
				new Card { Name = "Savage Roar" },
				new Card { Name = "Arbor Up" },
				new Card { Name = "Glowfly Swarm" },
				new Card { Name = "Solar Eclipse" },
				new Card { Name = "Soul of the Forest" },
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
				new Card { Name = "Animated Broomstick" }, // new
				new Card { Name = "Nature Studies" },
				new Card { Name = "Wild Growth" }, // new
				new Card { Name = "Overgrowth" },
				new Card { Name = "Anubisath Defender" },
				new Card { Name = "Lake Thresher" },
				new Card { Name = "Teacher's Pet" },
				new Card { Name = "Twilight Runner" },
				new Card { Name = "Overflow" },
				new Card { Name = "Strongman" }, // new
				new Card { Name = "Guardian Animals" },
				new Card { Name = "Carnival Clown" }, // new
				new Card { Name = "Survival of the Fittest" },
				new Card { Name = "Y'Shaarj, the Defiler" }, // new
				new Card { Name = "Yogg-Saron, Master of Fate" }, // new

				//new Card { Name = "Crystal Power" },
				//new Card { Name = "Ironbark" },
				//new Card { Name = "Bogbeam" },
				//new Card { Name = "Speaker Gidra" },
				//new Card { Name = "Kael'thas Sunstrider" },
				//new Card { Name = "Ysera, Unleashed" },
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
				new Card { Name = "Demon Companion" },
				new Card { Name = "Dwarven Sharpshooter" },
				new Card { Name = "Guardian Augmerchant" },
				new Card { Name = "Intrepid Initiate" },
				new Card { Name = "Mystery Winner" },
				new Card { Name = "Tour Guide" },
				new Card { Name = "Wolpertinger" },
				new Card { Name = "Bonechewer Brawler" },
				new Card { Name = "Freezing Trap" },
				new Card { Name = "Imprisoned Felmaw" },
				new Card { Name = "Open the Cages" },
				new Card { Name = "Pack Tactics" },
				new Card { Name = "Phase Stalker" },
				new Card { Name = "Scavenger's Ingenuity" },
				new Card { Name = "Snake Trap" },
				new Card { Name = "Wriggling Horror" },
				new Card { Name = "Zephrys the Great" },
				new Card { Name = "Animal Companion" },
				new Card { Name = "Eaglehorn Bow" },
				new Card { Name = "Inconspicuous Rider" },
				new Card { Name = "Kill Command" },
				new Card { Name = "Petting Zoo" },
				new Card { Name = "Unleash the Hounds" },
				new Card { Name = "Voracious Reader" },
				new Card { Name = "Dragonbane" },

				new Card { Name = "Lorekeeper Polkelt" },
				new Card { Name = "Rinling's Rifle" },
				new Card { Name = "Dinotamer Brann" },

				//new Card { Name = "Tracking" },
				//new Card { Name = "Desert Spear" },
				//new Card { Name = "Diving Gryphon" },
				//new Card { Name = "Primordial Explorer" },
				//new Card { Name = "Phase Stalker" },
				//new Card { Name = "Pressure Plate" },
				//new Card { Name = "Stormhammer" },
				//new Card { Name = "Zixor, Apex Predator" },
				//new Card { Name = "Evasive Feywing" },
				//new Card { Name = "Frizz Kindleroost" },
				//new Card { Name = "Big Ol' Whelp" },
				//new Card { Name = "Rotnest Drake" },
				//new Card { Name = "Evasive Wyrm" },
				//new Card { Name = "Veranus" },
				//new Card { Name = "Siamat" },
				//new Card { Name = "Ace Hunter Kreen" },
				//new Card { Name = "Dragonqueen Alexstrasza" },
				//new Card { Name = "Nagrand Slam" },
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
				new Card { Name = "Ancient Mysteries" }, // new
				new Card { Name = "Zephrys the Great" },
				new Card { Name = "Flame Ward" }, // new
				new Card { Name = "Ice Barrier" },
				new Card { Name = "Reno the Relicologist" },
				new Card { Name = "Devolving Missiles" }, // new
				new Card { Name = "Magic Trick" }, // new
				new Card { Name = "Ray of Frost" },
				new Card { Name = "Wand Thief" }, // new
				new Card { Name = "Acidic Swamp Ooze" }, // new
				new Card { Name = "Apexis Smuggler" }, // new
				new Card { Name = "Arcane Flakmage" }, // new
				new Card { Name = "Astromancer Solarian" },
				new Card { Name = "Doomsayer" },
				new Card { Name = "Frostbolt" }, // new
				new Card { Name = "Game Master" }, // new
				new Card { Name = "Starscyer" }, // new
				new Card { Name = "Wandmaker" }, // new
				new Card { Name = "Arcane Intellect" },
				new Card { Name = "Counterspell" }, // new
				new Card { Name = "Firebrand" }, // new
				new Card { Name = "Frost Nova" },
				new Card { Name = "Inconspicuous Rider" }, // new
				new Card { Name = "Kirin Tor Mage" }, // new
				new Card { Name = "Netherwind Portal" }, // new
				new Card { Name = "Rigged Faire Game" }, // new
				new Card { Name = "Spellbender" }, // new
				new Card { Name = "Bone Wraith" },
				new Card { Name = "Occult Conjurer" }, // new
				new Card { Name = "Ring Toss" }, // new
				new Card { Name = "Cloud Prince" }, // new
				new Card { Name = "Jandice Barov" },
				new Card { Name = "Blizzard" }, // new
				new Card { Name = "Khartut Defender" },
				new Card { Name = "Sayge, Seer of Darkmoon" }, // new
				new Card { Name = "Power of Creation" },
				new Card { Name = "Dragonqueen Alexstrasza" },
				new Card { Name = "C'Thun, the Shattered" }, // new
				new Card { Name = "Puzzle Box of Yogg-Saron" },
				new Card { Name = "The Amazing Reno" },
				new Card { Name = "Yogg-Saron, Master of Fate" }, // new

				//new Card { Name = "Sphere of Sapience" },
				//new Card { Name = "Arcane Breath" },
				//new Card { Name = "Devolving Missiles" },
				//new Card { Name = "Transfer Student" },
				//new Card { Name = "Combustion" },
				//new Card { Name = "Imprisoned Observer" },
				//new Card { Name = "Conjurer's Calling" },
				//new Card { Name = "Escaped Manasaber" },
				//new Card { Name = "Twilight Drake" },
				//new Card { Name = "Malygos, Aspect of Magic" },
				//new Card { Name = "Rolling Fireball" },
				//new Card { Name = "Dragoncaster" },
				//new Card { Name = "Deep Freeze" },
				//new Card { Name = "Tortollan Pilgrim" },
				//new Card { Name = "Alexstrasza" },
				//new Card { Name = "Kalecgos" },
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
				new Card { Name = "Raise Dead" }, // new
				new Card { Name = "Draconian Studies" }, // new
				new Card { Name = "Renew" },
				new Card { Name = "Wave of Apathy" },
				new Card { Name = "Insight" }, // new
				new Card { Name = "Penance" },
				new Card { Name = "Sethekk Veilweaver" },
				new Card { Name = "Shadow Word: Death" },
				new Card { Name = "Wandmaker" }, // new
				new Card { Name = "Zephrys the Great" },
				new Card { Name = "Apotheosis" },
				new Card { Name = "Breath of the Infinite" }, // new
				new Card { Name = "Madame Lazul" },
				new Card { Name = "Mindflayer Kaahrj" },
				new Card { Name = "Mindrender Illucia" },
				new Card { Name = "Palm Reading" }, // new
				new Card { Name = "Cabal Acolyte" },
				new Card { Name = "Holy Nova" },
				new Card { Name = "Cobalt Spelkin" }, // new
				new Card { Name = "Galakrond, the Unspeakable" },
				new Card { Name = "Soul Mirror" },
				new Card { Name = "Murozond the Infinite" },
				new Card { Name = "Dragonqueen Alexstrasza" },
				new Card { Name = "Plague of Death" }, // new
				new Card { Name = "Animated Broomstick" }, // new
				new Card { Name = "Wild Pyromancer" }, // new
				new Card { Name = "Nazmani Bloodweaver" }, // new
				new Card { Name = "Kronx Dragonhoof" },
				new Card { Name = "Siamat" }, // new
				new Card { Name = "G'huun the Blood God" }, // new
				new Card { Name = "Yogg-Saron, Master of Fate" }, // new

				//new Card { Name = "Lazul's Scheme" },
				//new Card { Name = "Forbidden Words" },
				//new Card { Name = "Disciple of Galakrond" },
				//new Card { Name = "Imprisoned Vilefiend" },
				//new Card { Name = "Thoughtsteal" },
				//new Card { Name = "Shadow Madness" },
				//new Card { Name = "Shadow Word: Ruin" },
				//new Card { Name = "Wretched Tutor" },
				//new Card { Name = "Convincing Infiltrator" },
				//new Card { Name = "Headmaster Kel'Thuzad" },
				//new Card { Name = "Time Rip" },
				//new Card { Name = "Cabal Shadow Priest" },
				//new Card { Name = "Onyx Magescribe" },
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
				new Card { Name = "Crystal Power" }, // new
				new Card { Name = "Nature Studies" },
				new Card { Name = "Wrath" }, // new
				new Card { Name = "Bogbeam" },
				new Card { Name = "Wild Growth" },
				new Card { Name = "Breath of Dreams" },
				new Card { Name = "Guess the Weight" }, // new
				new Card { Name = "Lunar Eclipse" }, // new
				new Card { Name = "Solar Eclipse" }, // new
				new Card { Name = "Gadgetzan Auctioneer" },
				new Card { Name = "Germination" },
				new Card { Name = "Overgrowth" },
				new Card { Name = "Swipe" },
				new Card { Name = "Forest Warden Omu" },
				new Card { Name = "Overflow" },
				new Card { Name = "Jepetto Joybuzz" },
				new Card { Name = "Alexstrasza" }, // new
				new Card { Name = "Malygos" },
				new Card { Name = "Ysera, Unleashed" },
				new Card { Name = "Yogg-Saron, Master of Fate" }, // new

				//new Card { Name = "Teacher's Pet" },
				//new Card { Name = "Twilight Runner" },
				//new Card { Name = "Guardian Animals" },
				//new Card { Name = "Kael'thas Sunstrider" },
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
				new Card { Name = "Secret Passage" },
				new Card { Name = "Wand Thief" },
				new Card { Name = "Dirty Tricks" },
				new Card { Name = "Eviscerate" }, // new
				new Card { Name = "Foxy Fraud" }, // new
				new Card { Name = "Shadowjeweler Hanar" },
				new Card { Name = "Swindle" }, // new
				new Card { Name = "Edwin VanCleef" },
				new Card { Name = "EVIL Miscreant" },
				new Card { Name = "Questing Adventurer" },
				new Card { Name = "Jandice Barov" }, // new
				new Card { Name = "Pharaoh Cat" },
				new Card { Name = "Plagiarize" },
				new Card { Name = "Zephrys the Great" }, // new

				//new Card { Name = "Dragon's Hoard" },
				//new Card { Name = "Cult Neophyte" },
				//new Card { Name = "Vendetta" },
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
				new Card { Name = "Lab Partner" },
				new Card { Name = "Magic Trick" },
				new Card { Name = "Primordial Studies" },
				new Card { Name = "Ray of Frost" },
				new Card { Name = "Wand Thief" },
				new Card { Name = "Cram Session" },
				new Card { Name = "Mana Cyclone" },
				new Card { Name = "Sorcerer's Apprentice" },
				new Card { Name = "Arcane Intellect" },
				new Card { Name = "Firebrand" },
				new Card { Name = "Mana Giant" },
				new Card { Name = "Brain Freeze" }, // new
				new Card { Name = "Devolving Missiles" }, // new
				new Card { Name = "Violet Spellwing" },
				new Card { Name = "Astromancer Solarian" },
				new Card { Name = "Evocation" },
				new Card { Name = "Conjurer's Calling" }, // new
				new Card { Name = "Yogg-Saron, Master of Fate" }, // new

				//new Card { Name = "Arcane Missiles" },
				//new Card { Name = "Chenvaala" },
				new Card { Name = "Mozaki, Master Duelist" },
			}
			};
		}
		private static Deck WhirlkickRogue()
		{
			var deck = new Deck
			{
				Name = "Whirlkick Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Brain Freeze" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Prize Plunderer" },
					new Card { Name = "Secret Passage" },
					new Card { Name = "Wand Thief" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Foxy Fraud" },
					new Card { Name = "Swindle" },
					new Card { Name = "Whirlkick Master" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Questing Adventurer" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Jandice Barov" },
				}
			};
			return deck;
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
				new Card { Name = "Consume Magic" },
				new Card { Name = "Spirit Jailer" },
				new Card { Name = "Crimson Sigil Runner" },
				new Card { Name = "Twin Slice" },
				new Card { Name = "Double Jump" },
				new Card { Name = "Blade Dance" },
				new Card { Name = "Chaos Strike" },
				new Card { Name = "Manafeeder Panthara" },
				new Card { Name = "Soul Shear" },
				new Card { Name = "Aldrachi Warblades" },
				new Card { Name = "Relentless Pursuit" },
				new Card { Name = "Wandmaker" },
				new Card { Name = "Il'gynoth" },
				new Card { Name = "Kayn Sunfury" },
				new Card { Name = "Marrowslicer" },
				new Card { Name = "Soulshard Lapidary" },

				new Card { Name = "Spectral Sight" },
				new Card { Name = "Shardshatter Mystic" },
				new Card { Name = "Hoard Pillager" },
				new Card { Name = "Glaivebound Adept" },
				new Card { Name = "Bladed Lady" },
				new Card { Name = "Soulciologist Malicia" },
			}
			};
			deck.AddAdvice(
				"Pure Paladin",
				"Keep Consume for buffed boys");
			deck.AddAdvice(
				"Pure Paladin",
				"Keep Kayn to get thru for the final blow");
			deck.AddAdvice(
				"Broom Paladin",
				"Keep Consume for buffed boys");
			deck.AddAdvice(
				"Broom Paladin",
				"Play fast to get under the Hopes");
			deck.AddAdvice(
				"Galakrond Rogue",
				"Race the face as Cthun and Gala are slow");
			deck.AddAdvice(
				"Small Spell Mage",
				"Bladedance the T8 Mana Giant into conjuring");
			deck.AddAdvice(
				"Bomb Warrior",
				"Hammer him down before the bombs go off");
			deck.AddAdvice(
				"Highlander Hunter",
				"You will need plenty of souls in ur deck");
			deck.AddAdvice(
				"Small Spell Mage",
				"Hold back some weapon damage for the fatal blow");
			deck.AddAdvice(
				"Stealth Rogue",
				"Save Silence for Edwin or Questing");
			deck.AddAdvice(
				"Stealth Rogue",
				"Beware discovered Counterspell from Wand Thief");
			deck.AddAdvice(
				"Secret Rogue",
				"Save Silence for Edwin or Questing");
			deck.AddAdvice(
				"Secret Rogue",
				"Beware discovered Counterspell from Wand Thief");
			deck.AddAdvice(
				"Evolve Shaman",
				"Blade dance the Hares");
			deck.AddAdvice(
				"Face Hunter",
				"Control the board until he runs out of gas");
			deck.AddAdvice(
				"Aggro Demon Hunter",
				"Control the early minions and get card advantage");
			deck.AddAdvice(
				"Aggro Demon Hunter",
				"Deal with the Brawler before it gets buffed");

			return deck;
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
		private static Deck StowawayRogue()
		{
			var deck = new Deck
			{
				Name = "Stowaway Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Secret Passage" },
					new Card { Name = "Togwaggle's Scheme" },
					new Card { Name = "Dirty Tricks" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Foxy Fraud" },
					new Card { Name = "Sap" },
					new Card { Name = "Akama" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Ticket Master" },
					new Card { Name = "Shadow of Death" },
					new Card { Name = "Ogremancer" },
					new Card { Name = "Stowaway" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "Heistbaron Togwaggle" },
					new Card { Name = "Khartut Defender" },
				}
			};
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
				new Card { Name = "Shadowstep" }, // new
				new Card { Name = "Secret Passage" },
				new Card { Name = "Spymistress" },
				new Card { Name = "Wand Thief" }, // new
				new Card { Name = "Eviscerate" },
				new Card { Name = "Foxy Fraud" }, // new
				new Card { Name = "Sneaky Delinquent" },
				new Card { Name = "Swindle" }, // new
				new Card { Name = "Edwin VanCleef" }, // new
				new Card { Name = "EVIL Miscreant" }, // new
				new Card { Name = "Greyheart Sage" },
				new Card { Name = "Jandice Barov" }, // new
				new Card { Name = "Preparation" }, // new
				new Card { Name = "Worgen Infiltrator" },
				new Card { Name = "Hooked Scimitar" },
				new Card { Name = "Questing Adventurer" }, // new

				//new Card { Name = "Plague of Madness" },
				//new Card { Name = "Sinister Strike" },
				//new Card { Name = "Ashtongue Slayer" },
				//new Card { Name = "Cold Blood" },
				//new Card { Name = "Sap" },
				//new Card { Name = "Akama" },
				//new Card { Name = "Wolfrider" },
				//new Card { Name = "Burrowing Scorpid" },
			}
			};
		}

		private static Deck BroomPaladin()
		{
			var deck = new Deck
			{
				Name = "Broom Paladin",
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
				new Card { Name = "Air Raid" },
				new Card { Name = "Hand of A'dal" },
				new Card { Name = "Libram of Wisdom" },
				new Card { Name = "Novice Engineer" },
				new Card { Name = "Lord Barov" },
				new Card { Name = "Salhet's Pride" },
				new Card { Name = "Aldor Truthseeker" },
				new Card { Name = "Libram of Justice" },
				new Card { Name = "Lothraxion the Redeemed" },
				new Card { Name = "Devout Pupil" },
				new Card { Name = "Libram of Hope" },
				new Card { Name = "Lady Liadrin" },
				new Card { Name = "Yogg-Saron, Master of Fate" }, // new
				new Card { Name = "Loot Hoarder" },
				//new Card { Name = "Lightforged Blessing" },
				//new Card { Name = "Murgur Murgurgle" },

				//new Card { Name = "Gift of Luminance" },
				//new Card { Name = "Goody Two-Shields" },
				//new Card { Name = "High Abbess Alura" },
				//new Card { Name = "Harrison Jones" },
			}
			};
			deck.AddKeyPlays("P will use Silas to rotate u on T7");
			return deck;
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
			var deck = new Deck
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
				new Card { Name = "Sludge Slurper" },
				new Card { Name = "Storm's Wrath" },
				new Card { Name = "Surging Tempest" },
				new Card { Name = "Tour Guide" },
				new Card { Name = "EVIL Totem" },
				new Card { Name = "Grand Totem Eys'or" },
				new Card { Name = "Trick Totem" },
				new Card { Name = "Mana Tide Totem" },
				new Card { Name = "Totemic Reflection" },
				new Card { Name = "Circus Amalgam" },
				new Card { Name = "Splitting Axe" },
				new Card { Name = "Bloodlust" },
				new Card { Name = "Cagematch Custodian" },
				new Card { Name = "Totem Goliath" },

				//new Card { Name = "Serpentshrine Portal" },
				//new Card { Name = "Runic Carvings" },
			}
			};
			deck.AddMulligans1(
				"Demonhunter",
				new List<string>
				{
					"Grand Totem Ey'sore" ,
					"Tour Guide" ,
					"Totemic Reflection" ,
					"Surging Tempest" ,
					"Storm's Wrath" ,
					"Totemic Might" ,
					"Sludge Slurper" ,
					"Cagematch Custodian",
					"Totemic Surge" ,
					"Circus Amalgam" ,
					"EVIL Totem" ,
					"Lightning Bloom" ,
					"Mana Tide Totem" ,
					"Totem Goliath" ,
					"Splitting Axe" ,
					"Trick Totem" ,
					"Bloodlust" ,
				});
			deck.AddMulligans2(
				"Demonhunter",
				new List<string>
				{
					"Grand Totem Ey'sore" ,
					"Totemic Reflection" ,
				});
			deck.AddMulligans1(
				"Druid",
				new List<string>
				{
					"Grand Totem Ey'sore" ,
					"Storm's Wrath" ,
					"Totem Goliath" ,
					"Cagematch Custodian",
					"Tour Guide" ,
					"Circus Amalgam" ,
					"Totemic Might" ,
					"Bloodlust" ,
					"Surging Tempest" ,
					"Lightning Bloom" ,
					"Mana Tide Totem" ,
					"Sludge Slurper" ,
					"Trick Totem" ,
					"Totemic Reflection" ,
				});
			deck.AddMulligans2(
				"Druid",
				new List<string>
				{
					"Grand Totem Ey'sore" ,
					"Totemic Reflection" ,
					"Bloodlust" ,
				});
			deck.AddMulligans1(
				"Hunter",
				new List<string>
				{
					"Totemic Might" ,
					"Tour Guide" ,
					"Grand Totem Ey'sore" ,
					"Totemic Reflection" ,
					"Surging Tempest" ,
					"Sludge Slurper" ,
					"Lightning Bloom" ,
					"EVIL Totem" ,
					"Circus Amalgam" ,
					"Trick Totem" ,
					"Storm's Wrath" ,
					"Cagematch Custodian",
					"Totemic Surge" ,
				});
			deck.AddMulligans2(
				"Hunter",
				new List<string>
				{
					"Tour Guide" ,
					"Totemic Might" ,
				});
			deck.AddMulligans1(
				"Mage",
				new List<string>
				{
					"Totem Goliath" ,
					"Grand Totem Ey'sore" ,
					"Tour Guide" ,
					"Totemic Reflection" ,
					"Splitting Axe" ,
					"Cagematch Custodian",
					"Storm's Wrath" ,
					"Surging Tempest" ,
					"Totemic Might" ,
					"EVIL Totem" ,
					"Lightning Bloom" ,
					"Mana Tide Totem" ,
					"Circus Amalgam" ,
					"Sludge Slurper" ,
				});

			deck.AddMulligans2(
				"Mage",
				new List<string>
				{
					"Grand Totem Ey'sore" ,
					"Totemic Reflection" ,
					"Totemic Might" ,
				});
			deck.AddMulligans1(
				"Paladin",
				new List<string>
				{
					"Surging Tempest" ,
					"Grand Totem Ey'sore" ,
					"Tour Guide" ,
					"Storm's Wrath" ,
					"Totemic Reflection" ,
					"Sludge Slurper" ,
					"Splitting Axe" ,
					"EVIL Totem" ,
					"Trick Totem" ,
					"Totemic Surge" ,
					"Circus Amalgam" ,
					"Totem Goliath" ,
				});
			deck.AddMulligans2(
				"Paladin",
				new List<string>
				{
					"Totem Goliath" ,
					"Tour Guide" ,
				});
			deck.AddMulligans1(
				"Priest",
				new List<string>
				{
					"Grand Totem Ey'sore" ,
					"Surging Tempest" ,
					"Sludge Slurper" ,
					"Mana Tide Totem" ,
					"Totemic Reflection" ,
					"Storm's Wrath" ,
					"Circus Amalgam" ,
					"Totemic Surge" ,
					"EVIL Totem" ,
					"Totemic Might" ,
				});
			deck.AddMulligans2(
				"Priest",
				new List<string>
				{
					"Grand Totem Ey'sore" ,
					"Totem Goliath" ,
					"Totemic Reflection" ,
					"Splitting Axe" ,
					"Lightning Bloom" ,
				});
			deck.AddMulligans1(
				"Rogue",
				new List<string>
				{
					"Tour Guide" ,
					"Grand Totem Ey'sore" ,
					"Storm's Wrath" ,
					"Surging Tempest" ,
					"EVIL Totem" ,
					"Cagematch Custodian",
					"Circus Amalgam" ,
					"Totemic Might" ,
					"Trick Totem" ,
					"Totem Goliath" ,
					"Sludge Slurper" ,
					"Mana Tide Totem" ,
					"Totemic Reflection" ,
				});
			deck.AddMulligans2(
				"Rogue",
				new List<string>
				{
					"Tour Guide" ,
					"Totemic Reflection" ,
					"Bloodlust" ,
				});
			deck.AddMulligans1(
				"Shaman",
				new List<string>
				{
					"Tour Guide" ,
					"Grand Totem Ey'sore" ,
					"Storm's Wrath" ,
					"Surging Tempest" ,
					"EVIL Totem" ,
					"Cagematch Custodian",
					"Circus Amalgam" ,
					"Totemic Might" ,
					"Trick Totem" ,
					"Totem Goliath" ,
					"Sludge Slurper" ,
					"Mana Tide Totem" ,
					"Totemic Reflection" ,
				});
			deck.AddMulligans2(
				"Shaman",
				new List<string>
				{
					"Totemic Reflection" ,
					"Bloodlust" ,
					"Tour Guide" ,
				});
			deck.AddMulligans1(
				"Warlock",
				new List<string>
				{
					"-Sludge Slurper" ,
					"-Lightning Bloom" ,
					"-Trick Totem" ,
				});
			deck.AddMulligans2(
				"Warlock",
				new List<string>
				{
					"Grand Totem Ey'sore" ,
					"Tour Guide" ,
					"Splitting Axe" ,
				});
			deck.AddMulligans1(
				"Warrior",
				new List<string>
				{
					"-Tour Guide" ,
					"-Surging Tempest" ,
					"-Storm's Wrath" ,
					"-Cagematch Custodian",
					"-Bloodlust" ,
				});
			deck.AddMulligans2(
				"Warrior",
				new List<string>
				{
					"Grand Totem Ey'sore" ,
					"Totemic Reflection" ,
					"Bloodlust" ,
					"Storm's Wrath" ,
					"Totem Goliath" ,
					"Circus Amalgam" ,
					"Totemic Might" ,
				});
			return deck;
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
				//new Card { Name = "Preparation" },
				new Card { Name = "Backstab" },
				new Card { Name = "Deadly Poison" },
				new Card { Name = "Nitroboost Poison" },  // mini-set
				new Card { Name = "Worgen Infiltrator" },
				new Card { Name = "Eviscerate" },
				new Card { Name = "Sap" },
				new Card { Name = "Sneaky Delinquent" },  // mini-set
				new Card { Name = "Cloak of Shadows" },  // mini-set
				new Card { Name = "Greyheart Sage" },   
				new Card { Name = "Hooked Scimitar" },
				new Card { Name = "Self-Sharpening Sword" },
				new Card { Name = "Dread Corsair" },
				new Card { Name = "Steeldancer" },   
				new Card { Name = "Cutting Class" },
				new Card { Name = "Doctor Krastinov" },
				new Card { Name = "Jandice Barov" },  

				//new Card { Name = "Blazing Battlemage" },
				//new Card { Name = "Intrepid Initiate" },
				//new Card { Name = "Secret Passage" },
				//new Card { Name = "Sinister Strike" },
				//new Card { Name = "Southsea Deckhand" },
				//new Card { Name = "Spymistress" },
				//new Card { Name = "Cold Blood" },
				//new Card { Name = "Voracious Reader" },
				//new Card { Name = "Vulpera Toxinblade" },
			}
			};
		}
		private static Deck ZooWarlock()
		{
			var deck = new Deck
			{
				Name = "Zoo Warlock",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
			{
				new Card { Name = "Raise Dead" },
				new Card { Name = "Animated Broomstick" }, // new
				new Card { Name = "Flame Imp" },
				new Card { Name = "Soulfire" },
				new Card { Name = "Spirit Jailer" },
				new Card { Name = "Tour Guide" },
				new Card { Name = "Wicked Whispers" }, // new
				new Card { Name = "Voidwalker" },
				new Card { Name = "Darkglare" },
				new Card { Name = "Expired Merchant" },
				new Card { Name = "Kanrethad Ebonlocke" }, // new
				new Card { Name = "Wriggling Horror" }, // new
				new Card { Name = "Nightshade Matron" },
				new Card { Name = "Hand of Gul'dan" },
				new Card { Name = "Flesh Giant" },
				new Card { Name = "Man'ari Mosher" }, // new
				new Card { Name = "Revenant Rascal" }, // new
				new Card { Name = "Midway Maniac" }, 

				//new Card { Name = "Soul Shear" },
				//new Card { Name = "Nether Breath" },
				//new Card { Name = "Crazed Netherwing" },
				//new Card { Name = "Neferset Thrasher" },
				//new Card { Name = "Shadowlight Scholar" },
				//new Card { Name = "Diseased Vulture" },
				//new Card { Name = "Void Drinker" },
				//new Card { Name = "Shadowflame" },
			}
			};
			deck.AddMulligans1(
				"Demon Hunter",
				new List<string>
				{
					"Hand of Gul'dan",
					"Spirit Jailer",
					"Voidwalker",
					"Tour Guide",
					"Darkglare",
				});
			deck.AddMulligans1(
				"Druid",
				new List<string>
				{
					"Kanrethad Ebonlocke",
					"Darkglare",
					"Hand of Gul'dan",
					"Tour Guide",
					"Voidwalker",
					"Spirit Jailer",
				});
			deck.AddMulligans1(
				"Hunter",
				new List<string>
				{
					"Spirit Jailer",
					"Hand of Gul'dan",
					"Tour Guide",
					"Flame Imp",
					"Kanrethad Ebonlocke",
					"Darkglare",
				});
			deck.AddMulligans1(
				"Mage",
				new List<string>
				{
					"Expired Merchant",
					"Kanrethad Ebonlocke",
					"Tour Guide",
					"Flame Imp",
					"Raise Dead",
					"Hand of Gul'dan",
					"Darkglare",
					"Spirit Jailer",
				});
			deck.AddMulligans1(
				"Paladin",
				new List<string>
				{
					"Hand of Gul'dan",
					"Flame Imp",
					"Expired Merchant",
					"Voidwalker",
					"Spirit Jailer",
					"Tour Guide",
					"Darkglare",
					"Kanrethad Ebonlocke",
					"Animated Broomstick",
				});
			deck.AddMulligans1(
				"Priest",
				new List<string>
				{
					"Darkglare",
					"Revenant Rascal",
					"Tour Guide",
					"Flame Imp",
					"Wriggling Horror",
					"Animated Broomstick",
					"Hand of Gul'dan",
					"Flesh Giant",
				});
			deck.AddMulligans1(
				"Rogue",
				new List<string>
				{
					"Flame Imp",
					"Expired Merchant",
					"Hand of Gul'dan",
					"Tour Guide",
					"Raise Dead",
					"Voidwalker",
					"Darkglare",
				});
			deck.AddMulligans1(
				"Shaman",
				new List<string>
				{
					"Tour Guide",
					"Expired Merchant",
					"Darkglare",
					"Spirit Jailer",
					"Kanrethad Ebonlocke",
					"Flame Imp",
				});
			deck.AddMulligans1(
				"Warlock",
				new List<string>
				{
					"Flame Imp",
					"Raise Dead",
					"Tour Guide",
					"Kanrethad Ebonlocke",
					"Darkglare"
				});
			deck.AddMulligans1(
				"Warrior",
				new List<string>
				{
					"Hand of Gul'dan",
					"Tour Guide",
					"Flame Imp",
					"Flesh Giant",
					"Kanrethad Ebonlocke",
					"Voidwalker",
				});
			deck.AddAdvice(
				"Priest",
				"Dont hold back early or u may face the plague");
			return deck;
		}
		#endregion


#region New Decks from HSR
		private static Deck AggroRogue()
		{
			var deck = new Deck
			{
				Name = "Aggro Rogue",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Secret Passage" },
					new Card { Name = "Sinister Strike" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Spymistress" },
					new Card { Name = "Worgen Infiltrator" },
					new Card { Name = "Ashtongue Slayer" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Foxy Fraud" },
					new Card { Name = "Sap" },
					new Card { Name = "Sneaky Delinquent" },
					new Card { Name = "Swindle" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "Greyheart Sage" },
					new Card { Name = "Hooked Scimitar" },
				}
			};
			return deck;
		}
		private static Deck BigPriest()
		{
			var deck = new Deck
			{
				Name = "Big Priest",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Renew" },
					new Card { Name = "Wave of Apathy" },
					new Card { Name = "Insight" },
					new Card { Name = "Penance" },
					new Card { Name = "Shadow Word: Death" },
					new Card { Name = "Breath of the Infinite" },
					new Card { Name = "Palm Reading" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Holy Nova" },
					new Card { Name = "Convincing Infiltrator" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Galakrond, the Unspeakable" },
					new Card { Name = "Soul Mirror" },
					new Card { Name = "Catrina Muerte" },
					new Card { Name = "G'huun the Blood God" },
					new Card { Name = "Idol of Y'Shaarj" },
					new Card { Name = "Blood of G'huun" },
					new Card { Name = "Mass Resurrection" },
					new Card { Name = "Plague of Death" },
				}
			};
			return deck;
		}
		private static Deck ClownDruid()
		{
			var deck = new Deck
			{
				Name = "Clown Druid",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Nature Studies" },
					new Card { Name = "Guess the Weight" },
					new Card { Name = "Lunar Eclipse" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Overgrowth" },
					new Card { Name = "Anubisath Defender" },
					new Card { Name = "Nourish" },
					new Card { Name = "Overflow" },
					new Card { Name = "Strongman" },
					new Card { Name = "Umbral Owl" },
					new Card { Name = "Carnival Clown" },
					new Card { Name = "Survival of the Fittest" },
					new Card { Name = "Yogg-Saron, Master of Fate" },
					new Card { Name = "Y'Shaarj, the Defiler" },
				}
			};
			return deck;
		}
		private static Deck TreantDruid()
		{
			var deck = new Deck
			{
				Name = "Treant Druid",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					//new Card { Name = "Garden Gnome" },

					new Card { Name = "Innervate" },
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Nature Studies" },
					new Card { Name = "Guess the Weight" },
					new Card { Name = "Lunar Eclipse" },
					new Card { Name = "Solar Eclipse" },
					new Card { Name = "Fungal Fortunes" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "Overgrowth" },
					new Card { Name = "Soul of the Forest" },
					new Card { Name = "Aeroponics" },
					new Card { Name = "Arbor Up" },    //  mini-set
					new Card { Name = "Force of Nature" },
					new Card { Name = "Glowfly Swarm" },
					new Card { Name = "Runic Carvings" },
					new Card { Name = "Goru the Mightree" },

					//new Card { Name = "Gibberling" },
					//new Card { Name = "Treenforcements" },
					//new Card { Name = "Dreamway Guardians" },
					//new Card { Name = "Power of the Wild" },
					//new Card { Name = "Rising Winds" },
					//new Card { Name = "Blessing of the Ancients" },
					//new Card { Name = "BEEEES!!!" },
					//new Card { Name = "The Forest's Aid" },
				}
			};
			return deck;
		}
		private static Deck ControlWarlock()
		{
			var deck = new Deck
			{
				Name = "Control Warlock",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Silas Darkmoon" },
					new Card { Name = "Spirit Jailer" },
					new Card { Name = "Imprisoned Vilefiend" },
					new Card { Name = "Soul Shear" },
					new Card { Name = "Dark Skies" },
					new Card { Name = "Free Admission" },
					new Card { Name = "Man'ari Mosher" },
					new Card { Name = "Cascading Disaster" },
					new Card { Name = "Fire Breather" },
					new Card { Name = "Void Drinker" },
					new Card { Name = "Abyssal Summoner" },
					new Card { Name = "Aranasi Broodmother" },
					new Card { Name = "Tickatus" },
					new Card { Name = "Soulciologist Malicia" },
					new Card { Name = "Strongman" },
					new Card { Name = "Valdris Felgorge" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "Y'Shaarj, the Defiler" },
				}
			};
			deck.AddAdvice(
				"Druid",
				"Keep Twisting Nether for the Clowns");
			deck.AddAdvice(
				"Secret Mage",
				"use coin and coils to test for Counterspell");
			deck.AddAdvice(
				"Broom Paladin",
				"try to silence the Wisdoms");
			return deck;
		}
		private static Deck CThunRogue()
		{
			var deck = new Deck
			{
				Name = "CThun Rogue",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Pharaoh Cat" },
					new Card { Name = "Secret Passage" },
					new Card { Name = "Wand Thief" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Foxy Fraud" },
					new Card { Name = "Swindle" },
					new Card { Name = "Tenwu of the Red Smoke" },
					new Card { Name = "Cloak of Shadows" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "EVIL Miscreant" },
					new Card { Name = "Jandice Barov" },
					new Card { Name = "Malevolent Strike" },
					new Card { Name = "Stowaway" },
					new Card { Name = "Flik Skyshiv" },
					new Card { Name = "C'Thun, the Shattered" },
				}
			};
			return deck;
		}
		private static Deck DeathrattleHunter()
		{
			var deck = new Deck
			{
				Name = "Deathrattle Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Animated Broomstick" },
					new Card { Name = "Carrion Studies" },
					new Card { Name = "Mystery Winner" },
					new Card { Name = "Tracking" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Open the Cages" },
					new Card { Name = "Pack Tactics" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Inconspicuous Rider" },
					new Card { Name = "Petting Zoo" },
					new Card { Name = "Ursatron" },
					new Card { Name = "Rinling's Rifle" },
					new Card { Name = "Vectus" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Oblivitron" },
					new Card { Name = "Darkmoon Tonk" },
					new Card { Name = "Jewel of N'Zoth" },
				}
			};
			return deck;
		}
		private static Deck ElementalMage()
		{
			var deck = new Deck
			{
				Name = "Elemental Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Elemental Allies" },
					new Card { Name = "Lab Partner" },
					new Card { Name = "Magic Trick" },
					new Card { Name = "Primordial Studies" },
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Violet Spellwing" },
					new Card { Name = "Astromancer Solarian" },
					new Card { Name = "Confection Cyclone" },
					new Card { Name = "Cram Session" },
					new Card { Name = "Evocation" },
					new Card { Name = "Mana Cyclone" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Wandmaker" },
					new Card { Name = "Chenvaala" },
					new Card { Name = "Conjurer's Calling" },
					new Card { Name = "Ras Frostwhisper" },
					new Card { Name = "Mana Giant" },
					new Card { Name = "C'Thun, the Shattered" },
				}
			};
			return deck;
		}
		private static Deck EnhancementShaman()
		{
			var deck = new Deck
			{
				Name = "Enhancement Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Devolving Missiles" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Surging Tempest" },
					new Card { Name = "Cagematch Custodian" },
					new Card { Name = "Rockbiter Weapon" },
					new Card { Name = "Voracious Reader" },
					new Card { Name = "Instructor Fireheart" },
					new Card { Name = "Lava Burst" },
					new Card { Name = "Serpentshrine Portal" },
					new Card { Name = "Stormstrike" },
					new Card { Name = "Dunk Tank" },
					new Card { Name = "Torrent" },
					new Card { Name = "Cumulo-Maximus" },
					new Card { Name = "Doomhammer" },
					new Card { Name = "Inara Stormcrash" },
				}
			};
			return deck;
		}
		private static Deck EtcOtkWarrior()
		{
			var deck = new Deck
			{
				Name = "ETC OTK Warrior",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Animated Broomstick" },
					new Card { Name = "Pen Flinger" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Risky Skipper" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Armorsmith" },
					new Card { Name = "Battle Rage" },
					new Card { Name = "E.T.C., God of Metal" },
					new Card { Name = "Ancharrr" },
					new Card { Name = "Bladestorm" },
					new Card { Name = "Bloodsworn Mercenary" },
					new Card { Name = "Coerce" },
					new Card { Name = "Minefield" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "EVIL Quartermaster" },
					new Card { Name = "Lord Barov" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Sword Eater" },
					new Card { Name = "Brawl" },
					new Card { Name = "Cutting Class" },
					new Card { Name = "Galakrond, the Unbreakable" },
					new Card { Name = "Rattlegore" },
				}
			};
			return deck;
		}
		private static Deck EvolveShaman()
		{
			var deck = new Deck
			{
				Name = "Evolve Shaman",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Animated Broomstick" },
					new Card { Name = "Revolve" },
					new Card { Name = "Serpentine Portal" },
					new Card { Name = "Cagematch Custodian" },
					new Card { Name = "EVIL Cable Rat" },
					new Card { Name = "Bogstrok Clacker" },
					new Card { Name = "Desert Hare" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Pit Master" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Tour Guide" },
					new Card { Name = "Hoard Pillager" },
					new Card { Name = "Boggspine Knuckles" },
					new Card { Name = "Derailed Coaster" },
					new Card { Name = "Faceless Corruptor" },
					new Card { Name = "Mogu Fleshshaper" },
				}
			};
			deck.AddMulligans1(
				"Demonhunter",
				new List<string>
				{
					"Dread Corsair",
					"Sepentineshrine Portal",
					"Mogu Fleshshaper",
					"Cagematch Custodian",
					"Sludge Slurper",
					"Animated Broomstick",
					"Derailed Coaster",
				});
			deck.AddMulligans2(
				"Demonhunter",
				new List<string>
				{
					"Dread Corsair",
					"Bogspine Knuckles",
					"Sepentineshrine Portal",
					"Derailed Coaster",
					"Mogu Fleshshaper",
					"Sludge Slurper",
				});
			deck.AddMulligans1(
				"Druid",
				new List<string>
				{
					"Sepentineshrine Portal",
					"Cagematch Custodian",
					"Mogu Fleshshaper",
					"Tour Guide",
					"Evil Cable Rat",
					"Dread Corsair",
					"Desert Hare",
					"Derailed Coaster",
				});
			deck.AddMulligans2(
				"Druid",
				new List<string>
				{
					"Sludge Slurper",
					"Desert Hare",
					"Boggspine Knuckles",
					"Hoard Pillager",
					"Dread Corsair",
					"Mogu Fleshshaper",
					"Lightning Bloom",
				});
			deck.AddMulligans1(
				"Hunter",
				new List<string>
				{
					"Sepentineshrine Portal",
					"Animated Broomstick",
					"Mogu Fleshshaper",
					"Boggspine Knuckles",
					"Pit Master",
					"Bogstrok Clacker",
					"Sludge Slurper",
					"Tour Guide",
					"Cagematch Custodian",
					"Dread Corsair",
					"Hoard Pillager"
				});
			deck.AddMulligans2(
				"Hunter",
				new List<string>
				{
					"Sludge Slurper",
					"Mogu Fleshshaper",
					"Pit Master",
					"Tour Guide",
					"Lightning Bloom",
					"Dread Corsair",
				});
			deck.AddMulligans1(
				"Mage",
				new List<string>
				{
					"EVIL Cable Rat",
					"Dread Corsair",
					"Cagematch Custodian",
					"Bogspine Knuckles",
				});			
			deck.AddMulligans2(
				"Mage",
				new List<string>
				{
					"-EVIL Cable Rat",
					"-Pit Master",
					"-Bogstrok Clacker",
					"-Sea Giant",
					"-Hoard Pillager",
				});
			deck.AddMulligans1(
				"Paladin",
				new List<string>
				{
					"Dread Corair",
					"Animated Broomstick",
					"Bogspine Knuckles",
					"Mogu Fleshshaper",
					"Sea Giant",
					"Cagematch Custodian",
					"Sludge Slurper",
					"Tour Guide",
					"Bogstrok Clacker",
				});
			deck.AddMulligans2(
				"Paladin",
				new List<string>
				{
					"EVIL Cable Rat",
					"Animated Broomstick",
				});
			deck.AddMulligans1(
				"Priest",
				new List<string>
				{
					"Pit Master",
					"Bogspine Knuckles",
					"EVIL Cable Rat",
					"Dread Corair",
					"Cagematch Custodian",
					"Hoard Pillager",
					"Bogstrok Clacker",
					"Tour Guide",
				});
			deck.AddMulligans2(
				"Priest",
				new List<string>
				{
					"-Derailed Coaster",
					"-Pit Master",
					"-Lightning Bloom",
					"-Tour Guide",
					"-Bogstrok Clacker",
					"-Sludge Slurper",
					"-Mogu Fleshshaper",
				});
			deck.AddMulligans1(
				"Rogue",
				new List<string>
				{
					"-Mogu Fleshshaper",
					"-Animated Broomstick",
					"-Lightning Bloom",
					"-Hoard Pillager",
					"-Sea Giant",
				});
			deck.AddMulligans2(
				"Rogue",
				new List<string>
				{
					"Derailed Coaster",
					"Animated Broomstick",
					"Sea Giant",
					"Tour Guide",
					"Hoard Pillager",
					"Bogstrok Clacker",
					"Mogu Fleshshaper",
					 "EVIL Cable Rat"
				});
			deck.AddMulligans1(
				"Shaman",
				new List<string>
				{
					"-Pit Master",
					"-Lightning Bloom",
					"-Sepentineshrine Portal",
					"-Sea Giant",
					"-Hoard Pillager"
				});
			deck.AddMulligans2(
				"Shaman",
				new List<string>
				{
					"Lightning Bloom",
					"Dread Corsair",
					"Boggspine Knuckles",
				});
			deck.AddMulligans1(
				"Warlock",
				new List<string>
				{
					"Sludge Slurper",
					"Bogstrok Clacker",
					"Bogspine Knuckles",
					"Hoard Pillager",
					"Cagematch Custodian",
					"Mogu Fleshshaper",
				});
			deck.AddMulligans2(
				"Warlock",
				new List<string>
				{
					"Cagematch Custodian",
					"Bogspine Knuckles",
					"Animated Broomstick",
					"Dsert Hare",
					"Sea Giant",
					"Lightning Bloom"
				});
			deck.AddMulligans1(
				"Warrior",
				new List<string>
				{
					"Hoard Pillager",
					"Lightning Bloom",
					"Dread Corsair",
					"Cagematch Custodian",
					"Sea Giant",
					"Sludge Slurper",
				});
			deck.AddMulligans2(
				"Warrior",
				new List<string>
				{
					"-Pit Master",
					"-Hoard Pillager",
					"-Evil Cable Rat",
					"-Sepentineshrine Portal",
					"-Bogstrok Clacker",
					"-Lightning Bloom",
				});
			deck.AddAdvice(
				"Control Priest",
				"T5 will steal ur weapon");
			deck.AddAdvice(
				"Control Priest",
				"T7 will try to wipe board with Soul Mirror");
			deck.AddAdvice(
				"Druid",
				"Keep Lightning Bloom for Ramp");
			deck.AddAdvice(
				"Soul Demon Hunter",
				"Dont Overcommit into their AOE");

			return deck;
		}

		private static Deck TokenDemonHunter()
		{
			var deck = new Deck
			{
				Name = "Token Demon Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Battlefiend" },
					new Card { Name = "Twin Slice" },
					new Card { Name = "Ur'zul Horror" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Feast of Souls" },
					new Card { Name = "Sightless Watcher" },
					new Card { Name = "Umberwing" },
					new Card { Name = "Coordinated Strike" },
					new Card { Name = "Eye Beam" },
					new Card { Name = "Satyr Overseer" },
					new Card { Name = "Wrathscale Naga" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Illidari Felblade" },
					new Card { Name = "Command the Illidari" },
					new Card { Name = "Glaivebound Adept" },
					new Card { Name = "Nethrandamus" },
				}
			};
			return deck;
		}

		private static Deck BeastHunter()
		{
			var deck = new Deck
			{
				Name = "Beast Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Adorable Infestation" },
					new Card { Name = "Bestial Wrath" },
					new Card { Name = "Overwhelm" },
					new Card { Name = "Stonetusk Boar" },
					new Card { Name = "Trueaim Crescent" },
					new Card { Name = "Wolpertinger" },
					new Card { Name = "Don't Feed the Animals" },
					new Card { Name = "Fresh Scent" },
					new Card { Name = "Scavenger's Ingenuity" },
					new Card { Name = "Diving Gryphon" },
					new Card { Name = "Ramkahen Wildtamer" },
					new Card { Name = "Shan'do Wildclaw" },
					new Card { Name = "Vulpera Scoundrel" },
					new Card { Name = "Zixor, Apex Predator" },
					new Card { Name = "Scrap Shot" },
					new Card { Name = "Trampling Rhino" },
				}
			};
			return deck;
		}

		private static Deck VargothOTKMage()
		{
			var deck = new Deck
			{
				Name = "Vargoth OTK Mage",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Ray of Frost" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Ancient Mysteries" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Flame Ward" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Ice Barrier" },
					new Card { Name = "Archmage Vargoth" },
					new Card { Name = "Potion of Illusion" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Khartut Defender" },
					new Card { Name = "Sayge, Seer of Darkmoon" },
					new Card { Name = "Mask of C'Thun" },
					new Card { Name = "The Amazing Reno" },
					new Card { Name = "Yogg-Saron, Master of Fate" },
				}
			};
			return deck;
		}
		private static Deck LifestealDemonHunter()
		{
			var deck = new Deck
			{
				Name = "Lifesteal Demon Hunter",
				Prototype = "COMBO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Demonhunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Crimson Sigil Runner" },
					new Card { Name = "Double Jump" },
					new Card { Name = "Ethereal Augmerchant" },
					new Card { Name = "Felosophy" },
					new Card { Name = "Felscream Blast" },
					new Card { Name = "Mana Burn" },
					new Card { Name = "Twin Slice" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Immolation Aura" },
					new Card { Name = "Mo'arg Artificer" },
					new Card { Name = "Spectral Sight" },
					new Card { Name = "Acrobatics" },
					new Card { Name = "Aldrachi Warblades" },
					new Card { Name = "Eye Beam" },
					new Card { Name = "Il'gynoth" },
					new Card { Name = "Skull of Gul'dan" },
				}
			};
			return deck;
		}
		private static Deck MenagerieWarrior()
		{
			var deck = new Deck
			{
				Name = "Menagerie Warrior",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Bloodsail Corsair" },
					new Card { Name = "Hot Air Balloon" },
					new Card { Name = "Sky Raider" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Corsair Cache" },
					new Card { Name = "Parachute Brigand" },
					new Card { Name = "Prize Vendor" },
					new Card { Name = "Ringmaster's Baton" },
					new Card { Name = "Stage Hand" },
					new Card { Name = "Ancharrr" },
					new Card { Name = "Darkmoon Dirigible" },
					new Card { Name = "Skybarge" },
					new Card { Name = "Southsea Captain" },
					new Card { Name = "Circus Amalgam" },
					new Card { Name = "Sword Eater" },
					new Card { Name = "Ringmaster Whatley" },
					new Card { Name = "Tent Trasher" },
				}
			};
			return deck;
		}
		private static Deck PurePaladin()
		{
			var deck = new Deck
			{
				Name = "Pure Paladin",
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
					new Card { Name = "Murgur Murgurgle" },
					new Card { Name = "Goody Two-Shields" },
					new Card { Name = "Consecration" },
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
				"Soul Demon Hunter",
				"heal out of Ilgnoth range");
			deck.AddAdvice(
				"Soul Demon Hunter",
				"dance around blade dance");
			deck.AddAdvice(
				"Soul Demon Hunter",
				"save board clear for Malicia");
			deck.AddAdvice(
				"Evolve Shaman",
				"play uptempo and kill all minions on site");
			deck.AddAdvice(
				"Evolve Shaman",
				"save board clear for late game wide board");
			return deck;
		}
		private static Deck SecretFaceHunter()
		{
			var deck = new Deck
			{
				Name = "Secret Face Hunter",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Mystery Winner" },
					new Card { Name = "Tour Guide" },
					new Card { Name = "Wolpertinger" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Imprisoned Felmaw" },
					new Card { Name = "Open the Cages" },
					new Card { Name = "Phase Stalker" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Inconspicuous Rider" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Petting Zoo" },
					new Card { Name = "Dragonbane" },
					new Card { Name = "Hyena Alpha" },
					new Card { Name = "Rinling's Rifle" },
				}
			};
			return deck;
		}
		private static Deck SecretMage()
		{
			var deck = new Deck
			{
				Name = "Secret Mage",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Ancient Mysteries" },
					new Card { Name = "Apexis Smuggler" },
					new Card { Name = "Arcane Flakmage" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Game Master" },
					new Card { Name = "Counterspell" },
					new Card { Name = "Flame Ward" },
					new Card { Name = "Ice Barrier" },
					new Card { Name = "Inconspicuous Rider" },
					new Card { Name = "Kirin Tor Mage" },
					new Card { Name = "Mirror Entity" },
					new Card { Name = "Netherwind Portal" },
					new Card { Name = "Rigged Faire Game" },
					new Card { Name = "Fireball" },
					new Card { Name = "Occult Conjurer" },
					new Card { Name = "Cloud Prince" },
					new Card { Name = "Jandice Barov" },
					new Card { Name = "Sayge, Seer of Darkmoon" },
				}
			};
			return deck;
		}
		private static Deck SilverHandPaladin()
		{
			var deck = new Deck
			{
				Name = "Silver Hand Paladin",
				Prototype = "CONTROL",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "First Day of School" },
					new Card { Name = "Aldor Attendant" },
					new Card { Name = "Air Raid" },
					new Card { Name = "Hand of A'dal" },
					new Card { Name = "Libram of Wisdom" },
					new Card { Name = "Carnival Barker" },
					new Card { Name = "Day at the Faire" },
					new Card { Name = "Goody Two-Shields" },
					new Card { Name = "Balloon Merchant" },
					new Card { Name = "High Abbess Alura" },
					new Card { Name = "Lightforged Zealot" },
					new Card { Name = "Aldor Truthseeker" },
					new Card { Name = "Libram of Justice" },
					new Card { Name = "Lothraxion the Redeemed" },
					new Card { Name = "Lady Liadrin" },
					new Card { Name = "High Exarch Yrel" },
					new Card { Name = "Libram of Hope" },
				}
			};
			return deck;
		}
		#endregion

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
					new Card { Name = "Wrathspike Brute" },
					new Card { Name = "Priestess of Fury" },
					new Card { Name = "Hulking Overfiend" },
					new Card { Name = "Beaming Sidekick" },
					new Card { Name = "Guardian Augmerchant" },
					new Card { Name = "Twin Slice" },
					new Card { Name = "Bonechewer Brawler" },
					new Card { Name = "Chaos Strike" },
					new Card { Name = "Netherwalker" },
					new Card { Name = "Sightless Watcher" },
					new Card { Name = "Eye Beam" },
					new Card { Name = "Frozen Shadoweaver" },
					new Card { Name = "Satyr Overseer" },
					new Card { Name = "Vulpera Scoundrel" },
					new Card { Name = "Altruis the Outcast" },
					new Card { Name = "Ashtongue Battlelord" },
					new Card { Name = "Bone Wraith" },
					new Card { Name = "Kayn Sunfury" },
					new Card { Name = "Maiev Shadowsong" },
					new Card { Name = "Raging Felscreamer" },
					new Card { Name = "Glaivebound Adept" },
					new Card { Name = "Metamorphosis" },
					new Card { Name = "Warglaives of Azzinoth" },
					new Card { Name = "Skull of Gul'dan" },
					new Card { Name = "Siamat" },
					new Card { Name = "Coilfang Warlord" },
					new Card { Name = "Dragonqueen Alexstrasza" },
				}
			};
		}

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
					new Card { Name = "Lightning Bloom" },
					new Card { Name = "Earth Shock" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Sludge Slurper" },
					new Card { Name = "Surging Tempest" },
					new Card { Name = "Cagematch Custodian" },
					new Card { Name = "Diligent Notetaker" },
					new Card { Name = "Rockbiter Weapon" },
					new Card { Name = "Instructor Fireheart" },
					new Card { Name = "Lava Burst" },
					new Card { Name = "Serpentine Portal" },
					new Card { Name = "Stormstrike" },
					new Card { Name = "Dunk Tank" },
					new Card { Name = "Torrent" },
					new Card { Name = "Cumulo-Maximus" },
					new Card { Name = "Doomhammer" },
					new Card { Name = "Inara Stormcrash" },

					//new Card { Name = "Voltaic Burst" },
					//new Card { Name = "EVIL Totem" },
					//new Card { Name = "Earthen Might" },
					//new Card { Name = "Likkim" },
					//new Card { Name = "Soul of the Murloc" },
					//new Card { Name = "Haunting Visions" },
					//new Card { Name = "SN1P-SN4P" },
					//new Card { Name = "Spirit of the Frog" },
					//new Card { Name = "Hex" },
					//new Card { Name = "Thunderhead" },
					//new Card { Name = "Vessina" },
					//new Card { Name = "Bloodlust" },
					//new Card { Name = "Faceless Corruptor" },
					//new Card { Name = "Sea Giant" },
				}
			};
		}

	}
}
