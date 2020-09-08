using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ProgrammeringsPrøve_08_09_2020
{
    class Program
    {
        /// <summary>
        /// This is not A finished product i need to make the ranking system where opponents fight eachother after their first ranking matches Features that are working at the moment:
        /// - Figthing
        /// - Random Champion queue
        /// - All champion Implemented
        /// - All Champion Can Fight
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Arena arena = new Arena();//creates arena
            arena.FillChapionRow();//fills the queue
            while (arena.ChampionRow.Count > 1)
            {
                arena.nextFighters();//queue up the next fighters

                while (arena.Champions[0].Hitpoints > 0 && arena.Champions[1].Hitpoints > 0)//Champions fight until Death
                {
                    arena.battle();
                    Console.WriteLine(arena.Champions[0] + "\n\n" + arena.Champions[1]);
                    Console.Clear();
                    Thread.Sleep(500);
                }
            }
            Console.ReadKey();
        }
    }
}
