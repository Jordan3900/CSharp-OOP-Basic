using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private double amoutOfFuel;
    private double fuelConsuption;
    private double distance;

    public string Model => this.model;
    public double AmountOfFuel => this.amoutOfFuel;
    public double DistanceTraveled => this.distance;

    public Car(string model, double amoutOfFuel, double fuelConsuption)
    {
        this.model = model;
        this.amoutOfFuel = amoutOfFuel;
        this.fuelConsuption = fuelConsuption;
        this.distance = 0;
    }
    public void Drive(int amountOfKm)
    {
        if (amountOfKm <= this.amoutOfFuel / this.fuelConsuption)
        {
            this.distance += amountOfKm;
            this.amoutOfFuel -= this.fuelConsuption * amountOfKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}


