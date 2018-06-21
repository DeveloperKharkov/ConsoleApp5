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

        public Product(int id, string name): this()
        {
            ID = id;
            Name = name;
        }
    }


    class Program
    {
        static Product CreateProduct()
        {
            Product product = new Product();

            Console.WriteLine("Please input ID:");
            product.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input Name:");
            product.Name = Console.ReadLine();

            Console.WriteLine("Please input Price:");
            product.Price = decimal.Parse(Console.ReadLine());

            return product;
        }

        static void SortArrayOfProducts(params Product[] arrayOfProducts)
        {
            var sortedArray = arrayOfProducts.OrderBy(p => p.Price);

            foreach (var item in sortedArray)
            {
                Console.WriteLine($"Id:{item.ID}, Name:{item.Name}, Price:{item.Price}");
            }
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;

            string outString = 
            $"Plus: {Calculator.Calculate(a, b, Calculator.Operation.Plus)} \n" +
            $"Minus: {Calculator.Calculate(a, b, Calculator.Operation.Minus)} \n" +
            $"Devide: {Calculator.Calculate(a, b, Calculator.Operation.Devide)} \n" +
            $"Multiply: {Calculator.Calculate(a, b, Calculator.Operation.Multiply)}";

            Console.WriteLine(outString);

            List<Product> arrayOfProducts;
            Console.WriteLine("Please input number of products:");
            int numberOfProducts = int.Parse(Console.ReadLine());

            arrayOfProducts = new List<Product>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                arrayOfProducts.Add(CreateProduct());
            }

            SortArrayOfProducts(arrayOfProducts.ToArray());
            SortArrayOfProducts(arrayOfProducts[0], new Product(), new Product());
            SortArrayOfProducts(arrayOfProducts[0], new Product());

            var random = new Random();
            arrayOfProducts.RemoveAt(random.Next(numberOfProducts));

            Console.WriteLine(String.Empty.PadRight(20, '*'));
            Console.WriteLine($"Number of products in list after removal:{arrayOfProducts.Count()}");
        }
    }
}
