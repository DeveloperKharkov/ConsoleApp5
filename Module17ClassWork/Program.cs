using Module17ClassWork.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = {
                new Car("Ferrari", FuelType.Gasoline, 35),
                new Car("lamborghini", FuelType.Gasoline, 50),
                new Car("Bentley continental gtc convertible 2018", FuelType.Disel, 100),
                new Car("Porsche 911", FuelType.Lpg, 40),
                new Car("Peugeot Bipper", FuelType.Disel, 40)
            };

            RefuelingStation[] refuelingStations = {
                new RefuelingStation("Sky", FuelType.Disel, 200),
                new RefuelingStation("Shell", FuelType.Gasoline, 300),
                new RefuelingStation("Wog", FuelType.Lpg, 500),
                new RefuelingStation("UkrSozYanikGoldFuelStation", FuelType.Lpg, 150),
                new RefuelingStation("Okko", FuelType.Disel, 100)
            };
            
            var engine = new Engine(cars, refuelingStations);
            engine.Run();
        }
    }
}
