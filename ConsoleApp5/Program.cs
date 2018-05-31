using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 10;
            Console.BackgroundColor = ConsoleColor.White;
            for (double i = -radius; i <= radius; i++)
            {
                double y = Math.Sqrt(Math.Pow(radius,2)-Math.Pow(i, 2));

                if (y < 0)
                    break;

                y /= 2;

                int top = 10 + (int)Math.Round(y);
                int top2 = 10 - (int)Math.Round(y);

                if (top < 0)
                    break;

                Console.SetCursorPosition(5 + (int)Math.Round(i) + 10, top);
                Console.Write("*");
                Console.SetCursorPosition(5 + (int)Math.Round(i) + 10, top2);
                Console.Write("*");

            }
            Console.ReadKey();
        }
    }
}

