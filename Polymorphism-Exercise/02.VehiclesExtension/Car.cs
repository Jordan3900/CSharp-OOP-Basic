using System;
using System.Collections.Generic;
using System.Text;


public class Car : Vehicles
{
    private double fuelQuantity;
    private double fuelConsuption;
    private double tankCapacity;
    public Car(double fuelQunatity, double fuelConsuption, double tankCapacity)
    {
        this.fuelQuantity = fuelQunatity;
        this.fuelConsuption = fuelConsuption + 0.9;
        this.tankCapacity = tankCapacity;

        if (FuelQuantity > tankCapacity)
        {
            this.fuelQuantity = 0;
        }
    }

    public double FuelQuantity
    {
        get => this.fuelQuantity;
        protected set
        {
            this.fuelQuantity = value;
        }
    }
    public double TankCapacity => this.tankCapacity;

    public double FuelConsuption
    {
        get => this.fuelConsuption;
     protected   set
        {
            this.fuelConsuption = value;
        }
    }

    public override void Drive(double distance)
    {
        var consuption = FuelConsuption * distance;
        if (FuelQuantity >= consuption)
        {
            Console.WriteLine($"Car travelled {distance} km");
            FuelQuantity -= consuption;
        }
        else
        {
            Console.WriteLine($"Car needs refueling");
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
        return $"Car: {FuelQuantity:f2}";
    }
}

