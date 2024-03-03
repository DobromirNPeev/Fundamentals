using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string reg = @"(?<name>\@[A-Za-z]+)[^'\@\-\!\:\>]+(?<behaviour>![G|N]!)";
            string input = string.Empty;
            List<string> names = new List<string>();
            while ((input = Console.ReadLine()) != "end")
            {
                string decrypted = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    char changed = (char)(input[i] - n);
                    decrypted += changed;
                }
                Match decryption = Regex.Match(decrypted, reg);
                string behaviour = decryption.Groups["behaviour"].ToString();
                if (behaviour=="!G!")
                {
                    string name = decryption.Groups["name"].ToString().Substring(1, decryption.Groups["name"].Length - 1);
                    names.Add(name);
                }
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
