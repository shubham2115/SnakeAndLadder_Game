using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class WiningPositionAndDiceCount
    {
        public const int POSITION = 0;
        public const int WINNING_POSITION = 100;
        public void diceCountToWinTheGame()
        {
            int position = 0;
            int diceCount = 0;
            Console.WriteLine("Snake And Ladder Game ");
            Random random = new Random();
            Random random1 = new Random();
            while (position != WINNING_POSITION)
            {
                diceCount++;
                int player = random.Next(0, 6) + 1;
                Console.WriteLine("Outcomes is : " + player);
                int option = random1.Next(0, 3) + 1;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Current position is: " + position);
                        Console.WriteLine("You stay in same position: " + position);

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
                        Console.WriteLine("You encountered a Snake");
                        Console.WriteLine("Current position is:" + position);
                        if (position < 0)
                        {
                            Console.WriteLine("Player snake moves bheind:" + POSITION);
                            position = POSITION;
                        }
                        else
                        {
                            position = position - player;
                            Console.WriteLine("Player moves behind :" + position);
                        }
                        break;
                }
                Console.WriteLine("Dice count : " + diceCount);
            }
        }
    }
}


 

