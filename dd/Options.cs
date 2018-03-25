using CommandLine;
using System.Collections.Generic;

namespace dd
{
    class Options
    {
        [Option('c')]
        public string HeroClass { get; set; }

        [Option('p', Separator =',')]
        public IEnumerable<string> Played { get; set; }
    }
}
