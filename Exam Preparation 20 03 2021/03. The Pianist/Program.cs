using System;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    class PieceProps
    {
        public string Composer { get; set; }
        public string Key { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, PieceProps> pieces = new Dictionary<string, PieceProps>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                PieceProps currPiece = new PieceProps
                {
                    Composer = composer,
                    Key = key
                };
                pieces.Add(piece, currPiece);
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commands = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string mainCommand = commands[0];
                if (mainCommand == "Add")
                {
                    string piece = commands[1];
                    string composer = commands[2];
                    string key = commands[3];
                    if (!pieces.ContainsKey(piece))
                    {
                        PieceProps currPiece = new PieceProps
                        {
                            Composer = composer,
                            Key = key
                        };
                        pieces.Add(piece, currPiece);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (mainCommand == "Remove")
                {
                    string piece = commands[1];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if(mainCommand == "ChangeKey")
                {
                    string piece = commands[1];
                    string newKey = commands[2];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            foreach (var item in pieces)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
            }
        }
    }
}
