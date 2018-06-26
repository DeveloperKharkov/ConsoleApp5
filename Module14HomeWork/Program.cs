using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14HomeWork
{
    public class TimeStamp
    {
        protected int timeInSec;

        public int TimeInHours {
            get { return timeInSec /3600; }
            set { timeInSec = value * 3600; }
        }
    }

    class Vehicle
    {
        private int _numberOfWeels;

        public string Name { get; }

        public int NumberOfWeels {
            get { return _numberOfWeels; }
            set {
                    if (value < 1)
                    {
                        throw new Exception("Number of weels should be more than 0");
                    }
                    _numberOfWeels = value;
                } 
        }

        protected virtual void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name}, Number of weels: {NumberOfWeels}");
        }
    }

    class Bike: Vehicle
    {
        public int MaxTopSpeed = 200;

        protected override void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name},  Max Top Speed: {MaxTopSpeed}");

            base.PrintInfo();
        }

        public Bike()
        {
            NumberOfWeels = 2;
        }
    }

    class Car: Vehicle
    {
        public int NumberOfDoors = 5;

        public void ShowMe()
        {
            PrintInfo();
        }

        protected override void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name},  Number Of Doors: {NumberOfDoors}");

            base.PrintInfo();
        }

        public Car()
        {
            NumberOfWeels = 4;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>();
            Vehicle v = new Car();
            try
            {
                v.NumberOfWeels = 0;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                v.NumberOfWeels = 1;
            }
            Console.WriteLine($"NumberOfWeels = {v.NumberOfWeels}");

            list.Add(new Bike());
            list.Add(new Car());

            //decimal a = Math.Abs(10);
            var t = new TimeStamp();
            t.TimeInHours = 2;
            Console.WriteLine(t.TimeInHours);
        }
    }
}
