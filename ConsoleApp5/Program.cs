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
            string firstName;
            string lastName;

            Console.WriteLine("Input first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Input last name:");
            lastName = Console.ReadLine();

            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
