using System;
using System.Linq;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        List<IBuyer> people = new List<IBuyer>();
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();

            if (tokens.Length == 4)
            {
                people.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
            }
            else
            {
                people.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
            }
        }
        var line = Console.ReadLine();
        
        while (line != "End")
        {
            if (people.Any(p => p.Name == line))
            {
                people.First(p => p.Name == line).BuyFood();
            }
            line = Console.ReadLine();
        }
        var food = 0;
        foreach (var person in people)
        {
            food += person.Food;
        }
        Console.WriteLine( food);
    }
}

