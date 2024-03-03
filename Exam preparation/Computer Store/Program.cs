using System;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            decimal sum = 0;
            while(input!="special" && input!= "regular")
            {
                decimal price = decimal.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sum += price;
                }
                input = Console.ReadLine();
            }
            decimal priceWithoutTaxes = sum;
            decimal taxes = sum*0.2m;
            decimal totalPrice = priceWithoutTaxes + taxes;
            if (input == "special")
            {
                totalPrice = totalPrice * 0.9m;
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
