using System;
using System.Collections.Generic;
using System.Text;

class Employee
{
    string name;
    decimal salary;
    string position;
    string department;
    string email;
    int age;

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = "n/a";
        this.age = -1;
    }

    public string Name => this.name;
    public decimal Salary => this.salary;
    public string Department => this.department;

    public string Email
    {
        get{ return this.email = email; }
        set { this.email = value; }
    }

    public int Age
    {
        get { return this.age = age; }
        set { this.age = value; }
    }
}

