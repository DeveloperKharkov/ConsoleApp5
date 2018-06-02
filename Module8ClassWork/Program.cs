using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача 7.9
            В заданном массиве найти минимальное и 
            максимальное значение.
            Вывести на экран массив, после чего максимальное 
            и минимальное значение с указанием номера этих 
            элементов в массиве. */
            int[] array = { 1, 4, 5, 3, 7, 45, 67, 89 };
            int min = int.MaxValue, max = int.MinValue;

            int positionOfMinValue = -1;
            int positionOfMaxValue = -1;

            for (int i=0; i<array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    positionOfMaxValue = i + 1;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    positionOfMinValue = i + 1;
                }
            }

            Console.WriteLine("List of all elements of array:");

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"min={min}, position of min element={positionOfMinValue}");
            Console.WriteLine($"max={max}, position of max element={positionOfMaxValue}");
        }
    }
}
