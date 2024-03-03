using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friend_List_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = string.Empty;
            int blacklistedCount = 0;
            int lostCount = 0;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] commandAsArray = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string theCommand = commandAsArray[0];
                if (theCommand == "Blacklist")
                {
                    string name = commandAsArray[1];
                    int index = -1;
                    for (int i = 0; i < friends.Length; i++)
                    {
                        if (friends[i] == name)
                        {
                            index = i;
                        }
                    }
                    Blacklist(friends, name);
                    if(index==-1)
                    {
                        continue;
                    }
                    else if (friends[index] == "Blacklisted")
                    {
                        blacklistedCount++;
                    }
                }
                else if(theCommand == "Error")
                {
                    int index =int.Parse(commandAsArray[1]);
                    if (index >= 0 && index < friends.Length)
                    {
                        if (friends[index] != "Lost")
                        {
                            Error(friends, index);
                            if (friends[index] == "Lost")
                            {
                                lostCount++;
                            }
                        }
                    }
                }
                else if (theCommand == "Change")
                {
                    int index = int.Parse(commandAsArray[1]);
                    string newName = commandAsArray[2];
                    Change(friends, index, newName);
                }
            }
            Console.WriteLine($"Blacklisted names: {blacklistedCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ",friends));
        }
        static void Blacklist(string[] friends,string name)
        {
            if (friends.Contains(name))
            {
                Console.WriteLine($"{name} was blacklisted.");
                int index = 0;
                for (int i = 0; i < friends.Length; i++)
                {
                    if (friends[i] == name)
                    {
                        index = i;
                    }
                }
                friends[index] = "Blacklisted";
            }
            else
            {
                Console.WriteLine($"{name} was not found.");
            }
        }
        static void Error(string[] friends,int index)
        {
            if (index >= 0 && index < friends.Length)
            {
                if (friends[index] != "Blacklisted" && friends[index] != "Lost")
                {
                    string name = friends[index];
                    Console.WriteLine($"{name} was lost due to an error.");
                    friends[index] = "Lost";
                }
            }
            else
            {
                return;
            }
        }
        static void Change(string[] friends,int index,string newName)
        {
            if (index >= 0 && index < friends.Length)
            {
                string currName = friends[index];
                Console.WriteLine($"{currName} changed his username to {newName}.");
                friends[index] = newName;
            }
            else
            {
                return;
            }
        }
    }
}
