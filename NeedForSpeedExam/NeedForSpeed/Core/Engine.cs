using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private CarManager carManager;


    public Engine()
    {
        this.carManager = new CarManager();

    }

    public void Run()
    {
        string input;
        while ((input = Console.ReadLine()) != "Cops Are Here")
        {
            var args = input.Split().ToList();
            var cmd = args[0];
            args = args.Skip(1).ToList();

            switch (cmd)
            {
                case "register":

                    var id = int.Parse(args[0]);
                    var type = args[1];
                    var brand = args[2];
                    var model = args[3];
                    var year = int.Parse(args[4]);
                    var horseP = int.Parse(args[5]);
                    var accelaration = int.Parse(args[6]);
                    var suspension = int.Parse(args[7]);
                    var durability = int.Parse(args[8]);

                    carManager.Register(id, type, brand, model, year, horseP, accelaration, suspension, durability);
                    break;
                case "check":
                    Console.Write(carManager.Check(int.Parse(args[0])));
                    break;
                case "open":
                    var raceId = int.Parse(args[0]);
                    var raceType = args[1];
                    var raceLenght = int.Parse(args[2]);
                    var route = args[3];
                    var prizePool = int.Parse(args[4]);

                    carManager.Open(raceId, raceType, raceLenght, route, prizePool);
                    break;
                    
                case "participate":
                    var carId = int.Parse(args[0]);
                    var rId = int.Parse(args[1]);
                    carManager.Participate(carId, rId);
                    break;
                case "park":
                    carManager.Park(int.Parse(args[0]));
                    break;
                case "unpark":
                    carManager.Unpark(int.Parse(args[0]));
                    break;
                case "tune":
                    carManager.Tune(int.Parse(args[0]), args[1]);
                    break;
                case "start":
                    Console.Write(carManager.Start(int.Parse(args[0]))); 
                        break;
                default:
                    break;
            }


        }
    }
}

