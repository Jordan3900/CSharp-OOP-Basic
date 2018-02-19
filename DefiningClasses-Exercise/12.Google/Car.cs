using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string name;
    private int speed;

    public Car(string name, int speed)
    {
        this.name = name;
        this.speed = speed;
    }

    public override string ToString()
    {
        return $"{name} {speed}";
    }
}

