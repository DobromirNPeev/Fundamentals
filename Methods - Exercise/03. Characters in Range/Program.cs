using System;
using System.Text;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            string finalRange = Range(a, b);
            Console.WriteLine(string.Join(" ",finalRange));
        }
        static string Range(char start,char end)
        {
            char range = '0';
            if (start <= end)
            {
               string result= string.Empty;
                for (int i = start+1; i < end; i++)
                {
                    range = (char)i;
                    result += range+" ";
                }
                return result;
            }
            else
            {
                string result = string.Empty;
                for (int i = end+1; i < start; i++)
                {
                    range = (char)i;
                    result += range+" ";
                }
                return result;
            }
        }
    }
}
