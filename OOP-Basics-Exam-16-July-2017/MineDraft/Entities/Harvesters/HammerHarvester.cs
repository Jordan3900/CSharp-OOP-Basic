using System;
using System.Collections.Generic;
using System.Text;


public class HammerHarvester : Harvester
{

    public HammerHarvester(string id, double oreOutput, double energyRequirment) : base(id, oreOutput, energyRequirment)
    {
        this.OreOutput *= 3;
        this.EnergyRequirement *= 2;
    }
}

