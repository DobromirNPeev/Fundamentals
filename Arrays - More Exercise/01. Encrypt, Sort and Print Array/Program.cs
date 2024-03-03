using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] allSum = new int[n];
            for (int i = 0; i < n; i++)
            {
                int nameSum = 0;
                string name = Console.ReadLine();
                char[] nameArray = new char[name.Length];
                for (int j = 0; j < name.Length; j++)
                {
                    nameArray[j] = name[j];
                    if (nameArray[j] == 'a' || nameArray[j] == 'e' || nameArray[j] == 'i' || nameArray[j] == 'o' || nameArray[j] == 'u')
                    {
                        nameSum += (char)nameArray[j] * name.Length;
                    }
                    else
                    {
                        nameSum += (char)nameArray[j] / name.Length;
                    }
                }
                allSum[i] = nameSum;
            }
            Array.Sort(allSum);
            for (int i = 0; i < allSum.Length; i++)
            {
                Console.WriteLine(allSum[i]);
            }
        }
    }
}
