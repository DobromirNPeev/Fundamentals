using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];
            int sum = CharMultiply(first, second);
            Console.WriteLine(sum);
        }
        static int CharMultiply(string first,string second)
        {
            int length = 0;
            int sum = 0;
            if (first.Length < second.Length)
            {
                length = first.Length;
                for (int i = 0; i < length; i++)
                {
                    sum += first[i] * second[i];
                }
                for (int i = length; i < second.Length; i++)
                {
                    sum += second[i];
                }
                return sum;
            }
            else if(first.Length>second.Length)
            {
                length = second.Length;
                for (int i = 0; i < length; i++)
                {
                    sum += first[i] * second[i];
                }
                for (int i = length; i < first.Length; i++)
                {
                    sum += first[i];
                }
                return sum;
            }
            else
            {
                length = first.Length;
                for (int i = 0; i < length; i++)
                {
                    sum += first[i] * second[i];
                }
                return sum;
            }
        }
    }
}
