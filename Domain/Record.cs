namespace Domain
{
	public class Record
	{
		public string Name { get; set; }
		public int Wins { get; set; }
		public int Losses { get; set; }

		public override string ToString()
		{
			return $"{Name}: ({Wins,2}-{Losses,2}) {Percent(),5}";
		}

		public string Percent()
		{
			if (TotalGames() == 0)
				return "0%";
			return $"{  Clip() * 100M:####0}%";
		}

		public decimal Clip()
		{
			if (TotalGames() == 0)
				return 0.000M;

			return Wins / (decimal)TotalGames() ;
		}

		public int TotalGames()
		{
			return Wins + Losses;
		}
	}
}
