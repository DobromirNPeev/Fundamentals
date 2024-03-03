using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputs = input.Split();
                if (inputs[0] == "Add")
                {
                    int addedPassengers = int.Parse(inputs[1]);
                    passengers.Add(addedPassengers);
                }
                else
                {
                    int addedPassengers = int.Parse(inputs[0]);
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (passengers[i] + addedPassengers <= capacity)
                        {
                            passengers[i] += addedPassengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",passengers));
        }
    }
}
