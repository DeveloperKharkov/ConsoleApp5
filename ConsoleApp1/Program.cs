using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public enum Direction
        {
            Left, 
            Right, 
            Top,
            Bottom
        }

        public struct Point
        {
            public int X;
            public int Y;
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsoleKey pressedKey;
            var snake = new List<Point>();

            int x = 0, y = 0;

            Direction direction = Direction.Right;
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.SetCursorPosition(x, y);

                    switch (direction)
                    {
                        case Direction.Left:
                            x--;
                            break;
                        case Direction.Right:
                            x++;
                            break;
                        case Direction.Top:
                            y--;
                            break;
                        case Direction.Bottom:
                            y++;
                            break;
                    }
                    Console.Write("@");
                    snake.Add(new Point { X = x, Y = y });

                    if (snake.Count > 15)
                    {
                        Console.SetCursorPosition(snake[0].X, snake[0].Y);
                        Console.Write(" ");
                        snake.RemoveAt(0);
                    }

                    Thread.Sleep(100);
                }

                pressedKey = Console.ReadKey(true).Key;

                switch (pressedKey)
                {
                    case ConsoleKey.DownArrow:
                        direction = Direction.Bottom;
                        continue;

                    case ConsoleKey.UpArrow:
                        direction = Direction.Top;
                        continue;

                    case ConsoleKey.LeftArrow:
                        direction = Direction.Left;
                        continue;

                    case ConsoleKey.RightArrow:
                        direction = Direction.Right;
                        continue;
                }
            }
            while (pressedKey != ConsoleKey.Spacebar);
        }
    }
}
