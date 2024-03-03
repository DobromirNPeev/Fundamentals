using System;
using System.Linq;

namespace Test
{
    class Program
    {

        public static void Main()
        {
            //long n = long.Parse(Console.ReadLine());
            //long openCount = 0;
            //long closeCount = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    string input = Console.ReadLine();
            //    if (input == "(")
            //    {
            //        openCount++;

            //    }
            //    else if (input == ")")
            //    {
            //        closeCount++;
            //        if (openCount - closeCount != 0)
            //        {
            //            Console.WriteLine("UNBALANCED");
            //            return;
            //        }
            //    }
            //}
            //if (openCount == closeCount)
            //{
            //    Console.WriteLine("BALANCED");
            //}
            //else
            //{
            //    Console.WriteLine("UNBALANCED");
            //}
            int n = int.Parse(Console.ReadLine());
            bool closed = false;
            bool allBalanced = true;
            bool current = false;
            int inARow = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    if (current)
                    {
                        closed = true;
                        current = false;
                    }
                    else
                    {
                        current = true;
                        inARow++;
                    }
                }
                else if(input==")")
                {
                    if (current && closed)
                    {
                        closed = false;
                        current = false;
                    }
                    else if (!current)
                    {
                        closed = true;
                    }
                }
                else
                {
                    inARow = 0;
                }
            }
            if (current)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}