using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				MuckShaman(),
				DragonSecretPaladin(),
				BombWarrior()
			};
			meta.AddDecks(tier1Decks, 1);

			//  TIER 2
			var tier2Decks = new List<Deck>
			{
				MurlocShaman(),
				Zoolock()
			};
			meta.AddDecks(tier2Decks, 2);

			//  TIER 3
			var tier3Decks = new List<Deck>
			{

			};
			meta.AddDecks(tier3Decks, 3);

			//  TIER 4
			var tier4Decks = new List<Deck>
			{

			};
			meta.AddDecks(tier4Decks, 4);

			////  TIER 5
			var tier5Decks = new List<Deck>
			{

			};
			meta.AddDecks(tier5Decks, 5);

			return meta;
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

		private static Deck MidrangeHunter()
		{
			return new Deck
			{
				Name = "Midrange Hunter",
				Prototype = "TEMPO",
				Tier = 1,
				Rank = 1,
				HeroClass = new Hero("Hunter"),
				Cards = new List<Card>
				{
					new Card { Name = "Candleshot" },
					new Card { Name = "Dire Mole" },
					new Card { Name = "Springpaw" },
					new Card { Name = "Timber Wolf" },
					new Card { Name = "Tracking" },
					new Card { Name = "Crackling Razormaw" },
					new Card { Name = "Revenge of the Wild" },
					new Card { Name = "Scavenging Hyena" },
					new Card { Name = "Animal Companion" },
					new Card { Name = "Kill Command" },
					new Card { Name = "Headhunter's Hatchet" },

					new Card { Name = "Master's Call" },
					new Card { Name = "Unleash the Hounds" },
					new Card { Name = "Dire Frenzy" },
					new Card { Name = "Flanking Strike" },
					new Card { Name = "Tundra Rhino" },
					new Card { Name = "Deathstalker Rexxar" },
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
