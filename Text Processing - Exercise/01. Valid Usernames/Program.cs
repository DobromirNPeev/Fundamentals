using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            List<string> validUsernames = new List<string>();
            bool valid = false;
            foreach (var item in usernames)
            {
                if(item.Length>=3 && item.Length <= 16)
                {
                    foreach (var itemInside in item)
                    {
                        if (char.IsDigit(itemInside) || char.IsLetter(itemInside) || itemInside=='-' || itemInside == '_')
                        {
                            valid = true;
                        }
                        else
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        validUsernames.Add(item);
                    }
                }
            }
            foreach (var item in validUsernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
