using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 10;
          //  Console.BackgroundColor = ConsoleColor.White;

            for (double i = -radius; i <= radius; i++)
            {
                double yTop = Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(i, 2));
                yTop /= 2;
                double yBottom = -yTop;
                Console.SetCursorPosition((int)i + radius, (int)Math.Round(yTop) + radius);
                Console.Write("*");
                Console.SetCursorPosition((int)i + radius, (int)Math.Round(yBottom) + radius);
                Console.Write("*");
            }


            Console.CursorVisible = false;

            ConsoleKeyInfo keyInfo;
            int left = 0, top = radius/2;
            int previousLeft = left, previousTop = top;
            do
            {
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        top--;
                        break;
                    case ConsoleKey.S:
                        top++;
                        break;
                    case ConsoleKey.D:
                        left++;
                        break;
                    case ConsoleKey.A:
                        left--;
                        break;
                    default:
                        break;
                }

                Console.MoveBufferArea(previousLeft, previousTop, 2*radius + 1, radius + 1, left, top);
                previousTop = top;
                previousLeft = left;
            }
            while (keyInfo.Key != ConsoleKey.Backspace);
        }
    }
}
