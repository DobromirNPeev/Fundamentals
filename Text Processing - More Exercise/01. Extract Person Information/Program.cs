using System;
using System.Collections.Generic;

namespace _01._Extract_Person_Information
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Age { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string current = Console.ReadLine();
                Person details = new Person();
                int @index = current.IndexOf('@');
                int Iindex = current.IndexOf('|');
                for (int j = @index+1; j < Iindex; j++)
                {
                    details.Name += current[j];
                }
                int Diindex = current.IndexOf('#');
                int Astindex = current.IndexOf('*');
                for (int j = Diindex+1; j <Astindex; j++)
                {
                    details.Age += current[j];
                }
                Console.WriteLine($"{details.Name} is {details.Age} years old.");
            }
        }
    }
}
