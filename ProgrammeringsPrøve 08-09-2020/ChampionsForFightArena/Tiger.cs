using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve_08_09_2020.ChampionsForFightArena
{
    class Tiger:Champions
    {
        private int tigerLifeCount;
        private bool hitCrit;

        public Tiger()
        {
            Name = "Tiger";
            Hitpoints = 3;
            tigerLifeCount = 0;
            hitCrit = false;
        }

        public override int AttackOpponent()//switch between to damage types
        {
            if (hitCrit == true)
            {
                hitCrit = false;
                return 6;
            }
            else
            {
                hitCrit = true;
                return 3;
            }
        }

        public override void TakeDamage(int incomingDamage)//Tiger got 9 lives for each hit he gain +3 hitpoints But when he have used all 9 lives it wont add +3
        {
            if (tigerLifeCount < 9)
            {
                Hitpoints = Hitpoints + 3;
            }
            incomingDamage = -Defence + incomingDamage;
            if (incomingDamage >= 0)
            {
                Hitpoints = Hitpoints - incomingDamage;
            }
        }
    }
}
