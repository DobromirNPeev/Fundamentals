using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dataType = string.Empty;
            while (input != "END")
            {
                if(int.TryParse(input,out int value))
                {
                    dataType = "integer";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if(float.TryParse(input, out float value1))
                {
                    dataType = "floating point";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (char.TryParse(input, out char value2))
                {
                    dataType = "character";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (bool.TryParse(input, out bool value3))
                {
                    dataType = "boolean";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else
                {
                    dataType = "string";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
