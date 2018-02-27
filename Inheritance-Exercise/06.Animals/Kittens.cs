using System;
using System.Collections.Generic;
using System.Text;


public class Kittens : Animal
{
    public Kittens(string name, int age) : base(name, age, "Female")
    {

    }
    public override string ProduceSound()
    {
        return "Meow";
    }
}

