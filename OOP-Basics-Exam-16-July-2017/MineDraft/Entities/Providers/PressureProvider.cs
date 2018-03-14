using System;
using System.Collections.Generic;
using System.Text;

public class PressureProvider : Provider
{

    protected PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        this.EnergyOutput += EnergyOutput / 2;
    }
}

