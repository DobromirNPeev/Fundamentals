using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = string.Empty;
            while ((command = Console.ReadLine())!="end")
            {
                string[] cmndArg=command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string typeOfInput = cmndArg[0];
                if (typeOfInput == "swap")
                {
                    int index1 = int.Parse(cmndArg[1]);
                    int index2 = int.Parse(cmndArg[2]);
                    Swap(input, index1, index2);
                }
                else if (typeOfInput == "multiply")
                {
                    int index1 = int.Parse(cmndArg[1]);
                    int index2 = int.Parse(cmndArg[2]);
                    Multiply(input, index1, index2);
                }
                else if (typeOfInput == "decrease")
                {
                    Decrease(input);
                }
            }
            Console.WriteLine(string.Join(", ",input));
        }
        static void Swap(int[] input,int index1,int index2)
        {
            int temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;
        }
        static void Multiply(int[] input, int index1, int index2)
        {
            int multiplication = input[index1] * input[index2];
            input[index1] = multiplication;
        }
        static void Decrease(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i]--;
            }
        }
    }
}
