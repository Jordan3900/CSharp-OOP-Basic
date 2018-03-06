using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var vehicles = new List<Vehicles>();
        var carTokens = Console.ReadLine().Split();
        var truckTokens = Console.ReadLine().Split();
        var car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));
        var truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var token = Console.ReadLine().Split();
            var cmd = token[0];
            var type = token[1];

            if (type == "Car")
            {
                switch (cmd)
                {
                    case "Drive":
                        car.Drive(double.Parse(token[2]));
                        break;
                    case "Refuel":
                        car.Refuel(double.Parse(token[2]));
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (cmd)
                {
                    case "Drive":
                        truck.Drive(double.Parse(token[2]));
                        break;
                    case "Refuel":
                        truck.Refuel(double.Parse(token[2]));
                        break;
                    default:
                        break;
                }
            }
        }
        vehicles.Add(car);
        vehicles.Add(truck);

        foreach (var item in vehicles)
        {
            Console.WriteLine(item.ToString());
        }

    }
}

