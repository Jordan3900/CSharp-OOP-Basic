using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private Engine engine;
    private double weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.weight = 0;
        this.color = "n/a";
    }

    public string Model => this.model;
    public Engine Engine => this.engine;

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    public string Color
    {
        get => this.color;
        set => this.color = value;
    }

    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendLine($"{this.model}:");
        print.AppendLine($"  {engine.Model}:");
        print.AppendLine($"    Power: {engine.Power}");
        print.AppendLine($"    Displacement: {engine.Displacement}");
        print.AppendLine($"    Efficiency: {engine.Efficiency}");
        if (Weight != 0)
        {
            print.AppendLine($"  Weight: {this.Weight}");
        }
        else
        {
            print.AppendLine($"  Weight: n/a");
        }
        print.AppendLine($"  Color: {this.Color}");

        return print.ToString();
    }
}

