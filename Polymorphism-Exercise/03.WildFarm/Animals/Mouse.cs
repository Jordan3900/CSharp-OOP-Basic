using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Mouse : Mammal
{
  
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    protected override string[] PreferanceFood => new string[] { "Vegetable", "Fruit" };
    protected override double WeightMultiplier => 0.10;

    public override string ToString()
    {
        return $"{GetType()} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }

    public override string ProduceSound()
    {
        return "Squeak";
    }
}

