using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve_08_09_2020.ChampionsForFightArena
{
    class PoisonusGunner: Champions
    {
        Random random = new Random();
        public PoisonusGunner()
        {
            Name = "Poisonus Gunner";
            Hitpoints = 90;
            Defence = 5;
        }

        public override int AttackOpponent()// to find attack value for gunner
        {
            Attack = random.Next(1, 14);
            return Attack;
        }
    }
}
