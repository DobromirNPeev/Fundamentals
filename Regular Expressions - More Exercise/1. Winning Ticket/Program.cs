using System;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string winning = @"[\@]{6,10}|[\#]{6,10}|[\$]{6,10}|[\^]{6,10}";
            string jackpot = @"[\@]{10}|[\#]{10}|[\$]{10}|[\^]{10}";
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length < 20 || input[i].Length>20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else if (input[i].Length == 20)
                {
                    string firstHalf = input[i].Substring(0, 10);
                    string secondHalf = input[i].Substring(10, 10);
                    if (Regex.IsMatch(firstHalf, winning) && Regex.IsMatch(secondHalf, winning))
                    {
                        if (Regex.IsMatch(firstHalf, jackpot) && Regex.IsMatch(secondHalf, jackpot))
                        {
                            Match winnerJackpot = Regex.Match(input[i], jackpot);
                            Console.WriteLine($"ticket \"{ input[i]}\" - {winnerJackpot.Length}{winnerJackpot.ToString().Substring(0, 1)} Jackpot!");
                        }
                        else
                        {
                            Match winnerleft = Regex.Match(firstHalf, winning);
                            Match winnerRight = Regex.Match(secondHalf, winning);
                            if (winnerleft.Length == winnerRight.Length)
                            {
                                Console.WriteLine($"ticket \"{input[i]}\" - {winnerleft.Length}{winnerleft.ToString().Substring(0, 1)}");
                            }
                            else if(winnerleft.Length < winnerRight.Length)
                            {
                                Console.WriteLine($"ticket \"{input[i]}\" - {winnerleft.Length}{winnerleft.ToString().Substring(0, 1)}");
                            }
                            else if(winnerleft.Length > winnerRight.Length)
                            {
                                Console.WriteLine($"ticket \"{input[i]}\" - {winnerRight.Length}{winnerRight.ToString().Substring(0, 1)}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                    }
                }              
            }
        }
    }
}
