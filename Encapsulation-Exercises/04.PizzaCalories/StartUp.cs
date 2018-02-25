using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var pizzaName = Console.ReadLine().Split();

        try
        {
            MakePizza(pizzaName);
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    private static void MakePizza(string[] tokens)
    {
        int numOfToppings = 0;
        var pizza = new Pizza(tokens[1]);

        tokens = Console.ReadLine().Split();

        while (tokens[0] != "END")
        {
            if (tokens[0] == "Dough")
            {
                var dough = new Dough(tokens[1], double.Parse(tokens[3]), tokens[2]);
                pizza.Dough = dough;
            }
            else
            {
                var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                pizza.AddTopping(topping);
                numOfToppings++;
            }
            tokens = Console.ReadLine().Split();
            
        }
        pizza.NumberOfToppings = numOfToppings;
        Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
    }
}

