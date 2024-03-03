using System;

namespace Problem_1___Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string commandInput = string.Empty;
            while ((commandInput = Console.ReadLine()) != "Done")
            {
                string[] commandAsArray = commandInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandAsArray[0];
                if (command == "TakeOdd")
                {
                    string odds = string.Empty;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            odds += password[i];
                        }
                    }
                    password = odds;
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(commandAsArray[1]);
                    int length = int.Parse(commandAsArray[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else
                {
                    string substring = commandAsArray[1];
                    string substitute = commandAsArray[2];
                    if (!password.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }
                    password=password.Replace(substring, substitute);
                    Console.WriteLine(password);
                } 
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
