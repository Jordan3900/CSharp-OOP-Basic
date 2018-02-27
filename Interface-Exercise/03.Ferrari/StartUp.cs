using System;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var driver = Console.ReadLine();
        Ferrari ferrari = new Ferrari(driver);

        Console.WriteLine($"488-Spider/{ferrari.Brakes()}/{ferrari.PushGas()}/{driver}");
    }
}

