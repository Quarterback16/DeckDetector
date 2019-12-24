using System;
using System.IO;
using Domain;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class CardParser
    {
        public List<Card> Cards { get; set; }
        public List<string> Code { get; set; }

        public CardParser()
		{
            Cards = new List<Card>();
            Code = new List<string>();
        }

        public int LoadInput(string fileName)
        {
            fileName = $"d:\\temp\\cards\\{fileName}.csv";
            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var cardName = values[0];
                    var manaCost = values[1];
                    var cardType = values[2];

                    var card = new Card(
                        cardName, 
                        Int32.Parse(manaCost), 
                        cardType);

                    Console.WriteLine(
                        $"{card}");

                    Cards.Add(card);
                }
            }
            return Cards.Count;
        }

		public void DisplayCode()
		{
			foreach (var card in Cards)
				AddCode(CodeLine(card));

            foreach (var item in Code)
                Console.WriteLine($"{item}");
        }

        private string CodeLine(Card card)
        {
            var sb = new StringBuilder();
            sb.Append($"[\"{card.Name}\", ");
            sb.Append($"new CardData [ ManaCost = {card.Mana},");
            if (card.CardType == "Secret")
                sb.Append(" IsSecret = true,");
            if (card.CardType == "Weapon")
                sb.Append(" IsWeapon = true,");
            sb.Append($"] ],");
            return sb.ToString()
                .Replace('[','{')
                .Replace(']','}');
        }

        public void AddCode(string line1)
        {
            Code.Add(line1);
        }
    }
}
