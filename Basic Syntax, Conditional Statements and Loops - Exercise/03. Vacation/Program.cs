using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var day = Console.ReadLine();
            double sum = 0;
            if(type== "Students")
            {
                if (day == "Friday")
                {
                    sum = people * 8.45;
                    if (people >= 30)
                    {
                        sum = sum * 0.85;
                    }
                }
                else if (day == "Saturday")
                {
                    sum = people * 9.80;
                    if (people >= 30)
                    {
                        sum = sum * 0.85;
                    }
                }
                else if (day == "Sunday")
                {
                    sum = people * 10.46;
                    if (people >= 30)
                    {
                        sum = sum * 0.85;
                    }
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    if (people >= 100)
                    {
                        people -= 10;
                        sum = people * 10.90;
                    }
                    else
                    {
                        sum = people * 10.90;
                    }
                }
                else if (day == "Saturday")
                {
                    if (people >= 100)
                    {
                        people -= 10;
                        sum = people * 15.60;
                    }
                    else
                    {
                        sum = people * 15.60;
                    }
                }
                else if (day == "Sunday")
                {
                    if (people >= 100)
                    {
                        people -= 10;
                        sum = people * 16;
                    }
                    else
                    {
                        sum = people * 16;
                    }
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    sum = people * 15;
                    if (people >= 10 && people<=20)
                    {
                        sum = sum * 0.95;
                    }
                }
                else if (day == "Saturday")
                {
                    sum = people * 20;
                    if (people >= 10 && people <= 20)
                    {
                        sum = sum * 0.95;
                    }
                }
                else if (day == "Sunday")
                {
                    sum = people * 22.50;
                    if (people >= 10 && people <= 20)
                    {
                        sum = sum * 0.95;
                    }
                }
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
