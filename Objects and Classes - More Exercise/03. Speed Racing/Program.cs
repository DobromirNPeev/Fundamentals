using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TravelDistance { get; set; }
        public void Movement(Car carModel,double amoungOfKm)
        {
            double distanceInFuel = carModel.FuelConsumptionPerKm * amoungOfKm;
            if (carModel.FuelAmount -distanceInFuel < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= distanceInFuel;
                carModel.TravelDistance += amoungOfKm;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCars = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();
            for (int i = 0; i < numbersOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ');
                string model = carInfo[0];
                double fuelAmount =double.Parse(carInfo[1]);
                double fuelConsumption =double.Parse(carInfo[2]);
                Car currCar = new Car
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKm = fuelConsumption,
                    TravelDistance=0
                };
                allCars.Add(currCar);
            }
            string command = string.Empty;
            while ((command=Console.ReadLine())!="End")
            {
                string[] commandAsArray = command.Split(' ');
                string carModel = commandAsArray[1];
                double amoutOfKm =double.Parse(commandAsArray[2]);
                foreach (var item in allCars)
                {
                    if (item.Model == carModel)
                    {
                        item.Movement(item, amoutOfKm);
                    }
                }
            }
            foreach (var item in allCars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelDistance}");
            }
        }
    }
}
