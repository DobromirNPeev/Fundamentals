using System;

namespace _05._Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            int lastIndex = 0;
            for (int i = 0; i < noun.Length; i++)
            {
                lastIndex = i;
            }
            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(lastIndex);
                noun += "ies";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }
            Console.WriteLine(noun) ;
        }
    }
}
