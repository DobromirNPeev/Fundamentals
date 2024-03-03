using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> keySequence = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "find")
            {
                bool finished = false;
                string decryption = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    if (finished) break;
                    for (int j = 0; j < keySequence.Count; j++)
                    {
                        int decrease = input[i];
                        decrease -= keySequence[j];
                        decryption += (char)decrease;
                        if (j != keySequence.Count - 1)
                        {
                                i++;
                            if (i == input.Length)
                            {
                                finished = true;
                                break;
                            }
                        }
                    }
                }
                int firstIndex = decryption.IndexOf('&');
                int LastIndex = decryption.LastIndexOf('&');
                string type = string.Empty;
                for (int i = firstIndex+1; i <= LastIndex-1; i++)
                {
                    type += decryption[i];
                }
                int firstIndexCoordinates = decryption.IndexOf('<');
                int lastIndexcCoordinates = decryption.IndexOf('>');
                string coordinates = string.Empty;
                for (int i = firstIndexCoordinates+1; i <= lastIndexcCoordinates-1; i++)
                {
                    coordinates += decryption[i];
                }
                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
