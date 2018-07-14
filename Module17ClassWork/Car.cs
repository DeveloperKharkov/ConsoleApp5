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
        public string Mark { get; private set; }
        public FuelType Type { get; private set; }

        /// <summary>
        /// объем бака
        /// </summary>
        public int TankVolume { get; private set; }

        /// <summary>
        /// текущее количество топлива
        /// </summary>
        public int TankState { get; private set; }

        public Car(string mark, FuelType fuelType, int tankVolume)
        {
            if (string.IsNullOrWhiteSpace(mark))
                throw new ArgumentException($"The mark = {mark} is invalid", nameof(mark));

            if (tankVolume <= 0)
                throw new ArgumentException($"TankVolume should be greater zero", nameof(tankVolume));

            Mark = mark;
            Type = fuelType;
            TankVolume = tankVolume;
            TankState = 0;
        }
        /// <summary>
        ///  позволяет добавить в бак топлива
        /// </summary>
        /// <param name="newFuel"></param>
        public void FillTank(int newFuel)
        {
            int remainTankValume = TankVolume - TankState;

            if (newFuel > remainTankValume)
                throw new ArgumentException($"Amount of new fuel = {newFuel} more than remaining tank valume", nameof(newFuel));

            TankState = TankState + newFuel;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Mark={Mark}, Fuel type={Type}, TankVolume={TankVolume}, Volume of fuel in tank ={TankState}");
        }

        public void Move()
        {
            var random = new Random();
            int randomValue = random.Next(TankVolume / 2);

            if (randomValue > TankState)
            {
                TankState = 0;
            }
            else
            {
                TankState -= randomValue;
            }
        }
    }
}
