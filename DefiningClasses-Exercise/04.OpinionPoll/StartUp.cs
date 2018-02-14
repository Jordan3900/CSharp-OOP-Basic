using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var members = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();
            var name = tokens[0];
            var age = int.Parse(tokens[1]);
            var member = new Person(name, age);
            members.Add(member);
        }
        var memAbove = members.Where(a => a.Age > 30).OrderBy(a => a.Name).ToList();
        foreach (var member in memAbove)
        {
            Console.WriteLine($"{member.Name} - {member.Age}");
        }
    }
}

