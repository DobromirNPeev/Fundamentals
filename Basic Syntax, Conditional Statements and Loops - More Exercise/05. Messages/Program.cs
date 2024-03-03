using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;
            for (int i = 1; i <=n; i++)
            {
                string num = Console.ReadLine();
                int length = num.Length;
                int maindigit = int.Parse(num[0].ToString());
                int offset= (maindigit - 2) *3;
                if(maindigit==8 || maindigit == 9)
                {
                    offset++;
                }
                int letterindex = (offset + num.Length - 1);
                char letter = Convert.ToChar(letterindex+97);
                if (maindigit == 0)
                {
                    word += " ";
                }
                else
                {
                    word += letter;
                }
            }
            Console.WriteLine(word);
        }
    }
}
