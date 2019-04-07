namespace Domain
{
	public class Record
	{
		public string Name { get; set; }
		public int Wins { get; set; }
		public int Losses { get; set; }

		public override string ToString()
		{
			return $"{Name}: ({Wins}-{Losses}) {Percent(),5}";
		}

		private string Percent()
		{
			if (TotalGames() == 0)
				return "0%";
			return $"{  Wins / (decimal) TotalGames() * 100M:####0}%";
		}

		private int TotalGames()
		{
			return Wins + Losses;
		}
	}
}
