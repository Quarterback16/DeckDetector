using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
	public class DeckParser
	{
		public string DeckName { get; set; }
		public string Class { get; set; }

		public List<Card> Cards { get; set; }
		public List<string> Code { get; set; }

		public void LoadInput(string fileName)
		{
			Cards = new List<Card>();
			Code = new List<string>();

			fileName = $"d:\\temp\\{fileName}.txt";
			string[] lines = System.IO.File.ReadAllLines(
				fileName);
			var lineNo = 0;
			var start = false;

			foreach (string line in lines)
			{
				// Use a tab to indent each line of the file.
				//Console.WriteLine(Environment.NewLine + line);

				lineNo++;
				if (lineNo.Equals(1))
					DeckName = LineFrom(line, 4);
				if (lineNo.Equals(2))
					Class = LineFrom(line, 9);
				if (line.Trim().Equals("#"))
				{
					start = true;
				}
				else
				{
					if (start)
					{
						if (!line.Substring(0,1).Equals("#"))
						{
							break;
						}
						ProcessLine(line);
					}
				}
			}
		}

		public void DisplayCode()
		{
			AddCode($"private static Deck {WikiName(DeckName)}()");
			AddCode( "{");
			AddCode("\treturn new Deck");
			AddCode("\t{");
			AddCode($"\t\tName = \"{DeckName}\",");
			AddCode($"\t\tPrototype = \"CONTROL\",");
			AddCode($"\t\tTier = 5,");
			AddCode($"\t\tRank = 25,");
			AddCode($"\t\tHeroClass = new Hero(\"{Class}\"),");
			AddCode($"\t\tCards = new List<Card>");
			AddCode("\t\t{");
			foreach (var card in Cards)
			{
				AddCode("\t\t\tnew Card { Name = \""
					+ $"{card.Name}\"" 
					+ " },");
			}
			AddCode("\t\t}");
			AddCode("\t};");
			AddCode( "}");

			foreach (var item in Code)
			{
				Console.WriteLine($"\t\t{item}");
			}
		}

		private void AddCode(string line1)
		{
			Code.Add(line1);
		}

		private string WikiName(
			string deckName)
		{
			return deckName.Replace(" ", string.Empty);
		}

		private string LineFrom(string line, int where)
		{
			return line.Substring(where, line.Length - where);
		}

		private void ProcessLine(string line)
		{
			var qty = int.Parse(line.Substring(2,1));
			var name = LineFrom(line, 9);
			var card = new Card
			{
				Single = qty == 1 ? true : false,
				Name = name
			};
			Cards.Add(card);
		}
	}
}
