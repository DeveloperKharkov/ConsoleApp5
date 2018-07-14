using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16._2ClassWork
{
    public interface IHuman
    {
        void PrintName();
        void PrintAge();
        void PrintSkills();
    }

    public interface ISkill
    {
        string Skills { get; set; }
    }

    public class Human : IHuman, ISkill
    {
        private readonly DateTime _dateOfBirth;
        private readonly string _name;
        private string _skills;

        public string Skills
        {
            get { return _skills; }
            set { _skills = value; }
        }

        public int Age {
            get
            {
                TimeSpan delta = (DateTime.Now - _dateOfBirth);
                return delta.Days / 365;

            }
        }



        public void PrintAge()
        {
            Console.WriteLine($"Age:{Age}");
        }

        public void PrintName()
        {
            Console.WriteLine($"Name:{_name}");
        }

        public void PrintSkills()
        {
            Console.WriteLine($"Skills:{_skills}");
        }

        public Human(DateTime dateOfBirth, string name, string skills)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _skills = skills ?? throw new ArgumentNullException(nameof(skills));
            _dateOfBirth = dateOfBirth;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IHuman> humans = new List<IHuman>();
            humans.Add(new Human(new DateTime(1977, 1, 1), "Ivan", "haker"));
            humans.Add(new Human(new DateTime(1986, 2, 4), "Slava", "haker too"));
            foreach (var item in humans)
            {
                //((ISkill)item).Skills = "Traktorist";
                item.PrintName();
                item.PrintAge();
                item.PrintSkills();

                Console.WriteLine();
            }
        }
    }
}
