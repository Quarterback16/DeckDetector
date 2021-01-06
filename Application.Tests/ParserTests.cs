using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace Application.Tests
{
	[TestClass]
	public class ParserTests
	{
		[TestMethod]
		public void DeckParserLoadsSingleInput()
		{
			var sut = new DeckParser();
			sut.LoadInput("Vargoth OTK Mage");
			sut.DisplayCode();
		}

		[TestMethod]
		public void DeckParserLoadsMany()
		{
			var filesIn = new List<string>();
			DirectoryInfo d = new DirectoryInfo(
				path: @"d:\temp\decks");
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				filesIn.Add(
					Path.GetFileNameWithoutExtension(file.Name));
			}
			var sut = new DeckParser();
			sut.AddCode("#region Decks");
			foreach (var item in filesIn)
			{
				sut.LoadInput(item);
				sut.DisplayCode();
			}
			Console.WriteLine($"#endregion");
		}

		[TestMethod]
		public void DeckParserCodesNames()
		{
			var filesIn = new List<string>();
			DirectoryInfo d = new DirectoryInfo(
				path: @"d:\temp\decks");
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				filesIn.Add(
					Path.GetFileNameWithoutExtension(file.Name));
			}
			var sut = new DeckParser();

			foreach (var item in filesIn)
			{
				sut.LoadLine(item);
			}
		}
	}
}
