using System;
using System.Collections.Generic;
using System.Text;


public class Rebel : IBuyer
{
    private string name;
    private int age;
    private int food;
    private string group;

    public Rebel(string name, int age, string group)
    {
        this.name = name;
        this.age = age;
        this.group = group;
    }
    public int Food
    {
        get => this.food;
    }
    public string Name
    {
        get => this.name;
    }
    public void BuyFood()
    {
        this.food += 5;
    }
}

