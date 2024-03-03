using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string input = string.Empty;
            int count = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                if(index<0 || index>=targets.Length || targets[index] == -1)
                { 
                    continue;
                }
                int shotted = targets[index];
                targets[index] = -1;
                count++;
                for (int i = 0; i < targets.Length; i++)
                {
                    if (i==index || targets[i]==-1)
                    {
                        continue;
                    }
                    if (targets[i] > shotted)
                    {
                        targets[i] -= shotted;
                    }
                    else
                    {
                        targets[i] += shotted;
                    }
                }
            }
            Console.Write($"Shot targets: {count} -> ");
            foreach (var item in targets)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
