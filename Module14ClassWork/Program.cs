using ItCloud.Education.MathLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lengthOfArray = random.Next(100);

            byte[] byteArray = new byte[lengthOfArray];
            int count = 0;

            do
            {
                int index = random.Next(lengthOfArray + 5);
                try
                {
                    byteArray[index] = (byte)random.Next(300);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"{index} out of range. lengthOfArray={lengthOfArray}");
                }
                count++;
            }
            while (count < lengthOfArray);

            Console.WriteLine($"Count = {count}"); 
        }
    }
}

