using System;
using System.Collections.Generic;
using System.Text;

public class Gandalf
{
    private int hapinesPoint;

    public Gandalf()
    {
        this.hapinesPoint = 0;
    }

    public int HapinesPoint => this.hapinesPoint;

    public void EatingFood(string food)
    {
        var foodPoint = new Dictionary<string, int>();

     
        foodPoint["cram"] = 2;
        foodPoint["lembas"] = 3;
        foodPoint["apple"] = 1;
        foodPoint["melon"] = 1;
        foodPoint["honeycake"] = 5;
        foodPoint["mushrooms"] = -10;

        if (foodPoint.ContainsKey(food))
        {
            this.hapinesPoint += foodPoint[food];
        }
        else
        {
            this.hapinesPoint -= 1;
        }
    }

    public void GetTheMood()
    {
        if (hapinesPoint < -5)
        {
            Console.WriteLine("Angry");
        }
        else if (hapinesPoint == -5 || hapinesPoint <= 0)
        {
            Console.WriteLine("Sad");
        }
        else if (hapinesPoint > 15)
        {
            Console.WriteLine("JavaScript");
        }
        else if (hapinesPoint > 0 || hapinesPoint <= 15)
        {
            Console.WriteLine("Happy");
        }
       
    }
}

