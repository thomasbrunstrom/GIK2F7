using System;

namespace Lektion2
{
    public class TacoDude : SuperHero
    {
        public TacoDude()
        {

        }
        public TacoDude(string Name, int Strength, int Stamina) : base(Name, Strength, Stamina)
        {
            Ability = Abilites.Burrito;
        }

        public override Abilites GetAbility()
        {
            return Ability;
        }

    }
}
