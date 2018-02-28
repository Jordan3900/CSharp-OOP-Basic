using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IIdentifiable
{
    private string name;
    private string id;

    public Citizen(string name, string id)
    {
        this.name = name;
        this.Id = id;
    }

    public string Id
    {
        get => this.id;
        set
        {
            this.id = value;
        }
    }
    public string Model
    {
        get => this.name;
        set
        {
            this.name = value;
        }
    }

   
}

