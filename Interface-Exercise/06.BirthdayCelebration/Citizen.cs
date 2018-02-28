﻿using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IIdentifiable, IDatable
{
    private string name;
    private string date;
    

    public Citizen(string name, string date)
    {
        this.name = name;
        this.date = date;
    }

    public string Id
    {
        get => this.date;
        set
        {
            this.date = value;
        }
    }
    public string Date
    {
        get => this.date;
        set
        {
            this.date = value;
        }
    }

   
}

