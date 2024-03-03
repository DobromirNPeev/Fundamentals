using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "Craft!")
            {
                string[] props = inputCommand.Split(" - ");
                string command = props[0];
                if (command == "Collect")
                {
                    string currItem = props[1];
                    if (!items.Contains(currItem))
                    {
                        items.Add(currItem);
                    }
                }
                else if (command == "Drop")
                {
                    string currItem = props[1];
                    if (items.Contains(currItem))
                    {
                        items.Remove(currItem);
                    }
                }
                else if(command== "Combine Items")
                {
                    string[] splitingItems = props[1].Split(":");
                    string oldItem = splitingItems[0];
                    string newItem = splitingItems[1];
                    if (items.Contains(oldItem))
                    {
                        items.Insert(items.IndexOf(oldItem)+1, newItem);
                    }
                }
                else
                {
                    string currItem = props[1];
                    if (items.Contains(currItem))
                    {
                        items.Remove(currItem);
                        items.Add(currItem);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",items));
        }
    }
}
