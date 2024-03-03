using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int count = 0;
            string password = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i].ToString();
            }
            while (true)
            {
                string guess = Console.ReadLine();
                count++;
                if (count == 4 && guess != password)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else if (guess != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}