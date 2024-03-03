using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmndArgs = command.Split().ToArray();
                string firstCommand = cmndArgs[0];
                if (firstCommand == "Urgent")
                {
                    string item = cmndArgs[1];
                    if (!input.Contains(item))
                    {
                        input.Insert(0,item);
                    }
                }
                else if (firstCommand == "Unnecessary")
                {
                    string item = cmndArgs[1];
                    if (input.Contains(item))
                    {
                        input.Remove(item);
                    }
                }
                else if (firstCommand == "Correct")
                {
                    string oldItem = cmndArgs[1];
                    string newItem = cmndArgs[2];
                    if (input.Contains(oldItem))
                    {
                        int index=input.IndexOf(oldItem);
                        input.RemoveAt(index);
                        input.Insert(index, newItem);
                    }
                }
                else if(firstCommand== "Rearrange")
                {
                    string item = cmndArgs[1];
                    if (input.Contains(item))
                    {
                        int index = input.IndexOf(item);
                        input.RemoveAt(index);
                        input.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
