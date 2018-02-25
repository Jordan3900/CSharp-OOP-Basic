using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    private double length;
    private double width;
    private double heigth;

    public Box(double length, double width, double heigth)
    {
        this.Length = length;
        this.Width= width;
        this.Heigth = heigth;
    }

    public double Length
    {
        get { return this.length; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    public double Width
    {
        get { return this.width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    public double Heigth
    {
        get { return this.heigth; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.heigth = value;
        }
    }

    public double CalculateSurfaceArea()
    {
     
        return 2 * (length * width) + 2 * (length * heigth) + 2 * (width * heigth);
    }

    public double CalculateLateralSurfaceArea()
    {

        return  2 * (length * heigth) + 2 * (width * heigth);
    }

    public double CalculateVolume()
    {

        return length * heigth * width;
    }
}

