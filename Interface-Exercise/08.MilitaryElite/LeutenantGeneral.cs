using System;
using System.Collections.Generic;
using System.Text;


public class LeutenantGeneral : Private, ILeutantGeneral
{
    private ICollection<ISoldier> privates;

    public LeutenantGeneral(int id, string firstName, string lastName, decimal salary) : base (id, firstName, lastName, salary) 
    {
        privates = new List<ISoldier>();
    }

    public IReadOnlyCollection<ISoldier> Privates => (IReadOnlyCollection<ISoldier>)this.privates;

    public void AddPrivate(ISoldier soldier)
    {
        this.privates.Add(soldier);
    }
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(base.ToString()).AppendLine($"{nameof(this.Privates)}:");

        foreach (var item in this.Privates)
        {
            builder.AppendLine($"  {item.ToString()}");
        }

        string result = builder.ToString().TrimEnd();
        return result;
    }
}

