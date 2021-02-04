using System;

namespace SnakeAndLadder
{
    class Program
    {
        //Constant
       const int NO_OF_PLAYER = 1;
       const int POSITION = 0;
       const int NO_PLAY = 0;
       const int SNAKE = 1;
       const int LADDER = 2;
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to snake and ladder program");            //welcome message
            
            Console.WriteLine("Number of player: " + NO_OF_PLAYER +  " is playing in game at position: " + POSITION);
            Random random = new Random();               //Computatiom
            int dicenumber = random.Next(0, 7);
            Console.WriteLine("Roll the dice and get answer " + dicenumber);
           
            Random random1 = new Random();
            int Checkposition = random1.Next(0, 3);
            //Option statement
            switch(Checkposition)
            {
                case NO_PLAY:
                   int newposition = (POSITION);
                    Console.WriteLine("Position of player not changed " + newposition);
                    break;
                case SNAKE:
                    newposition = (POSITION - dicenumber);
                    Console.WriteLine("Position of player is decrement and reached to  " + newposition);
                    break;
                case LADDER:
                    newposition = (POSITION + dicenumber);
                    Console.WriteLine("Position of player is increment and reached to  " + newposition);
                    break;
                default:
                    Console.WriteLine("Invalid action");
                    break;
                    


            }
            

        }
    }
}
