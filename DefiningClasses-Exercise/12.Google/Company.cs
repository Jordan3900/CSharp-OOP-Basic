using System;
using System.Collections.Generic;
using System.Text;


public class Company
{
    private string name;
    private string position;
    private decimal salary;

    public Company(string name,string position, decimal salary)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
    }
    public override string ToString()
    {
        return $"{name} {position} {salary:f2}";
    }
}

