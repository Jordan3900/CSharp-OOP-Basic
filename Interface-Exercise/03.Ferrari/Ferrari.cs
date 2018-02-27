using System;
using System.Collections.Generic;
using System.Text;


public class Ferrari : IDrivable
{

    private string driver;

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }
    public string Driver
    {
        get => this.driver;
        set
        {
            this.driver = value;
        }
    }
    public string Brakes()
    {
        return "Brakes!";
    }
    public string PushGas()
    {
        return "Zadu6avam sA!";
    }
}

