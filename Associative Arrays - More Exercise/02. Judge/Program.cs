using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Participant>> contests = new Dictionary<string, List<Participant>>();
            Dictionary<string,int> users = new Dictionary<string, int>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] inputAsArray = input.Split(" -> ").ToArray();
                string username = inputAsArray[0];
                string contest = inputAsArray[1];
                int points = int.Parse(inputAsArray[2]);
                Participant currParticipant = new Participant(username, points);
                if (!contests.Keys.Contains(contest))
                {
                    List<Participant> adding = new List<Participant>
                    {
                        currParticipant
                    };
                    contests.Add(contest, adding);
                    bool userAlready = false;
                    foreach (var itemInside in users)
                    {
                        if (itemInside.Key == username)
                        {
                            userAlready = true;
                        }
                    }
                    if (!userAlready)
                    {
                        users.Add(username,points);
                    }
                    else
                    {
                        users[username] += points;
                    }
                }
                else
                {
                    bool exist = false;
                    foreach (var item in contests)
                    {
                        if (item.Key == contest)
                        {
                            foreach (var itemNested in item.Value)
                            {
                                if (itemNested.Username == username)
                                {
                                    exist = true;
                                    if (itemNested.Points < points)
                                    {
                                        itemNested.Points = points;
                                        users[username] = points;
                                    }
                                }
                            }
                        }
                    }
                    if (!exist)
                    {
                        contests[contest].Add(currParticipant);
                        bool userAlready = false;
                        foreach (var itemInside in users)
                        {
                            if (itemInside.Key == username)
                            {
                                userAlready = true;
                            }
                        }
                        if (!userAlready)
                        {
                            users.Add(username, points);
                        }
                        else
                        {
                            users[username] += points;
                        }
                    }
                }
            }
            foreach (var item in contests)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                List<Participant> ordered = item.Value.OrderByDescending(x => x.Points).ThenBy(x => x.Username).ToList();
                int i = 1;
                foreach (var itemNested in ordered)
                {
                    Console.WriteLine($"{i}. {itemNested.Username} <::> {itemNested.Points}");
                    i++;
                }
            }
            Console.WriteLine("Individual standings:");
            int counter = 1;
            foreach (var item in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counter}. {item.Key} -> {item.Value}");
                counter++;
            }
        }
        class Participant
        {
            public Participant(string username, int points)
            {
                this.Username = username;
                this.Points = points;
            }
            public string Username { get; set; }
            public int Points { get; set; }
        }
    }
}

