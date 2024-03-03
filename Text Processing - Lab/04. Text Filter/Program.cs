using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                if (text.Contains(bannedWords[i]))
                {
                    text = text.Replace(bannedWords[i],new string('*',bannedWords[i].Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
