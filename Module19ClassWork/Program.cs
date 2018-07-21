#define DEBUG
#undef MYTEST

using Module19ClassWork.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Module19ClassWork
{

    class Program
    {
        static void Main(string[] args)
        {
            var units = new List<MilitaryUnit>();
            units.Add(new Solder("Hero 1"));
            units.Add(new Solder("Hero 2"));
            units.Add(new AirPlane("Stells"));
            units.Add(new Cannon("Dora"));
            units.Add(new Tank("PZ IV"));

            var militaryBase = new MilitaryBase(units);

            militaryBase.GoToAttack();

            Console.ReadKey();
        }
    }
}
