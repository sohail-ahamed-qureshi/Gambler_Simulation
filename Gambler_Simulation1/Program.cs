using System;

namespace Gambler_Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambler Simulation");

            //variable
            int gamblerStake = 100;
         
            //constants
            const int BET =1;
             int days = 30;
            
            while (days != 0)
            {
                gamblerStake -= BET;
                days--;
                Console.WriteLine(gamblerStake);
            }
        }
    }
}
