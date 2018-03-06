using System;
using System.Collections.Generic;
using System.Text;


public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

   
    protected override double WeightMultiplier => 0.35;
    
    public override string ProduceSound()
    {
        return "Cluck";
    }
}

