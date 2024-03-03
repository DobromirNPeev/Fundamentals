using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string largeNum = Console.ReadLine();
            string finaldLarge = string.Empty;
            int multiply = int.Parse(Console.ReadLine());
            int remainder = 0;
            for (int i = largeNum.Length-1; i >=0; i--)
            {
                int currNum = int.Parse(largeNum[i].ToString());
                int multi = currNum * multiply;
                multi += remainder;
                if (multi < 10)
                {
                    finaldLarge+=multi.ToString();
                    remainder = 0;
                }
                else
                {
                    finaldLarge+=multi % 10;
                    remainder = multi/10;
                }
            }
            if (remainder != 0)
            {
                finaldLarge += remainder;
            }
            string reversed = string.Empty;
            for (int i = finaldLarge.Length-1; i >=0; i--)
            {

                reversed += finaldLarge[i].ToString();
            }
            int zeroCounter = 0;
            int count = 0;
            while (count<reversed.Length)
            {
                if(reversed[count] == '0')
                {
                    zeroCounter++;
                    count++;
                }
                else
                {
                    break;
                }
            }
            reversed = reversed.Remove(0, zeroCounter);
            if (reversed == "")
            {
                reversed += "0";
            }
            Console.WriteLine(reversed);
        }
    }
}
