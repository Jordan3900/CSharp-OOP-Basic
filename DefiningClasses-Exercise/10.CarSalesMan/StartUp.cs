using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        var engines = new List<Engine>();
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = tokens[0];
            var power = double.Parse(tokens[1]);

            var engine = new Engine(model, power);
            var displ = string.Empty;
            if (tokens.Length == 3)
            {
                if (int.TryParse(tokens[2], out int displacement))
                {
                    engine.Displacement = tokens[2];
                }
                else
                {
                    engine.Efficiency = tokens[2];
                }

            }
            else if (tokens.Length == 4)
            {
                engine.Displacement = tokens[2];
                engine.Efficiency = tokens[3];
            }
            engines.Add(engine);
        }
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = tokens[0];
            var engine = tokens[1];
            var car = new Car(model, engines.FirstOrDefault(e => e.Model == engine));

            if (tokens.Length == 3)
            {
                if (double.TryParse(tokens[2], out double weight))
                {
                    car.Weight = double.Parse(tokens[2]);
                }
                else
                {
                    car.Color = tokens[2];
                }
            }
            else if (tokens.Length == 4)
            {
                car.Weight = double.Parse(tokens[2]);
                car.Color = tokens[3];
            }
            cars.Add(car);
        }

        cars = cars.Where(w => w.Engine != null && w.Model != null).ToList();

        cars.ForEach(c => Console.Write(c.ToString()));
    }
}

