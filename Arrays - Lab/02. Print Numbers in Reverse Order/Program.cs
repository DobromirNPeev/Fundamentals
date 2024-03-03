using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] n = new string[count];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = Console.ReadLine();
            }
            for (int i = n.Length-1; i >= 0; i--)
            {
                Console.Write($"{n[i]} ");
            }
        }
    }
}
