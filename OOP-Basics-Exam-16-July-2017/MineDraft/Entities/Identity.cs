using System;
using System.Collections.Generic;
using System.Text;


public abstract class Identity
{
    private string id;

    protected Identity(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get => this.id;
        private set => this.id = value;
    }
}

