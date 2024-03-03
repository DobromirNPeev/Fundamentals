using System;
using System.Text.RegularExpressions;

namespace Problem_2___Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(\@[\#]{1,})[A-Z][A-Za-z0-9]{4,}[A-Z](\@[\#]{1,})";
            string digitExtract = @"\d+";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input,regex))
                {
                    if (Regex.IsMatch(input, digitExtract))
                    {
                        MatchCollection digits = Regex.Matches(input, digitExtract);
                        string code = string.Empty;
                        foreach (var item in digits)
                        {
                            code += item.ToString();
                        }
                        Console.WriteLine($"Product group: {code}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
