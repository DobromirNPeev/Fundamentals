using System;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> BagOfProducts { get; set; }
    }
    class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPeople = new List<Person>();
            string[] people = Console.ReadLine().Split(';');
            for (int i = 0; i < people.Length; i++)
            {
                string[] personAndMoney = people[i].Split('=');
                string name = personAndMoney[0];
                decimal money = decimal.Parse(personAndMoney[1]);
                List<Product> bag = new List<Product>();
                Person newPerson = new Person
                {
                    Name = name,
                    Money = money,
                    BagOfProducts=bag
                };
                allPeople.Add(newPerson);
            }
            List<Product> allProducts = new List<Product>();
            string[] products = Console.ReadLine().Split(';');
            for (int i = 0; i < products.Length; i++)
            {
                string[] personAndMoney = products[i].Split('=');
                if (personAndMoney[0] == string.Empty) break;
                string name = personAndMoney[0];
                double cost = double.Parse(personAndMoney[1]);
                Product newProduct = new Product
                {
                    Name = name,
                    Cost = cost,
                };
                allProducts.Add(newProduct);
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandAsArray = command.Split(' ');
                string person = commandAsArray[0];
                string product = commandAsArray[1];
                foreach (var item in allPeople)
                {
                    if (item.Name == person)
                    {
                        foreach (var itemInside in allProducts)
                        {
                            if (itemInside.Name == product)
                            {
                                if (item.Money - (decimal)itemInside.Cost >= 0)
                                {
                                    item.Money -= (decimal)itemInside.Cost;
                                    item.BagOfProducts.Add(itemInside);
                                    Console.WriteLine($"{person} bought {product}");
                                }
                                else
                                {
                                    Console.WriteLine($"{item.Name} can't afford {itemInside.Name}");
                                }
                            }
                        }
                    }
                }
            }
            foreach (var item in allPeople)
            {
                Console.Write($"{item.Name} - ");
                int i = 0;
                if (item.BagOfProducts.Count == 0)
                {
                    Console.Write("Nothing bought");
                }
                else
                {
                    foreach (var itemInside in item.BagOfProducts)
                    {
                        if (i ==item.BagOfProducts.Count-1)
                        {
                            Console.Write($"{itemInside.Name}");
                        }
                        else
                        {
                            Console.Write($"{itemInside.Name}, ");
                            i++;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
