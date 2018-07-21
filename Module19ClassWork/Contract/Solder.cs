using Module19ClassWork.Contract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module19ClassWork.Contract
{
    class Solder : MilitaryUnit, IAirDefender, IGroundDefender
    {
        public string Name { get; private set; }

        public override void Attack()
        {
            Console.WriteLine($"{GetType().Name} {Name} attacking!!");
        }

        public void Defend()
        {
            Console.WriteLine($"{GetType().Name} {Name} defending!!!");
        }

        public void Hide()
        {
            Console.WriteLine($"{GetType().Name} {Name} hiding!!!");
        }

        public Solder(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
