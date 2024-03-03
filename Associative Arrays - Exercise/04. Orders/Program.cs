using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class ProductAttributes
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,ProductAttributes> products= new Dictionary<string, ProductAttributes> ();
            string command = string.Empty;
            while ((command=Console.ReadLine()) != "buy")
            {
                string[] commandAsArray = command.Split().ToArray();
                string name = commandAsArray[0];
                double price = double.Parse(commandAsArray[1]);
                int quantity = int.Parse(commandAsArray[2]);
                ProductAttributes currProd = new ProductAttributes
                {
                    Price = price,
                    Quantity = quantity
                };
                if (!products.ContainsKey(name))
                {
                    products.Add(name, currProd);
                }
                else
                {
                    products[name].Quantity += quantity;
                    if (products[name].Price != price)
                    {
                        products[name].Price = price;
                    }
                }
            }
            double sum = 0;
            foreach (var item in products)
            {
                sum = item.Value.Price * item.Value.Quantity;
                Console.WriteLine($"{item.Key} -> {sum:f2}");
            }
        }
    }
}
