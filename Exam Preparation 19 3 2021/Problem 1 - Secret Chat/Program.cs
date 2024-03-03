using System;

namespace Problem_1___Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] inputAsArray = input.Split(":|:");
                string command = inputAsArray[0];
                if (command == "InsertSpace")
                {
                    int index = int.Parse(inputAsArray[1]);
                    message=message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substring = inputAsArray[1];
                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring[0]);
                        message = message.Remove(index,substring.Length);
                        char[] substrings = substring.ToCharArray();
                        Array.Reverse(substrings);
                        message += string.Join("",substrings);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    string substring = inputAsArray[1];
                    string replacement = inputAsArray[2];
                    message=message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
