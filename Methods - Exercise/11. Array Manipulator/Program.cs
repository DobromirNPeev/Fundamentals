using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        ");
        }
        static void exchange(int[] arr,int index)
        {
            if(index>=0 && index < arr.Length)
            {
                int count = 0;
                int[] newArray = new int[index+1];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i <= index)
                    {
                        newArray[count] += arr[i];
                        count++;
                    }
                }
                count = 0;
                for (int i = 0; i <= index; i++)
                {
                    for (int k = 0; k < arr.Length - 1; k++)
                    {
                        arr[k] = arr[k + 1];
                    }
                }
                for (int i = arr.Length-index-1; i < arr.Length; i++)
                {
                    arr[i] = newArray[count];
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        static void MaxEvenOdd(int[] arr, string minOrMax, string oddOrEven)
        {
                int max = int.MinValue;
                int maxArray = int.MinValue;
                if (oddOrEven == "odd")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 1 && arr[i] >= maxArray)
                        {
                            maxArray = arr[i];
                            max = i;
                        }
                    }
                    if (max == int.MinValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(max);
                    }
                }
                else if (oddOrEven == "even")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0 && arr[i] >= maxArray)
                        {
                            maxArray = arr[i];
                            max = i;
                        }
                    }
                    if (max == int.MinValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(max);
                    }
            }
        }
        static void MinEvenOdd(int[] arr, string minOrMax, string oddOrEven)
        {
                int min = int.MaxValue;
                int minArray = int.MaxValue;
                if (oddOrEven == "odd")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 1 && arr[i] <= min)
                        {
                            minArray = arr[i];
                            min = i;
                        }
                    }
                    if (min == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(min);
                    }
                }
                else if (oddOrEven == "even")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0 && arr[i] <= minArray)
                        {
                            minArray = arr[i];
                            min = i;
                        }
                    }
                    if (min == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {

                        Console.WriteLine(min);
                    }
            }
        }
        static void FirstEvenOdd(int[] arr,int count,string evenOrOdd)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int methodCount = 0;
                int[] newArray = new int[count];
                bool unedited = true;
                if (evenOrOdd == "even")
                {
                    int evenCount = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            unedited = false;
                            newArray[methodCount] = arr[i];
                            methodCount++;
                            evenCount++;
                            if (methodCount == count)
                            {
                                break;
                            }
                        }
                    }
                    if (unedited)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        int[] finalArray = new int[evenCount];
                        for (int i = 0; i < newArray.Length; i++)
                        {
                            if (newArray[i] != 0)
                            {
                                finalArray[i] = newArray[i];
                            }
                        }
                        Console.WriteLine($"[{string.Join(", ", finalArray)}]");
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    int oddCount = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 1)
                        {
                            unedited = false;
                            newArray[methodCount] = arr[i];
                            methodCount++;
                            oddCount++;
                            if (methodCount == count)
                            {
                                break;
                            }
                        }
                    }
                    if (unedited)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        int[] finalArray = new int[oddCount];
                        for (int i = 0; i <newArray.Length; i++)
                        {
                            if (newArray[i] != 0)
                            {
                                finalArray[i] = newArray[i];
                            }
                        }
                        Console.WriteLine($"[{string.Join(", ", finalArray)}]");
                    }
                }

            }           
        }
        static void LastEvenOdd(int[] arr, int count, string evenOrOdd)
        {
            int methodCount = 0;
            int[] newArray = new int[count];
            bool unedited = true;
            if (evenOrOdd == "even")
            {
                int evenCount = 0;
                for (int i = arr.Length-1; i >=0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        unedited = false;
                        newArray[methodCount] = arr[i];
                        methodCount++;
                        evenCount++;
                        if (methodCount == count)
                        {
                            break;
                        }
                    }
                }
                if (unedited)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    int[] finalArray = new int[evenCount];
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] != 0)
                        {
                            finalArray[i] = newArray[i];
                        }
                    }
                    Array.Reverse(finalArray);
                    Console.WriteLine($"[{string.Join(", ", finalArray)}]");
                }
            }
            else if (evenOrOdd == "odd")
            {
                int oddCount = 0;
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 1)
                    {
                        unedited = false;
                        newArray[methodCount] = arr[i];
                        oddCount++;
                        methodCount++;
                        if (methodCount == count)
                        {
                            break;
                        }
                    }
                }
                if (unedited)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    int[] finalArray = new int[oddCount];
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (newArray[i] != 0)
                        {
                            finalArray[i] = newArray[i];
                        }
                    }
                    Array.Reverse(finalArray);
                    Console.WriteLine($"[{string.Join(", ", finalArray)}]");
                }
            }
        }
    }
 }
