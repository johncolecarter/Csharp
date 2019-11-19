using System;
using System.Collections.Generic;

namespace IRentable
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<IRentable> rentables = new List<IRentable>();
            rentables.Add(new Boat("red", "fishing", 50.00));
            rentables.Add(new Boat("green", "sport", 75.00));
            rentables.Add(new Car("red", 4, "Chevy", 100.00));
            rentables.Add(new Car("midnight blue", 4, "CRV", 75.00));
            rentables.Add(new House(4, 3, 500.00));
            rentables.Add(new House(5, 5.5, 650.00));
            rentables.Add(new House(2, 2, 250.00));

            foreach(IRentable rent in rentables)
            {
                rent.GetDescription();
                rent.GetDailyRate();
                Console.WriteLine("\n");
            }
        }
    }
    public interface IRentable
    {
        void GetDailyRate();
        void GetDescription();
    }
    public class Boat : IRentable
    {
        string Color;
        double Rate;
        string Type;

        public Boat(string color, string type, double rate)
        {
            this.Color = color;
            this.Type = type;
            this.Rate = rate;
        }

        public void GetDailyRate()
        {
            Console.WriteLine("It is {0} an hour to rent a boat.", Rate);
        }

        public void GetDescription()
        {
            Console.WriteLine("This is a {0} {1} boat.", Color, Type);
        }
    }
    public class Car : IRentable
    {
        string Color;
        int Door;
        string Type;
        double Rate;

        public Car(string color, int door, string type, double rate)
        {
            this.Color = color;
            this.Door = door;
            this.Type = type;
            this.Rate = rate;
        }

        public void GetDailyRate()
        {
            Console.WriteLine("It is {0} a day to rent a car.", Rate);
        }

        public void GetDescription()
        {
            Console.WriteLine("This is a {0} {1} door {2} car.", Color, Door, Type);
        }
    }
    public class House : IRentable
    {
        int Bed;
        double Bath;
        double Rate;

        public House(int bed, double bath, double rate)
        {
            this.Bed = bed;
            this.Bath = bath;
            this.Rate = rate;
        }

        public void GetDailyRate()
        {
            Console.WriteLine("It is {0} a week to rent a house.", Rate);
        }

        public void GetDescription()
        {
            Console.WriteLine("This is a {0} bedroom {1} bathroom house.", Bed, Bath);
        }
    }
}
