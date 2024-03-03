using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            int changes=0;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split();
                command = commands[0];
                if (command == "Contains")
                {
                    int number = int.Parse(commands[1]);
                    Console.WriteLine(ContainsNumber(numbers,number));
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ",PrintEven(numbers)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", PrintOdd(numbers)));
                }
                else if(command=="Filter")
                {
                    string condition =commands[1];
                    int number = int.Parse(commands[2]);
                    Console.WriteLine(string.Join(" ", Filter(numbers, condition, number)));
                }
                else if(command=="GetSum")
                {
                    Console.WriteLine(GetSum(numbers));
                }
                else if (command == "Add")
                {
                    int number = int.Parse(commands[1]);
                    add(numbers, number);
                    changes++;
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(commands[1]);
                    remove(numbers, number);
                    changes++;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);
                    removeAt(numbers, index);
                    changes++;
                }
                else
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    insert(numbers, number, index);
                    changes++;
                }
            }
            if (changes > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static void add(List<int> numbers, int number)
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
        static void insert(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
        }
        static string ContainsNumber(List<int> numbers,int number)
        {
            if (numbers.Contains(number))
            {
                return "Yes";
            }
            else
            {
                return "No such number";
            }
        }
        static List<int> PrintEven(List<int> numbers)
        {
            List<int> newList= new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    newList.Add(numbers[i]);
                }
            }
            return newList;
        }
        static List<int> PrintOdd(List<int> numbers)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    newList.Add(numbers[i]);
                }
            }
            return newList;
        }
        static List<int> Filter(List<int> numbers,string condition,int number)
        {
            List<int> newList = new List<int>();
            if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > number)
                    {
                        newList.Add(numbers[i]);
                    }
                }
            }
            else if(condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < number)
                    {
                        newList.Add(numbers[i]);
                    }
                }
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= number)
                    {
                        newList.Add(numbers[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= number)
                    {
                        newList.Add(numbers[i]);
                    }
                }
            }
            return newList;
        }
        static int GetSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
