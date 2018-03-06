using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



public abstract class Animal
{
    
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    public string Name { get; }
    public double Weight { get; protected set; }
    public int FoodEaten { get; protected set; }
    protected virtual double WeightMultiplier => 1;
    protected virtual string[] PreferanceFood => new string[] { };

    public abstract string ProduceSound();
    public void EatFood(Food food)
    {
        if (!PreferanceFood.Contains(food.GetType().ToString()) && GetType().ToString() != "Hen")
        {
            throw new ArgumentException($"{GetType()} does not eat {food.GetType()}!");
        }
        this.Weight += food.Quantity * this.WeightMultiplier;
        this.FoodEaten += food.Quantity;
    }
    


}

