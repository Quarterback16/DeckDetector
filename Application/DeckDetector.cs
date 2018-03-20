using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class DeckDetector
    {
        public Meta CurrentMeta { get; set; }

        public DeckDetector()
        {
            LoadKatacombsAndKoboldsPostNerfMeta();
        }

        private void LoadKatacombsAndKoboldsPostNerfMeta()
        {
            var meta = new Meta("MC2", "Katacombs And Kobolds Post Nerf");
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
            LoadMeta(meta);
        }

        public void LoadMeta(Meta meta)
        {
            CurrentMeta = meta;
        }

        public List<Deck> ListDecks()
        {
            return CurrentMeta.Decks;
        }

        public List<Deck> ListDecks(string heroClass)
        {
            var list = CurrentMeta.Decks.Where(d => d.HeroClass.Name.Equals(heroClass));
            return list.ToList();
        }

        public List<Deck> ListDecks(string heroClass, string[] played)
        {
            //  deck must all the cards played
            var shortList = new List<Deck>();
            var list = CurrentMeta.Decks.Where(d => d.HeroClass.Name.Equals(heroClass));
            foreach (Deck deck in list.ToList())
            {
                var cardCount = 0;
                for (int i = 0; i < played.Length; i++)
                {
                    List<Card> cards = deck.Cards;
                    if (deck.HasCardNamed(played[i]))
                    {
                        cardCount++;
                    }
                }
                if (cardCount.Equals(played.Length))
                    shortList.Add(deck);
            }
            return shortList.ToList();
        }

        private static Deck ComboDragonPriest()
        {
            return new Deck
            {
                Name = "Combo Dragon Priest",
                HeroClass = new Hero("Priest"),
                Cards = new List<Card>
                {
                    new Card { Name = "Inner Fire" },
                    new Card { Name = "Northsire Cleric" },
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
                HeroClass = new Hero("Priest"),
                Cards = new List<Card>
                {
                    new Card { Name = "Northsire Cleric" },
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
                    new Card { Name = "Shadowreader Anduin" },
                }
            };
        }

        private static Deck Cubelock()
        {
            return new Deck
            {
                Name = "Cubelock",
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
                    new Card { Name = "Divine Favour" },
                    new Card { Name = "Rallying Blade" },
                    new Card { Name = "Steward of Darkshire" },
                    new Card { Name = "Unidentified Maul" },
                    new Card { Name = "Call to Arms" },
                    new Card { Name = "Lightfused Stegodon" },
                    new Card { Name = "Level Up!" },
                    new Card { Name = "Stand Against Darkness" },
                    new Card { Name = "Cyrstal Lion" },
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
                HeroClass = new Hero("Warlock"),
                Cards = new List<Card>
                {
                    new Card { Name = "Dark Pact" },
                    new Card { Name = "Kobold Librarian" },
                    new Card { Name = "Mistress of Mixtures" },
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
                    new Card { Name = "Rin, the First Disciple" },
                    new Card { Name = "Siphon Soul" },
                    new Card { Name = "Skulking Geist" },
                    new Card { Name = "Twisting Nether" },
                    new Card { Name = "N'Zoth, the Corruptor" },
                    new Card { Name = "Dirty Rat" },
                    new Card { Name = "Mortal Coil" },
                }
            };
        }

        private static Deck TempoMage()
        {
            return new Deck
            {
                Name = "Tempo Mage",
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
                    new Card { Name = "Y'Shaarj, Rage Unbound" },
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
                HeroClass = new Hero("Priest"),
                Cards = new List<Card>
                {
                    new Card { Name = "Northsire Cleric" },
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
                }
            };
        }

        private static Deck Zoolock()
        {
            return new Deck
            {
                Name = "Zoolock",
                HeroClass = new Hero("Warlock"),
                Cards = new List<Card>
                {
                    new Card { Name = "Flame Imp" },
                    new Card { Name = "Clacial Shard" },
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
                }
            };
        }

        private static Deck BigBurstPriest()
        {
            return new Deck
            {
                Name = "Big Burst Priest",
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
                    new Card { Name = "Y'Shaarj, Rage Unbound" },
                    new Card { Name = "Potion of Madness" },
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
