using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IPerson, IResident
{
    public string name;

    public Citizen(string name)
    {
        this.name = name;
    }
    void IPerson.GetName()
    {
        Console.WriteLine($"{this.name}");
    }
     void IResident.GetName()
    {
        Console.WriteLine($"Mr/Ms/Mrs {this.name}");
    }
}

