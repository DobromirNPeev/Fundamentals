using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (command == "add")
            {
                Add(number1, number2);
            }
            else if (command == "multiply")
            {
                Multiply(number1, number2);
            }
            else if (command == "subtract")
            {
                Subtract(number1, number2);
            }
            else if (command == "divide")
            {
                Divide(number1, number2);
            }
        }
        static void Add(int number1,int number2)
        {
            Console.WriteLine(number1+number2);
        }
        static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }
        static void Subtract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }
        static void Divide(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }
    }
}
