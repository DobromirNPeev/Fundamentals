using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputAsArray = input.Split(" -> ").ToArray();
                string company = inputAsArray[0];
                string id = inputAsArray[1];
                if (companies.ContainsKey(company))
                {
                    if (!companies[company].Contains(id))
                    {
                        companies[company].Add(id);
                    }
                }
                else
                {
                    List<string> ids = new List<string>
                    {
                        id
                    };
                    companies.Add(company, ids);
                }
            }
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine($"-- {item1}");
                }
            }
        }
    }
}
