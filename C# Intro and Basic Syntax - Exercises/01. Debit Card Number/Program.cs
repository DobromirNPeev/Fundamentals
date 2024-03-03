using System;

namespace _01._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            Console.Write($"{n1:D4} ");
            Console.Write($"{n2:D4} ");
            Console.Write($"{n3:D4} ");
            Console.Write($"{n4:D4}");
        }
    }
}
