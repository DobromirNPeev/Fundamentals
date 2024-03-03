using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputs = string.Empty;
            int quantity = 0;
            Dictionary<string, int> mines = new Dictionary<string, int>();
            while ((inputs = Console.ReadLine())!= "stop")
            {
                quantity = int.Parse(Console.ReadLine());
                if (mines.ContainsKey(inputs))
                {
                    mines[inputs] += quantity;
                }
                else
                {
                    mines.Add(inputs, quantity);
                }
            }
            foreach (var item in mines)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
