using System;
using System.Linq;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var line = Console.ReadLine();
        List<IIdentifiable> persons = new List<IIdentifiable>();

        while (line != "End")
        {
            var tokens = line.Split();
            
            if (tokens.Length == 3)
            {
                persons.Add(new Citizen(tokens[0], tokens[2]));
            }
            else
            {
                persons.Add(new Robot(tokens[0], tokens[1]));
            }
            line = Console.ReadLine();
        }

        var lastNums = Console.ReadLine();

        var badPersons = persons.Where(p => p.Id.EndsWith(lastNums));
        foreach (var person in badPersons)
        {
            Console.WriteLine(person.Id);
        }
    }
}

