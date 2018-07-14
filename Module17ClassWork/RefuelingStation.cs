using Module17ClassWork.Contract;
using System;

namespace Module17ClassWork
{
    class RefuelingStation: IPrintLog
    {
        private int _volume;
        public string Name { get; private set; }
        public FuelType Type { get; private set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Refueling Station {Name} supports {Type} and has the following {_volume}");
        }

        public RefuelingStation(string name, FuelType fuelType, int amountOfFuel)
        {
            if (amountOfFuel < 0)
                throw new ArgumentException("amountOfFuel should be greater zero", nameof(amountOfFuel));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The name should not be empty", nameof(name));

            _volume = amountOfFuel;
            Name = name;
            Type = fuelType;
        }

        public void Refuel(IFuel fuel)
        {
            if (fuel == null) throw new ArgumentNullException(nameof(fuel));

            if (Type != fuel.Type)
            {
                Console.WriteLine($"Our RefuelingStation supports only {Type}, but your car requires {fuel.Type}. Sorry");
                return;
            }

            if (_volume == 0)
            {
                Console.WriteLine("Sorry but there is no fuel on the station.");
                return;
            }

            int howMuchNeedToRefuel = fuel.TankVolume - fuel.TankState;

            if (howMuchNeedToRefuel == 0)
            {
                Console.WriteLine("Sorry but you don't need to refuel you have a full tank");
                return;
            }

            if (howMuchNeedToRefuel > _volume)
            {
                Console.WriteLine($"Required amount of fuel = {howMuchNeedToRefuel} but the refueling station we have {_volume}.");

                howMuchNeedToRefuel = _volume;
            }

            fuel.FillTank(howMuchNeedToRefuel);

            _volume -= howMuchNeedToRefuel;
        }
    }
}
