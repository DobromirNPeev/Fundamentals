using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordReturn(Console.ReadLine());
        }
        static void PasswordReturn(string password)
        {
            bool isValid = true;
            int count = 0;
            if (password.Length<6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            for (int i =0; i <password.Length; i++)
            {
                char range = (char)password[i];
                if (char.IsLetter(range))
                {
                    continue;
                }
                else if (char.IsDigit(range))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                char range = (char)password[i];
                if (char.IsDigit(range))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
