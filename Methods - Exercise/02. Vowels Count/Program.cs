using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(VowelsCount(str));
        }
        static int VowelsCount(string str)
        {
            int count = 0;
            string newStr = str;
            for (int i = 0; i < newStr.Length; i++)
            {
                if (newStr[i] == 'a' || newStr[i]=='e' || newStr[i] == 'o' || newStr[i] == 'i' || newStr[i] == 'u')
                {
                    count++;
                }
                if (newStr[i] == 'A' || newStr[i] == 'E' || newStr[i] == 'O' || newStr[i] == 'I' || newStr[i] == 'U')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
