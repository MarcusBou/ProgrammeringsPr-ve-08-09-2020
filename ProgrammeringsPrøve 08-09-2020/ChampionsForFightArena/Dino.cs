using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve_08_09_2020.ChampionsForFightArena
{
    class Dino: Champions
    {
        public Dino()//Dino's attack and defence isnt defined, since he has a range of damage or defence
        {
            Name = "Super Dog Dino";
            Hitpoints = 70;
        }

        public override int AttackOpponent()
        {
            Attack = random.Next(6, 9);
            return Attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            Defence = random.Next(2, 9);
            incomingDamage = - Defence + incomingDamage;
            if (incomingDamage >= 0)
            {
                Hitpoints = Hitpoints - incomingDamage;
            }
        }
    }
}
