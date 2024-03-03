using System;
using System.Collections.Generic;

namespace _02._Oldest_Family_Member
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family
    {
        public List<Person> People { get; set; }
        public void AddMember(Person newPerson)
        {
            People.Add(newPerson);
        }
        public Person GetOldestFamilyMember(List<Person> people)
        {
            int maxAge = int.MinValue;
            Person returningPerson = new Person();
            foreach (var item in people)
            {
                if (item.Age > maxAge)
                {
                    maxAge = item.Age;
                    returningPerson = new Person
                    {
                        Name=item.Name,
                        Age=maxAge
                    };
                }
            }
            return returningPerson;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family
            {
                People=new List<Person>()
            };
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age =int.Parse(input[1]);
                Person newPerson = new Person
                {
                    Name = name,
                    Age = age
                };
                family.AddMember(newPerson);
            }
            Person oldest = family.GetOldestFamilyMember(family.People);
            Console.WriteLine(oldest.Name + " "+oldest.Age);
        }
    }
}
