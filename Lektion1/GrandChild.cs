using System;

namespace Lektion1
{
    public class GrandChild : Child
    {
        protected string Address {
            get;
            set;
        }

        private int Age;

        public GrandChild() : base()
        {
        }
        public GrandChild(string Name)
        {
            this.Name = Name;
        }

        public GrandChild(int Age)
        {
            this.Age = Age;
        }
        public GrandChild(string Name, int Age) 
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void PrintInfo(bool showAge = false)
        {
            if(showAge) 
            {
                Console.WriteLine(Name + " " + Age);
            }
            else 
            {
                Console.WriteLine(Name);
            }
        }

        public override void SetName(string Name) 
        {

        }
        public static GrandChild operator+ (GrandChild a, GrandChild b)
        {
            GrandChild c = new GrandChild();
            c.Name = b.Name;
            c.LastName = a.LastName;
            return c;
        }
    }
}
