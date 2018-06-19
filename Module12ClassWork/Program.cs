using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItCloud.Education.MathLibs;

namespace Module12ClassWork
{
    public struct Product
    {
        public int ID;
        public string Name;
        public decimal Price;

        public void PrintInfo()
        {
            Console.WriteLine($"Id = {ID}, Name = {Name}, Price = {Price}");
        }

        public Product(int id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Product[] arrayOfProducts;
            Console.WriteLine("Please input number of products:");
            int numberOfProducts = int.Parse(Console.ReadLine());

            arrayOfProducts = new Product[numberOfProducts];

            for (int i = 0; i < numberOfProducts; i++)
            {

            }
        }
    }
}
