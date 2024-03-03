using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Phone_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputAsArray = input.Split(" - ").ToArray();
                string command = inputAsArray[0];
                if (command == "Add")
                {
                    string phone = inputAsArray[1];
                    if (phones.Contains(phone))
                    {
                        continue;
                    }
                    else
                    {
                        phones.Add(phone);
                    }
                }
                else if (command == "Remove")
                {
                    string phone = inputAsArray[1];
                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Bonus phone")
                {
                    string[] oldphoneAndnewPhone = inputAsArray[1].Split(':');
                    string oldPhone = oldphoneAndnewPhone[0];
                    string newPhone = oldphoneAndnewPhone[1];
                    if (phones.Contains(oldPhone))
                    {
                        int indexOfOldPhone = phones.IndexOf(oldPhone);
                        phones.Insert(indexOfOldPhone+1,newPhone);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Last")
                {
                    string phone = inputAsArray[1];
                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                        phones.Add(phone);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",phones));
        }
    }
}
