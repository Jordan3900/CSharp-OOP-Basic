using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicles
{
    private double fuelQuantity;
    private double fuelConsuption;
    private double tankCapacity;

    public Truck(double fuelQunatity, double fuelConsuption, double tankCapacity)
    {
        this.fuelQuantity = fuelQunatity;
        this.fuelConsuption = fuelConsuption + 1.6;
        this.tankCapacity = tankCapacity;

        if (FuelQuantity > tankCapacity)
        {
            this.fuelQuantity = 0;
        }
    }
    public double TankCapacity => this.tankCapacity;
    

    public double FuelQuantity
    {
        get => this.fuelQuantity;
      protected  set
        {
            this.fuelQuantity = value;
        }
    }

    public double FuelConsuption
    {
        get => this.fuelConsuption;
       protected set
        {
            this.fuelConsuption = value;
        }
    }

    public override void Drive(double distance)
    {
        var consuption = FuelConsuption * distance;
        if (FuelQuantity >= consuption)
        {
            Console.WriteLine($"Truck travelled {distance} km");
            FuelQuantity -= consuption;
        }
        else
        {
            Console.WriteLine($"Truck needs refueling");
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
            FuelQuantity += fuel * 0.95;
        }
       
    }
    public override string ToString()
    {
        return $"Truck: {FuelQuantity:f2}";
    }
}

