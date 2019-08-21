using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_DungeonsAndDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRound gameRound = new GameRound();
            int result = gameRound.RollGameDie();           
            gameRound.IsCriticalHit(result);
            gameRound.IsCriticalMiss(result);
            Console.ReadLine();
        }
    }
}
