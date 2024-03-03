using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    class CarProps
    {
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, CarProps> cars = new Dictionary<string, CarProps>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] currCar = Console.ReadLine().Split("|");
                string carName = currCar[0];
                int mileage = int.Parse(currCar[1]);
                int fuel = int.Parse(currCar[2]);
                CarProps newCar = new CarProps
                {
                    Mileage = mileage,
                    Fuel = fuel
                };
                cars.Add(carName, newCar);
            }
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "Stop")
            {
                string[] commandsAsArray = commands.Split(" : ");
                string theCommand = commandsAsArray[0];
                if (theCommand == "Drive")
                {
                    string carName = commandsAsArray[1];
                    int distance = int.Parse(commandsAsArray[2]);
                    int fuel = int.Parse(commandsAsArray[3]);
                    if (cars[carName].Fuel - fuel < 0)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        continue;
                    }
                    cars[carName].Mileage += distance;
                    cars[carName].Fuel -= fuel;
                    Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    if (cars[carName].Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {carName}!");
                        cars.Remove(carName);
                    }
                }
                else if (theCommand == "Refuel")
                {
                    string carName = commandsAsArray[1];
                    int fuel = int.Parse(commandsAsArray[2]);
                    int original = cars[carName].Fuel;
                    cars[carName].Fuel += fuel;
                    if (cars[carName].Fuel > 75)
                    {
                        fuel = 75 - original;
                        cars[carName].Fuel = 75;
                    }
                    Console.WriteLine($"{carName} refueled with {fuel} liters");
                }
                else
                {
                    string carName = commandsAsArray[1];
                    int kms = int.Parse(commandsAsArray[2]);
                    cars[carName].Mileage -= kms;
                    Console.WriteLine($"{carName} mileage decreased by {kms} kilometers");
                    if (cars[carName].Mileage < 10000)
                    {
                        cars[carName].Mileage = 10000;
                    }
                }
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
}
