using System;
using System.Linq;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        List<IDatable> birthdays = new List<IDatable>();
        var line = Console.ReadLine();

        while (line.Trim() != "End")
        {
            var tokens = line.Split();
            switch (tokens[0])
            {
                case "Citizen": birthdays.Add(new Citizen(tokens[1], tokens[4]));
                    break;
                case "Pet": birthdays.Add(new Pet(tokens[1], tokens[2]));
                    break;
                default:
                    break;
            }
            line = Console.ReadLine();
        }
        var year = Console.ReadLine();
        var birthdaysCeleb = birthdays.Where(b => b.Date.EndsWith(year));
        foreach ( var birthday in birthdaysCeleb)
        {
            Console.WriteLine(birthday.Date);
        }
    }
}

