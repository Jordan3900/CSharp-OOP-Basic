using System;
using System.Collections.Generic;
using System.Text;


public class Robot : IIdentifiable
{
    private string model;
    private string id;

    public Robot(string model, string id)
    {
        this.model = model;
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
        get => this.model;
        set
        {
            this.model = value;
        }
    }

  
}

