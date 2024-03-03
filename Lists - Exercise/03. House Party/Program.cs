using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = string.Empty;
            List<string> guests = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ");
                name = command[0];
                if(string.Join(" ",command) == $"{name} is going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(" \n",guests));
        }
    }
}
