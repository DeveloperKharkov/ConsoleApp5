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


            for (double i = 1d; i < 2*radius; i++)
            {
                double y = Math.Sqrt(radius*radius-Math.Pow(i-radius, 2));
                if (y < 0)
                    break;

                int top = 20 + (int)Math.Round(y);
                int top2 = 20 - (int)Math.Round(y);

                if (top < 0)
                    break;

                Console.SetCursorPosition(5 + (int)Math.Round(i) + 10, top);
                Console.Write("*");
                Console.SetCursorPosition(5 + (int)Math.Round(i) + 10, top2);
                Console.Write("*");

            }
            Console.ReadKey();
            Console.MoveBufferArea(1, 1, 50, 50, 5, 5);
        }
    }
}

