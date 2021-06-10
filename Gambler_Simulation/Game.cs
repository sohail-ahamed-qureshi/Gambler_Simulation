using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler_Simulation
{
    class Game
    {
        public void Gambler()
        {
            const int WIN = 0;
            const int LOSE = 1;
            Random random = new Random();
            int game = random.Next(0, 2);
            if (game == WIN)
            {
                Console.WriteLine("gambler wins!");
            }
            if (game == LOSE)
            {
                Console.WriteLine("gambler lose!");
            }

        }
    }
}
