using System;
using System.Collections.Generic;
using System.Text;


public class Car : Vehicles
{
    private double fuelQuantity;
    private double fuelConsuption;

    public Car(double fuelQunatity, double fuelConsuption)
    {
        this.fuelQuantity = fuelQunatity;
        this.fuelConsuption = fuelConsuption + 0.9;
    }

    public double FuelQuantity
    {
        get => this.fuelQuantity;
        set
        {
            this.fuelQuantity = value;
        }
    }

    public double FuelConsuption
    {
        get => this.fuelConsuption;
        set
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
        FuelQuantity += fuel;
    }
    public override string ToString()
    {
        return $"Car: {FuelQuantity:f2}";
    }
}

