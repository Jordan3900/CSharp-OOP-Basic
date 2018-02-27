using System;
using System.Collections.Generic;
using System.Text;


public class Phone : ISmartPhone
{
   
    public string Browsing(string site)
    {
        return $"Browsing: {site}!";
    }

    public string Calling(string phone)
    {
        return $"Calling... {phone}";
    }
}

