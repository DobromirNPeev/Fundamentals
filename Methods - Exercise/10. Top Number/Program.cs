using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <=number; i++)
            {
                if (DivisibleBy8(i) && OneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool DivisibleBy8(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int currentNumber = number % 10;
                number = number / 10;
                    sum += currentNumber;
            }
            if (sum%8==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool OneOddDigit(int number)
        {
            bool isValid = false;
            string numberString = number.ToString();
            for (int i = 0; i < numberString.Length; i++)
            {
                int currentNum = int.Parse(numberString[i].ToString());
                if (currentNum % 2 == 1)
                {
                    return true;
                }
            }
            return isValid;
        }
    }
}
