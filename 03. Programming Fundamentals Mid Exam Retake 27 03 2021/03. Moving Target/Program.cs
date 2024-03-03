using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandAsArray = command.Split(" ");
                string theCommand = commandAsArray[0];
                if (theCommand=="Shoot")
                {
                    int index = int.Parse(commandAsArray[1]);
                    if(index<0 || index >= targets.Count)
                    {
                        continue;
                    }
                    int power = int.Parse(commandAsArray[2]);
                    targets[index] -= power;
                    if (targets[index] <= 0)
                    {
                       targets.RemoveAt(index);
                    }
                }
                else if (theCommand == "Add")
                {
                    int index = int.Parse(commandAsArray[1]);
                    if (index < 0 || index >= targets.Count)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                    int value = int.Parse(commandAsArray[2]);
                    targets.Insert(index, value);
                }
                else
                {
                    int index = int.Parse(commandAsArray[1]);
                    int radius = int.Parse(commandAsArray[2]);
                    int originalLength = targets.Count;
                    int begin = index - radius;
                    int end = index + radius;
                    for (int i = begin; i <=end; i++)
                    {
                        if(i<0 || i >= originalLength)
                        {
                            break;
                        }
                        else
                        {
                            targets.RemoveAt(begin);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join("|",targets));
        }
    }
}
