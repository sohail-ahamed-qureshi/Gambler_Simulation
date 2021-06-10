using System;

namespace Gambler_Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambler Simulation");
            Game game = new Game();
            game.Gambler(50);
        }

       
    }
}
