using System;
public class Exercise47
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string nString = n.ToString();
        int length = nString.Length;
        int currentSum = 0;
        int fact = 1;
        for (int i = 0; i < length; i++)
        {
            int currentNum = int.Parse(nString[i].ToString());
            for (int j = 1; j <= currentNum; j++)
            {
                fact = fact * j;
            }
            currentSum += fact;
            fact = 1;
        }
        if (currentSum == n)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
