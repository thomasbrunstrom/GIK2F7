using System;
using System.Collections.Generic;

namespace Lektion2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISuperHero> InvisibleManList = new List<ISuperHero>();
            for(int i = 0; i < 5; i++) 
            {
                int strength = new Random().Next(-10, 11);
                int stamina = new Random().Next(-10, 11);
                InvisibleMan im = new InvisibleMan("InvisibleMan", strength, stamina);
                TacoDude td = new TacoDude("Cheese man", strength, stamina);
                InvisibleManList.Add(im);
                InvisibleManList.Add(td);
            }
        }
    }
}