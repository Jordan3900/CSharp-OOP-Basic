using System;
using System.Collections.Generic;
using System.Text;


public class MyList : IAddRemoveUsed
{
    public List<string> Strings { get; }

    public void Add(string str)
    {
        Strings.Add(str);
    }

    public void Remove(string str)
    {
        Strings.RemoveAt(Strings.Count - 1);
    }

    public void Used()
    {
        Console.WriteLine(Strings.Count);
    }
}

