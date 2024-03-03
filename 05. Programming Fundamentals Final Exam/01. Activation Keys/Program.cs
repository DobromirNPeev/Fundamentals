using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandAsArray = command.Split(">>>");
                string theCommand = commandAsArray[0];
                if (theCommand == "Contains")
                {
                    string substring = commandAsArray[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                        continue;
                    }
                    Console.WriteLine("Substring not found!");
                }
                else if (theCommand == "Flip")
                {
                    string upperOrLower = commandAsArray[1];
                    int startIndex = int.Parse(commandAsArray[2]);
                    int endIndex = int.Parse(commandAsArray[3]);
                    if (upperOrLower == "Upper")
                    {
                        string old = input.Substring(startIndex, endIndex - startIndex);
                        string change = input.Substring(startIndex, endIndex - startIndex).ToUpper();
                        input = input.Replace(old, change);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        string old = input.Substring(startIndex, endIndex - startIndex);
                        string change = input.Substring(startIndex, endIndex - startIndex).ToLower();
                        input = input.Replace(old, change);
                        Console.WriteLine(input);
                    }
                }
                else
                {
                    int startIndex = int.Parse(commandAsArray[1]);
                    int endIndex = int.Parse(commandAsArray[2]);
                    input = input.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
