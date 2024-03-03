using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int leftStrength = 0;
            bool noMore = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int strength =int.Parse(input[i + 1].ToString());
                    if (leftStrength != 0)
                    {
                        strength += leftStrength;
                    }
                    while (input[i+1] != '>' && strength!=0)
                    {
                        input = input.Remove(i + 1,1);
                        strength--;
                        if (i + 1 >= input.Length)
                        {
                            break;
                        }
                    }
                    leftStrength = strength;
                }
            }
            Console.WriteLine(input);
        }
    }
}
