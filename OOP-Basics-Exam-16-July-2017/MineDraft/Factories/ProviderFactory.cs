using System;
using System.Collections.Generic;
using System.Text;

public class ProviderFactory
{
    public static Provider CreateProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = int.Parse(arguments[2]);

        switch (type)
        {
            case "Solar":
                return new SolarProvider(id, energyOutput);
            case "Pressure":
                return new SolarProvider(id, energyOutput);
            default:
                throw new ArgumentException("Harvester is not registered, because of it's Type");
               
        }
    }
}

