using System;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> allVehicles = new List<Vehicle>();
            List<Vehicle> allCars = new List<Vehicle>();
            List<Vehicle> allTrucks = new List<Vehicle>();
            string currVehicle = string.Empty;
            while ((currVehicle = Console.ReadLine()) != "End")
            {
                string[] currVehiclesAsArray = currVehicle.Split(' ');
                string type = currVehiclesAsArray[0];
                string model = currVehiclesAsArray[1];
                string color = currVehiclesAsArray[2];
                double horsePower =double.Parse(currVehiclesAsArray[3]);
                Vehicle addingTheVehicle = new Vehicle
                {
                    TypeOfVehicle = char.ToUpper(type[0]) + type.Substring(1),
                    Model = model,
                    Color = color,
                    HorsePower = horsePower
                };
                if (addingTheVehicle.TypeOfVehicle == "Car")
                {
                    allCars.Add(addingTheVehicle);
                }
                else if(addingTheVehicle.TypeOfVehicle == "Truck")
                {
                    allTrucks.Add(addingTheVehicle);
                }
                allVehicles.Add(addingTheVehicle);
            }
            string carInfo = string.Empty;
            while ((carInfo=Console.ReadLine())!= "Close the Catalogue")
            {
                foreach (var item in allVehicles)
                {
                    if (item.Model == carInfo)
                    {
                        Console.WriteLine($"Type: {item.TypeOfVehicle}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                        break;
                    }
                }
            }
            double sumOfHPCars = 0;
            double sumOfHPTrucks = 0;
            foreach (var item in allCars)
            {
                sumOfHPCars += item.HorsePower;
            }
            foreach (var item in allTrucks)
            {
                sumOfHPTrucks += item.HorsePower;
            }
            double averageHPCars = sumOfHPCars/allCars.Count;
            double averageHPTrucks = sumOfHPTrucks/allTrucks.Count;
            if (sumOfHPCars == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {averageHPCars:f2}.");
            }
            if (sumOfHPTrucks == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageHPTrucks:f2}.");
            }
        }
    }
}
