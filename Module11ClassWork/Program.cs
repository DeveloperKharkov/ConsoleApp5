using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11ClassWork
{
    class Program
    {
        public struct Rectange
        {
            public int X1;
            public int X2;
            public int Y1;
            public int Y2;
            
            public void Draw()
            {
                Console.SetCursorPosition(X1, Y1);
                for (int i = 0; i < X2 - X1; i++)
                {
                    Console.Write("*");
                }

                for (int i = 0; i < Y2 - Y1; i++)
                {
                    Console.SetCursorPosition(X1, Y1 + i);
                    Console.Write("*");
                    Console.SetCursorPosition(X2, Y1 + i);
                    Console.Write("*");
                }

                Console.SetCursorPosition(X1, Y2);
                for (int i = 0; i < X2 - X1; i++)
                {
                    Console.Write("*");
                }
            }
                        
            public Rectange(int x1, int y1, int x2, int y2)
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
            }
        }

        static void Fill(int x1, int y1, int x2, int y2)
        {
            if ((x1 >= x2) || (y1 >= y2))
            {
                return;
            }

            Rectange rect = new Rectange(x1, y1, x2, y2);
            rect.Draw();
            Fill(x1 + 1, y1 + 1, x2 - 1, y2 - 1);
        }

        static void Main(string[] args)
        {
            //        Задача 11.1
            //Написать программу, которая содержит функцию рисования прямоугольника
            //из символов "*" по двум координатам(x1, y1), (x2, y2).

            //     (x1, y1)
            //               * ***************
            //       **
            //       **
            //       **
            //       **
            //       **
            //       **
            //       ****************
            //                      (x2, y2)

            Console.BufferHeight = 120;
            Fill(0, 0, Console.BufferWidth - 1, Console.BufferHeight - 1);
            Console.SetCursorPosition(Console.BufferWidth - 1, Console.BufferHeight - 1);
        }
    }
}
