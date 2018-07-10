using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16._1ClassWork
{
    abstract class Figure
    {
        public abstract double Area();
    }

    class Square : Figure
    {
        public int Side { get; private set; }

        public override double Area()
        {
            return Side * Side;
        }

        public Square(int side)
        {
            Side = side;
        }
    }

    class Circle : Figure
    {
        public int Radius { get; private set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public Circle(int radius)
        {
            Radius = radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figure[] array = new Figure[2];
            array[0] = new Square(10);
            array[1] = new Circle(10);

            foreach (Figure item in array)
            {
                Console.WriteLine($"Area for {item.GetType().Name} equal {item.Area()}");
            }
        }
    }
}
