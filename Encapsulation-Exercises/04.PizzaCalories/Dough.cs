using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
    private const int MinWeight = 1;
    private const int MaxWeight = 200;
    private const int BaseCalories = 2;

    private string type;
    private double weight;
    private string bakingTechnique;

    public Dough(string type, double weight, string bakingTechnique)
    {
        this.type = type;
        this.weight = weight;
        this.bakingTechnique = bakingTechnique;
    }

    public string Type
    {
        get => this.type;
        private set
        {
            if (value.ToLower() != "wholegrain" && value.ToLower() != "white")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.type = value;
        }
    }

    public string BakingTechnique
    {
        get => this.type;
        private set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value;
        }
    }

    public double Weight
    {
        get => this.weight;
        private set
        {
            if (value < MinWeight || value >  MaxWeight)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
            }
            this.weight = value;
        }
    }
    public double GetCalories()
    {
        return BaseCalories * this.weight * this.GetFlourModifier() * GetBakingTechniqueModifier();
    }

    private double GetBakingTechniqueModifier()
    {
        if (this.type.ToLower() =="white")
        {
            return 1.5;
        }
        return 1;
    }

    private double GetFlourModifier()
    {
        if (this.bakingTechnique.ToLower() == "crispy")
        {
            return 0.9;
        }
        if (this.bakingTechnique.ToLower() == "chewy")
        {
            return 1.1;
        }
        return 1;
    }
}

