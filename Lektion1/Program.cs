using System;

namespace Lektion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.SetName("Anna");
            c.SetLastName("Book");
            GrandChild gc = new GrandChild("Michael");
            gc.SetLastName("Andersson");
            GrandChild gc2 = new GrandChild("Simon");
            GrandChild p = gc + gc2;
            Console.WriteLine(p.GetName());
        }
    }
}