using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
    class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> allEmployees = new List<Employee>();
            List<Department> allDeps = new List<Department>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string departmentName = input[2];
                bool createNew = true;
                List<Employee> depEmp = new List<Employee>();
                Employee currEmployee = new Employee
                {
                    Name = name,
                    Salary = salary,
                    Department = departmentName
                };
                allEmployees.Add(currEmployee);
                foreach (var item in allDeps)
                {
                    if (item.Name.Contains(departmentName))
                    {
                        createNew = false;
                        break;
                    }
                }
                if (createNew)
                {
                    depEmp.Add(currEmployee);
                    Department newDep = new Department
                    {
                        Name = departmentName,
                        Employees=depEmp
                    };
                    allDeps.Add(newDep);
                }
                else
                {
                    foreach (var item in allDeps)
                    {
                        if (item.Name == departmentName)
                        {
                            item.Employees.Add(currEmployee);
                            break;
                        }
                    }
                }
            }
            decimal maxAvgSalary = decimal.MinValue;
            Department BestDep = new Department();
            foreach (var item in allDeps)
            {
                decimal sum = 0;
                foreach (var itemInside in item.Employees)
                {
                    sum += itemInside.Salary;
                }
                sum = sum / item.Employees.Count;
                if (sum > maxAvgSalary)
                {
                    maxAvgSalary = sum;
                    BestDep = new Department
                    {
                        Name = item.Name,
                        Employees = item.Employees
                    };
                }
            }
            BestDep.Employees=BestDep.Employees.OrderByDescending(x => x.Salary).ToList();
            Console.WriteLine($"Highest Average Salary: {BestDep.Name}");
            foreach (var item in BestDep.Employees)
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }
        }
    }
}
