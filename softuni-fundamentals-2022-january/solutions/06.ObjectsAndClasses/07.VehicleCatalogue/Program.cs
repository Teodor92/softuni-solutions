using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        class Truck
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }
        }
        class Car
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int HorsePower { get; set; }
        }

        class Catalog
        {
            public Catalog()
            {
                this.Trucks = new List<Truck>();
                this.Cars = new List<Car>();
            }

            public List<Truck> Trucks { get; set; }

            public List<Car> Cars { get; set; }
        }

        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> lineParams = command
                    .Split('/')
                    .ToList();

                if (lineParams[0] == "end")
                {
                    break;
                }

                string type = lineParams[0];
                string brand = lineParams[1];
                string model = lineParams[2];
                int horsePowerWeight = int.Parse(lineParams[3]);

                if (type == "Car")
                {
                    Car car = new Car()
                    {
                        Model = model,
                        Brand = brand,
                        HorsePower = horsePowerWeight
                    };

                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck() {
                        Brand = brand,
                        Model = model,
                        Weight = horsePowerWeight
                    };

                    catalog.Trucks.Add(truck);
                }

                command = Console.ReadLine();
            }

            catalog.Cars = catalog
                    .Cars
                    .OrderBy(x => x.Brand)
                    .ToList();

            catalog.Trucks = catalog
                    .Trucks
                    .OrderBy(x => x.Brand)
                    .ToList();

            if (catalog.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");

                foreach (var car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in catalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
