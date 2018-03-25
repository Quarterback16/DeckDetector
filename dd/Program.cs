using Application;
using CommandLine;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dd
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            IEnumerable<string> cardsPlayed = new List<string>();

            var result = Parser.Default.ParseArguments<Options>(args)
                .WithParsed(o => options.HeroClass = o.HeroClass)
                .WithParsed(o => cardsPlayed = o.Played);

            var dd = new DeckDetector();

            var decks = dd.ListDecks(options.HeroClass, cardsPlayed.ToArray());
            if (decks.Count == 0)
                Console.WriteLine("Unknown Deck");
            else
                DumpDecks(decks);

            Console.WriteLine();
        }

        private static void DumpDecks(List<Deck> results)
        {
            var deckCount = 0;
            Deck theFirstDeck = new Deck();
            Deck theDeck = new Deck();
            foreach (var deck in results)
            {
                deckCount++;
                if (deckCount == 1)
                    theFirstDeck = deck;
                Console.WriteLine($"T{deck.Tier} {deck.Name} ({deck.Rank})");
                theDeck = deck;
            }
            if (results.Count == 1)
            {
                theDeck.Dump();
            }
            else if (deckCount > 1)
                theFirstDeck.Dump();
        }
    }
}
