using System;

namespace _06._Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object concat = hello + " " + world;
            string united = (string)concat;
            Console.WriteLine(united);
        }
    }
}
