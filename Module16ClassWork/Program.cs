using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16ClassWork
{
    class Human
    {
        public string Name;
        public virtual void Print()
        {

        }
        public int Age { get; set; }

        public Human()
        {
            Name = "Noname";
        }

        public Human(string name)
        {
            Name = name;
        }

    }

    class Child: Human
    {
        public string Name;

        public new void Print()
        {

        }

        public int Age { get; set; }

        public string DrivingSkills;

        public Child(string drivingSkills)
        {
            DrivingSkills = drivingSkills;
            Name = "Child name";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child("Truck");
            Console.WriteLine(child.Name);
        }
    }
}
