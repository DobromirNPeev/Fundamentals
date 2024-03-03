using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] currPerson = input.Split(' ');
                string name = currPerson[0];
                string id = currPerson[1];
                int age =int.Parse(currPerson[2]);
                bool alreadyIn = false;
                Person addingCurrPerson = new Person
                {
                    Name = name,
                    ID = id,
                    Age = age
                };
                foreach (var item in people)
                {
                    if (item.ID == id)
                    {
                        item.Name = name;
                        item.Age = age;
                        alreadyIn = true;
                        break;
                    }
                }
                if (!alreadyIn)
                {
                    people.Add(addingCurrPerson);
                }
            }
            people = people.OrderBy(x => x.Age).ToList();
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
}
