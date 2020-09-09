using System;

namespace Lektion2
{
    public enum Abilites 
    {
        Invisiblity,
        Teleportation,
        SuperStrength, 
        Speed,
        Burrito,
    }
    public enum Colors 
    {
        Red,
        Green,
        Blue,
        White,
        Black,
    }

    public abstract class SuperHero : ISuperHero
    {
        public bool HasCape { get; set; }
        public string Name { get; set; }

        private int m_Strength;
        public int Strength { 
            get 
            {
                return m_Strength;
            } 
            set {
                if(value > -11 && value < 11) 
                {
                    m_Strength = value;
                }
                else {
                    throw new ArgumentOutOfRangeException("Value strength has to be between -10 and 10.");
                }
            } 
        }
        private int m_Stamina;
        public int Stamina { 
            get 
            {
                return m_Stamina;
            } 
            set {
                if(value > -11 && value < 11) 
                {
                    m_Stamina = value;
                }
                else {
                    throw new ArgumentOutOfRangeException("Value stamina has to be between -10 and 10.");
                }
            } 
        }
        protected Abilites Ability;
        public SuperHero()
        {

        }
        public SuperHero(string Name, int Strength, int Stamina)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Stamina = Stamina;
        }
        public abstract Abilites GetAbility();

        public override string ToString()
        {
            return Name + " " + Strength + " " + Stamina;
        }

        public int CompareTo(object obj)
        {
            SuperHero td = (SuperHero)obj;
            if(Strength > td.Strength) 
            {
                return 1;
            }
            else if(Strength < td.Strength)
            {
                return -1;
            }
            return 0;
        }
    }
}