using System;
using System.Linq;
using System.Collections.Generic;
namespace _06.CompanyRoster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                var name = tokens[0];
                var salary = decimal.Parse(tokens[1]);
                var position = tokens[2];
                var department = tokens[3];
                var employee = new Employee(name, salary, position, department);
                if (tokens.Length > 4)
                {
                    if (int.TryParse(tokens[4], out int age))
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = tokens[4];
                    }
                }
                if (tokens.Length > 5)
                {
                   
                    employee.Age = int.Parse(tokens[5]);
                }
                employees.Add(employee);
            }
            var result = employees.GroupBy(e => e.Department).Select(d => new
            {
                Department = d.Key,
                AverageSalary = d.Average(e => e.Salary),
                Employees = d.OrderByDescending(emp => emp.Salary).ToList()
            })
                .OrderByDescending(d => d.AverageSalary)
                .FirstOrDefault();

            if (result != null)
            {
                Console.WriteLine($"Highest Average Salary: {result.Department}");

                foreach (var employee in result.Employees)
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
                }
            }
        }
        
    }
}
