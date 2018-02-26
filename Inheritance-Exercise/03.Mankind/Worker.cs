using System;
using System.Collections.Generic;
using System.Text;


public class Worker : Human
{
    private decimal weekSalary;
    private decimal hoursPerDay;
    public Worker(string firstName, string lastName, decimal salary, decimal hoursPerDay) : base(firstName,lastName)
    {
        this.WeekSalary = salary;
        this.HoursPerDay = hoursPerDay;
    }

    public decimal WeekSalary
    {
        get => this.weekSalary;
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    public decimal HoursPerDay
    {
        get => this.hoursPerDay;
       protected set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.hoursPerDay = value;
        }
    }

   
    public decimal GetSalaryPerHour()
    {
        return this.WeekSalary / 5 / this.HoursPerDay;
    }


    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        builder.AppendLine($"First Name: {this.FirstName}");
        builder.AppendLine($"Last Name: {this.LastName}");
        builder.AppendLine($"Week Salary: {this.weekSalary:f2}");
        builder.AppendLine($"Hours per day: {this.hoursPerDay:f2}");
        builder.AppendLine($"Salary per hour: {GetSalaryPerHour():f2}");
        return builder.ToString();
    }
}

