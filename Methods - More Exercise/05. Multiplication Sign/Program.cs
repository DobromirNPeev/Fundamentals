using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Type(num1,num2,num3));
        }
        static string Type(int num1,int num2,int num3)
        {
            int[] arr = {num1,num2,num3 };
            int minusCount = 0;
            string type = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    return type = "zero";
                }
                if (arr[i] < 0)
                {
                    minusCount++;
                }
            }
            if (minusCount == 0)
            {
                type = "positive";
                return type;
            }
            else if (minusCount == 1)
            {
                type = "negative";
                return type;
            }
            else if (minusCount == 2)
            {
                type = "positive";
                return type;
            }
            else
            {
                type = "negative";
                return type;
            }
        }

    }
}
