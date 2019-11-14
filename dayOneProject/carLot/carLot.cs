using System;
using System.Collections.Generic;
using carLot;

namespace carLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("DXT 9884", "4 door", "Honda", "CRV", 15000);
            Car c2 = new Car("JYA 1827", "4 door", "GMC", "Tahoe", 75000);
            Car c3 = new Car("HMW 0312", "4 door", "Chevy", "Blazer", 40000);
            Truck t = new Truck("GYS 2818", "Long Bed", "Ford", "F250", 40000);
            Truck t2 = new Truck("ISQ 3927", "Short Bed", "Chevy", "Avalanche", 40000);

            List<Vehicle> carList1 = new List<Vehicle>();
            carList1.Add(c);
            carList1.Add(c2);
            carList1.Add(c3);

            Console.WriteLine("                   Car Lot: ");
            Console.WriteLine("\n");
            foreach (var item in carList1)
            {
                Console.WriteLine(item.PrintVehicle());
            }

            List<Vehicle> carList2 = new List<Vehicle>();
            carList2.Add(t);
            carList2.Add(t2);

            Console.WriteLine("                   Truck Lot: ");
            Console.WriteLine("\n");
            foreach (var truck in carList2)
            {
                Console.WriteLine(truck.PrintVehicle());
            }
        }
    }

    class CarLot
    {

    }

    public abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public Vehicle(string licencePLate, string make, string model, int price)
        {
            LicensePlate = licencePLate;
            Make = make;
            Model = model;
            Price = price;
        }
        public virtual string PrintVehicle()
        {
            return "This vehicles license plate number is " + LicensePlate + ". It's a " + Make + Model + " and it costs " + Price + ".";
        }
    }

    public class Car : Vehicle
    {
        string Doors { get; set; }

        public Car (string licensePlate, string doors, string make, string model, int price) : base(licensePlate, make, model, price)
        {
            Doors = doors;
        }

        public override string PrintVehicle()
        {
            return "This cars license plate number is " + LicensePlate + ". It's a " + Doors + " " + Make + " " + Model + " and it costs " + Price + ".";
        }
    }

    public class Truck : Vehicle
    {
        string Bed { get; set; }

        public Truck(string licensePlate, string bed, string make, string model, int price) : base(licensePlate, make, model, price)
        {
            Bed = bed;
        }

        public override string PrintVehicle()
        {
            return "This trucks license plate number is " + LicensePlate + ". It's a " + Bed + " " + Make + " " + Model + " and it costs " + Price + ".";
        }
    }
}
