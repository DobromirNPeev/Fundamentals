using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalogue
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public Catalogue (List<Car> cars,List<Truck> trucks)
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            Catalogue allVehicles = new Catalogue(cars, trucks);
            while (true)
            {
                string[] command = Console.ReadLine().Split('/');
                if (command[0] == "end") break;
                string type = command[0];
                string brand = command[1];
                string model = command[2];
                int horsePoweOrWeight = int.Parse(command[3]);
                if (type == "Car")
                {
                    Car currCar = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePoweOrWeight
                    };
                    cars.Add(currCar);
                }
                else
                {
                    Truck currTruck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = horsePoweOrWeight
                    };

                    trucks.Add(currTruck);
                }
            }
            allVehicles.Cars.AddRange(cars);
            allVehicles.Trucks.AddRange(trucks);
            allVehicles.Cars = allVehicles.Cars.OrderBy(x =>x.Brand).ToList();           
            allVehicles.Trucks = allVehicles.Trucks.OrderBy(x => x.Brand).ToList();           
            if (cars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (var item in allVehicles.Cars)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            if (trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var item in allVehicles.Trucks)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }
    }
}
