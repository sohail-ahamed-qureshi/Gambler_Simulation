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
            Game game = new Game();
            game.Gambler();
        }

       
    }
}
