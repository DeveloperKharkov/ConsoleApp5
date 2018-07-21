using Module19ClassWork.Contract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module19ClassWork.Contract
{
    class Tank: TechnicalMilitaryUnit, IGroundDefender
    {
        public override void Attack()
        {
            Console.WriteLine($"{GetType().Name} {Mark} attacking!!");
        }

        public void Defend()
        {
            Console.WriteLine($"{GetType().Name} {Mark} defending!!!");
        }

        public void Hide()
        {
            Console.WriteLine($"{GetType().Name} {Mark} hiding!!!");
        }

        public Tank(string mark) : base(mark)
        {

        }
    }
}
