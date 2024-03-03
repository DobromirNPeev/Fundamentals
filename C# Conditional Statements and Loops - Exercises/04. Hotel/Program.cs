using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            if(month=="May" || month == "October")
            {
                doublePrice = 65 * nightsCount;
                suitePrice = nightsCount * 75;
                studioPrice = 50 * nightsCount;
                if (month == "May" && nightsCount>7)
                {
                    studioPrice = studioPrice * 0.95;
                }
                if(month == "October" && nightsCount > 7)
                {
                    studioPrice = 0;
                    studioPrice = 50 * (nightsCount - 1);
                    studioPrice = studioPrice * 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60 * nightsCount;
                doublePrice = 72 * nightsCount;
                suitePrice = nightsCount * 82;
                if (nightsCount > 14)
                {
                    doublePrice = doublePrice*0.9;
                }
                if (month == "September")
                {
                    studioPrice = 0;
                    studioPrice = 60 * (nightsCount-1);
                }
            }
            else if (month == "July" || month == "August" || month=="December")
            {
                studioPrice = 68 * nightsCount;
                doublePrice = 77 * nightsCount;
                suitePrice = nightsCount * 89;
                if (nightsCount > 14)
                {
                    suitePrice = suitePrice * 0.85;
                }
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
