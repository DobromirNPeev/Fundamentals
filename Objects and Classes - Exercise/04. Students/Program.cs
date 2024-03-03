using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> allStudents = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] currStudent = Console.ReadLine().Split(' ');
                string firstName = currStudent[0];
                string lastName = currStudent[1];
                double grade = double.Parse(currStudent[2]);
                Student theStudent = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };
                allStudents.Add(theStudent);
            }
            allStudents = allStudents.OrderByDescending(x => x.Grade).ToList();
            foreach (var item in allStudents)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }
        }
    }
}
