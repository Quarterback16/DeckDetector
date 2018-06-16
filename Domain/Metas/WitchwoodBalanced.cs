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
			meta.AddDeck(Cubelock());
			meta.AddDeck(ControlWarlock());
			meta.AddDeck(MiracleRogue());
			meta.AddDeck(Shudderwock());
			meta.AddDeck(TauntDruid());
			meta.AddDeck(EvenWarlock());
			meta.AddDeck(SpellHunter());
			meta.AddDeck(EvenShaman());
			meta.AddDeck(OddRogue());
			meta.AddDeck(AggroMage());
			meta.AddDeck(MalygosDruid());
			meta.AddDeck(RecruitWarrior());
			meta.AddDeck(ControlPriest());
			meta.AddDeck(QuestWarrior());
			meta.AddDeck(OddPaladin());
			return meta;
        }

        private static Deck TokenDruid()
        {
            return new Deck
            {
                Name = "Token Druid",
                Tier = 1,
                Rank = 1,
                HeroClass = new Hero("Druid"),
                Cards = new List<Card>
                {
                    new Card { Name = "Innervate" },
                    new Card { Name = "Lesser Jasper Spellstone" },
                    new Card { Name = "Power of the Wild" },
                    new Card { Name = "Wild Growth" },
                    new Card { Name = "Wrath" },
                    new Card { Name = "Savage Roar" },
                    new Card { Name = "Branching Paths" },
                    new Card { Name = "Evolving Spores" },
                    new Card { Name = "Oaken Sumons" },
                    new Card { Name = "Soul of the Forest" },
                    new Card { Name = "Swipe" },
                    new Card { Name = "Violet Teacher" },
                    new Card { Name = "Wispering Woods" },
                    new Card { Name = "Arcane Tyrant" },
                    new Card { Name = "Nourish" },
                    new Card { Name = "Spreading Plague" },
                    new Card { Name = "Malfurion The Pestilent" },
                    new Card { Name = "Ultimate Infestation" },
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
				Tier = 1,
				Rank = 2,
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
				Tier = 1,
				Rank = 3,
				HeroClass = new Hero("Warlock"),
				Cards = new List<Card>
				{
					new Card { Name = "Dark Pact" },
					new Card { Name = "Kobold Librarian" },
					//new Card { Name = "Mistress of Mixtures" },
					new Card { Name = "Acidic Swamp Ooze" },
					new Card { Name = "Gnomeferatu" },
					new Card { Name = "Plated Beetle" },
					new Card { Name = "Defile" },
					new Card { Name = "Ironbeak Owl" },
					new Card { Name = "Stonehill Defender" },
					new Card { Name = "Tar Creeper" },
					new Card { Name = "Tinkmaster Overspark" },
					new Card { Name = "Doomsayer" },  // tech vs agro
					new Card { Name = "Hellfire" },
					new Card { Name = "Lesser Amethyst Spellstone" },
					//new Card { Name = "Doomguard" },
					new Card { Name = "Shroom Brewer" },
					new Card { Name = "Possessed Lackey" },
					new Card { Name = "Voidlord" },
					new Card { Name = "Bloodreaver Gul'dan" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Rin the First Disciple" },
					new Card { Name = "Siphon Soul" },
					new Card { Name = "Lord Godfrey" },
					new Card { Name = "Twisting Nether" },
				}
			};
		}

		private static Deck MiracleRogue()
		{
			return new Deck
			{
				Name = "Miracle Rogue",
				Tier = 1,
				Rank = 4,
				HeroClass = new Hero("Rogue"),
				Cards = new List<Card>
				{
					new Card { Name = "Backstab" },
					//new Card { Name = "Counterfeit Coin" },
					new Card { Name = "Preparation" },
					new Card { Name = "Cold Blood" },
					new Card { Name = "Fire Fly" },
					new Card { Name = "Hallucination" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Eviscerate" },
					new Card { Name = "Sap" },
					new Card { Name = "Shiv" },
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
				Tier = 1,
				Rank = 5,
				HeroClass = new Hero("Shaman"),
				Cards = new List<Card>
				{
					new Card { Name = "Glacial Shard" },
					new Card { Name = "Lightning Bolt" },
					new Card { Name = "Prince Keleseth" },
					new Card { Name = "Acolyte of Pain" },
					new Card { Name = "Far Sight" },
					new Card { Name = "Gluttonous Ooze" },
					new Card { Name = "Healing Rain" },
					new Card { Name = "Lightning Storm" },
					new Card { Name = "Mana Tide Totem" },
					new Card { Name = "Mind Control Tech" },
					new Card { Name = "Zola The Gorgon" },
					new Card { Name = "Hex" },
					new Card { Name = "Lifedrinker" },
					new Card { Name = "Sandbinder" },
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
				Tier = 2,
				Rank = 6,
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
				Tier = 2,
				Rank = 7,
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
					new Card { Name = "Gen Greymane" },
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
				Tier = 2,
				Rank = 8,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Arcane Shot" },
					new Card { Name = "Candleshot" },
					new Card { Name = "Hunter's Mark" },
					new Card { Name = "Tracking" },
					//new Card { Name = "Cat Trick" },
					new Card { Name = "Explosive Trap" },
					new Card { Name = "Freezing Trap" },
					new Card { Name = "Grievous Bite" },
					new Card { Name = "Snipe" },
					new Card { Name = "Wandering Monster" },
					new Card { Name = "Animal Companion" },
					//new Card { Name = "Deadly Shot" },
					new Card { Name = "Eaglehorn Bow" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Unleash the Hounds" },
					//new Card { Name = "Barnes" },
					new Card { Name = "Flanking Strike" },
					new Card { Name = "Lesser Emerald Spellstone" },
					new Card { Name = "Deathstalker Rexxar" },
					new Card { Name = "Rhok'delar" },
					//new Card { Name = "Y'Shaarj Rage Unbound" },
					new Card { Name = "To My Side!" },
					//new Card { Name = "Call of the Wild" },
				}
			};
		}

		private static Deck EvenShaman()
		{
			return new Deck
			{
				Name = "Even Shaman",
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
					new Card { Name = "Viscious Scalehide" },
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
				Tier = 2,
				Rank = 10,
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
				Tier = 2,
				Rank = 11,
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
				Tier = 2,
				Rank = 12,
				HeroClass = new Hero("Druid"),
				Cards = new List<Card>
				{
					new Card { Name = "Innervate" },
					new Card { Name = "Moonfire" },
					new Card { Name = "Lesser Jasper Spellstone" },
					new Card { Name = "Bloodmage Thalnos" },
					new Card { Name = "Wild Growth" },
					new Card { Name = "Wrath" },
					new Card { Name = "Ferocious Howl" },
					new Card { Name = "Rummaging Kobold" },
					new Card { Name = "Branching Paths" },
					new Card { Name = "Swipe" },
					new Card { Name = "Twig Of The World Tree" },
					new Card { Name = "Arcane Tyrant" },
					new Card { Name = "Faceless Manipulator" },
					new Card { Name = "Nourish" },
					new Card { Name = "Starfall" },
					new Card { Name = "Spreading Plague" },
					new Card { Name = "Malfurion the Pestilent" },
					new Card { Name = "Dragonhatcher" },
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
				Tier = 2,
				Rank = 13,
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
				Tier = 2,
				Rank = 14,
				HeroClass = new Hero("Priest"),
				Cards = new List<Card>
				{
					new Card { Name = "Northshire Cleric" },
					new Card { Name = "Power Word: Shield" },
					new Card { Name = "Divine Hymn" },
					new Card { Name = "Mind Blast" },
					new Card { Name = "Shadow Visions" },
					new Card { Name = "Wild Pyromancer" },
					new Card { Name = "Acolyte Of Pain" },
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

		private static Deck QuestWarrior()
		{
			return new Deck
			{
				Name = "Quest Warrior",
				Tier = 2,
				Rank = 15,
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
				Tier = 2,
				Rank = 16,
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
					new Card { Name = "Stonehil Defender" },
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
	}
}
