using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            double price = 0;
            string revenue = string.Empty;
            if (groupSize <= 50)
            {
                revenue = "Small Hall";
                price += 2500;
                if (service == "Normal")
                {
                    price += 500;
                    price = price * 0.95;
                    Console.WriteLine($"We can offer you the {revenue}");
                    Console.WriteLine($"The price per person is {price/groupSize:f2}$");
                }
                else if (service == "Gold")
                {
                    price += 750;
                    price = price * 0.9;
                    Console.WriteLine($"We can offer you the {revenue}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
                else if (service == "Platinum")
                {
                    price += 1000;
                    price = price * 0.85;
                    Console.WriteLine($"We can offer you the {revenue}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
            }
            else if (groupSize > 50 && groupSize<=100)
            {
                revenue = "Terrace";
                price += 5000;
                if (service == "Normal")
                {
                    price += 500;
                    price = price * 0.95;
                    Console.WriteLine($"We can offer you the {revenue}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
                else if (service == "Gold")
                {
                    price += 750;
                    price = price * 0.9;
                    Console.WriteLine($"We can offer you the {revenue}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
                else if (service == "Platinum")
                {
                    price += 1000;
                    price = price * 0.85;
                    Console.WriteLine($"We can offer you the {revenue}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                revenue = "Great Hall";
                price += 7500;
                if (service == "Normal")
                {
                    price += 500;
                    price = price * 0.95;
                    Console.WriteLine($"We can offer you the {revenue}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
                else if (service == "Gold")
                {
                    price += 750;
                    price = price * 0.9;
                    Console.WriteLine($"We can offer you the {revenue}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
                else if (service == "Platinum")
                {
                    price += 1000;
                    price = price * 0.85;
                    Console.WriteLine($"We can offer you the {revenue}");
                    Console.WriteLine($"The price per person is {price / groupSize:f2}$");
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
