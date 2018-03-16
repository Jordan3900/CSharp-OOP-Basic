using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(int id, string brand, string model, int yearOfproduction, int horsePower, int acceleration, int suspension, int durability) :
        base(id, brand, model, yearOfproduction, horsePower + (horsePower * 50) / 100, acceleration, suspension - (suspension * 25) / 100, durability )
    {
        addOns = new List<string>();
    }

    public List<string> AddOns
    {
        get { return addOns; }
        protected set { addOns = value; }
    }

    public override string ToString()
    {
        var additional = AddOns.Count == 0 ? "None" : string.Join(", ", AddOns);
        var builder = new StringBuilder();
        builder.AppendLine($"{Brand} {Model} {YearOfProduction}").AppendLine($"{Horsepower} HP, 100 m/h in {Acceleration} s")
            .AppendLine($"{Suspension} Suspension force, {Durability} Durability")
            .AppendLine($"Add-ons: {additional}");

        return builder.ToString(); ;
    }

}

