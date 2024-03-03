using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input=Console.ReadLine()) != "END")
            {
                int number = int.Parse(input);
                Console.WriteLine(Palindrom(number));
            }
        }
        static bool Palindrom(int number)
        {
            string numberString = number.ToString();
            string leftPart = string.Empty;
            string rightPart = string.Empty;
            for (int i = 0; i < numberString.Length/2; i++)
            {
                leftPart += numberString[i].ToString();
            }
            if (numberString.Length%2==0)
            {
                for (int i = numberString.Length / 2 ; i < numberString.Length; i++)
                {
                    rightPart += numberString[i].ToString();
                }
            }
            else
            {
                for (int i = numberString.Length / 2 + 1; i < numberString.Length; i++)
                {
                    rightPart += numberString[i].ToString();
                }
            }
            if (leftPart == Reverse(rightPart))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string Reverse(string text)
        {
            string reversed = string.Empty;
            for (int i = text.Length-1; i >= 0; i--)
            {
                reversed += text[i].ToString();
            }
            return reversed;
        }
    }
}
