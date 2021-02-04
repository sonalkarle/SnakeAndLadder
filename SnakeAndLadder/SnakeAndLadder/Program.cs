using System;

namespace SnakeAndLadder
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder program");
            int NO_OF_PLAYER = 1;
            int POSITION = 0;
            Console.WriteLine("Number of player: " + NO_OF_PLAYER + " is playing in game at position: " + POSITION);


            Random random = new Random();
            while (POSITION != 100)
            {
                int dicenumber = random.Next(0, 7);
                Console.WriteLine("Roll the dice and get answer " + dicenumber);
                int Choice = random.Next(0, 3);
                if (Choice == 0)
                {
                    Console.WriteLine("No Play");
                }
                else if (Choice == 1)
                {
                    POSITION += dicenumber;
                    Console.WriteLine("Ladder" + POSITION);

                }
                else
                {
                    POSITION -= dicenumber;
                    Console.WriteLine("Snake" + POSITION);
                }

                
            }

        }
    }
}

