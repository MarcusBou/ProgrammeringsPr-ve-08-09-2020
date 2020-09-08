using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve_08_09_2020.ChampionsForFightArena
{
    class Moose_Egon: Champions
    {
        public Moose_Egon()
        {
            Name = "Moose Egon";
            Hitpoints = 90;
            Defence = 4;
        }

        public override int AttackOpponent()
        {
            Attack = random.Next(5, 12);
            return Attack;
        }
    }
}
