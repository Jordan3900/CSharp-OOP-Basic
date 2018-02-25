using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                double tire1Pressure = double.Parse(parameters[5]);
                int tire1age = int.Parse(parameters[6]);
                double tire2Pressure = double.Parse(parameters[7]);
                int tire2age = int.Parse(parameters[8]);
                double tire3Pressure = double.Parse(parameters[9]);
                int tire3age = int.Parse(parameters[10]);
                double tire4Pressure = double.Parse(parameters[11]);
                int tire4age = int.Parse(parameters[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tire1 = new Tire(tire1age, tire1Pressure);
                var tire2 = new Tire(tire2age, tire2Pressure);
                var tire3 = new Tire(tire3age, tire3Pressure);
                var tire4 = new Tire(tire4age, tire4Pressure);
                var tires = new Tire[] { tire1, tire2, tire3, tire4 };
                var car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                var fragile = cars.Where(c => c.Cargo.Type == "fragile" &&  c.Tires.Any(t=> t.Pressure  < 1)).ToList();

                foreach (var car in fragile)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                var flamable = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList();

                foreach (var car in flamable)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
