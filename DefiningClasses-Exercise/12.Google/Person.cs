using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private Company company;
    private Car car;
    private List<Pokemon> pokemons;
    private List<FamilyMember> parents;
    private List<FamilyMember> childrens;

    public Person(string name)
    {
        this.name = name;
        this.pokemons = new List<Pokemon>();
        this.parents = new List<FamilyMember>();
        this.childrens = new List<FamilyMember>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Company Company
    {
        get { return company; }
        set { company = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public List<FamilyMember> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<FamilyMember> Childrens
    {
        get { return childrens; }
        set { childrens = value; }
    }
    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine(name);
        builder.AppendLine($"Company:");
        if (company != null)
        {
            builder.AppendLine(company.ToString());
        }
        builder.AppendLine($"Car:");
        if (car != null)
        {
            builder.AppendLine(car.ToString());
        }
        builder.AppendLine("Pokemon:");
        this.pokemons.ForEach(p => builder.AppendLine(p.ToString()));
        builder.AppendLine("Parents:");
        this.parents.ForEach(p => builder.AppendLine(p.ToString()));
        builder.AppendLine("Children:");
        this.childrens.ForEach(c => builder.AppendLine(c.ToString()));
        return builder.ToString();
    }
}

