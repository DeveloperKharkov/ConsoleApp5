using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10HomeWork
{
    class Program
    {
        static int SumFromOneToN(int n)
        {
            if (n == 1)
            {
                return n;
            }

            return n + SumFromOneToN(n - 1);
        }

        static int SumFromList(int[] list, int index)
        {
            if (index == 0)
            {
                return list[0];
            }

            return list[index] + SumFromList(list, index - 1);
        }

        static int SumFromList(int[] list)
        {
            return SumFromList(list, list.Length - 1);
        }

        static void Main(string[] args)
        {
            //Задача 10.7
            //  Написать функцию вычисления суммы целых чисел от 1 до N.
            //Задача 10.8
            //   Решить задачу 10.7 при помощи рекурсии

            //Version 1
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(SumFromOneToN(n));

            //Version 2
            int[] array = { 1, 3, 4, 5, 6};
            Console.WriteLine(SumFromList(array));
        }
    }
}
