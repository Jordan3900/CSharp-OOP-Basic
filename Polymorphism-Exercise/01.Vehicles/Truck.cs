using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicles
{
    private double fuelQuantity;
    private double fuelConsuption;

    public Truck(double fuelQunatity, double fuelConsuption)
    {
        this.fuelQuantity = fuelQunatity;
        this.fuelConsuption = fuelConsuption + 1.6;
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
        FuelQuantity += fuel *0.95;
    }
    public override string ToString()
    {
        return $"Truck: {FuelQuantity:f2}";
    }
}

