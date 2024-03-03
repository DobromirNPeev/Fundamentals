using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input=Console.ReadLine();
            if (type == "int")
            {
                Console.WriteLine(IntType(int.Parse(input)));
            }
            else if(type == "real")
            {
                    DoubleType(double.Parse(input));
            }
            else if (type == "string")
            {
                Console.WriteLine(StringType(input));
            }
        }
        static int IntType(int number)
        {
            return number * 2;
        }
        static void DoubleType(double number)
        {
            Console.WriteLine($"{number*1.5:f2}");
        }
        static string StringType(string input)
        {
            return $"${input}$";
        }
    }
}
