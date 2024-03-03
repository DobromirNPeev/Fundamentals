using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string CityTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                string firstName = command[0];
                if (firstName == "end") break;
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string cityTown = command[3];
                Student student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    CityTown = cityTown
                };
                students.Add(student);
            }
            string town = Console.ReadLine();
            foreach (var item in students)
            {
                if (item.CityTown==town)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
                }
            }
        }
    }
}
