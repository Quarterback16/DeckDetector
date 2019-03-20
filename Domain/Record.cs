namespace Domain
{
	public class Record
	{
		public string Name { get; set; }
		public int Wins { get; set; }
		public int Losses { get; set; }

		public override string ToString()
		{
			return $"{Name}: ({Wins}-{Losses})";
		}
	}
}
