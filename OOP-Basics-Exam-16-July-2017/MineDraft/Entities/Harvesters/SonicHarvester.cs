using System;
using System.Collections.Generic;
using System.Text;


public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirment, int sonicFactor) : base(id, oreOutput, energyRequirment)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement /= this.SonicFactor;
    }

    public int SonicFactor
    {
        get => this.sonicFactor;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's SonicFactor");
            }
            this.sonicFactor = value;
        }
    }
}

