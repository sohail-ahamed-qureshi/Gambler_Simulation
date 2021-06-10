using System;

namespace Gambler_Simulation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambler Simulation");
            //constants
            const int STAKE = 100;
            const int BET =1;
            Gambler();
        }

        public static void Gambler()
        {
            const int WIN = 0;
            const int LOSE = 1;
            Random random = new Random();
            int game = random.Next(0,2);
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
