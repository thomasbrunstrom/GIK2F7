using System;

namespace Lektion2
{
    public class InvisibleMan : SuperHero
    {
        public InvisibleMan()
        {
            Ability = Abilites.Invisiblity;
        }
        public InvisibleMan(string Name, int Strength, int Stamina) : base(Name, Strength, Stamina)
        {
            Ability = Abilites.Invisiblity;
        }
        public override Abilites GetAbility()
        {
            return Ability;
        }
    }
}
