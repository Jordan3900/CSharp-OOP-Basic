using System;
using System.Collections.Generic;
using System.Text;


public class HarvestFactory
{

    public static Harvester CreatHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirment = double.Parse(arguments[3]);

        switch (type)
        {
            case "Hammer":
                return new HammerHarvester(id, oreOutput, energyRequirment);
            case "Sonic":
                var sonicFactor = int.Parse(arguments[4]);
                return new SonicHarvester(id, oreOutput, energyRequirment, sonicFactor);
            default:
                throw new ArgumentException("Harvester is not registered, because of it's Type");
                
        }
    }
}

