using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler_Simulation
{
    class Game
    {
        //constants
        public const int STAKE = 100;
        public const int BET = 1;
        public void Gambler(int target)
        {
            const int WIN = 0;
            const int LOSE = 1;
            int loseTarget = ((STAKE / 100) * target) - STAKE;
            int winTarget = ((STAKE / 100) * target) + STAKE;
            int gamblerStake = STAKE;
            Random random = new Random();
            int game;
            while (gamblerStake <= winTarget || gamblerStake == loseTarget)
            {
                game = random.Next(0, 2);
                if (game == WIN)
                {
                    gamblerStake += BET;
                    Console.WriteLine("gambler wins!");
                }
                if (game == LOSE)
                {
                    gamblerStake -= BET;
                    Console.WriteLine("gambler lose!");
                }
                Console.WriteLine($"money left with gambler: {gamblerStake}");
            }
        }
    }
}
