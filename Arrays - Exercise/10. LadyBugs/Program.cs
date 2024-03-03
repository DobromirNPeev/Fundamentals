using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            //uint fieldSize = uint.Parse(Console.ReadLine());
            //int[] arrFinal = new int[fieldSize];
            //int[] bugsIndex = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //for (int i = 0; i < fieldSize; i++)
            //{
            //    if (bugsIndex.Contains(i))
            //    {
            //        arrFinal[i]=1;
            //    }
            //}
            //string command;
            //while ((command=Console.ReadLine()) != "end")
            //{
            //    string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    int ladybugIndex = int.Parse(commandArgs[0]);
            //    string direction = commandArgs[1];
            //    int flyLength = int.Parse(commandArgs[2]);
            //    if(ladybugIndex >= fieldSize || ladybugIndex < 0)
            //     {
            //        continue;
            //    }
            //    else if (arrFinal[ladybugIndex] == 0)
            //    {
            //        continue;

            //    }
            //    arrFinal[ladybugIndex] = 0;
            //    int nextIndex = ladybugIndex;
            //    while (true)
            //    {
            //        if (direction == "right")
            //        {
            //            nextIndex += flyLength;
            //        }
            //        else if(direction=="left")
            //        {
            //            nextIndex -= flyLength;
            //        }
            //        if(nextIndex<0 || nextIndex >= arrFinal.Length)
            //        {
            //            break;
            //        }
            //        if (arrFinal[nextIndex] == 0)
            //        {
            //            break;
            //        }
            //    }
            //    if(nextIndex>=0 && nextIndex < arrFinal.Length)
            //    {
            //        arrFinal[nextIndex] = 1;
            //    }
            //}
            //Console.WriteLine(string.Join(" ", arrFinal));
            int n = int.Parse(Console.ReadLine());
            int[] ladybugs = new int[n];
            int[] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < indexes.Length; i++)
            {
                ladybugs[indexes[i]]++;
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputAsArray = input.Split(" ");
                int index = int.Parse(inputAsArray[0]);
                string direction = inputAsArray[1];
                int length = int.Parse(inputAsArray[2]);
                if (direction == "right")
                {
                    for (int i = index; i <= ladybugs.Length; i+=length)
                    {
                        if (i == ladybugs.Length)
                        {
                            ladybugs[index] = 0;
                            continue;
                        };
                        if (ladybugs[i] == 0)
                        {
                            ladybugs[i] = 1;
                            ladybugs[index] = 0;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = index ; i >= 0; i -= length)
                    {
                        if (index - length == 0)
                        {
                            ladybugs[index] = 0;
                            continue;
                        };
                        if (ladybugs[i] == 0)
                        {
                            ladybugs[i] = 1;
                            ladybugs[index] = 0;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",ladybugs));
        }
    }
}