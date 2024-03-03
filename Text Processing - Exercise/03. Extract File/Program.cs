using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split($"{(char) 92}");
            string name = string.Empty;
            string extension = string.Empty;
            foreach (var item in input)
            {
                if(item.Contains("."))
                {
                    int index = item.IndexOf(".");
                    name=item.Substring(0, index);
                    extension = item.Substring(index+1);
                }
            }
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
