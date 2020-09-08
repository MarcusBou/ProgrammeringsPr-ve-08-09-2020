using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve_08_09_2020.ChampionsForFightArena
{
    class Fast_Karl: Champions
    {
        public Fast_Karl()
        {
            Name = "Fast Karl";
            Hitpoints = 90;
            Defence = 3;
        }

        public override int AttackOpponent()//Fast karl havve to differnt attack values;
        {
            bool hands = true;//if true Right hand, if false left hand
            if (hands == true)
            {
                hands = false;
                return 5;
            }
            else
            {
                hands = true;
                return 2;
            }
        }
    }
}
