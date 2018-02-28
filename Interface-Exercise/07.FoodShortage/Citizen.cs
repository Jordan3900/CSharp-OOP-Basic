using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IBuyer
{
    private string name;
    private int age;
    private string id;
    private string birthdate;
    private int food;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.name = name;
        this.age = age;
        this.birthdate = birthdate;
        this.id = id;
        this.food = 0;
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
        food += 10;
    }
}

