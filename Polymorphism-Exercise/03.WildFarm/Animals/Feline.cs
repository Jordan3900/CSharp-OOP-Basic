﻿using System;
using System.Collections.Generic;
using System.Text;


public abstract class Feline : Mammal
{
    public Feline(string name, double weight,string livingRegion, string breed) : base(name, weight, livingRegion)
    {
        this.Breed = breed;
    }
    public string Breed { get; set; }

    public override string ToString()
    {
        return $"{GetType()} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]"; 
    }
}
