using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commmand = command.Split(":",StringSplitOptions.RemoveEmptyEntries);
                string comm = commmand[0];
                if(comm=="Add Stop")
                {
                    int index =int.Parse(commmand[1]);
                    string add =commmand[2];
                    if(index<0 || index >= stops.Length)
                    {
                        Console.WriteLine(stops);
                        continue;
                    }
                    stops = stops.Insert(index, add);
                    Console.WriteLine(stops);
                }
                else if(comm=="Remove Stop")
                {
                    int startIndex = int.Parse(commmand[1]);
                    int endIndex = int.Parse(commmand[2]);
                    if ((startIndex < 0 || startIndex >= stops.Length) || (endIndex < 0 || endIndex >= stops.Length))
                    {
                        Console.WriteLine(stops);
                        continue;
                    }
                    stops = stops.Remove(startIndex,endIndex-startIndex+1);
                    Console.WriteLine(stops);
                }
                else
                {
                    string old = commmand[1];
                    string newstr = commmand[2];
                    if (!stops.Contains(old))
                    {
                        Console.WriteLine(stops);
                        continue;
                    }
                    stops = stops.Replace(old, newstr);
                    Console.WriteLine(stops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
