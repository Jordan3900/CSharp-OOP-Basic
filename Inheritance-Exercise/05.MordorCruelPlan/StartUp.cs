using System;
using System.Linq;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var foodTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var gandalf = new Gandalf();
        foreach (var food in foodTokens)
        {
            gandalf.EatingFood(food.ToLower());
        }
        Console.WriteLine(gandalf.HapinesPoint);
        gandalf.GetTheMood();
    }
}

