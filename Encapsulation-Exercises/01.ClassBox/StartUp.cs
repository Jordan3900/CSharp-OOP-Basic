using System;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        try
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var heigth = double.Parse(Console.ReadLine());

            var box = new Box(length, width, heigth);
            Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.CalculateVolume():f2}");
        }
        catch (ArgumentException Ex)
        {

            Console.WriteLine(Ex.Message);
        }



    }
}

