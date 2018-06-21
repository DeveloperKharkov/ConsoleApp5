using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13HomeWork
{
    class Program
    {
        public static void GetData(int index)
        {
            if (index == 0)
            {
                Exception error = new Exception("Some error happens!");
                throw error;
            }
            Console.WriteLine("GetData done.");
        }

        static void Main(string[] args)
        {
            try
            {
                GetData(0);
            }
            catch(Exception err)
            {
                Console.WriteLine($"Text of exception:{err.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block");
            }

            Console.WriteLine("End");

        }
    }
}
