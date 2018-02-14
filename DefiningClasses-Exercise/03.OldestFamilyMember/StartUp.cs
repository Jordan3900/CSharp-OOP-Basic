using System;
using System.Collections.Generic;
using System.Linq;


class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var familyMembers = new List<Person>();
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();
            var age = int.Parse(tokens[1]);
            var name = tokens[0];
            var member = new Person(name,age);
            familyMembers.Add(member);
        }
        var oldestMember = familyMembers.OrderByDescending(a => a.Age).First();
        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}

