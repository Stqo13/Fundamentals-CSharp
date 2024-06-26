﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog catalog = new Catalog();
            while (input!="end")
            {
                string[] vehicleInfo = input.Split('/');
                string vehicleType = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]);
                if (vehicleType=="Truck")
                {
                    Truck truck = new Truck(brand, model, value);
                    catalog.Truck.Add(truck);
                }
                else
                {
                    Car car = new Car(brand, model, value);
                    catalog.Car.Add(car);
                }
                input = Console.ReadLine();
            }
            if (catalog.Car.Count>0)
            {
                Console.WriteLine("Cars:");
            }
            foreach (var car in catalog.Car.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            if (catalog.Truck.Count>0)
            {
                Console.WriteLine("Trucks:");
            }
            foreach (var truck in catalog.Truck.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
        public class Catalog
        {
            public Catalog()
            {
                Car = new List<Car>();
                Truck = new List<Truck>();
            }
            public List<Car> Car { get; set; }
            public List<Truck> Truck { get; set; }
        }
        public class Car
        {
            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        public class Truck
        {
            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
    }
}
