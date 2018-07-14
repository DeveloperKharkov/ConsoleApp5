using Module17ClassWork.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17ClassWork
{
    class Car : IPrintLog, IFuel, IMoving
    {
        private int _tankState;

        public FuelType Type => throw new NotImplementedException();

        public int TankVolume { get; private set; }

        public int TankState => _tankState;

        public void FillTank(int newFuel)
        {
            throw new NotImplementedException();
        }

        public void PrintInfo(string data)
        {
            throw new NotImplementedException();
        }

        //private int 
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
