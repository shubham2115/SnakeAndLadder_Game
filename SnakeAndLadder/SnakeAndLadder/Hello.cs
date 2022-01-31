using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class PlayerPosition
    {

        public const int POSITION = 0;
        public void checkingForOption()
        {
            int position = 0, ladderCount = 0, snakeCount = 0;
            Console.WriteLine("Snake And Ladeer Game ");
            Random random = new Random();
            int player = random.Next(0, 6) + 1;
            Console.WriteLine("Outcome is : " + player);
            Random random1 = new Random();
            int option = random1.Next(0, 3) + 1;
            switch (option)
            {
                case 1:
                    Console.WriteLine("Current position is : " + position);
                    Console.WriteLine("You stay in same position : " + position);
                    break;
                case 2:
                    ladderCount++;
                    Console.WriteLine("Current Position is : " + position);
                    position = position + player;
                    Console.WriteLine("Player Ladder moves ahed : " + position);
                    break;
                case 3:
                    snakeCount++;
                    Console.WriteLine("Current Positin is : " + position);
                    position = position - player;
                    if (position < 0)
                    {
                        Console.WriteLine("Player Snake move behind : " + POSITION);
                    }
                    else
                    {
                        Console.WriteLine("Player moves behind : " + position);
                    }
                    break;
            }
        }
    }
}
          


   
