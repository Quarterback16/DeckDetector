using System;

namespace Domain
{
    public class Hero
    {
        public string Name { get; set; }
        public HeroClass HeroClass { get; set; }
        public Hero(string name )
        {
            Name = name;
            Enum.TryParse(name, out HeroClass heroClass);
            HeroClass = heroClass;
        }
    }
}
