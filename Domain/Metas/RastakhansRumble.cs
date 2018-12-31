using System.Collections.Generic;

namespace Domain.Metas
{
	public static class RastakhansRumble
	{
		public static Meta LoadMeta()
		{
			var meta = new Meta(
				code: "RR",
				name: "Rastakhans Rumble");

			//  TIER 1
			meta.AddDeck(SpellHunter());
			meta.AddDeck(DeathrattleHunter());
			meta.AddDeck(EvenPaladin());
			meta.AddDeck(SecretHunter());
			meta.AddDeck(OddQuestWarrior());
			meta.AddDeck(OddWarrior());
			meta.AddDeck(EvenWarlock());

			//  TIER 2
			meta.AddDeck(OtkDeathKnightPaladin());
			meta.AddDeck(QuestRogue());
			meta.AddDeck(ControlPriest());
			meta.AddDeck(MastersCallHunter());
			meta.AddDeck(ApmPriest());
			meta.AddDeck(EvenShaman());
			meta.AddDeck(Cubelock());
			meta.AddDeck(OddRogue());
			meta.AddDeck(ResurrectPriest());

			//  TIER 3
			meta.AddDeck(TempoRogue());
			meta.AddDeck(Zoolock());
			meta.AddDeck(AggroShaman());
			meta.AddDeck(OddMage());
			meta.AddDeck(TokenDruid());
			meta.AddDeck(TempoMage());
			meta.AddDeck(SpitefulDruid());
			meta.AddDeck(QuestMage());
			meta.AddDeck(MechathunPriest());
			meta.AddDeck(EggPaladin());
			meta.AddDeck(KingsbaneRogue());

			////  TIER 4
			meta.AddDeck(SpitefulPriest());
			meta.AddDeck(DeathrattleRogue());
			meta.AddDeck(TogwaggleDruid());
			meta.AddDeck(MalygosDruid());
			meta.AddDeck(TauntDruid());

			////  TIER 5
			meta.AddDeck(OddPaladin());
			return meta;
		}

		private static Deck TogwaggleDruid()
		{
			return new Deck
			{
				Name = "Togwaggle Druid",
				Prototype = "COMBO",
				Tier = 4,
				Rank = 30,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					//new Card { Name = "Biology Project" },
					new Card { Name = "Lesser Jasper Spellstone" },
					new Card { Name = "Naturalize" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Wild Growth" },
					//new Card { Name = "Bloodmage Thalnos" },
					//new Card { Name = "Wrath" },
					new Card { Name = "Branching Paths" },
					new Card { Name = "Ironwwod Golem" },
					new Card { Name = "Oaken Summons" },
					new Card { Name = "Swipe" },
					new Card { Name = "Twig of the World Tree" },
					new Card { Name = "Arcane Tyrant" },
					new Card { Name = "Starfall" },
					new Card { Name = "Nourish" },
					new Card { Name = "Spreading Plague" },
					new Card { Name = "Azalina Soulthief" },
					new Card { Name = "Dreampetal Florist" },
					new Card { Name = "Malfurion the Pestilent" },
					new Card { Name = "King Togwaggle" },
					new Card { Name = "Ultimate Infestation" },
				}
			};
		}

		private static Deck TokenDruid()
		{
			return new Deck
			{
				Name = "Token Druid",
				Prototype = "AGGRO",
				Tier = 3,
				Rank = 21,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
                    new Card { Name = "Dendrologist" },
					new Card { Name = "Power of the Wild" },
                    new Card { Name = "Greedy Sprite" },
                    new Card { Name = "Landscaping" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "Branching Paths" },
					new Card { Name = "Soul of the Forest" },
					new Card { Name = "Swipe" },
					new Card { Name = "Wispering Woods" },
					new Card { Name = "Arcane Tyrant" },
					new Card { Name = "Force of Nature" },
                    new Card { Name = "Living Mana" },
					new Card { Name = "Treespeaker" },
					new Card { Name = "Spreading Plague" },
                    new Card { Name = "Mulchmuncher" },
					new Card { Name = "Sea Giant" },
					new Card { Name = "Ultimate Infestation" },

					//new Card { Name = "Lesser Jasper Spellstone" },
					//new Card { Name = "Wild Growth" },
					////new Card { Name = "Wrath" },
					//new Card { Name = "Evolving Spores" },
					//new Card { Name = "Oaken Summons" },
					//new Card { Name = "Void Ripper" },
					//new Card { Name = "Violet Teacher" },
					//new Card { Name = "Giggling Inventor" },
					//new Card { Name = "Nourish" },
					//new Card { Name = "Malfurion the Pestilent" },
					//new Card { Name = "The Lich King" },
					//new Card { Name = "Starfall" },  // tech vs Aggro
                    //new Card { Name = "Naturalize" },  // tech vs Control
                }
			};
		}

		private static Deck Cubelock()
		{
			return new Deck
			{
				Name = "Cubelock",
				Prototype = "CONTROL",
				Tier = 2,
				Rank = 14,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Dark Pact" },
					new Card { Name = "Kobold Librarian" },
					//new Card { Name = "Mistress of Mixtures" },
					new Card { Name = "Defile" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Prince Taldaram" },
					new Card { Name = "Hellfire" },
					//new Card { Name = "Stonehill Defender" },
					new Card { Name = "Lesser Amethyst Spellstone" },
					new Card { Name = "Spiritsinger Umbra" },  
					new Card { Name = "Carnivorous Cube" },
					new Card { Name = "Doomguard" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Skull of the Man'ari" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Possessed Lackey" },
					new Card { Name = "Lord Godfrey" },  
					new Card { Name = "Voidlord" },
					new Card { Name = "Bloodreaver Gul'dan" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}

		private static Deck ControlWarlock()
		{
			return new Deck
			{
				Name = "Control Warlock",
				Prototype = "CONTROL",
				Tier = 2,
				Rank = 13,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Sacrificial Pact" },
					new Card { Name = "Kobold Librarian" },
					//new Card { Name = "Mistress of Mixtures" },
					//new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Defile" },
					new Card { Name = "Demonic Project" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Gnomeferatu" },
					new Card { Name = "Plated Beetle" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Stonehill Defender" },
					//new Card { Name = "Tar Creeper" },
					//new Card { Name = "Tinkmaster Overspark" },
					//new Card { Name = "Doomsayer" },  // tech vs agro
					new Card { Name = "Hellfire" },
					new Card { Name = "Lesser Amethyst Spellstone" },
					//new Card { Name = "Doomguard" },
					new Card { Name = "Shroom Brewer" },
					new Card { Name = "Giggling Inventor" },
					new Card { Name = "Skull of the Man'ari" },
					//new Card { Name = "Possessed Lackey" },
					new Card { Name = "Skulking Geist" },
					new Card { Name = "Siphon Soul" },
					new Card { Name = "Lord Godfrey" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "Voidlord" },
					new Card { Name = "Bloodreaver Gul'dan" },
				}
			};
		}

		private static Deck MechathunWarlock()
		{
			return new Deck
			{
				Name = "Mechathun Warlock",
				Prototype = "CONTROL",
				Tier = 4,
				Rank = 26,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					//new Card { Name = "Sacrificial Pact" },
					new Card { Name = "Kobold Librarian" },
					new Card { Name = "Mortal Coil" },
					new Card { Name = "The Soularium" },
					new Card { Name = "Bloodbloom" },
					new Card { Name = "Bloodmage Thalnos" },
					//new Card { Name = "Mistress of Mixtures" },
					//new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Defile" },
					//new Card { Name = "Demonic Project" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Galvanizer" },
					//new Card { Name = "Gnomeferatu" },
					//new Card { Name = "Plated Beetle" },
					//new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Stonehill Defender" },
					//new Card { Name = "Tar Creeper" },
					//new Card { Name = "Tinkmaster Overspark" },
					new Card { Name = "Voodoo Doll" },
					new Card { Name = "Cataclysm" },
					new Card { Name = "Hellfire" },
					new Card { Name = "Lesser Amethyst Spellstone" },
					//new Card { Name = "Doomguard" },
					new Card { Name = "Shroom Brewer" },
					new Card { Name = "Witchwood Piper" },
					//new Card { Name = "Giggling Inventor" },
					//new Card { Name = "Skull of the Man'ari" },
					//new Card { Name = "Possessed Lackey" },
					//new Card { Name = "Skulking Geist" },
					new Card { Name = "Siphon Soul" },
					new Card { Name = "Lord Godfrey" },
					new Card { Name = "Twisting Nether" },
					//new Card { Name = "Voidlord" },
					//new Card { Name = "Bloodreaver Gul'dan" },
					new Card { Name = "Mecha'thun" },
				}
			};
		}

		private static Deck MiracleRogue()
		{
			return new Deck
			{
				Name = "Miracle Rogue",
				Prototype = "TEMPO",
				Tier = 3,
				Rank = 19,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					//new Card { Name = "Counterfeit Coin" },
					new Card { Name = "Preparation" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Fire Fly" },
					//new Card { Name = "Hallucination" },
					//new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Augmented Elekk" },
					//new Card { Name = "Shiv" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "Fan of Knives" },
					new Card { Name = "Hench-Clan Thug" },  // IN
					//new Card { Name = "SI:7 Agent" },
					new Card { Name = "Elven Minstrel" },
					new Card { Name = "Fal'dorei Strider" },
					new Card { Name = "Giggling Inventor" },  // IN
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Vilespine Slayer" },
					//new Card { Name = "Gadgetzan Auctioneer" },
					new Card { Name = "Mossy Horror" },
					new Card { Name = "Sprint" },
				}
			};
		}

		private static Deck TempoRogue()
		{
			return new Deck
			{
				Name = "Tempo Rogue",
				Prototype = "TEMPO",
				Tier = 3,
				Rank = 17,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Prince Keleseth" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "Hench-Clan Thug" },  
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Elven Minstrel" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Spirit of the Shark" },
					new Card { Name = "Fungalmancer" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Vilespine Slayer" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mojomaster Zihi" },
					new Card { Name = "The Lich King" },
				}
			};
		}

		private static Deck PogoRogue()
		{
			return new Deck
			{
				Name = "Pogo Rogue",
				Prototype = "TEMPO",
				Tier = 4,
				Rank = 28,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					//new Card { Name = "Counterfeit Coin" },
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					//new Card { Name = "Cold Blood" },
					//new Card { Name = "Fire Fly" },
					//new Card { Name = "Hallucination" },
					//new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Lab Recruiter" },
					new Card { Name = "Pogo-Hopper" },
					new Card { Name = "Sap" },
					new Card { Name = "Augmented Elekk" },
					//new Card { Name = "Shiv" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "Fan of Knives" },
					//new Card { Name = "Hench-Clan Thug" },  // IN
					//new Card { Name = "SI:7 Agent" },
					new Card { Name = "Academic Espionage" },
					new Card { Name = "Elven Minstrel" },
					new Card { Name = "Fal'dorei Strider" },
					new Card { Name = "Giggling Inventor" },
					new Card { Name = "Myra's Unstable Element" },
					//new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Vilespine Slayer" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Gadgetzan Auctioneer" },
					new Card { Name = "Valeera the Hollow" },
					//new Card { Name = "Sprint" },
				}
			};
		}

		private static Deck KingsbaneRogue()
		{
			return new Deck
			{
				Name = "Kingsbane Rogue",
				Prototype = "AGGRO",
				Tier = 3,
				Rank = 27,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Fire Fly" },
					//new Card { Name = "Preparation" },
					//new Card { Name = "Doomerang" },
					new Card { Name = "Kingsbane" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Cavern Shinyfinder" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Toxicologist" },
					new Card { Name = "Cutthroat Buccaneer" },
					new Card { Name = "Hench-Clan Thug" },
					//new Card { Name = "Hallucination" },
					//new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Raiding Party" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Captain Greenskin" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Myra's Unstable Element" },
					new Card { Name = "Vilespine Slayer" },

					//new Card { Name = "Leeching Poison" },
					//new Card { Name = "Lorewalker Cho" },
					//new Card { Name = "Sap" },
					//new Card { Name = "Blade Flurry" },
					//new Card { Name = "Shiv" },
					//new Card { Name = "Edwin VanCleef" },
					//new Card { Name = "Fan of Knives" },
					//new Card { Name = "Elven Minstrel" },
					//new Card { Name = "Fal'dorei Strider" },
					//new Card { Name = "Leeroy Jenkins" },
					//new Card { Name = "Gadgetzan Auctioneer" },
					//new Card { Name = "Vanish" },
					//new Card { Name = "Sprint" },
					//new Card { Name = "Valeera the Hollow" },
				}
			};
		}

		private static Deck ComboShudderwock()
		{
			return new Deck
			{
				Name = "Combo Shudderwock Shaman",
				Prototype = "COMBO",
				Tier = 2,
				Rank = 15,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					//new Card { Name = "Zap!" },
					new Card { Name = "Earth Shock" },
					new Card { Name = "Glacial Shard" },
					//new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Prince Keleseth" },
					//new Card { Name = "Murmuring Elemental" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Electra Stormsurge" },
					new Card { Name = "Far Sight" },
					//new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Healing Rain" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Mana Tide Totem" },
					new Card { Name = "Mind Control Tech" },
					//new Card { Name = "Hemet Jungle Hunter" },
					//new Card { Name = "Zola the Gorgon" },
					new Card { Name = "Hex" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Sandbinder" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Storm Chaser" },
					new Card { Name = "Volcano" },
					new Card { Name = "Grumble Worldshaker" },
					new Card { Name = "Hagatha The Witch" },
					new Card { Name = "Shudderwock" },
					//new Card { Name = "Tar Creeper" },   // tech vs aggro
				}
			};
		}

		private static Deck TempoShudderwock()
		{
			return new Deck
			{
				Name = "Shudderwock Shaman",
				Prototype = "TEMPO",
				Tier = 2,
				Rank = 1,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					//new Card { Name = "Zap!" },
					new Card { Name = "Fire Fly" },
					//new Card { Name = "Glacial Shard" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Unstable Evolution" },
					new Card { Name = "Prince Keleseth" },
					new Card { Name = "Electra Stormsurge" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Hex" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Fungalmancer" },
					new Card { Name = "Giggling Inventor" },
					new Card { Name = "Thrall Deathseer" },
					//new Card { Name = "Wild Pyromancer" },
					//new Card { Name = "Murmuring Elemental" },
					new Card { Name = "Corridor Creeper" },
					new Card { Name = "Hagatha The Witch" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Kalimos Primal Lord" },
					//new Card { Name = "Healing Rain" },
					//new Card { Name = "Mana Tide Totem" },
					//new Card { Name = "Hemet Jungle Hunter" },
					//new Card { Name = "Zola the Gorgon" },
					//new Card { Name = "Lifedrinker" },
					//new Card { Name = "Sandbinder" },
					//new Card { Name = "Volcano" },
					//new Card { Name = "Grumble Worldshaker" },
					new Card { Name = "Shudderwock" },
					//new Card { Name = "Tar Creeper" },   // tech vs aggro
				}
			};
		}

		private static Deck TauntDruid()
		{
			return new Deck
			{
				Name = "Taunt Druid",
				Prototype = "CONTROL",
				Tier = 4,
				Rank = 32,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Lesser Jasper Spellstone" },
					new Card { Name = "Naturalize" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Savage Roar" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Astral Tiger" },
					new Card { Name = "Branching Paths" },
					new Card { Name = "Ironwood Golem" },
					new Card { Name = "Oaken Summons" },
					new Card { Name = "Swipe" },
					new Card { Name = "Nourish" },
					new Card { Name = "Spreading Plague" },
					new Card { Name = "Amani War Bear" },
					new Card { Name = "Malfurion the Pestilent" },
					new Card { Name = "Da Undatakah" },
					new Card { Name = "Mosh'ogg Enforcer" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Hadronox" },
					new Card { Name = "Master Oakheart" },
					//new Card { Name = "Wrath" },
					//new Card { Name = "Witching Hour" },
					//new Card { Name = "Carnivorous Cube" },
					//new Card { Name = "Primordial Drake" },
					//new Card { Name = "Dragonhatcher" },
					//new Card { Name = "Sleepy Dragon" },
					//new Card { Name = "Ultimate Infestation" },
				}
			};
		}

		private static Deck BigDruid()
		{
			return new Deck
			{
				Name = "Big Druid",
				Prototype = "CONTROL",
				Tier = 2,
				Rank = 16,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Biology Project" },
					new Card { Name = "Lesser Jasper Spellstone" },
					new Card { Name = "Naturalize" },
					new Card { Name = "Wild Growth" },
					//new Card { Name = "Wrath" },
					new Card { Name = "Drakkari Enchanter" },
					new Card { Name = "Greedy Sprite" },
					new Card { Name = "Branching Paths" },
					new Card { Name = "Bright-Eyed Scout" },
					//new Card { Name = "Oaken Summons" },
					//new Card { Name = "Swipe" },
					//new Card { Name = "Carnivorous Cube" },
					new Card { Name = "Nourish" },
					new Card { Name = "Spreading Plague" },
					new Card { Name = "Malfurion the Pestilent" },
					new Card { Name = "Gloop Sprayer" },
					new Card { Name = "Primordial Drake" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Dragonhatcher" },
					new Card { Name = "Hadronox" },
					new Card { Name = "Master Oakheart" },
					new Card { Name = "Sleepy Dragon" },
					new Card { Name = "Ysera" },
					new Card { Name = "Tyrantus" }
				}
			};
		}

		private static Deck EvenWarlock()
		{
			return new Deck
			{
				Name = "Even Warlock",
				Prototype = "AGGRO",
				Tier = 1,
				Rank = 7,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Defile" },
					new Card { Name = "Soup Vendor" },
					//new Card { Name = "Doomsayer" },
					//new Card { Name = "Plated Beetle" },
					new Card { Name = "Sunfury Protector" },
					new Card { Name = "Vulgar Homunculus" },
					new Card { Name = "Hellfire" },
					new Card { Name = "Hooked Reaver" },
					new Card { Name = "Lesser Amethyst Spellstone" },
					//new Card { Name = "Shadowflame" },
					new Card { Name = "Shroom Brewer" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Dread Infernal" },
					new Card { Name = "Genn Greymane" },
					//new Card { Name = "Mossy Horror" },
					new Card { Name = "Mojomaster Zihi" },
					//new Card { Name = "Skulking Geist" },
					new Card { Name = "Nerubian Unraveler" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Bloodreaver Gul'dan" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}

		private static Deck SecretHunter()
		{
			return new Deck
			{
				Name = "Secret Hunter",
				Prototype = "TEMPO",
				Tier = 1,
				Rank = 4,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					//new Card { Name = "Arcane Shot" },
					new Card { Name = "Candleshot" },
					new Card { Name = "Secretkeeper" },
					//new Card { Name = "Hunter's Mark" },
					new Card { Name = "Tracking" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					//new Card { Name = "Grievous Bite" },
					new Card { Name = "Rat Trap" },
					new Card { Name = "Snake Trap" },
					new Card { Name = "Snipe" },
					new Card { Name = "Venomstrike Trap" },
					new Card { Name = "Wandering Monster" },
					new Card { Name = "Bloodscalp Strategist" },  // new
					new Card { Name = "Animal Companion" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Masked Contender" },  // new

					//new Card { Name = "Stitched Tracker" },
					//new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Flanking Strike" },
					//new Card { Name = "Professor Putricide" },
					new Card { Name = "Lesser Emerald Spellstone" },
					new Card { Name = "Deathstalker Rexxar" },
					new Card { Name = "Subject 9" },
					//new Card { Name = "Mossy Horror" },
					new Card { Name = "Zul'jin" },  // new

					//new Card { Name = "To My Side!" },
					//new Card { Name = "Rhok'delar" },
				}
			};
		}

		private static Deck SpellHunter()
		{
			return new Deck
			{
				Name = "Spell Hunter",
				Prototype = "TEMPO",
				Tier = 1,
				Rank = 1,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					//new Card { Name = "Arcane Shot" },
					new Card { Name = "Candleshot" },
					new Card { Name = "Hunter's Mark" },
					new Card { Name = "Secret Plan" },  // new
					new Card { Name = "Tracking" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Snake Trap" },   //  added
					//new Card { Name = "Grievous Bite" },
					//new Card { Name = "Snipe" },
					new Card { Name = "Wandering Monster" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Deadly Shot" },   //  added
					//new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Flanking Strike" },
					new Card { Name = "Lesser Emerald Spellstone" },
					new Card { Name = "Deathstalker Rexxar" },
					new Card { Name = "To My Side!" },
					new Card { Name = "Rhok'delar" },
					new Card { Name = "Zul'jin" },  // new
				}
			};
		}

		private static Deck DeathrattleHunter()
		{
			return new Deck
			{
				Name = "Deathrattle Hunter",
				Prototype = "TEMPO",
				Tier = 1,
				Rank = 2,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					//new Card { Name = "Arcane Shot" },
					new Card { Name = "Candleshot" },
					new Card { Name = "Hunter's Mark" },
					new Card { Name = "Tracking" },
					new Card { Name = "Play Dead" },
					new Card { Name = "Prince Keleseth" },  //  added
					//new Card { Name = "Explosive Trap" },
					//new Card { Name = "Fireworks Tech" },
					//new Card { Name = "Loot Hoarder" },
					//new Card { Name = "Sunfury Protector" },
					new Card { Name = "Devilsaur Egg" },
					new Card { Name = "Spider Bomb" },
					new Card { Name = "Stitched Tracker" },
					new Card { Name = "Terrorscale Stalker" },
					//new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Flanking Strike" },
					new Card { Name = "Houndmaster Shaw" },
					new Card { Name = "Carnivorous Cube" },
					new Card { Name = "Witchwood Grizzly" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Deathstalker Rexxar" },
					//new Card { Name = "Mechanical Whelp" },
					//new Card { Name = "Mossy Horror" },
					new Card { Name = "Charged Devisaur" },
					new Card { Name = "Kathrena Winterwisp" },
					new Card { Name = "King Krush" },
					new Card { Name = "Oondasta" },  //  new
				}
			};
		}

		private static Deck EvenShaman()
		{
			return new Deck
			{
				Name = "Even Shaman",
				Prototype = "TEMPO",
				Tier = 2,
				Rank = 13,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Dire Wolf Alpha" },
					new Card { Name = "Earthen Might" },
					new Card { Name = "Flametongue Totem" },
					//new Card { Name = "Knife Jugger" },
					new Card { Name = "Menacing Nimbus" },
					new Card { Name = "Murkspark Eel" },
					new Card { Name = "Primalfin Totem" },
					new Card { Name = "Scarab Egg" },

					//new Card { Name = "Stormforged Axe" },
					new Card { Name = "Vicious Scalehide" },
					new Card { Name = "Corpsetaker" },
					//new Card { Name = "Fire Plume Phoenix" },
					new Card { Name = "Hex" },
					new Card { Name = "Saronite Chain Gang" },
					//new Card { Name = "Spellbreaker" },
					new Card { Name = "Argent Commander" },

					//new Card { Name = "Thunderhead" },
					//new Card { Name = "Arcane Dynamo" },
					new Card { Name = "Fire Elemental" },
					new Card { Name = "Genn Greymane" },
					new Card { Name = "Al'Akir the Windlord" },
					new Card { Name = "Hagatha The Witch" },
					//new Card { Name = "Kalimos Primal Lord" },
					//new Card { Name = "The Runespear" },
					new Card { Name = "The Lich King" },

					new Card { Name = "Sea Giant" },
					//new Card { Name = "Primalfin Totem" },
					//new Card { Name = "Grumble Worldshaker" },

					//new Card { Name = "Plated Beetle" },   // tech vs aggro
					//new Card { Name = "Argent Commander" },   // tech vs control
				}
			};
		}

		private static Deck AggroShaman()
		{
			return new Deck
			{
				Name = "Aggro Shaman",
				Prototype = "TEMPO",
				Tier = 3,
				Rank = 19,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Zap!" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Glacial Shard" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Totemic Smash" },
					new Card { Name = "Voltaic Burst" },
					new Card { Name = "Earthen Might" },
					new Card { Name = "Flametongue Totem" },
					new Card { Name = "Likkim" },
					new Card { Name = "Rockbiter Weapon" },
					new Card { Name = "Electra Stormsurge" },
					new Card { Name = "Lava Burst" },
					new Card { Name = "Spirit of the Frog" },
					new Card { Name = "Unbound Elemental" },
					new Card { Name = "Zentimo" },
					new Card { Name = "Thunderhead" },
					new Card { Name = "Doomhammer" },
				}
			};
		}

		private static Deck OddRogue()
		{
			return new Deck
			{
				Name = "Odd Rogue",
				Prototype = "AGGRO",
				Tier = 2,
				Rank = 15,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Argent Squire" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Crystallizer" },
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Dire Mole" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Hench-Clan Thug" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Vicious Fledgling" },
					new Card { Name = "Void Ripper" },
					new Card { Name = "Colbalt Scalebane" },
					new Card { Name = "Fungalmancer" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Myra's Unstable Element" },
					new Card { Name = "Vilespine Slayer" },
					new Card { Name = "Baku the Mooneater" },

					//new Card { Name = "Blink Fox" },
					//new Card { Name = "Blood Knight" },
					//new Card { Name = "Edwin VanCleef" },
//					new Card { Name = "Ironbeak Owl" },
//					new Card { Name = "Giggling Inventor" },
				}
			};
		}

		private static Deck AggroMage()
		{
			return new Deck
			{
				Name = "Aggro Mage",
				Prototype = "AGGRO",
				Tier = 2,
				Rank = 10,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Missiles" },
					new Card { Name = "Mana Wyrm" },
					new Card { Name = "Shooting Star" },
					new Card { Name = "Arcanologist" },
					new Card { Name = "Celestial Emissary" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Primordial Glyph" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Cinderstorm" },
					new Card { Name = "Counterspell" },
					new Card { Name = "Explosive Runes" },
					new Card { Name = "Kirin Tor Mage" },
					new Card { Name = "Stargazer Luna" },
					new Card { Name = "Cosmic Anomaly" },
					new Card { Name = "Fireball" },
					new Card { Name = "Aluneth" },
					//new Card { Name = "Pyroblast" },
				}
			};
		}

		private static Deck TempoMage()
		{
			return new Deck
			{
				Name = "Aggro Mage",
				Prototype = "AGGRO",
				Tier = 3,
				Rank = 22,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Missiles" },
					//new Card { Name = "Mana Wyrm" },
					new Card { Name = "Shooting Star" },
					new Card { Name = "Arcanologist" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Mana Addict" },
					new Card { Name = "Primordial Glyph" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Spellzerker" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Cinderstorm" },
					new Card { Name = "Counterspell" },
					new Card { Name = "Explosive Runes" },
					new Card { Name = "Kirin Tor Mage" },
					new Card { Name = "Stargazer Luna" },
					new Card { Name = "Cosmic Anomaly" },
					new Card { Name = "Fireball" },

					//new Card { Name = "Celestial Emissary" },
					new Card { Name = "Aluneth" },
					//new Card { Name = "Pyroblast" },
				}
			};
		}

		private static Deck MalygosDruid()
		{
			return new Deck
			{
				Name = "Malygos Druid",
				Prototype = "CONTROL",
				Tier = 4,
				Rank = 31,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					//new Card { Name = "Innervate" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Lesser Jasper Spellstone" },
					//new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Naturalize" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Branching Paths" },
					new Card { Name = "Flobbidinous Floop" },
					new Card { Name = "Swipe" },
					new Card { Name = "Twig Of The World Tree" },
					new Card { Name = "Arcane Tyrant" },
					new Card { Name = "Nourish" },
					new Card { Name = "Spreading Plague" },
					new Card { Name = "Dreampetal Florist" },
					new Card { Name = "Malfurion the Pestilent" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Malygos" },
					new Card { Name = "Ultimate Infestation" },

					//new Card { Name = "Wrath" },
//					new Card { Name = "Prince Taldaram" },
					//new Card { Name = "Prince Kobold" },
					//new Card { Name = "Juicy Psychmelon" },
					//new Card { Name = "Faceless Manipulator" },
					//new Card { Name = "Starfall" },
					//new Card { Name = "Dragonhatcher" },
				}
			};
		}

		private static Deck RecruitWarrior()
		{
			return new Deck
			{
				Name = "Recruit Warrior",
				Prototype = "CONTROL",
				Tier = 3,
				Rank = 22,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					//new Card { Name = "Iron Hide" },
					new Card { Name = "Shield Slam" },
					//new Card { Name = "Bring It On!" },
					new Card { Name = "Dead Man's Hand" },
					new Card { Name = "Execute" },
					new Card { Name = "Forge Of Souls" },
					//new Card { Name = "Slam" },
					new Card { Name = "Warpath" },
					new Card { Name = "Weapons Project" },
					new Card { Name = "Reckless Flurry" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Blood Razor" },
					new Card { Name = "Brawl" },
					new Card { Name = "Damaged Stegotron" },
					new Card { Name = "Gather Your Party" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					//new Card { Name = "Geosculptor Yip" },
					new Card { Name = "Grommash Hellscream" },
					new Card { Name = "Rotface" },
					new Card { Name = "Scourgelord Garrosh" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Woecleaver" },
					new Card { Name = "Bull Dozer" },
					new Card { Name = "The Boomship" },
					//new Card { Name = "Ysera" },
				}
			};
		}

		private static Deck ControlPriest()
		{
			return new Deck
			{
				Name = "Control Priest",
				Prototype = "CONTROL",
				Tier = 2,
				Rank = 10,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Firetree Witchdoctor" },
//					new Card { Name = "Divine Hymn" },
					new Card { Name = "Mind Blast" },
					new Card { Name = "Shadow Visions" },
					//new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Twilight Acolyte" },
					new Card { Name = "Duskbreaker" },
					//new Card { Name = "Mass Dispel" },
					new Card { Name = "Scaleworm" },

					//new Card { Name = "Shadow Word: Horror" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Cabal Shadow Priest" },
					new Card { Name = "Holy Fire" },
					new Card { Name = "Archbishop Benedictus" },
					new Card { Name = "Crowd Roaster" },
					new Card { Name = "Psychic Scream" },
					//new Card { Name = "Primordial Drake" },
					new Card { Name = "Shadowreaper Anduin" },
					new Card { Name = "Alexstraza" },
				}
			};
		}

		private static Deck SpitefulPriest()
		{
			return new Deck
			{
				Name = "Spiteful Priest",
				Prototype = "CONTROL",
				Tier = 4,
				Rank = 28,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Prince Keleseth" },
					new Card { Name = "Curious Glimmerroot" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Twilight Acolyte" },
					new Card { Name = "Duskbreaker" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Cobalt Scalebane" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Bone Drake" },
					new Card { Name = "Cabal Shadow Priest" },
					new Card { Name = "Crowd Roaster" },
					new Card { Name = "Spiteful Summoner" },
					new Card { Name = "Princess Talanji" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Mind Control" },
				}
			};
		}

		private static Deck MechathunPriest()
		{
			return new Deck
			{
				Name = "Mechathun Priest",
				Prototype = "CONTROL",
				Tier = 3,
				Rank = 25,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Circle of Healing" },
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Dead Ringer" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Plated Beetle" },
					new Card { Name = "Radient Elemental" },
					//new Card { Name = "Divine Hymn" },
					//new Card { Name = "Mind Blast" },
					new Card { Name = "Shadow Visions" },
					new Card { Name = "Spirit Lash" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Twilight's Call" },
					new Card { Name = "Ticking Abomination" },
					new Card { Name = "Reckless Experimenter" },
					new Card { Name = "Coffin Crasher" },
					//new Card { Name = "Twilight Acolyte" },
					//new Card { Name = "Duskbreaker" },
					//new Card { Name = "Mass Dispel" },
					//new Card { Name = "Twilight Drake" },
					new Card { Name = "Hemet Jungle Hunter" },
					new Card { Name = "Psychic Scream" },
					//new Card { Name = "Silence" },
					new Card { Name = "Mecha'thun" }
				}
			};
		}

		private static Deck OddFatigueWarrior()
		{
			return new Deck
			{
				Name = "Odd Fatigue Warrior",
				Prototype = "CONTROL",
				Tier = 3,
				Rank = 17,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Eternium Rover" },
					new Card { Name = "Omega Assembly" },
					new Card { Name = "Shield Slam" },
					//new Card { Name = "Town Crier" },
					new Card { Name = "Whirlwind" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Ironbeak Owl" },
					//new Card { Name = "Rabid Worgen" },
					new Card { Name = "Reckless Flurry" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Big Game Hunter" },
					new Card { Name = "Brawl" },
					//new Card { Name = "Darius Crowley" },
					new Card { Name = "Direhorn Hatchling" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Giggling Inventor" },
					//new Card { Name = "Elise the Trailblazer" },
					//new Card { Name = "Faceless Manipulator" },
					//new Card { Name = "Harrison Jones" },
					//new Card { Name = "Azina Soulthief" },
					new Card { Name = "Baron Geddon" },
					new Card { Name = "Beryllium Nullifier" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Gorehowl" },
					new Card { Name = "Baku the Mooneater" },
					new Card { Name = "King Mosh" },
				}
			};
		}

		private static Deck OddQuestWarrior()
		{
			return new Deck
			{
				Name = "Odd Quest Warrior",
				Prototype = "CONTROL",
				Tier = 1,
				Rank = 5,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Fire Plume's Heart" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Phantom Militia" },
					new Card { Name = "Reckless Flurry" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Brawl" },
					new Card { Name = "Direhorn Hatchling" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Witchwood Grizzly" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Amani War Bear" },
					new Card { Name = "Baku the Mooneater" },
					new Card { Name = "Oondasta" },
				}
			};
		}

		private static Deck OddWarrior()
		{
			return new Deck
			{
				Name = "Odd Warrior",
				Prototype = "CONTROL",
				Tier = 1,
				Rank = 6,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Omega Assembly" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Ironbeak Owl" },
					new Card { Name = "Reckless Flurry" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Smolderthorn Lancer" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Brawl" },
					new Card { Name = "Direhorn Hatchling" },
					new Card { Name = "Dragonmaw Scorcher" },
					new Card { Name = "Dyn-o-matic" },
					new Card { Name = "Emberscale Drake" },
					new Card { Name = "Supercollider" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Crowd Roaster" },
					new Card { Name = "Dr. Boom, Mad Genius" },
					new Card { Name = "Baku the Mooneater" },
				}
			};
		}

		private static Deck QuestWarrior()
		{
			return new Deck
			{
				Name = "Quest Warrior",
				Prototype = "CONTROL",
				Tier = 3,
				Rank = 17,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Fire Plume's Heart" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Whirlwind" },
					new Card { Name = "Cornered Sentry" },
					new Card { Name = "Drywhisker Armorer" },
					new Card { Name = "Execute" },
					new Card { Name = "Slam" },
					new Card { Name = "Warpath" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Phantom Militia" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Blood Razor" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Brawl" },
					new Card { Name = "Scourgelord Garrosh" },
				}
			};
		}

		private static Deck OtkDeathKnightPaladin()
		{
			return new Deck
			{
				Name = "OTK Death Knight Paladin",
				Prototype = "Combo",
				Tier = 2,
				Rank = 8,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Righteous Protector" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Crystalsmith Kangor" },
					new Card { Name = "Equality" },
					new Card { Name = "Flash of Light" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Youthful Brewmaster" },
					new Card { Name = "Time Out!" },
					new Card { Name = "Zola the Gorgon" },
					new Card { Name = "Ancient Brewmaster" },
					new Card { Name = "Consecration" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Call to Arms" },
					new Card { Name = "Spikeridged Steed" },
					new Card { Name = "Sunkeeper Tarim" },
					new Card { Name = "Lynessa Sunsorrow" },
					new Card { Name = "Uther of the Ebon Blade" },
					new Card { Name = "Shirvallah, the Tiger" },
				}
			};
		}

		private static Deck OddPaladin()
		{
			return new Deck
			{
				Name = "Odd Paladin",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 33,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					//new Card { Name = "Acherus Veteran" },
					//new Card { Name = "Argent Squire" },
					new Card { Name = "Blessing of Might" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Glow-Tron" },
					new Card { Name = "Lost in the Jungle" },
					new Card { Name = "Mecharoo" },
					new Card { Name = "Righteous Protector" },
					new Card { Name = "Divine Favor" },
					new Card { Name = "Raid Leader" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Unidentified Maul" },
					new Card { Name = "Void Ripper" },
					new Card { Name = "Fungalmancer" },
//					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Level Up!" },
					new Card { Name = "Wargear" },
					new Card { Name = "Corridor Creeper" },
					//new Card { Name = "Stormwind Champion" },
					new Card { Name = "Vinecleaver" },
					new Card { Name = "Baku the Mooneater" },
					//new Card { Name = "Witch's Cauldron" },  // tech vs Control
				}
			};
		}

		private static Deck EggPaladin()
		{
			return new Deck
			{
				Name = "Egg Paladin",
				Prototype = "COMBO",
				Tier = 3,
				Rank = 26,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Crystology" },
					new Card { Name = "Equality" },
					new Card { Name = "Hydrologist" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Annoy-o-Module" },
					new Card { Name = "Consecration" },
					new Card { Name = "Meat Wagon" },
					new Card { Name = "Spiritsinger Umbra" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Carnivorous Cube" },
					new Card { Name = "Mechano-Egg" },
					new Card { Name = "Shrink Ray" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mossy Horror" },
					new Card { Name = "Spikeridged Steed" },
					new Card { Name = "Sunkeeper Tarim" },
					new Card { Name = "Kangor's Endless Army" },
					new Card { Name = "Lay on Hands" },
					new Card { Name = "Uther of the Ebon Blade" },
				}
			};
		}

		private static Deck SpitefulDruid()
		{
			return new Deck
			{
				Name = "Spiteful Druid",
				Prototype = "TEMPO",
				Tier = 3,
				Rank = 23,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Fire Fly" },
					new Card { Name = "Glacial Shard" },
					new Card { Name = "Prince Keleseth" },
					new Card { Name = "Crypt Lord" },
					new Card { Name = "Druid of the Scythe" },
					new Card { Name = "Greedy Sprite" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Tar Creeper" },
					//new Card { Name = "Saronite Chain Gang" },
					//new Card { Name = "Mossy Horror" },  //  tech v aggro
					new Card { Name = "Vicious Fledgling" },
					new Card { Name = "Wardruid Loti" },
					new Card { Name = "Flobbidnous Floop" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Cobalt Scalebane" },
					new Card { Name = "Fungalmancer" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Nerubian Unraveler" },
					new Card { Name = "Malfurion the Pestilent" },
					new Card { Name = "Spiteful Summoner" },
					new Card { Name = "Grand Archivist" },

					//new Card { Name = "The Lich King" },
					new Card { Name = "Ultimate Infestation" },
				}
			};
		}

		private static Deck DinoDruid()
		{
			return new Deck
			{
				Name = "Dino Druid",
				Prototype = "TEMPO",
				Tier = 5,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Lesser Jasper Spellstone" },
					new Card { Name = "Naturalize" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Wrath" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Witching Hour" },
					new Card { Name = "Branching Paths" },
					new Card { Name = "Ironwood Golem" },
					new Card { Name = "Oaken Summons" },
					new Card { Name = "Swipe" },
					new Card { Name = "Arcane Tyrant" },
					new Card { Name = "Carnivorous Cube" },
					new Card { Name = "Nourish" },
					new Card { Name = "Silver Vanguard" },
					new Card { Name = "Charged Devilsaur" },
					new Card { Name = "Ultimate Infestation" },
				}
			};
		}

		private static Deck MechathunDruid()
		{
			return new Deck
			{
				Name = "Mechathun Druid",
				Prototype = "TEMPO",
				Tier = 4,
				Rank = 25,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Barkskin" },
					new Card { Name = "Biology Project" },
					new Card { Name = "Floop's Glorious Gloop" },
					new Card { Name = "Lesser Jasper Spellstone" },
					new Card { Name = "Naturalize" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Wrath" },
					new Card { Name = "Ferocious Howl" },
					//new Card { Name = "Witching Hour" },
					new Card { Name = "Branching Paths" },
					//new Card { Name = "Ironwood Golem" },
					new Card { Name = "Flobbidinous Floop" },
					//new Card { Name = "Oaken Summons" },
					new Card { Name = "Swipe" },
					//new Card { Name = "Arcane Tyrant" },
					//new Card { Name = "Carnivorous Cube" },
					new Card { Name = "Nourish" },
					new Card { Name = "Gadgetzan Auctioneer" },
					new Card { Name = "Malfurion the Pestilent" },
					//new Card { Name = "Ultimate Infestation" },
					new Card { Name = "Mecha'thun" },
				}
			};
		}

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
					new Card { Name = "Tome of Intellect" },
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

		private static Deck ControlMage()
		{
			return new Deck
			{
				Name = "Control Mage",
				Prototype = "CONTROL",
				Tier = 3,
				Rank = 20,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Artificer" },
					new Card { Name = "Doomsayer" },
					//new Card { Name = "Novice Engineer" },
					new Card { Name = "Raven Familiar" },
					//new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Gluttonous Ooze" },
					//new Card { Name = "Stonehill Defender" },
					new Card { Name = "Voodoo Doll" },
					new Card { Name = "Bright-Eyed Scout" },
					new Card { Name = "Tar Creeper" },  // tech v aggro
					new Card { Name = "Polymorph" },
					new Card { Name = "Arcane Tyrant" },
					new Card { Name = "Dragon's Fury" },
					new Card { Name = "Giggling Inventor" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Meteor" },
					new Card { Name = "Skulking Geist" },
					new Card { Name = "Astromancer" },
					new Card { Name = "Baron Geddon" },
					new Card { Name = "Flamestrike" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Dragoncaller Alanna" },
					new Card { Name = "Frost Lich Jaina" },
				}
			};
		}

		private static Deck OddMage()
		{
			return new Deck
			{
				Name = "Odd Mage",
				Prototype = "CONTROL",
				Tier = 3,
				Rank = 20,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Daring Fire-Eater" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Black Cat" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Pyromaniac" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Tar Creeper" },  
					new Card { Name = "Voodoo Doll" },
					new Card { Name = "Arcane Tyrant" },
					new Card { Name = "Blast Wave" },
					new Card { Name = "Dragon's Fury" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Astromancer" },
					new Card { Name = "Baron Geddon" },
					new Card { Name = "Flamestrike" },
				
					new Card { Name = "Jan'alai, the Dragonhawl" },
					new Card { Name = "Baku the Mooneater" },
					new Card { Name = "Frost Lich Jaina" },
				}
			};
		}

		private static Deck PocketMage()
		{
			return new Deck
			{
				Name = "Pocket Mage",
				Prototype = "CONTROL",
				Tier = 4,
				Rank = 27,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Mana Wyrm" },
					new Card { Name = "Mirror Image" },
					new Card { Name = "Shooting Star" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Primordial Glyph" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intelect" },
					new Card { Name = "Frost Nova" },
					new Card { Name = "Stargazer Luna" },
					new Card { Name = "Cosmic Anomaly" },
					new Card { Name = "Fireball" },
					//new Card { Name = "Polymorph" },
					//new Card { Name = "Arcane Tyrant" },
					//new Card { Name = "Dragon's Fury" },
					//new Card { Name = "Giggling Inventor" },
					//new Card { Name = "Blizzard" },
					new Card { Name = "Meteor" },
					new Card { Name = "Archmage Antonidas" },
					//new Card { Name = "Astromancer" },
					//new Card { Name = "Baron Geddon" },
					new Card { Name = "Flamestrike" },
					new Card { Name = "Luna's Pocket Galaxy" },
					new Card { Name = "Alexstrasza" },
					new Card { Name = "Malygos" },
					//new Card { Name = "Frost Lich Jaina" },
				}
			};
		}

		private static Deck RecruitHunter()
		{
			return new Deck
			{
				Name = "Recruit Hunter",
				Prototype = "TEMPO",
				Tier = 2,
				Rank = 11,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Candleshot" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Hunters Mark" },
					new Card { Name = "Play Dead" },
					new Card { Name = "Prince Keleseth" },
					//new Card { Name = "Explosive Trap" },
					//new Card { Name = "Freezing Trap" },
					//new Card { Name = "Wandering Monster" },
					//new Card { Name = "Crackling Razormaw" },
					//new Card { Name = "Animal Companion" },
					//new Card { Name = "Deadly Shot" },
					//new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Stitched Tracker" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Flanking Strike" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Houndmaster Shaw" },  // tech v A
					new Card { Name = "Witchwood Grizzly" },
					new Card { Name = "Deathstalker Rexxar" },
					new Card { Name = "Seeping Oozeling" },
					new Card { Name = "Silver Vanguard" },
					new Card { Name = "Charged Devilsaur" },
					new Card { Name = "Kathrena Winterwisp" },
					new Card { Name = "The Lich King" },
					new Card { Name = "King Krush" },
				}
			};
		}

		private static Deck QuestPriest()
		{
			return new Deck
			{
				Name = "Quest Priest",
				Prototype = "COMBO",
				Tier = 4,
				Rank = 24,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Awaken the Makers" },
					new Card { Name = "Crystalline Oracle" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Plated Beetle" },
					new Card { Name = "Shadow Visions" },
					new Card { Name = "Spirit Lash" },
					new Card { Name = "Shadow Word: Death" }, // tech v Control
					new Card { Name = "Baleful Banker" },  // tech v Control
					new Card { Name = "Twillight's Call" },
					new Card { Name = "Zola the Gorgon" },
					new Card { Name = "Duskbreaker" },
					new Card { Name = "Stonehill Defender" },  //  tech vs Aggro
					new Card { Name = "Spiritsinger Umbra" },
					new Card { Name = "Rotten Applebaum" },
					new Card { Name = "Bone Drake" },
					new Card { Name = "Archbishop Benedictus" },
					new Card { Name = "Psychic Scream" },
					new Card { Name = "Primordial Drake" },
					new Card { Name = "Shadowreaper Anduin" },
					new Card { Name = "Alexstrasza" },
					//new Card { Name = "Mind Control" },
				}
			};
		}

		private static Deck DeathrattleRogue()
		{
			return new Deck
			{
				Name = "Deathrattle Rogue",
				Prototype = "TEMPO",
				Tier = 4,
				Rank = 29,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					new Card { Name = "Argent Squire" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Cavern Shinyfinder" },
					new Card { Name = "Devilsaur Egg" },
					new Card { Name = "Hench-Clan Thug" },
					new Card { Name = "Necrium Blade" },
					new Card { Name = "Sonya Shadowdancer" },
					new Card { Name = "Blightnozzle Crawler" },
					new Card { Name = "Corpsetaker" },
					new Card { Name = "Half-Time Scavenger" },
					new Card { Name = "Carnivorous Cube" },
					new Card { Name = "Necrium Vial" },
					new Card { Name = "Vilespine Slayer" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Mechanical Whelp" },
					new Card { Name = "Stormwatcher" },

					//new Card { Name = "Shadowstep" },
					//new Card { Name = "Southsea Deckhand" },
					//new Card { Name = "Prince Keleseth" },
					//new Card { Name = "SI:7 Agent" },
					//new Card { Name = "Vicious Scalehide" },
					//new Card { Name = "Youthful Brewmaster" },
					//new Card { Name = "Fan of Knives" },
					//new Card { Name = "Mimic Pod" },
					//new Card { Name = "Zola the Gorgon" },
					//new Card { Name = "Elven Minstrel" },
					//new Card { Name = "Leeroy Jenkins" },
				}
			};
		}

		private static Deck QuestRogue()
		{
			return new Deck
			{
				Name = "Quest Rogue",
				Prototype = "TEMPO",
				Tier = 2,
				Rank = 9,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Preparation" },
					new Card { Name = "Shadowstep" },
					new Card { Name = "Glacial Shard" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Stonetusk Boar" },
					new Card { Name = "The Caverns Below" },
					new Card { Name = "Wax Elemental" },
					new Card { Name = "Lab Recruiter" },
					new Card { Name = "Novice Engineer" },
					//new Card { Name = "Sap" },
					new Card { Name = "Vicious Scalehide" },
					new Card { Name = "Youthful Brewmaster" },
					new Card { Name = "Fan of Knives" },
					new Card { Name = "Mimic Pod" },
					new Card { Name = "Sonya Shadowdancer" },
					new Card { Name = "Zola the Gorgon" },
					new Card { Name = "Elven Minstrel" },
//					new Card { Name = "Giggling Inventor" },
					new Card { Name = "Vanish" },
					new Card { Name = "Valeera the Hollow" },
				}
			};
		}

		private static Deck EvenPaladin()
		{
			return new Deck
			{
				Name = "Even Paladin",
				Prototype = "TEMPO",
				Tier = 1,
				Rank = 3,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					//new Card { Name = "Armani Berserker" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Argent Protector" },
					new Card { Name = "Crystalsmith Kangor" },
					new Card { Name = "Equality" },
					//new Card { Name = "Loot Hoarder" },
					new Card { Name = "Hydrologist" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Consecration" },
					new Card { Name = "Corpsetaker" },
					//new Card { Name = "Chillblade Champion" },
					//new Card { Name = "Plated Beetle" },  // tech v Aggro
					//new Card { Name = "Hammer of Wrath" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Spellbreaker" },
					//new Card { Name = "The Glass Knight" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Argent Commander" },
					new Card { Name = "Avenging Wrath" },
					new Card { Name = "Genn Greymane" },
					new Card { Name = "Sunkeeper Tarim" },
					new Card { Name = "Val'anyr" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Tirion Fordring" },  // tech v Control
				}
			};
		}

		private static Deck ResurrectPriest()
		{
			return new Deck
			{
				Name = "Resurrect OTK Priest",
				Prototype = "COMBO",
				Tier = 2,
				Rank = 16,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Holy Smite" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Mind Blast" },
					new Card { Name = "Radient Elemental" },
					new Card { Name = "Shadow Visions" },
					new Card { Name = "Spirit Lash" },
					new Card { Name = "Guilded Gargoyle" },
					new Card { Name = "Eternal Servitude" },
					new Card { Name = "Lyra the Sunshard" },
					new Card { Name = "Mass Hysteria" },
					new Card { Name = "Zilliax" },
					new Card { Name = "Shadow Essence" },
					new Card { Name = "Lesser Diamond Spellstone" },
					new Card { Name = "Prophet Velen" },
					new Card { Name = "Psychic Scream" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Malygos" },
					new Card { Name = "Zerek's Cloning Gallery" },
				}
			};
		}

		private static Deck ComboPriest()
		{
			return new Deck
			{
				Name = "Combo Priest",
				Prototype = "COMBO",
				Tier = 3,
				Rank = 19,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Circle of Healing" },
					new Card { Name = "Silence" },
					new Card { Name = "Inner Fire" },
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Divine Spirit" },
					new Card { Name = "Radient Elemental" },
					new Card { Name = "Shadow Ascendant" },
					new Card { Name = "Shadow Visions" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Injured Blademaster" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Tortollan Shellraiser" },
					new Card { Name = "Unpowered Steambot" },
					new Card { Name = "Witchwood Piper" },
					new Card { Name = "Lyra the Sunshard" },
				}
			};
		}

		private static Deck ApmPriest()
		{
			return new Deck
			{
				Name = "APM Priest",
				Prototype = "COMBO",
				Tier = 2,
				Rank = 12,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Topsy Turvy" },
					//new Card { Name = "Binding Heal" },
					//new Card { Name = "Inner Fire" },
					//new Card { Name = "Northshire Cleric" },
					new Card { Name = "Awaken the Makers" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Stonetusk Boar" },
					new Card { Name = "Test Subject" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Dead Ringer" },
					new Card { Name = "Divine Spirit" },
//					new Card { Name = "Doomsayer" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Radient Elemental" },
					//new Card { Name = "Shadow Ascendant" },
					new Card { Name = "Shadow Visions" },
					new Card { Name = "Spirit Lash" },
					new Card { Name = "Twilight's Call" },
					new Card { Name = "Vivid Nightmare" },
					//new Card { Name = "Tortollan Shellraiser" },
					//new Card { Name = "Unpowered Steambot" },
					new Card { Name = "Witchwood Piper" },
					new Card { Name = "Mass Hysteria" },  // new
					new Card { Name = "Psychic Scream" },
				}
			};
		}

		private static Deck MurlocPaladin()
		{
			return new Deck
			{
				Name = "Murloc Paladin",
				Prototype = "AGGRO",
				Tier = 3,
				Rank = 21,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Lost in the Jungle" },
					new Card { Name = "Murloc Tidecaller" },
					new Card { Name = "Righteous Protector" },
					new Card { Name = "Hydrologist" },
					new Card { Name = "Knife Juggler" },
					new Card { Name = "Rockpool Hunter" },
					new Card { Name = "Coldlight Seer" },
					new Card { Name = "Divine Favor" },
					new Card { Name = "Murloc Warleader" },
					new Card { Name = "Nightmare Amalgam" },
					new Card { Name = "Unidentified Maul" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Gentle Megasaur" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Call to Arms" },
					new Card { Name = "Fungalmancer" },
					new Card { Name = "Sunkeeper Tarim" },
					new Card { Name = "Vinecleaver" },
				}
			};
		}

		private static Deck MastersCallHunter()
		{
			return new Deck
			{
				Name = "Master's Call Hunter",
				Prototype = "MIDRANGE",
				Tier = 2,
				Rank = 11,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Candleshot" },
					new Card { Name = "Dire Mole" },
					new Card { Name = "Hunter's Mark" },
					new Card { Name = "Springpaw" },
					new Card { Name = "Timber Wolf" },
					new Card { Name = "Tracking" },
					new Card { Name = "Crackling Razormaw" },
					new Card { Name = "Plated Beetle" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Master's Call" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Dire Frenzy" },
					new Card { Name = "Flanking Strike" },
					new Card { Name = "Tundra Rhino" },
					new Card { Name = "Deathstalker Rexxar" },
					new Card { Name = "Savannah Highmane" },
				}
			};
		}

		private static Deck OddHunter()
		{
			return new Deck
			{
				Name = "Odd Hunter",
				Prototype = "AGGRO",
				Tier = 5,
				Rank = 28,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Acherus Veteran" },
					new Card { Name = "Arcane Shot" },
					new Card { Name = "Argent Squire" },
					new Card { Name = "Candleshot" },
					new Card { Name = "Dire Mole" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Glacial Shard" },
					new Card { Name = "Acherus Veteran" },
					new Card { Name = "Tracking" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Ironbeak Owl" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Wolfrider" },
					new Card { Name = "Baku the Mooneater" },
					new Card { Name = "Leeroy Jenkins" },
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
				Rank = 29,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Upgrade!" },
					new Card { Name = "Bloodsail Raider" },
					new Card { Name = "Heroic Strike" },
					new Card { Name = "Woodcutter's Axe" },
					new Card { Name = "Fiery War Axe" },
					new Card { Name = "Frothing Berserker" },
					new Card { Name = "Hench-Clan Thug" },
					new Card { Name = "Rabid Worgen" },
					new Card { Name = "Dread Corsair" },
					new Card { Name = "Kor'kron Elite" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Arcanite Reaper" },
					new Card { Name = "Captain Greenskin" },
					new Card { Name = "Darius Crowley" },
					new Card { Name = "Leeroy Jenkins" },
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
					new Card { Name = "Acherus Veteran" },
					new Card { Name = "Argent Squire" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Flame Imp" },
					//new Card { Name = "Glacial Shard" },
					new Card { Name = "Grim Rally" },
					new Card { Name = "Kobold Librarian" },
					new Card { Name = "Saronite Taskmaster" },
					new Card { Name = "Soul Infusion" },

					//new Card { Name = "Lightwarden" },
					new Card { Name = "Soulfire" },
					//new Card { Name = "The Soularium" },
					new Card { Name = "Voidwalker" },
					//new Card { Name = "Voodoo Doctor" },
					new Card { Name = "Prince Keleseth" },
					new Card { Name = "Doubling Imp" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Doomguard" },
					new Card { Name = "Fungalmancer" },

					//new Card { Name = "Fungal Enchanter" },
					//new Card { Name = "Happy Ghoul" },
					//new Card { Name = "Tar Creeper" },
//					new Card { Name = "Vicious Fledgling" },
					//new Card { Name = "Dark Iron Dwarf" },
					//new Card { Name = "Void Ripper" },
					//new Card { Name = "Despicable Dreadlord" },
					//new Card { Name = "Bloodreaver Gul'dan" },
				}
			};
		}

	}
}
