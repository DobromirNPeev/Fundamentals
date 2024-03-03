using System;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Car(string model,int engineSpeed,int enginePower,int cargoWeight,string cargoType)
        {
            Model = model;
            Engine = new Engine
            {
                EngineSpeed = engineSpeed,
                EnginePower = enginePower
            };
            Cargo = new Cargo
            {
                CargoWeight = cargoWeight,
                CargoType = cargoType
            };
        }
    }
    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCars = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();
            for (int i = 0; i < numbersOfCars; i++)
            {
                string[] currCar = Console.ReadLine().Split(' ');
                string model = currCar[0];
                int engineSpeed = int.Parse(currCar[1]);
                int enginePower = int.Parse(currCar[2]);
                int cargoWeight = int.Parse(currCar[3]);
                string cargoType = currCar[4];
                Car addingTheCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);
                allCars.Add(addingTheCar);
            }
            string command = Console.ReadLine();
            if (command == "flamable")
            {
                foreach (var item in allCars)
                {
                    if (item.Cargo.CargoType == "flamable" && item.Engine.EnginePower>250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
            else
            {
                foreach (var item in allCars)
                {
                    if (item.Cargo.CargoType == "fragile" && item.Cargo.CargoWeight < 1000)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }
    }
}
