using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve_08_09_2020
{
    class Champions
    {
        private string name;
        private int hitpoints, attack, defence;
        protected Random random = new Random();

        public string Name { get { return name; } set { name = value; } }
        public int Hitpoints { get { return hitpoints; } set { hitpoints = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int Defence { get { return defence; } set { defence = value; } }

        public virtual int AttackOpponent()//Returns Attack Damage, and is made possible to override in subclasses
        {
            return attack;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            incomingDamage = - defence + incomingDamage;//
            if (incomingDamage >= 0)
            {
                Hitpoints = hitpoints - incomingDamage;
            }
        }

        public override string ToString()
        {
            return "|Name: " + Name +
                   "\n|Hitpoints Left: " + hitpoints;
        }
    }
}
