using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Cat : Feline
{
    

    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
        
    }

    protected override string[] PreferanceFood => new string[] { "Meat", "Vegetable" };
    protected override double WeightMultiplier => 0.30;
    public override string ProduceSound()
    {
        return "Meow";
    }
}

