using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defiend position
            int Position_player = 0;
            int Final_position = 100;
            int numOfDieRoll = 0;
            Random random = new Random();        //Computation

            while (Position_player < Final_position)   //Condition
            {
                int Dicenumber = random.Next(1, 6);    //random calculation
                int option = random.Next(0, 2);       //random calculation
                //Option selection statement
                switch (option)
                {
                    case 0:
                        Console.WriteLine("NO PLAY");
                        break;

                    case 1:
                        Position_player += Dicenumber;
                        Console.WriteLine("Ladder" + Position_player);
                        if (Position_player > 100)
                        {
                            Position_player -= Dicenumber;
                        }
                        break;

                    default:
                        Position_player -= Dicenumber;
                        Console.WriteLine("Snake" + Position_player);
                        if (Position_player < 0)
                        {
                            Position_player = 0;
                        }
                        break;
                }
                numOfDieRoll++;
                Console.Write("Number of times dice rolled: " + numOfDieRoll);
            }

        }
    }
}

