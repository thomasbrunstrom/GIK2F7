using System;

namespace Lektion2
{
    public interface ISuperHero : IComparable
    {
        int Strength { get; set; }
        int Stamina { get; set; }
        string Name { get; set; }
    }
}
