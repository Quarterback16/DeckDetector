using System.Collections.Generic;

namespace Domain.Metas
{
    public static class WitchwoodBalanced
    {
        public static Meta LoadMeta()
        {
            var meta = new Meta(
            code: "RW2",
            name: "The Witchwood Post Balance changes");

            meta.AddDeck(TokenDruid());
			meta.AddDeck(TauntDruid());
			meta.AddDeck(EvenWarlock());
			meta.AddDeck(Shudderwock());
			meta.AddDeck(Cubelock());

			meta.AddDeck(MiracleRogue());
			meta.AddDeck(OddPaladin());
			meta.AddDeck(OddRogue());
			meta.AddDeck(EvenShaman());
			meta.AddDeck(ControlPriest());
			meta.AddDeck(RecruitHunter());
			meta.AddDeck(SpellHunter());
			meta.AddDeck(SpitefulDruid());
			meta.AddDeck(MalygosDruid());
			meta.AddDeck(AggroMage());

			meta.AddDeck(ControlMage());
			meta.AddDeck(QuestWarrior());
			meta.AddDeck(RecruitWarrior());
			meta.AddDeck(ComboPriest());
			meta.AddDeck(Zoolock());
			meta.AddDeck(MurlocPaladin());
			meta.AddDeck(ControlWarlock());

			meta.AddDeck(OddFatigueWarrior());
			meta.AddDeck(QuestPriest());

			meta.AddDeck(DinoDruid());
			meta.AddDeck(QuestRogue());
			meta.AddDeck(EvenPaladin());
			meta.AddDeck(OddHunter());
			meta.AddDeck(PirateWarrior());

			return meta;
        }

        private static Deck TokenDruid()
        {
            return new Deck
            {
                Name = "Token Druid",
				Prototype = "AGGRO",
                Tier = 1,
                Rank = 1,
                HeroClass = new Hero("Druid"),
                Cards = new List<Card>
                {
                    //new Card { Name = "Innervate" },
                    new Card { Name = "Lesser Jasper Spellstone" },
                    new Card { Name = "Power of the Wild" },
                    new Card { Name = "Wild Growth" },
                    new Card { Name = "Wrath" },
                    new Card { Name = "Savage Roar" },
                    new Card { Name = "Branching Paths" },
                    new Card { Name = "Evolving Spores" },
                    new Card { Name = "Oaken Summons" },
                    new Card { Name = "Soul of the Forest" },
                    new Card { Name = "Swipe" },
                    new Card { Name = "Violet Teacher" },
                    new Card { Name = "Wispering Woods" },
                    new Card { Name = "Arcane Tyrant" },
                    new Card { Name = "Nourish" },
                    new Card { Name = "Spreading Plague" },
                    new Card { Name = "Malfurion the Pestilent" },
                    new Card { Name = "Ultimate Infestation" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Starfall" },  // tech vs Aggro
                    new Card { Name = "Naturalize" },  // tech vs Control
                }
            };
        }

		private static Deck Cubelock()
		{
			return new Deck
			{
				Name = "Cubelock",
				Prototype = "CONTROL",
				Tier = 1,
				Rank = 5,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Dark Pact" },
					new Card { Name = "Kobold Librarian" },
					//new Card { Name = "Mistress of Mixtures" },
					new Card { Name = "Defile" },
					new Card { Name = "Doomsayer" },
					//new Card { Name = "Prince Taldaram" },
					new Card { Name = "Hellfire" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Lesser Amethyst Spellstone" },
					new Card { Name = "Spiritsinger Umbra" },  // IN
					new Card { Name = "Carnivorous Cube" },
					new Card { Name = "Doomguard" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Possessed Lackey" },
					new Card { Name = "The Lich King" },  // IN
					new Card { Name = "Lord Godfrey" },  // IN
					new Card { Name = "Skull of the Man'ari" },
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
				Tier = 3,
				Rank = 22,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Dark Pact" },
					new Card { Name = "Kobold Librarian" },
					//new Card { Name = "Mistress of Mixtures" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Defile" },
					new Card { Name = "Gnomeferatu" },
					new Card { Name = "Plated Beetle" },
					new Card { Name = "Ironbeak Owl" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Tinkmaster Overspark" },
					new Card { Name = "Doomsayer" },  // tech vs agro
					new Card { Name = "Hellfire" },
					new Card { Name = "Lesser Amethyst Spellstone" },
					//new Card { Name = "Doomguard" },
					new Card { Name = "Shroom Brewer" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Skull of the Man'ari" },
					new Card { Name = "Possessed Lackey" },
					new Card { Name = "Rin the First Disciple" },
					new Card { Name = "Siphon Soul" },
					new Card { Name = "Lord Godfrey" },
					new Card { Name = "Twisting Nether" },
					new Card { Name = "Voidlord" },
					new Card { Name = "Bloodreaver Gul'dan" },
				}
			};
		}

		private static Deck MiracleRogue()
		{
			return new Deck
			{
				Name = "Miracle Rogue",
				Prototype = "TEMPO",
				Tier = 2,
				Rank = 6,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					//new Card { Name = "Counterfeit Coin" },
					new Card { Name = "Preparation" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Fire Fly" },
					//new Card { Name = "Hallucination" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					//new Card { Name = "Shiv" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "Hench-Clan Thug" },  // IN
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

		private static Deck Shudderwock()
		{
			return new Deck
			{
				Name = "Shudderwock Shaman",
				Prototype = "COMBO",
				Tier = 1,
				Rank = 4,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Zap!" },
					new Card { Name = "Glacial Shard" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Murmuring Elemental" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Healing Rain" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Mana Tide Totem" },
					new Card { Name = "Hemet Jungle Hunter" },
					new Card { Name = "Zola the Gorgon" },
					new Card { Name = "Hex" },
					new Card { Name = "Lifedrinker" },
					//new Card { Name = "Sandbinder" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Volcano" },
					new Card { Name = "Grumble Worldshaker" },
					new Card { Name = "Hagatha The Witch" },
					new Card { Name = "Shudderwock" },
					new Card { Name = "Tar Creeper" },   // tech vs aggro
				}
			};
		}

		private static Deck TauntDruid()
		{
			return new Deck
			{
				Name = "Taunt Druid",
				Prototype = "CONTROL",
				Tier = 1,
				Rank = 2,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Lesser Jasper Spellstone" },
					new Card { Name = "Naturalize" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Wrath" },
					new Card { Name = "Witching Hour" },
					new Card { Name = "Branching Paths" },
					new Card { Name = "Ironwood Golem" },
					new Card { Name = "Oaken Summons" },
					new Card { Name = "Swipe" },
					new Card { Name = "Carnivorous Cube" },
					new Card { Name = "Nourish" },
					new Card { Name = "Primordial Drake" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Dragonhatcher" },
					new Card { Name = "Hadronox" },
					new Card { Name = "Master Oakheart" },
					new Card { Name = "Sleepy Dragon" },
					new Card { Name = "Ultimate Infestation" },
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
				Rank = 3,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Acidic Swap Ooze" },
					new Card { Name = "Defile" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Plated Beetle" },
					new Card { Name = "Sunfury Protector" },
					new Card { Name = "Vulgar Homunculus" },
					new Card { Name = "Hellfire" },
					new Card { Name = "Hooked Reaver" },
					new Card { Name = "Lesser Amethyst Spellstone" },
					new Card { Name = "Shroom Brewer" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Dread Infernal" },
					new Card { Name = "Genn Greymane" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Bloodreaver Gul'dan" },
					new Card { Name = "Mountain Giant" },
				}
			};
		}

		private static Deck SpellHunter()
		{
			return new Deck
			{
				Name = "Spell Hunter",
				Prototype = "TEMPO",
				Tier = 2,
				Rank = 12,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Shot" },
					new Card { Name = "Candleshot" },
					new Card { Name = "Hunter's Mark" },
					new Card { Name = "Tracking" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Grievous Bite" },
					new Card { Name = "Snipe" },
					new Card { Name = "Wandering Monster" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Flanking Strike" },
					new Card { Name = "Lesser Emerald Spellstone" },
					new Card { Name = "Deathstalker Rexxar" },
					new Card { Name = "To My Side!" },
					new Card { Name = "Rhok'delar" },
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
				Rank = 9,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Dire Wolf Alpha" },
					new Card { Name = "Earthen Might" },
					new Card { Name = "Flametongue Totem" },
					new Card { Name = "Knife Jugger" },
					new Card { Name = "Murkspark Eel" },
					new Card { Name = "Primalfin Totem" },
					new Card { Name = "Vicious Scalehide" },
					new Card { Name = "Corpsetaker" },
					new Card { Name = "Fire Plume Phoenix" },
					new Card { Name = "Hex" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Fire Elemental" },
					new Card { Name = "Genn Greymane" },
					new Card { Name = "Al'Akir the Windlord" },
					new Card { Name = "Hagatha The Witch" },
					new Card { Name = "Kalimos Primal Lord" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Sea Giant" },
					new Card { Name = "Plated Beetle" },   // tech vs aggro
					new Card { Name = "Argent Commander" },   // tech vs control
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
				Rank = 8,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Argent Squire" },
					new Card { Name = "Deadly Poison" },
					new Card { Name = "Dire Mole" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Southsea Deckhand" },
					new Card { Name = "Blink Fox" },
					new Card { Name = "Edwin VanCleef" },
					new Card { Name = "Hench-Clan Thug" },
					new Card { Name = "Ironbeak Owl" },
					new Card { Name = "SI:7 Agent" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Colbalt Scalebane" },
					new Card { Name = "Vicious Fledgling" },
					new Card { Name = "Fungalmancer" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Vilespine Slayer" },
					new Card { Name = "Baku the Mooneater" },
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
				Rank = 15,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Missiles" },
					new Card { Name = "Mana Wyrm" },
					new Card { Name = "Amani Berserker" },
					new Card { Name = "Arcanologist" },
					new Card { Name = "Frostbolt" },
					new Card { Name = "Primordial Glyph" },
					new Card { Name = "Sorcerer's Apprentice" },
					new Card { Name = "Arcane Intellect" },
					new Card { Name = "Cinderstorm" },
					new Card { Name = "Counterspell" },
					new Card { Name = "Explosive Runes" },
					new Card { Name = "Kirin Tor Mage" },
					new Card { Name = "Arcane Keysmith" },
					new Card { Name = "Fireball" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Aluneth" },
					new Card { Name = "Pyroblast" },
				}
			};
		}

		private static Deck MalygosDruid()
		{
			return new Deck
			{
				Name = "Malygos Druid",
				Prototype = "CONTROL",
				Tier = 2,
				Rank = 14,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Lesser Jasper Spellstone" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Wrath" },
					new Card { Name = "Prince Taldaram" },
					//new Card { Name = "Rummaging Kobold" },
					new Card { Name = "Branching Paths" },
					new Card { Name = "Swipe" },
					new Card { Name = "Twig Of The World Tree" },
					new Card { Name = "Arcane Tyrant" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Nourish" },
					new Card { Name = "Naturalize" },  // tech v Control
					new Card { Name = "Starfall" },
					new Card { Name = "Spreading Plague" },
					new Card { Name = "Malfurion the Pestilent" },
					//new Card { Name = "Dragonhatcher" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Malygos" },
					new Card { Name = "Ultimate Infestation" },
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
				Rank = 18,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Iron Hide" },
					new Card { Name = "Shield Slam" },
					new Card { Name = "Bring It On!" },
					new Card { Name = "Dead Man's Hand" },
					new Card { Name = "Execute" },
					new Card { Name = "Forge Of Souls" },
					new Card { Name = "Slam" },
					new Card { Name = "Warpath" },
					new Card { Name = "Reckless Flurry" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Blood Razor" },
					new Card { Name = "Brawl" },
					new Card { Name = "Gather Your Party" },
					new Card { Name = "Geosculptor Yip" },
					new Card { Name = "Grommash Hellscream" },
					new Card { Name = "Rotface" },
					new Card { Name = "Scourgelord Garrosh" },
					new Card { Name = "The Lich King" },
					new Card { Name = "Woecleaver" },
					new Card { Name = "Ysera" },
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
					new Card { Name = "Divine Hymn" },
					new Card { Name = "Mind Blast" },
					new Card { Name = "Shadow Visions" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Twilight Acolyte" },
					new Card { Name = "Duskbreaker" },
					new Card { Name = "Mass Dispel" },
					new Card { Name = "Shadow Word: Horror" },
					new Card { Name = "Twilight Drake" },
					new Card { Name = "Holy Fire" },
					new Card { Name = "Cabal Shadow Priest" },
					new Card { Name = "Psychic Scream" },
					new Card { Name = "Primordial Drake" },
					new Card { Name = "Shadowreaper Anduin" },
					new Card { Name = "Alexstraza" },
					new Card { Name = "Tar Creeper" },  // tech v aggro
					new Card { Name = "Harrison Jones" },  // tech v control
				}
			};
		}

		private static Deck OddFatigueWarrior()
		{
			return new Deck
			{
				Name = "Odd Fatigue Warrior",
				Prototype = "CONTROL",
				Tier = 4,
				Rank = 23,
				HeroClass = new Hero("Warrior"),
				Cards = new List<Card>
				{
					new Card { Name = "Shield Slam" },
					new Card { Name = "Town Crier" },
					new Card { Name = "Whirlwind" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Ironbeak Owl" },
					new Card { Name = "Rabid Worgen" },
					new Card { Name = "Reckless Flurry" },
					new Card { Name = "Shield Block" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Big Game Hunter" },
					new Card { Name = "Brawl" },
					new Card { Name = "Darius Crowley" },
					new Card { Name = "Direhorn Hatchling" },
					new Card { Name = "Elise the Trailblazer" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Harrison Jones" },
					new Card { Name = "Azina Soulthief" },
					new Card { Name = "Baron Geddon" },
					new Card { Name = "Gorehowl" },
					new Card { Name = "Baku the Mooneater" },
					new Card { Name = "King Mosh" },
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

		private static Deck OddPaladin()
		{
			return new Deck
			{
				Name = "Odd Paladin",
				Prototype = "AGGRO",
				Tier = 2,
				Rank = 7,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Acherus Veteran" },
					new Card { Name = "Argent Squire" },
					new Card { Name = "Blessing of Might" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Lost in the Jungle" },
					new Card { Name = "Righteous Protector" },
					new Card { Name = "Divine Favor" },
					new Card { Name = "Raid Leader" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Unidentified Maul" },
					new Card { Name = "Fungalmancer" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Level Up!" },
					new Card { Name = "Corridor Creeper" },
					new Card { Name = "Stormwind Champion" },
					new Card { Name = "Vinecleaver" },
					new Card { Name = "Baku the Mooneater" },
					new Card { Name = "Witch's Cauldron" },  // tech vs Control

				}
			};
		}

		private static Deck SpitefulDruid()
		{
			return new Deck
			{
				Name = "Spiteful Druid",
				Prototype = "TEMPO",
				Tier = 2,
				Rank = 13,
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
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Mossy Horror" },  //  tech v aggro
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Cobalt Scalebane" },
					new Card { Name = "Fungalmancer" },
					new Card { Name = "Leeroy Jenkins" },
					new Card { Name = "Spiteful Summoner" },
					new Card { Name = "Malfurion the Pestilent" },
					new Card { Name = "Grand Archivist" },
					new Card { Name = "The Lich King" },
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

		private static Deck ControlMage()
		{
			return new Deck
			{
				Name = "Control Mage",
				Prototype = "CONTROL",
				Tier = 3,
				Rank = 16,
				HeroClass = new Hero("Mage"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Artificer" },
					new Card { Name = "Doomsayer" },
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Raven Familiar" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Voodoo Doll" },
					new Card { Name = "Arcane Keysmith" },
					new Card { Name = "Tar Creeper" },  // tech v aggro
					new Card { Name = "Polymorph" },
					new Card { Name = "Witchwood Piper" },
					new Card { Name = "Dragon's Fury" },
					new Card { Name = "Blizzard" },
					new Card { Name = "Meteor" },
					new Card { Name = "Skulking Geist" },
					new Card { Name = "Baron Geddon" },
					new Card { Name = "Flamestrike" },
					new Card { Name = "Sindragosa" },  // tech v Control
					//new Card { Name = "Alexstrasza" },
					new Card { Name = "Dragoncaller Alanna" },
					new Card { Name = "Frost Lich Jaina" },
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

		private static Deck QuestRogue()
		{
			return new Deck
			{
				Name = "Quest Rogue",
				Prototype = "TEMPO",
				Tier = 5,
				Rank = 26,
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
					new Card { Name = "Novice Engineer" },
					new Card { Name = "Sap" },
					new Card { Name = "Vicious Scalehide" },
					new Card { Name = "Youthful Brewmaster" },
					new Card { Name = "Fan of Knives" },
					new Card { Name = "Mimic Pod" },
					new Card { Name = "Sonya Shadowdancer" },
					new Card { Name = "Zola the Gorgon" },
					new Card { Name = "Elven Minstrel" },
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
				Tier = 5,
				Rank = 27,
				HeroClass = new Hero("Paladin"),
				Cards = new List<Card>
				{
					new Card { Name = "Armani Berserker" },
					new Card { Name = "Argent Protector" },
					new Card { Name = "Equality" },
					new Card { Name = "Loot Hoarder" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Blessing of Kings" },
					new Card { Name = "Chillblade Champion" },
					new Card { Name = "Plated Beetle" },  // tech v Aggro
					new Card { Name = "Hammer of Wrath" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "The Glass Knight" },
					new Card { Name = "Truesilver Champion" },
					new Card { Name = "Argent Commander" },
					new Card { Name = "Avenging Wrath" },
					new Card { Name = "Genn Greymane" },
					new Card { Name = "Sunkeeper Tarim" },
					new Card { Name = "Val'anyr" },
					new Card { Name = "Consecration" },
					new Card { Name = "Tirion Fordring" },  // tech v Control
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
				Rank = 20,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Fire Fly" },
					new Card { Name = "Flame Imp" },
					new Card { Name = "Glacial Shard" },
					new Card { Name = "Kobold Librarian" },
					new Card { Name = "Soulfire" },
					new Card { Name = "Voidwalker" },
					new Card { Name = "Prince Keleseth" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Vicious Fledgling" },
					new Card { Name = "Dark Iron Dwarf" },
					new Card { Name = "Saronite Chain Gang" },
					new Card { Name = "Spellbreaker" },
					new Card { Name = "Despicable Dreadlord" },
					new Card { Name = "Doomguard" },
					new Card { Name = "Fungalmancer" },
					new Card { Name = "Bloodreaver Gul'dan" },
				}
			};
		}
	}
}
