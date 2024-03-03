using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double total = 0;
            while(true)
            {
                if(game== "OutFall 4")
                {
                    if (budget < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {game}");
                        budget -= 39.99;
                        total += 39.99;
                    }
                }
                else if(game== "CS: OG")
                {
                    if (budget < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {game}");
                        budget -= 15.99;
                        total += 15.99;
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (budget < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {game}");
                        budget -= 19.99;
                        total += 19.99;
                    }
                }
                else if (game == "Honored 2")
                {
                    if (budget < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {game}");
                        budget -= 59.99;
                        total += 59.99;
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (budget < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {game}");
                        budget -= 29.99;
                        total += 29.99;
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (budget < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {game}");
                        budget -= 39.99;
                        total += 39.99;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                game = Console.ReadLine();
                if(game=="Game Time")
                {
                    Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${budget:f2}");
                    break;
                }
            }
        }
    }
}
