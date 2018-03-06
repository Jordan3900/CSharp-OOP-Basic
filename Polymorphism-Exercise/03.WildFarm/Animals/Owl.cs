using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Owl : Bird
{
    private string[] preferanceFood = new string[] { "Meat" };

    public Owl( string name, double weight, double wingSize) : base(name, weight,wingSize)
    {
    }

    protected override string[] PreferanceFood => new string[] { "Meat", };
    protected override double WeightMultiplier => 0.25;
    public override string ProduceSound()
    {
        
        return "Hoot Hoot";
    }
}

