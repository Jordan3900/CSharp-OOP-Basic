using System;
using System.Collections.Generic;
using System.Text;



public class Person
{
    private string name;
    private int age;

    public virtual string Name
    {
        get => this.name;
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name's lenght should not be less than 3 symbols!");
            }
            this.name = value;
        }
    }

    public virtual int Age
    {
        get => this.age;
      protected  set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            this.age = value;
        }
    }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(string.Format($"Name: {this.Name}, Age: {this.Age}"));
        return stringBuilder.ToString();
    }
}


