using System;
using System.Collections.Generic;
using System.Text;


public class AddRemoveCollection : IAddRemoveCollection

{
    public List<string> Strings { get; }

    public void Add(string str)
    {
        Strings.Insert(0, str);
    }

    public void Remove(string str)
    {
        Strings.RemoveAt(Strings.Count -1);
    }
}

