using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i <wagons.Length; i++)
            {
                for (int j = wagons[i]; j < 4; j++)
                {
                    if (people != 0)
                    {
                        wagons[i]++;
                        people--;
                    }
                }
            }
            if (wagons[wagons.Length - 1] == 4 && people==0)
            {
                Console.WriteLine(string.Join(" ",wagons));
            }
            else if(wagons[wagons.Length - 1] != 4 && people == 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if(wagons[wagons.Length - 1] == 4 && people != 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
