using ProgrammeringsPrøve_08_09_2020.ChampionsForFightArena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve_08_09_2020
{
    class Arena
    {
        Champions[] champions = new Champions[2];
        Queue<Champions> championRow = new Queue<Champions>();

        public Champions[] Champions { get { return champions; } }
        public Queue<Champions> ChampionRow { get { return championRow; } }

        public void nextFighters()//adds the next champions in queue
        {
            champions[0] = championRow.Dequeue();
            champions[1] = championRow.Dequeue();
        }

        public void battle()//Each opponet take an attack turn
        {
            champions[1].TakeDamage(champions[0].AttackOpponent());
            champions[0].TakeDamage(champions[1].AttackOpponent());
        }

        public void FillChapionRow()//Randomizes the Champions Places, and their opponents
        {
            #region creationOfChampions
            KongFuHarry kongFuHarry = new KongFuHarry();
            Dino dino = new Dino();
            Fast_Karl fast_Karl = new Fast_Karl();
            PoisonusGunner poisonusGunner = new PoisonusGunner();
            MiniMouse_Mikkel miniMouse_Mikkel = new MiniMouse_Mikkel();
            Tiger tiger = new Tiger();
            RubberGoat rubberGoat = new RubberGoat();
            Moose_Egon moose_Egon = new Moose_Egon();
            #endregion

            Random rnd = new Random();
            do
            {
            int randomQueueForBattle = rnd.Next(1, 9);
            switch (randomQueueForBattle)
            {
                case 1:
                    if (!championRow.Contains(kongFuHarry))
                    {
                        championRow.Enqueue(kongFuHarry);
                    }
                    break;
                case 2:
                    if (!championRow.Contains(dino))
                    {
                        championRow.Enqueue(dino);
                    }
                    break;
                case 3:
                    if (!championRow.Contains(fast_Karl))
                    {
                        championRow.Enqueue(fast_Karl);
                    }
                    break;
                case 4:
                    if (!championRow.Contains(poisonusGunner))
                    {
                        championRow.Enqueue(poisonusGunner);
                    }
                    break;
                case 5:
                    if (!championRow.Contains(miniMouse_Mikkel))
                    {
                        championRow.Enqueue(miniMouse_Mikkel);
                    }
                    break;
                case 6:
                    if (!championRow.Contains(tiger))
                    {
                        championRow.Enqueue(tiger);
                    }
                    break;
                case 7:
                    if (!championRow.Contains(rubberGoat))
                    {
                        championRow.Enqueue(rubberGoat);
                    }
                    break;
                case 8:
                    if (!championRow.Contains(moose_Egon))
                    {
                        championRow.Enqueue(moose_Egon);
                    }
                    break;
                default:
                    break;
            }
            } while (championRow.Count != 8);
        }
    }
}
