using System.Collections.Generic;

namespace Domain.Metas
{
    public static class KatacombsAndKoboldsPostNerf
    {
        public static Meta LoadMeta()
        {
            var meta = new Meta(
                code: "MC2",
                name: "Katacombs And Kobolds Post Nerf",
				patchNo: 10.0M);
            meta.AddDeck(Cubelock());
            meta.AddDeck(ComboDragonPriest());
            meta.AddDeck(ControlPriest());
            meta.AddDeck(MurlocPaladin());
            meta.AddDeck(DudePaladin());
            meta.AddDeck(ControlWarlock());
            meta.AddDeck(TempoMage());
            meta.AddDeck(SpellHunter());
            meta.AddDeck(SpitefulDragonPriest());
            meta.AddDeck(Zoolock());
            meta.AddDeck(BigBurstPriest());
            meta.AddDeck(JadeShaman());
            meta.AddDeck(ControlWarrior());
            meta.AddDeck(EvolveShaman());
            meta.AddDeck(ControlPaladin());
            meta.AddDeck(FaceHunter());
            meta.AddDeck(ControlMage());
            meta.AddDeck(MillRogue());
            meta.AddDeck(MiracleRogue());
            meta.AddDeck(SpitefulDruid());
            meta.AddDeck(JadeDruid());
            meta.AddDeck(TempoRogue());
            meta.AddDeck(QuestMage());
            meta.AddDeck(AggroDruid());
            meta.AddDeck(QuestRogue());
            meta.AddDeck(BigDragonDruid());
            meta.AddDeck(PirateWarrior());
            return meta;
        }


        private static Deck ComboDragonPriest()
        {
            return new Deck
            {
                Name = "Combo Dragon Priest",
                Tier = 1,
                Rank = 4,
                HeroClass = new Hero("Priest"),
                Cards = new List<Card>
                {
                    new Card { Name = "Inner Fire" },
                    new Card { Name = "Northshire Cleric" },
                    new Card { Name = "Potion of Madness" },
                    new Card { Name = "Power Word: Shield" },
                    new Card { Name = "Divine Spirit" },
                    new Card { Name = "Netherspite Historian" },
                    new Card { Name = "Radiant Elemental" },
                    new Card { Name = "Shadow Visions" },
                    new Card { Name = "Kabal Talonpriest" },
                    new Card { Name = "Tar Creeper" },
                    new Card { Name = "Twilight Acolyte" },
                    new Card { Name = "Duskbreaker" },
                    new Card { Name = "Mass Dispel" },
                    new Card { Name = "Twilight Drake" },
                    new Card { Name = "Drakonid Operative" },
                    new Card { Name = "Book Wyrm" },
                }
            };
        }

        private static Deck ControlPriest()
        {
            return new Deck
            {
                Name = "Control Priest",
                Tier = 2,
                Rank = 6,
                HeroClass = new Hero("Priest"),
                Cards = new List<Card>
                {
                    new Card { Name = "Northshire Cleric" },
                    new Card { Name = "Pint-Size Potion" },
                    new Card { Name = "Potion of Madness" },
                    new Card { Name = "Power Word: Shield" },
                    new Card { Name = "Netherspite Historian" },
                    new Card { Name = "Shadow Visions" },
                    new Card { Name = "Twilight Acolyte" },
                    new Card { Name = "Duskbreaker" },
                    new Card { Name = "Priest of the Feast" },
                    new Card { Name = "Shadow Word: Horror" },
                    new Card { Name = "Twilight Drake" },
                    new Card { Name = "Drakonid Operative" },
                    new Card { Name = "Elise the Trailblazer" },
                    new Card { Name = "Cabal Shadow Priest" },
                    new Card { Name = "Primordial Drake" },
                    new Card { Name = "Shadowreaper Anduin" },
                }
            };
        }

        private static Deck Cubelock()
        {
            return new Deck
            {
                Name = "Cubelock",
                Tier = 1,
                Rank = 1,
                HeroClass = new Hero("Warlock"),
                Cards = new List<Card>
                {
                    new Card { Name = "Dark Pact" },
                    new Card { Name = "Kobold Librarian" },
                    new Card { Name = "Mistress of Mixtures" },
                    new Card { Name = "Defile" },
                    new Card { Name = "Doomsayer" },
                    new Card { Name = "Prince Taldaram" },
                    new Card { Name = "Hellfire" },
                    new Card { Name = "Stonehill Defender" },
                    new Card { Name = "Lesser Amethyst Spellstone" },
                    new Card { Name = "Carnivorous Cube" },
                    new Card { Name = "Doomguard" },
                    new Card { Name = "Faceless Manipulator" },
                    new Card { Name = "Possessed Lackey" },
                    new Card { Name = "Skull of the Man'ari" },
                    new Card { Name = "Voidlord" },
                    new Card { Name = "Bloodreaver Gul'dan" },
                    new Card { Name = "Mountain Giant" },
                }
            };
        }

        private static Deck MurlocPaladin()
        {
            return new Deck
            {
                Name = "Murloc Paladin",
                Tier = 1,
                Rank = 2,
                HeroClass = new Hero("Paladin"),
                Cards = new List<Card>
                {
                    new Card { Name = "Grimscale Chum" },
                    new Card { Name = "Murloc Tidecaller" },
                    new Card { Name = "Righteous Protector" },
                    new Card { Name = "Vilefin Inquisitor" },
                    new Card { Name = "Hydrologist" },
                    new Card { Name = "Knife Juggler" },
                    new Card { Name = "Rockpool Hunter" },
                    new Card { Name = "Coldlight Seer" },
                    new Card { Name = "Divine Favor" },
                    new Card { Name = "Murloc Warleader" },
                    new Card { Name = "Rallying Blade" },
                    new Card { Name = "Unidentified Maul" },
                    new Card { Name = "Call to Arms" },
                    new Card { Name = "Gentle Megasaur" },
                    new Card { Name = "Spellbreaker" },
                    new Card { Name = "Fungalmancer" },
                    new Card { Name = "Sunkeeper Tarim" },
                    new Card { Name = "Vinecleaver" },
                    new Card { Name = "Consecration" },  // tech vs Aggro
                    new Card { Name = "Leeroy Jenkins" },  // tech vs Control
                    new Card { Name = "Val'anyr" },
                }
            };
        }

        private static Deck DudePaladin()
        {
            return new Deck
            {
                Name = "Dude Paladin",
                Tier = 1,
                Rank = 3,
                HeroClass = new Hero("Paladin"),
                Cards = new List<Card>
                {
                    new Card { Name = "Argent Squire" },
                    new Card { Name = "Lost in the Jungle" },
                    new Card { Name = "Righteous Protector" },
                    new Card { Name = "Dire Wolf Alpha" },
                    new Card { Name = "Drygulch Jailor" },
                    new Card { Name = "Equality" },
                    new Card { Name = "Knife Juggler" },
                    new Card { Name = "Divine Favor" },
                    new Card { Name = "Rallying Blade" },
                    new Card { Name = "Steward of Darkshire" },
                    new Card { Name = "Unidentified Maul" },
                    new Card { Name = "Call to Arms" },
                    new Card { Name = "Lightfused Stegodon" },
                    new Card { Name = "Level Up!" },
                    new Card { Name = "Stand Against Darkness" },
                    new Card { Name = "Crystal Lion" },
                    new Card { Name = "Sunkeeper Tarim" },
                    new Card { Name = "Vinecleaver" },
                    new Card { Name = "Consecration" },  // tech
                }
            };
        }

        private static Deck ControlWarlock()
        {
            return new Deck
            {
                Name = "Control Warlock",
                Tier = 1,
                Rank = 5,
                HeroClass = new Hero("Warlock"),
                Cards = new List<Card>
                {
                    new Card { Name = "Dark Pact" },
                    new Card { Name = "Kobold Librarian" },
                    new Card { Name = "Mistress of Mixtures" },
                    new Card { Name = "Plated Beetle" },
                    new Card { Name = "Defile" },
                    new Card { Name = "Doomsayer" },
                    new Card { Name = "Hellfire" },
                    new Card { Name = "Lesser Amethyst Spellstone" },
                    new Card { Name = "Doomguard" },
                    new Card { Name = "Possessed Lackey" },
                    new Card { Name = "Voidlord" },
                    new Card { Name = "Bloodreaver Gul'dan" },
                    new Card { Name = "Acidic Swamp Ooze" },
                    new Card { Name = "Stonehill Defender" },
                    new Card { Name = "Spellbreaker" },
                    new Card { Name = "Rin the First Disciple" },
                    new Card { Name = "Siphon Soul" },
                    new Card { Name = "Skulking Geist" },
                    new Card { Name = "Twisting Nether" },
                    new Card { Name = "N'Zoth the Corruptor" },
                    new Card { Name = "Dirty Rat" },
                    new Card { Name = "Mortal Coil" },
                }
            };
        }

        private static Deck TempoMage()
        {
            return new Deck
            {
                Name = "Tempo Secret Mage",
                Tier = 2,
                Rank = 7,
                HeroClass = new Hero("Mage"),
                Cards = new List<Card>
                {
                    new Card { Name = "Kabal Lackey" },
                    new Card { Name = "Mana Wyrm" },
                    new Card { Name = "Arcanologist" },
                    new Card { Name = "Frostbolt" },
                    new Card { Name = "Medivh's Valet" },
                    new Card { Name = "Primordial Glyph" },
                    new Card { Name = "Sorcerer's Apprentice" },
                    new Card { Name = "Arcane Intellect" },
                    new Card { Name = "Counterspell" },
                    new Card { Name = "Explosive Runes" },
                    new Card { Name = "Ice Block" },
                    new Card { Name = "Kirin Tor Mage" },
                    new Card { Name = "Mana Bind" },
                    new Card { Name = "Fireball" },
                    new Card { Name = "Aluneth" },
                    new Card { Name = "Kabal Crystal Runner" },
                    new Card { Name = "Firelands Portal" },
                    new Card { Name = "Pyroblast" },
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
                    new Card { Name = "Candleshot" },
                    new Card { Name = "Hunter's Mark" },
                    new Card { Name = "Tracking" },
                    new Card { Name = "Cat Trick" },
                    new Card { Name = "Explosive Trap" },
                    new Card { Name = "Flare" },
                    new Card { Name = "Wandering Monster" },
                    new Card { Name = "Animal Companion" },
                    new Card { Name = "Deadly Shot" },
                    new Card { Name = "Eaglehorn Bow" },
                    new Card { Name = "Kill Command" },
                    new Card { Name = "Unleash the Hounds" },
                    new Card { Name = "Barnes" },
                    new Card { Name = "Flanking Strike" },
                    new Card { Name = "Lesser Emerald Spellstone" },
                    new Card { Name = "Deathstalker Rexxar" },
                    new Card { Name = "Rhok'delar" },
                    new Card { Name = "Y'Shaarj Rage Unbound" },
                    new Card { Name = "Freezing Trap" },
                    new Card { Name = "Call of the Wild" },
                }
            };
        }

        private static Deck SpitefulDragonPriest()
        {
            return new Deck
            {
                Name = "Spiteful Dragon Priest",
                Tier = 2,
                Rank = 9,
                HeroClass = new Hero("Priest"),
                Cards = new List<Card>
                {
                    new Card { Name = "Northshire Cleric" },
                    new Card { Name = "Netherspite Historian" },
                    new Card { Name = "Radiant Elemental" },
                    new Card { Name = "Shadow Visions" },
                    new Card { Name = "Kabal Talonpriest" },
                    new Card { Name = "Tar Creeper" },
                    new Card { Name = "Twilight Acolyte" },
                    new Card { Name = "Duskbreaker" },
                    new Card { Name = "Twilight Drake" },
                    new Card { Name = "Drakonid Operative" },
                    new Card { Name = "Book Wyrm" },
                    new Card { Name = "Shadow Ascendant" },
                    new Card { Name = "Curious Glimmerroot" },
                    new Card { Name = "Cobalt Scalebane" },
                    new Card { Name = "Kabal Songstealer" },
                    new Card { Name = "Spiteful Summoner" },
                    new Card { Name = "Free From Amber" },
                    new Card { Name = "Grand Archivist" },
                    new Card { Name = "Mind Control" },
                }
            };
        }

        private static Deck Zoolock()
        {
            return new Deck
            {
                Name = "Zoolock",
                Tier = 2,
                Rank = 10,
                HeroClass = new Hero("Warlock"),
                Cards = new List<Card>
                {
                    new Card { Name = "Flame Imp" },
                    new Card { Name = "Glacial Shard" },
                    new Card { Name = "Kobold Librarian" },
                    new Card { Name = "Malchezaar's Imp" },
                    new Card { Name = "Soulfire" },
                    new Card { Name = "Voidwalker" },
                    new Card { Name = "Demonfire" },
                    new Card { Name = "Vulgar Homunculus" },
                    new Card { Name = "Bloodfury Potion" },
                    new Card { Name = "Unlicensed Apothecary" },
                    new Card { Name = "Crystalweaver" },
                    new Card { Name = "Spellbreaker" },
                    new Card { Name = "Despicable Dreadlord" },
                    new Card { Name = "Doomguard" },
                    new Card { Name = "Fungalmancer" },
                }
            };
        }

        private static Deck BigBurstPriest()
        {
            return new Deck
            {
                Name = "Big Burst Priest",
                Tier = 2,
                Rank = 11,
                HeroClass = new Hero("Priest"),
                Cards = new List<Card>
                {
                    new Card { Name = "Holy Smite" },
                    new Card { Name = "Pint-Size Potion" },
                    new Card { Name = "Mind Blast" },
                    new Card { Name = "Shadow Visions" },
                    new Card { Name = "Spirit Lash" },
                    new Card { Name = "Shadow Word: Death" },
                    new Card { Name = "Barnes" },
                    new Card { Name = "Eternal Servitude" },
                    new Card { Name = "Greater Healing Potion" },
                    new Card { Name = "Shadow Word: Horror" },
                    new Card { Name = "Malygos" },
                    new Card { Name = "Prophet Velen" },
                    new Card { Name = "Obsidian Statue" },
                    new Card { Name = "Y'Shaarj Rage Unbound" },
                    new Card { Name = "Potion of Madness" },
                    new Card { Name = "Shadow Essence" },
                    new Card { Name = "Lesser Diamond Spellstone" },
                    new Card { Name = "Psychic Scream" },
                    new Card { Name = "Shadowreaper Anduin" },
                }
            };
        }

        private static Deck ComboPaladin()
        {
            return new Deck
            {
                Name = "Combo Paladin",
                Tier = 3,
                Rank = 12,
                HeroClass = new Hero("Paladin"),
                Cards = new List<Card>
                {
                    new Card { Name = "Blessing of Wisdom" },
                    new Card { Name = "Righteous Protector" },
                    new Card { Name = "Bloodmage Thalnos" },
                    new Card { Name = "Dirty Rat" },
                    new Card { Name = "Equality" },
                    new Card { Name = "Hydrologist" },
                    new Card { Name = "Loot Hoarder" },
                    new Card { Name = "Potion of Heroism" },
                    new Card { Name = "Wild Pyromancer" },
                    new Card { Name = "Autionmaster Beardo" },
                    new Card { Name = "Rallying Blade" },
                    new Card { Name = "Call to Arms" },
                    new Card { Name = "Consecration" },
                    new Card { Name = "Spellbreaker" },
                    new Card { Name = "Burgly Bully" },
                    new Card { Name = "Spikeridged Steed" },
                    new Card { Name = "Sunkeeper Tarim" },
                    new Card { Name = "Lynessa Sunsorrow" },
                    new Card { Name = "Uther of the Ebon Blade" },
                }
            };
        }

        private static Deck ControlMage()
        {
            return new Deck
            {
                Name = "Control Mage",
                Tier = 3,
                Rank = 13,
                HeroClass = new Hero("Mage"),
                Cards = new List<Card>
                {
                    new Card { Name = "Arcane Artificer" },
                    new Card { Name = "Arcanologist" },
                    new Card { Name = "Dirty Rat" },
                    new Card { Name = "Doomsayer" },
                    new Card { Name = "Raven Familiar" },
                    new Card { Name = "Coldlight Oracle" },
                    new Card { Name = "Ice Block" },
                    new Card { Name = "Tar Creeper" },
                    new Card { Name = "Polymorph" },
                    new Card { Name = "Dragon's Fury" },
                    new Card { Name = "Blizzard" },
                    new Card { Name = "Meteor" },
                    new Card { Name = "Skulking Geist" },
                    new Card { Name = "Firelands Portal" },
                    new Card { Name = "Flamestrike" },
                    new Card { Name = "Medivh the Guardian" },
                    new Card { Name = "Alexstrasza" },
                    new Card { Name = "Dragoncaller Alanna" },
                    new Card { Name = "Frost Lich Jaina" },
                }
            };
        }

        private static Deck FaceHunter()
        {
            return new Deck
            {
                Name = "Face Hunter",
                Tier = 3,
                Rank = 14,
                HeroClass = new Hero("Hunter"),
                Cards = new List<Card>
                {
                    new Card { Name = "Alleycat" },
                    new Card { Name = "Dire Mole" },
                    new Card { Name = "Hungry Crab" },
                    new Card { Name = "Crackling Razormaw" },
                    new Card { Name = "Dire Wolf Alpha" },
                    new Card { Name = "Kindly Grandmother" },
                    new Card { Name = "Knife Juggler" },
                    new Card { Name = "Scavenging Hyena" },
                    new Card { Name = "Animal Companion" },
                    new Card { Name = "Eaglehorn Bow" },
                    new Card { Name = "Kill Command" },
                    new Card { Name = "Unleash the Hounds" },
                    new Card { Name = "Houndmaster" },
                    new Card { Name = "Spellbreaker" },
                    new Card { Name = "Bittertide Hydra" },
                    new Card { Name = "Leeroy Jenkins" },
                }
            };
        }

        private static Deck ControlPaladin()
        {
            return new Deck
            {
                Name = "Control Paladin",
                Tier = 3,
                Rank = 15,
                HeroClass = new Hero("Paladin"),
                Cards = new List<Card>
                {
                    new Card { Name = "Dirty Rat" },
                    new Card { Name = "Equality" },
                    new Card { Name = "Loot Hoarder" },
                    new Card { Name = "Plated Beetle" },
                    new Card { Name = "Wild Pyromancer" },
                    new Card { Name = "Rallying Blade" },
                    new Card { Name = "Stonehill Defender" },
                    new Card { Name = "Zola the Gorgon" },
                    new Card { Name = "Call to Arms" },
                    new Card { Name = "Consecration" },
                    new Card { Name = "Harrison Jones" },
                    new Card { Name = "Cairn Bloodhoof" },
                    new Card { Name = "Skulking Geist" },
                    new Card { Name = "Spikeridged Steed" },
                    new Card { Name = "Sunkeeper Tarim" },
                    new Card { Name = "Ragnaros Lightlord" },
                    new Card { Name = "Tirion Fordring" },
                    new Card { Name = "Uther of the Ebon Blade" },
                    new Card { Name = "Ysera" },
                    new Card { Name = "N'Zoth the Corruptor" },
                }
            };
        }

        private static Deck EvolveShaman()
        {
            return new Deck
            {
                Name = "Token Evolve Shaman",
                Tier = 3,
                Rank = 16,
                HeroClass = new Hero("Shaman"),
                Cards = new List<Card>
                {
                    new Card { Name = "Dire Mole" },
                    new Card { Name = "Evolve" },
                    new Card { Name = "Fire Fly" },
                    new Card { Name = "Unstable Evolution" },
                    new Card { Name = "Devolve" },
                    new Card { Name = "Flametongue Totem" },
                    new Card { Name = "Jade Claws" },
                    new Card { Name = "Maelstrom Portal" },
                    new Card { Name = "Mana Tide Totem" },
                    new Card { Name = "Stonehill Defender" },
                    new Card { Name = "Jade Lightning" },
                    new Card { Name = "Master of Evolution" },
                    new Card { Name = "Bloodlust" },
                    new Card { Name = "Dopplegangster" },
                    new Card { Name = "Thrall Deathseer" },
                    new Card { Name = "Volcano" },
                    new Card { Name = "Corridor Creeper" },
                }
            };
        }

        private static Deck ControlWarrior()
        {
            return new Deck
            {
                Name = "Control Warrior",
                Tier = 3,
                Rank = 17,
                HeroClass = new Hero("Warrior"),
                Cards = new List<Card>
                {
                    new Card { Name = "Shield Slam" },
                    new Card { Name = "Whirlwind" },
                    new Card { Name = "Bring It On!" },
                    new Card { Name = "Dead Man's Hand" },
                    new Card { Name = "Dirty Rat" },
                    new Card { Name = "Drywhisker Armorer" },
                    new Card { Name = "Execute" },
                    new Card { Name = "Slam" },
                    new Card { Name = "Sleep with the Fishes" },
                    new Card { Name = "Acolyte of Pain" },
                    new Card { Name = "Coldlight Oracle" },
                    new Card { Name = "Shield Block" },
                    new Card { Name = "Blood Razor" },
                    new Card { Name = "Brawl" },
                    new Card { Name = "Harrison Jones" },
                    new Card { Name = "Scourgelord Garrosh" },
                }
            };
        }

        private static Deck JadeShaman()
        {
            return new Deck
            {
                Name = "Jade Shaman",
                Tier = 3,
                Rank = 18,
                HeroClass = new Hero("Shaman"),
                Cards = new List<Card>
                {
                    new Card { Name = "Devolve" },
                    new Card { Name = "Jade Claws" },
                    new Card { Name = "Maelstrom Portal" },
                    new Card { Name = "Murmuring Elemental" },
                    new Card { Name = "Coldlight Oracle" },
                    new Card { Name = "Healing Rain" },
                    new Card { Name = "Rummaging Kobold" },
                    new Card { Name = "Hex" },
                    new Card { Name = "Jade Lightning" },
                    new Card { Name = "Jade Spirit" },
                    new Card { Name = "Jinyu Waterspeaker" },
                    new Card { Name = "Harrison Jones" },
                    new Card { Name = "Thrall Deathseer" },
                    new Card { Name = "Volcano" },
                    new Card { Name = "Aya Blackpaw" },
                    new Card { Name = "Grumble Worldshaker" },
                    new Card { Name = "Jade Chieftan" },
                }
            };
        }

        private static Deck MillRogue()
        {
            return new Deck
            {
                Name = "Kingsbane Mill Rogue",
                Tier = 3,
                Rank = 19,
                HeroClass = new Hero("Rogue"),
                Cards = new List<Card>
                {
                    new Card { Name = "Backstab" },
                    new Card { Name = "Preparation" },
                    new Card { Name = "Shadowstep" },
                    new Card { Name = "Deadly Poison" },
                    new Card { Name = "Doomerang" },
                    new Card { Name = "Kingsbane" },
                    new Card { Name = "Cavern Shinyfinder" },
                    new Card { Name = "Doomsayer" },
                    new Card { Name = "Leeching Poison" },
                    new Card { Name = "Sap" },
                    new Card { Name = "Coldlight Oracle" },
                    new Card { Name = "Elven Minstrel" },
                    new Card { Name = "Nage Corsair" },
                    new Card { Name = "Southsea Squidface" },
                    new Card { Name = "Captain Greenskin" },
                    new Card { Name = "Vanish" },
                    new Card { Name = "Valeera the Hollow" },
                }
            };
        }

        private static Deck MiracleRogue()
        {
            return new Deck
            {
                Name = "Miracle Rogue",
                Tier = 3,
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

        private static Deck SpitefulDruid()
        {
            return new Deck
            {
                Name = "Spiteful Druid",
                Tier = 3,
                Rank = 21,
                HeroClass = new Hero("Druid"),
                Cards = new List<Card>
                {
                    new Card { Name = "Enchanted Raven" },
                    new Card { Name = "Hungry Crab" },
                    new Card { Name = "Beckoner of Evil" },
                    new Card { Name = "Disciple of C'Thun" },
                    new Card { Name = "Greedy Sprite" },
                    new Card { Name = "Mind Control Tech" },
                    new Card { Name = "Tar Creeper" },
                    new Card { Name = "Twilight Elder" },
                    new Card { Name = "C'Thun's Chosen" },
                    new Card { Name = "Mire Keeper" },
                    new Card { Name = "Dark Arakkoa" },
                    new Card { Name = "Spiteful Summoner" },
                    new Card { Name = "Malfurion the Pestilent" },
                    new Card { Name = "Twin Emperor Vak'lor" },
                    new Card { Name = "Grand Archivist" },
                    new Card { Name = "C'Thun" },
                    new Card { Name = "Kun the Forgotten King" },
                    new Card { Name = "Ultimate Infestation" },
                }
            };
        }

        private static Deck JadeDruid()
        {
            return new Deck
            {
                Name = "Jade Druid",
                Tier = 3,
                Rank = 22,
                HeroClass = new Hero("Druid"),
                Cards = new List<Card>
                {
                    new Card { Name = "Innervate" },
                    new Card { Name = "Jade Idol" },
                    new Card { Name = "Lesser Jasper Spellstone" },
                    new Card { Name = "Mark of the Lotus" },
                    new Card { Name = "Wild Growth" },
                    new Card { Name = "Jade Blossom" },
                    new Card { Name = "Branching Paths" },
                    new Card { Name = "Fandral Staghelm" },
                    new Card { Name = "Oaken Summons" },
                    new Card { Name = "Swipe" },
                    new Card { Name = "Violent Teacher" },
                    new Card { Name = "Nourish" },
                    new Card { Name = "Aya Blackpaw" },
                    new Card { Name = "Jade Behemoth" },
                    new Card { Name = "Spreading Plague" },
                    new Card { Name = "Malfurion the Pestilent" },
                    new Card { Name = "Ultimate Infestation" },
                }
            };
        }

        private static Deck TempoRogue()
        {
            return new Deck
            {
                Name = "Tempo Rogue",
                Tier = 3,
                Rank = 23,
                HeroClass = new Hero("Rogue"),
                Cards = new List<Card>
                {
                    new Card { Name = "Backstab" },
                    new Card { Name = "Shadowstep" },
                    new Card { Name = "Fire Fly" },
                    new Card { Name = "Glacial Shard" },
                    new Card { Name = "Prince Keleseth" },
                    new Card { Name = "Edwin VanCleef" },
                    new Card { Name = "SI:7 Agent" },
                    new Card { Name = "Tar Creeper" },
                    new Card { Name = "Elven Minstrel" },
                    new Card { Name = "Fire Plume Phoenix" },
                    new Card { Name = "Saronite Chang Gang" },
                    new Card { Name = "Fungalmancer" },
                    new Card { Name = "Shadowcaster" },
                    new Card { Name = "Vilespine Slayer" },
                    new Card { Name = "Blazecaller" },
                    new Card { Name = "The Lich King" },
                }
            };
        }

        private static Deck QuestMage()
        {
            return new Deck
            {
                Name = "Quest Mage",
                Tier = 3,
                Rank = 24,
                HeroClass = new Hero("Mage"),
                Cards = new List<Card>
                {
                    new Card { Name = "Arcane Artificer" },
                    new Card { Name = "Babbling Book" },
                    new Card { Name = "Open the Waygate" },
                    new Card { Name = "Arcanologist" },
                    new Card { Name = "Doomsayer" },
                    new Card { Name = "Novice Engineer" },
                    new Card { Name = "Primordial Glyph" },
                    new Card { Name = "Sorcerer's Apprentice" },
                    new Card { Name = "Arcane Intellect" },
                    new Card { Name = "Coldlight Oracle" },
                    new Card { Name = "Frost Nova" },
                    new Card { Name = "Ice Barrier" },
                    new Card { Name = "Ice Block" },
                    new Card { Name = "Molten Reflection" },
                    new Card { Name = "Cabalist's Tome" },
                    new Card { Name = "Blizzard" },
                    new Card { Name = "Archmage Antonidas" },
                }
            };

        }

        private static Deck AggroDruid()
        {
            return new Deck
            {
                Name = "Aggro Druid",
                Tier = 3,
                Rank = 25,
                HeroClass = new Hero("Druid"),
                Cards = new List<Card>
                {
                    new Card { Name = "Dire Mole" },
                    new Card { Name = "Enchanted Raven" },
                    new Card { Name = "Fire Fly" },
                    new Card { Name = "Hungry Crab" },
                    new Card { Name = "Mark of the Lotus" },
                    new Card { Name = "Murloc Tidecaller" },
                    new Card { Name = "Druid of the Swarm" },
                    new Card { Name = "Mark of Y'Shaarj" },
                    new Card { Name = "Power of the Wild" },
                    new Card { Name = "Rockpool Hunter" },
                    new Card { Name = "Murloc Warleader" },
                    new Card { Name = "Savage Roar" },
                    new Card { Name = "Viscious Fledgling" },
                    new Card { Name = "Gentle Megasaur" },
                    new Card { Name = "Finja the Flying Star" },
                    new Card { Name = "Living Mana" },
                }
            };
        }

        private static Deck QuestRogue()
        {
            return new Deck
            {
                Name = "Quest Rogue",
                Tier = 4,
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
                    new Card { Name = "Bluegill Warrior" },
                    new Card { Name = "Gadgetzan Ferryman" },
                    new Card { Name = "Novice Engineer" },
                    new Card { Name = "Sap" },
                    new Card { Name = "Youthful Brewmaster" },
                    new Card { Name = "Coldlight Oracle" },
                    new Card { Name = "Mimic Pod" },
                    new Card { Name = "Sonya Shadowdancer" },
                    new Card { Name = "Zola the Gorgon" },
                    new Card { Name = "Vanish" },
                }
            };
        }

        private static Deck BigDragonDruid()
        {
            return new Deck
            {
                Name = "Big Dragon Druid",
                Tier = 4,
                Rank = 27,
                HeroClass = new Hero("Druid"),
                Cards = new List<Card>
                {
                    new Card { Name = "Earthen Scales" },
                    new Card { Name = "Wild Growth" },
                    new Card { Name = "Drakkari Enchanter" },
                    new Card { Name = "Jade Blossom" },
                    new Card { Name = "Bright-Eyed Scout" },
                    new Card { Name = "Mire Keeper" },
                    new Card { Name = "Swipe" },
                    new Card { Name = "Nourish" },
                    new Card { Name = "Spreading Plague" },
                    new Card { Name = "Malfurion the Pestilent" },
                    new Card { Name = "Dragonhatcher" },
                    new Card { Name = "Master Oakheart" },
                    new Card { Name = "Sleepy Dragon" },
                    new Card { Name = "Ysera" },
                    new Card { Name = "Deathwing" },
                    new Card { Name = "Deathwing, Dragonlord" },
                    new Card { Name = "Kun the Forgotten King" },
                    new Card { Name = "Ultimate Infestation" },
                    new Card { Name = "Y'Shaarj Rage Unbound" },
                }
            };
        }

        private static Deck PirateWarrior()
        {
            return new Deck
            {
                Name = "Pirate Warrior",
                Tier = 4,
                Rank = 28,
                HeroClass = new Hero("Warrior"),
                Cards = new List<Card>
                {
                    new Card { Name = "N'Zoth's First Mate" },
                    new Card { Name = "Patches the Pirate" },
                    new Card { Name = "Southsea Deckhand" },
                    new Card { Name = "Upgrade!" },
                    new Card { Name = "Bloodsail Raider" },
                    new Card { Name = "Heroic Strike" },
                    new Card { Name = "Bloodsail Cultist" },
                    new Card { Name = "Fiery War Axe" },
                    new Card { Name = "Frothing Berserker" },
                    new Card { Name = "Southsea Captain" },
                    new Card { Name = "Dread Corsair" },
                    new Card { Name = "Kor'kron Elite" },
                    new Card { Name = "Spellbreaker" },
                    new Card { Name = "Arcanite Reaper" },
                    new Card { Name = "Bittertide Hydra" },
                    new Card { Name = "Leeroy Jenkins" },
                }
            };
        }


        private static Deck BlankDeck()
        {
            return new Deck
            {
                Name = "Blank Deck",
                HeroClass = new Hero(""),
                Cards = new List<Card>
                {
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                    new Card { Name = "" },
                }
            };
        }
    }
}
