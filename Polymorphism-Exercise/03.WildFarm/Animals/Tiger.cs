using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Tiger : Feline
{


    public Tiger(string name, double weight,string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
        
    }

    protected override string[] PreferanceFood => new string[] { "Meat", };
    protected override double WeightMultiplier => 1;

    public override string ProduceSound()
    {
        return "ROAR!!!";
    }
}

