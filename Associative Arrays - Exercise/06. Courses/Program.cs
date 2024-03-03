using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputAsArray = input.Split(" : ").ToArray();
                string course = inputAsArray[0];
                string name = inputAsArray[1];
                if (courses.ContainsKey(course))
                {
                    courses[course].Add(name);
                }
                else
                {
                    List<string> names = new List<string>
                    {
                        name
                    };
                    courses.Add(course, names);
                }
            }
            foreach (var item in courses)
            {
                int count = item.Value.Count;
                Console.WriteLine($"{item.Key}: {count}");
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine($"-- {item1}");
                }
            }
        }
    }
}
