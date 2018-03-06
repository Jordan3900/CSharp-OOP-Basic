using System;


class StartUp
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        while (input != "End")
        {
            var tokens = input.Split();
            var citizen = new Citizen(tokens[0]);
            IPerson person = (IPerson)citizen;
            IResident resident = (IResident)citizen;
            person.GetName();
            resident.GetName();
            input = Console.ReadLine();
        }
    }
}

