using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class TwoPlayerGameToWinTheGame
    {
        //Constant
        public const int POSITION = 0;
        public const int WINNING_POSITION = 100;
        public void playGame()
        {
            //Variable
            int dieCountForPlayer1 = 0;
            int dieCountForPlayer2 = 0;
            int positionForPlayer1 = 0;
            int positionForPlayer2 = 0;
            int position = 0;

            Random random = new Random();
            int player = random.Next(0, 6) + 1;
            Random random1 = new Random();
            int option = random1.Next(1, 3) + 1;

            Console.WriteLine("Snake And Ladder Game");
            while (dieCountForPlayer1 != WINNING_POSITION && dieCountForPlayer2 != WINNING_POSITION)
            {
                dieCountForPlayer1++;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Player stay at the same position");
                        break;
                    case 2:
                        Console.WriteLine("Your current position is:" + position);
                        Console.WriteLine("You encountered a ladder");
                        if ((position + player) > 100)
                        {
                            Console.WriteLine("Current position is:" + position);
                        }
                        else
                        {
                            position = position + player;
                            Console.WriteLine("Player ladder moves ahead:" + position);
                        }
                        break;
                    case 3:
                        if (position > player)
                        {
                            position = position - player;
                        }
                        break;
                }
                positionForPlayer1 = position;
                Console.WriteLine("player 1 die count " + dieCountForPlayer1 + ": Position" + positionForPlayer1);
                dieCountForPlayer2++;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Player stay at the same position");
                        break;
                    case 2:
                        Console.WriteLine("Your current position is:" + position);
                        Console.WriteLine("You encountered a ladder");
                        if ((position + player) > 100)
                        {
                            Console.WriteLine("Current position is:" + position);
                        }
                        else
                        {
                            position = position + player;
                            Console.WriteLine("Player ladder moves ahead:" + position);
                        }
                        break;
                    case 3:
                        if (position > player)
                        {
                            position = position - player;
                        }
                        break;
                }
                positionForPlayer2 = position;
                Console.WriteLine("player 2 die count" + dieCountForPlayer2 + ": Position" + positionForPlayer2);
            }
            if (positionForPlayer1 == WINNING_POSITION)
            {
                Console.WriteLine("Player1 won the game, You rolled the die " + dieCountForPlayer1 + " times");
            }
            else
            {
                Console.WriteLine("Player2 won the game, You rolled the die " + dieCountForPlayer2 + " times");
            }
        }
        
    }
}


 

