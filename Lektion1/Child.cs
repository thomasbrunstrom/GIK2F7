using System;

namespace Lektion1
{
    public class Child : Parent
    {
        protected string LastName;

        public override string GetName()
        {
            return this.Name;
        }
        public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }

        public override string ToString()
        {
            return this.Name + " " + this.LastName;
        }
    }
}
