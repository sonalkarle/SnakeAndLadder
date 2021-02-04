using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defiend position
            int Position_player_1 = 0;
            int Position_player_2 = 0;
            int Final_position = 100;
            int numOfDieRoll = 0;

            Random random = new Random();          //Computation
            int TURN = random.Next(0, 1);
            int Player_TURN = random.Next(0, 1);
            while (Position_player_1 < Final_position && Position_player_2 < Final_position)    //condition
            {
                if (Player_TURN== 0)
                {

                    int DicenumberPlayer1 = random.Next(1, 6);  //Check with first player
                    int option = random.Next(0, 2);
                    //Option statement
                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("NO PLAY");
                            break;

                        case 1:
                           Position_player_1 += DicenumberPlayer1;
                            Console.WriteLine("Ladder" + Position_player_1);
                            if (Position_player_1 > 100)
                            {
                                Position_player_1 -= DicenumberPlayer1;
                            }
                            break;

                        default:
                            Position_player_1 -= DicenumberPlayer1;
                            Console.WriteLine("Snake" + Position_player_1);
                            if (Position_player_1 < 0)
                            {
                                Position_player_1 = 0;
                            }
                            break;
                    }
                    numOfDieRoll++;
                    Console.Write("Number of times dice rolled: " + numOfDieRoll);
                }

            

                else
                {
                    int DicenumberPlayer2 = random.Next(1, 6);
                    int option = random.Next(0, 2);
                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("NO PLAY");
                            break;

                        case 1:
                            Position_player_2 += DicenumberPlayer2;
                            Console.WriteLine("Ladder" + Position_player_2);
                            if (Position_player_2 > 100)
                            {
                                Position_player_2 -= DicenumberPlayer2;
                            }
                            break;

                        default:
                            Position_player_2 -= DicenumberPlayer2;
                            Console.WriteLine("Snake" + Position_player_2);
                            if (Position_player_2 < 0)
                            {
                                Position_player_2 = 0;
                            }
                            break;
                    }
                    numOfDieRoll++;
                    Console.Write("Number of times dice rolled: " + numOfDieRoll);
                }

            }
            if (Position_player_1 == Final_position)
                Console.WriteLine("Player 1 wins");
            else
                Console.WriteLine("Player 2 wins");
        }
    }
}
