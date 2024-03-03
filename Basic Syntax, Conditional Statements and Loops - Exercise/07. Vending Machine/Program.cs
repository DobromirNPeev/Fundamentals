using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double coinSum= 0;
            while (command != "Start")
            {
                double coin = double.Parse(command);
                if(coin==0.1 || coin==0.2 || coin==0.5 || coin==1 || coin == 2)
                {
                    coinSum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "Nuts")
                {
                    coinSum -= 2;
                    if (coinSum>=0)
                    {
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        coinSum += 2;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if(command == "Water")
                {
                    coinSum -= 0.7;
                    if (coinSum >= 0)
                    {
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        coinSum += 0.7;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Crisps")
                {
                    coinSum -= 1.5;
                    if (coinSum >= 0)
                    {
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        coinSum += 1.5;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Soda")
                {
                    coinSum -= 0.8;
                    if (coinSum >= 0)
                    {
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        coinSum += 0.8;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Coke")
                {
                    coinSum -= 1;
                    if (coinSum >= 0)
                    {
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        coinSum += 1;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coinSum:f2}");
        }
    }
}
