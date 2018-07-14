using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17ClassWork
{
    class Engine
    {
        private List<Car> _cars = new List<Car>();
        private List<RefuelingStation> _refuelingStations = new List<RefuelingStation>();

        public void Run()
        {
            var random = new Random();

            foreach (Car car in _cars)
            {
                Console.WriteLine();
                Console.WriteLine($"Car {car.Mark} start moving. Tank state = {car.TankState}");
                car.Move();
                Console.WriteLine($"Car {car.Mark} stop moving. Tank state = {car.TankState}");
                Console.WriteLine();

                List<RefuelingStation> filteredRefuelingStations = _refuelingStations
                    .Where(r => r.Type == car.Type).ToList();

                int _refuelingStationIndex = random.Next(filteredRefuelingStations.Count());
                RefuelingStation refuelingStation = filteredRefuelingStations[_refuelingStationIndex];

                Console.WriteLine($"Refueling Station {refuelingStation.Name} start refuling car {car.Mark}. car tank state = {car.TankState}");
                refuelingStation.Refuel(car);
                Console.WriteLine($"Refueling Station {refuelingStation.Name} stop refuling car {car.Mark}. car tank state = {car.TankState}");
                Console.WriteLine();
            }
        }

        public Engine(Car[] cars, RefuelingStation[] refuelingStations)
        {
            Console.WriteLine("---------- Cars ---------------");
            foreach (Car car in cars)
            {
                car.PrintInfo();
                _cars.Add(car);
                
            }
            Console.WriteLine();

            Console.WriteLine("---------- Refueling Stations ---------------");
            foreach (RefuelingStation refuelingStation in refuelingStations)
            {
                refuelingStation.PrintInfo();
                _refuelingStations.Add(refuelingStation);
            }
            Console.WriteLine();
        }
    }
}
