using System;
using System.Collections.Generic;
using System.Text;


public class AddCollection : IAddCollection
{

    private int countOfOperations;
    public List<string> Strings { get;  }
    public List<int> Operations { get; }
    public void Add(string str)
    {
        this.Strings.Add(str);
        Operations.Add(countOfOperations);
        countOfOperations++;
    }
}

