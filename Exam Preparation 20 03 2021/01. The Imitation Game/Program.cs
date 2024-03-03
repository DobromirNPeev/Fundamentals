using System;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commandInput = string.Empty;
            while ((commandInput = Console.ReadLine()) != "Decode")
            {
                string[] commandAsArray = commandInput.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = commandAsArray[0];
                if (command == "Move")
                {
                    int numberOfletters = int.Parse(commandAsArray[1]);
                    string lettersForMoving = message.Substring(0, numberOfletters);
                    message = message.Remove(0, numberOfletters);
                    message += lettersForMoving;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandAsArray[1]);
                    string value = commandAsArray[2];
                    message = message.Insert(index , value);
                }
                else
                {
                    string substring = commandAsArray[1];
                    string replacement = commandAsArray[2];
                    message = message.Replace(substring, replacement);
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
