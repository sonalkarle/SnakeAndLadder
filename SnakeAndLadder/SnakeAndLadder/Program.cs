using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder program");     //welcome message
            int NO_OF_PLAYER = 1;             //number of player
            int POSITION = 0;                //Position of player
            Console.WriteLine("Number of player: " + NO_OF_PLAYER +  " is playing in game at position: " + POSITION);
            Random random = new Random();               //Computation
            int dicenumber = random.Next(0, 7);
            Console.WriteLine("Roll the dice and get answer " + dicenumber);
            
        }
    }
}
