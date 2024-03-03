using System;
using System.Linq;

namespace _11._Array_Manipulator_New_Try
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandAsArray = command.Split();
                string theCommand = commandAsArray[0];
                if (theCommand=="exchange")
                {
                    int index = int.Parse(commandAsArray[1]);
                    theArray=Exchange(theArray, index);
                }
                else if (theCommand == "max")
                {
                    string typeOfInt = commandAsArray[1];
                    if (typeOfInt== "even")
                    {
                        int max = MaxEven(theArray);
                        if (max == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(max);
                    }
                    else
                    {
                        int max = MaxOdd(theArray);
                        if (max == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(max);
                    }
                }
                else if (theCommand == "min")
                {
                    string typeOfInt = commandAsArray[1];
                    if (typeOfInt == "even")
                    {
                        int min = MinEven(theArray);
                        if (min == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(min);
                    }
                    else
                    {
                        int min = MinOdd(theArray);
                        if (min == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(min);
                    }
                }
                else if (theCommand == "first")
                {
                    int count = int.Parse(commandAsArray[1]);
                    if (count > theArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeOfInt = commandAsArray[2];
                    if (typeOfInt=="even")
                    {
                        int[] changed = FirstEven(theArray, count);
                        if (changed == theArray)
                        {
                            Console.WriteLine("[]");
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ", changed)}]");
                    }
                    else
                    {
                        int[] changed = FirstOdd(theArray, count);
                        if (changed == theArray)
                        {
                            Console.WriteLine("[]");
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ", changed)}]");
                    }
                }
                else if (theCommand == "last")
                {
                    int count = int.Parse(commandAsArray[1]);
                    if (count > theArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeOfInt = commandAsArray[2];
                    if (typeOfInt == "even")
                    {
                        int[] changed = LastEven(theArray, count);
                        if (changed == theArray)
                        {
                            Console.WriteLine("[]");
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ", changed)}]");
                    }
                    else
                    {
                        int[] changed = LastOdd(theArray, count);
                        if (changed == theArray)
                        {
                            Console.WriteLine("[]");
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ", changed)}]");
                    }
                }
            }
            Console.WriteLine($"[{(string.Join(", ", theArray))}]");
        }
        static int[] Exchange(int[] theArray,int index)
        {
            if(index<0 || index >= theArray.Length)
            {
                Console.WriteLine("Invalid index");
                return theArray;
            }
            int[] saved = new int[theArray.Length];
            int count = 0;
            for (int i = index+1; i < theArray.Length; i++)
            {
                saved[count] = theArray[i];
                count++;
            }
            for (int i = 0; i <= index; i++)
            {
                saved[count] = theArray[i];
                    count++;
            }
            return theArray = saved;
        }
        static int MaxEven(int[] theArray)
        {
            int maxValue = int.MinValue;
            int max = -1;
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] % 2 == 0 && theArray[i]>=maxValue)
                {
                    max = i;
                    maxValue = theArray[i];
                }
            }
            return max;
        }
        static int MaxOdd(int[] theArray)
        {
            int maxValue = int.MinValue;
            int max = -1;
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] % 2 == 1 && theArray[i] >= maxValue)
                {
                    max = i;
                    maxValue = theArray[i];
                }
            }
            return max;
        }
        static int MinEven(int[] theArray)
        {
            int minValue = int.MaxValue;
            int min = -1;
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] % 2 == 0 && theArray[i] <=minValue )
                {
                    min = i;
                    minValue = theArray[i];
                }
            }
            return min;
        }
        static int MinOdd(int[] theArray)
        {
            int minValue = int.MaxValue;
            int min = -1;
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] % 2 == 1 && theArray[i] <= minValue)
                {
                    min = i;
                    minValue = theArray[i];
                }
            }
            return min;
        }
        static int[] FirstEven(int[] theArray,int length)
        {
            int[] valid = new int[length];
            int count = 0;
            bool changed = false;
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] % 2 == 0)
                {
                    valid[count] = theArray[i];
                    changed = true;
                    count++;
                    if (count == valid.Length)
                    {
                        break;
                    }
                }
            }
            if (count < length)
            {
                int[] incompleteValid = new int[count];
                for (int i = 0; i < incompleteValid.Length; i++)
                {
                    incompleteValid[i] = valid[i];
                }
                return incompleteValid;
            }
            if (changed)
            {
                return valid;
            }
            else
            {
                return theArray;
            }
        }
        static int[] FirstOdd(int[] theArray, int length)
        {
            int[] valid = new int[length];
            int count = 0;
            bool changed = false;
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] % 2 == 1)
                {
                    valid[count] = theArray[i];
                    changed = true;
                    count++;
                    if (count == valid.Length)
                    {
                        break;
                    }
                }
            }
            if (count < length)
            {
                int[] incompleteValid = new int[count];
                for (int i = 0; i < incompleteValid.Length; i++)
                {
                    incompleteValid[i] = valid[i];
                }
                return incompleteValid;
            }
            if (changed)
            {
                return valid;
            }
            else
            {
                return theArray;
            }
        }
        static int[] LastEven(int[] theArray, int length)
        {
            int[] valid = new int[length];
            int count = 0;
            bool changed = false;
            for (int i = theArray.Length-1; i >=0; i--)
            {
                if (theArray[i] % 2 == 0)
                {
                    valid[count] = theArray[i];
                    changed = true;
                    count++;
                    if (count == valid.Length)
                    {
                        break;
                    }
                }
            }
            if (count < length)
            {
                int[] incompleteValid = new int[count];
                for (int i = 0; i < incompleteValid.Length; i++)
                {
                    incompleteValid[i] = valid[i];
                }
                return incompleteValid;
            }
            if (changed)
            {
                Array.Reverse(valid);
                return valid;
            }
            else
            {
                return theArray;
            }
        }
        static int[] LastOdd(int[] theArray, int length)
        {
            int[] valid = new int[length];
            int count = 0;
            bool changed = false;
            for (int i = theArray.Length-1; i >= 0; i--)
            {
                if (theArray[i] % 2 == 1)
                {
                    valid[count] = theArray[i];
                    changed = true;
                    count++;
                    if (count == valid.Length)
                    {
                        break;
                    }
                }
            }
            if (count < length)
            {
                int[] incompleteValid = new int[count];
                for (int i = 0; i < incompleteValid.Length; i++)
                {
                    incompleteValid[i] = valid[i];
                }
                return incompleteValid;
            }
            if (changed)
            {
                Array.Reverse(valid);
                return valid;
            }
            else
            {
                return theArray;
            }
        }
    }
}
