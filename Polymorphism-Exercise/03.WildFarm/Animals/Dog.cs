using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Dog : Mammal
{
  

    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    protected override string[] PreferanceFood => new string[] { "Meat", };
    protected override double WeightMultiplier => 0.40;

    public override string ToString()
    {
        return $"{GetType()} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }

    public override string ProduceSound()
    {
        return "Woof!";
    }
}

