using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                //Pesho 120.00 Dev Development pesho@abv.bg 28
                string name = inputArgs[0];
                decimal salary = decimal.Parse(inputArgs[1]);
                string position = inputArgs[2];
                string department = inputArgs[3];

                Employee employee = new Employee(name, salary, position, department);

                if (inputArgs.Length == 5)
                {
                    if (int.TryParse(inputArgs[4], out int result))
                    {
                        employee.Age = result;
                    }
                    else
                    {
                        employee.Email = inputArgs[4];
                    }
                }
                else if (inputArgs.Length == 6)
                {
                    employee.Email = inputArgs[4];
                    employee.Age = int.Parse(inputArgs[5]);
                }

                employees.Add(employee);
            }

            var topDepartment = employees.GroupBy(x => x.Department)
                                                .ToDictionary(x => x.Key, y => y.Select(s => s))
                                                .OrderByDescending(x => x.Value.Average(s => s.Salary))
                                                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (var employee in topDepartment.Value.OrderByDescending(x=> x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
