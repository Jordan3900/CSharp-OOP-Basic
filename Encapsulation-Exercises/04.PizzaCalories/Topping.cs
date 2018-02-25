
using System;
using System.Collections.Generic;
using System.Text;


public class Topping
{
    public const int MinWeight = 1;
    public const int MaxWeight = 50;
    public const int BaseCalories = 2;

    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }
   public string Type
    {
        get { return this.type; }
        set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "sauce" && value.ToLower() != "veggies" && value.ToLower() != "cheese")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.type = value;
        }
    }
    public double Weight
    {
        get { return this.weight; }
        set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException("Meat weight should be in the range [1..50].");
            }
            this.weight = value;
        }
    }
    public double GetCalories()
    {
        return BaseCalories * this.weight * GetTypeModifier();
    }

    private double GetTypeModifier()
    {
        if (this.type.ToLower() == "meat")
        {
            return 1.2;
        }
        else if (this.type.ToLower() == "veggies")
        {
            return 0.8;
        }
        else if (this.type.ToLower() == "cheese")
        {
            return 1.1;
        }
        return 0.9;
    }
}

