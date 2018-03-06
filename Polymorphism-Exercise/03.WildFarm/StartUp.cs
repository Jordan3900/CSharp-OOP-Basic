using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        var line = Console.ReadLine();
        var counter = 2;

        while (line != "End")
        {
            var tokens = line.Split();


            Animal animal = GetAnimal(tokens);

            Console.WriteLine(animal.ProduceSound());

            var foodTokens = Console.ReadLine().Split();
            Food food = GetFood(foodTokens);

            try
            {
                animal.EatFood(food);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
            animals.Add(animal);


            line = Console.ReadLine();
            counter++;
        }

        foreach (var beast in animals)
        {
            Console.WriteLine(beast.ToString());
        }

    }

    private static Food GetFood(string[] tokens)
    {
        string type = tokens[0];
        int quantity = int.Parse(tokens[1]);
        Food food = null;

        switch (type)
        {
            case "Fruit":
                food = new Fruit();
                food.Quantity = quantity;
                break;
            case "Vegetable":
                food = new Vegetable();
                food.Quantity = quantity;
                break;
            case "Meat":
                food = new Meat();
                food.Quantity = quantity;
                break;
            case "Seeds":
                food = new Seeds();
                food.Quantity = quantity;
                break;
            default:
                break;
        }
        return food;
    }

    private static Animal GetAnimal(string[] tokens)
    {
        string type = tokens[0];
        string name = tokens[1];
        double weight = double.Parse(tokens[2]);
        Animal animal = null;
        switch (type)
        {
            case "Cat":
                animal = new Cat(name, weight, tokens[3], tokens[4]);
                break;
            case "Dog":
                animal = new Dog(name, weight, tokens[3]);
                break;
            case "Mouse":
                animal = new Mouse(name, weight, tokens[3]);
                break;
            case "Tiger":
                animal = new Tiger(name, weight, tokens[3], tokens[4]);
                break;
            case "Hen":
                animal = new Hen(name, weight, double.Parse(tokens[3]));
                break;
            case "Owl":
                animal = new Owl(name, weight, double.Parse(tokens[3]));
                break;
            default:
                Console.WriteLine("Invalid type");
                break;
        }

        return animal;
    }
}

