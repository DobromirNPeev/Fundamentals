using System;

namespace _14._Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt =int.Parse(Console.ReadLine());
            string myHex = myInt.ToString("X");  // Gives you hexadecimal
            Console.WriteLine(myHex);
            int remainder;
            string result = string.Empty;
            while (myInt > 0)
            {
                remainder = myInt % 2;
                myInt /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
