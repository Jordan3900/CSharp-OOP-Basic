using System;


class AnimalFarm
{
    static void Main(string[] args)
    {
        try
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var chiken = new Chiken(name, age);

            Console.WriteLine($"Chicken Mara (age {chiken.Age}) can produce {chiken.GetProductPerDay()} eggs per day.");
        }
        catch (ArgumentException Ex)
        {
            Console.WriteLine(Ex.Message);
        }
       
    }
}

