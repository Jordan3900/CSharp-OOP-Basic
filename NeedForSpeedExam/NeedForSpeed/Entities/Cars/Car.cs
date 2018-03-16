using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int durability;
    private int suspension;
    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }


    protected Car(int id, string brand, string model, int yearOfproduction, int horsepower, int acceleration,int suspension, int durability)
    {
        this.Brand= brand;
        this.Durability = durability;
        this.Model = model;
        this.YearOfProduction = yearOfproduction;
        this.Horsepower = horsepower ;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.IsCarParked = false;
        this.IsCarRacing = false;
        this.Id = id;
    }
    public bool IsCarParked { get; set; }
    public bool IsCarRacing { get; set; }

    public int OverallPerformance => EnginePerformance + SuspensionPerformance;
    public int EnginePerformance => Horsepower / Acceleration;
    public int SuspensionPerformance => Suspension + Durability;

    public int Suspension
    {
        get { return suspension; }
        set { suspension = value; }
    }


    public int Durability
    {
        get { return durability; }
        protected set { durability = value; }
    }


    public int Acceleration
    {
        get { return acceleration; }
        protected set { acceleration = value; }
    }

    public int Horsepower
    {
        get { return horsepower; }
        set { horsepower = value; }
    }

    public int YearOfProduction
    {
        get { return yearOfProduction; }
        protected set { yearOfProduction = value; }
    }

    public string Model
    {
        get { return model; }
        protected set { model = value; }
    }

    public string Brand
    {
        get { return brand; }
        protected set { brand = value; }
    }

    public override string ToString()
    {
        return base.ToString();
    }

}

