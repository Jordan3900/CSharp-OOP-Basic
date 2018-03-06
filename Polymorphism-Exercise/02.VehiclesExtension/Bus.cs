using System;
using System.Collections.Generic;
using System.Text;

public class Bus : Vehicles
{
    private double fuelQuantity;
    private double fuelConsuption;
    private double tankCapacity;
    private bool isEmpty;

    public Bus(double fuelQunatity, double fuelConsuption, double tankCapacity)
    {
        this.tankCapacity = tankCapacity;
        this.fuelQuantity = fuelQunatity;
        this.fuelConsuption = fuelConsuption ;
        if (FuelQuantity > tankCapacity)
        {
            this.fuelQuantity = 0;
        }
    }

    public bool IsEmpty
    {
        get => this.isEmpty;
        set
        {
            this.isEmpty = value;
        }
    }

    public double FuelQuantity
    {
        get => this.fuelQuantity;
     protected   set
        {
            this.fuelQuantity = value;
        }
    }
    public double TankCapacity => this.tankCapacity;



    public double FuelConsuption
    {
        get => this.fuelConsuption;
      protected  set
        {
            this.fuelConsuption = value;
        }
    }

    public override void Drive(double distance)
    {
        var consuption = 0d;
        if (isEmpty)
        {
             consuption += FuelConsuption * distance;
        }
        else
        {
            consuption += (FuelConsuption+1.4) * distance;
        }
        

        if (FuelQuantity >= consuption)
        {
            Console.WriteLine($"Bus travelled {distance} km");
          
                FuelQuantity -= consuption;
        }
        else
        {
            Console.WriteLine($"Bus needs refueling");
        }
    }



    public override void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            Console.WriteLine($"Fuel must be a positive number");
        }
        else if (fuel > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {fuel} fuel in the tank");

        }
        else
        {
            FuelQuantity += fuel;
        }
    }
    public override string ToString()
    {
        return $"Bus: {this.FuelQuantity:f2}";
    }
}

