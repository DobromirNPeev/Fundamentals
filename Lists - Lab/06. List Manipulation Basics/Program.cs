using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split();
                command = commands[0];
                if (command == "Add")
                {
                    int number = int.Parse(commands[1]);
                    add(numbers, number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(commands[1]);
                    remove(numbers, number);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);
                    removeAt(numbers, index);
                }
                else
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    insert(numbers, number, index);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
        static void add(List<int> numbers,int number)
        {
            numbers.Add(number);
        }
        static void remove(List<int> numbers, int number)
        {
            numbers.Remove(number);
        }
        static void removeAt(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }
        static void insert(List<int> numbers, int number,int index)
        {
            numbers.Insert(index,number);
        }
    }
}
