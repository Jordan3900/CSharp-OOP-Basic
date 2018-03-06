using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var vehicles = new List<Vehicles>();
        var carTokens = Console.ReadLine().Split();
        var truckTokens = Console.ReadLine().Split();
        var busTokens = Console.ReadLine().Split();

        var busCurrentFuel = double.Parse(busTokens[1]);
        var busTankCapacity = double.Parse(busTokens[3]);
        var carCurrentFuel = double.Parse(carTokens[1]);
        var carTank = double.Parse(carTokens[3]);
        var truckCurrentFuel = double.Parse(truckTokens[1]);
        var truckTank = double.Parse(truckTokens[3]);



        var car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));
        var truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));
        var bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));




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
            else if (type == "Bus")
            {
                bus.IsEmpty = cmd != "Drive";
                switch (cmd)
                {
                    case "Drive":
                        bus.Drive(double.Parse(token[2]));
                        break;
                    case "DriveEmpty":
                        bus.Drive(double.Parse(token[2]));
                        break;
                    case "Refuel":
                        bus.Refuel(double.Parse(token[2]));
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
        vehicles.Add(bus);
        foreach (var item in vehicles)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

