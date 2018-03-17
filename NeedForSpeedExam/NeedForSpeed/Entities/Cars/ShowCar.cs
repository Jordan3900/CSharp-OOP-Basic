using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ShowCar : Car
{
    private int stars;

    public ShowCar(int id, string brand, string model, int yearOfproduction, int horsePower, int acceleration, int suspension, int durability) : base(id,brand, model, yearOfproduction, horsePower , acceleration, suspension, durability)
    {
        this.stars = 0;
        
    }

    public int Stars
    {
        get { return stars; }
        set
        {
            stars = value;
         
        }
    }
  
    public override string ToString()
    {
        
        var builder = new StringBuilder();
        builder.AppendLine($"{Brand} {Model} {YearOfProduction}").AppendLine($"{Horsepower} HP, 100 m/h in {Acceleration} s")
            .AppendLine($"{Suspension} Suspension force, {Durability} Durability")
            .AppendLine($"{Stars} *");

        return builder.ToString().Trim(); 
    }

}

