using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        class Contests
        {
            public string ConName { get; set; }
            public int Points { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string addingContest = string.Empty;
            while ((addingContest = Console.ReadLine()) != "end of contests")
            {
                string[] currContest = addingContest.Split(':').ToArray();
                string contest = currContest[0];
                string password = currContest[1];
                contests.Add(contest, password);
            }
            string input = string.Empty;
            SortedDictionary<string, List<Contests>> people = new SortedDictionary<string, List<Contests>>();
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] inputAsArray = input.Split("=>").ToArray();
                string contest = inputAsArray[0];
                string password = inputAsArray[1];
                string username = inputAsArray[2];
                int points = int.Parse(inputAsArray[3]);
                Contests currCon = new Contests
                {
                    ConName = contest,
                    Points = points
                };
                foreach (var item in contests)
                {
                    if (item.Key == contest && item.Value == password)
                    {
                        if (!people.ContainsKey(username))
                        {
                            List<Contests> addingCon = new List<Contests>
                            {
                                currCon
                            };
                            people.Add(username, addingCon);
                        }
                        else
                        {
                            bool strong = false;
                            foreach (var itemInside in people)
                            {
                                if (itemInside.Key == username)
                                {
                                    foreach (var itemNested in itemInside.Value)
                                    {
                                        if (itemNested.ConName == contest)
                                        {
                                            strong = true;
                                            if (itemNested.Points < points)
                                            {
                                                itemNested.Points = points;
                                            }
                                        }
                                    }
                                }
                            }
                            if (!strong)
                            {
                                people[username].Add(currCon);
                            }
                        }
                    }
                }
            }
            Dictionary<string, int> usersTootalPoints = new Dictionary<string, int>();
            foreach (var kvp in people)
            {
                usersTootalPoints[kvp.Key] = kvp.Value.Sum(x=>x.Points);
            }

            int maxPoints = usersTootalPoints
                .Values
                .Max();

            foreach (var kvp in usersTootalPoints)
            {
                if (kvp.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Key}");
                List<Contests> ordered = item.Value;
                ordered = item.Value.OrderByDescending(x => x.Points).ToList();
                foreach (var itemNested in ordered)
                {
                    Console.WriteLine($"#  {itemNested.ConName} -> {itemNested.Points}");
                }
            }
        }
    }
}
