using CommandLine;
using System.Collections.Generic;

namespace dd
{
    internal class Options
    {
        [Option('c')]
        public string HeroClass { get; set; }

        [Option('p', Separator =',')]
        public IEnumerable<string> Played { get; set; }

		[Option('r')]
		public string Report { get; set; }

        [Option('d')]
        public string ReportDate { get; set; }

		[Option('o')]
		public string Opponent { get; set; }

		[Option('m')]
		public string Mulligan { get; set; }
	}
}
