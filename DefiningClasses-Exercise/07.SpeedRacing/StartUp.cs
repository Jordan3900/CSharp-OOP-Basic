using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();

            var carModel = tokens[0];
            var fuelAmout = double.Parse(tokens[1]);
            var fuelConsuption = double.Parse(tokens[2]);
            var car = new Car(carModel, fuelAmout, fuelConsuption);
            cars.Add(car);
        }
       var line = Console.ReadLine();

        while (line != "End")
        {
            var tokens = line.Split();
            var model = tokens[1];
            var amoutOfKm = int.Parse(tokens[2]);
            var carToDrive = cars.First(c => c.Model == model);
            carToDrive.Drive(amoutOfKm);

            line = Console.ReadLine();
        }
        cars.ForEach(c => Console.WriteLine($"{c.Model} {c.AmountOfFuel:f2} {c.DistanceTraveled}"));
    }
}

