using System;

namespace Lektion1
{
    public abstract class Parent
    {
        protected string Name;
        public Parent()
        {
            
        }
        public virtual string GetName()
        {
            return Name;
        }
        public virtual void SetName(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
