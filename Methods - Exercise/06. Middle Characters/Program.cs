using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(Middle(word));
        }
        static string Middle(string word)
        {
            string middle = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Length % 2 == 1)
                {
                    if (i == word.Length / 2 )
                    {
                        middle = word[i].ToString();
                    }
                }
                if (word.Length % 2 == 0)
                {
                    if (i == word.Length / 2 || i == word.Length / 2-1)
                    {
                        middle += word[i].ToString();
                    }
                }
            }
            return middle;
        }
    }
}
