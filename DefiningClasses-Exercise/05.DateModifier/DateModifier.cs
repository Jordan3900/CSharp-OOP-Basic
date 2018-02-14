using System;
using System.Collections.Generic;
using System.Text;

public class DateModifier
{
    public static int CalculateDifferance(string firstDate, string secondDate)
    {
        var difference = DateTime.Parse(firstDate) - DateTime.Parse(secondDate);

        return Math.Abs(difference.Days);
    }
}

