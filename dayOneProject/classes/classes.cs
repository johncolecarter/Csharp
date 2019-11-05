using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            dL dl = new dL();
            string value = dl.fullDL();

            Console.WriteLine(value);
            Console.ReadKey();

            Book newBook = new Book();
            string books = newBook.fullBook();

            Console.WriteLine("Title: " + books);
            Console.ReadKey();

            Airplane newPlane = new Airplane();
            string plane = newPlane.fullPLane();

            Console.WriteLine("Manufacturer: " + plane);
            Console.ReadKey();
            
        }
    }
    public class dL
    {
        string firstName = string.Empty;
        string lastName = string.Empty;
        string dLnumber = string.Empty;
        string gender = string.Empty;

        public dL()
        {
            Console.WriteLine("First Name");
            firstName = Console.ReadLine();
            Console.WriteLine("Last Name");
            lastName = Console.ReadLine();
            Console.WriteLine("DL Number");
            dLnumber = Console.ReadLine();
            Console.WriteLine("Gender");
            gender = Console.ReadLine();
        }

        public string fullDL()
        {
            return firstName + " " + lastName + " DL Number: " + dLnumber + " Gender: " + gender;
        }

    }
    public class Book
    {
        string title = string.Empty;
        string authors = string.Empty;
        string pages = string.Empty;
        string sku = string.Empty;
        string publisher = string.Empty;
        string price = string.Empty;

        public Book()
        {
            Console.WriteLine("Title of the book.");
            title = Console.ReadLine();
            Console.WriteLine("Authors of the book.");
            authors = Console.ReadLine();
            Console.WriteLine("Number of pages.");
            pages = Console.ReadLine();
            Console.WriteLine("SKU");
            sku = Console.ReadLine();
            Console.WriteLine("Publisher");
            publisher = Console.ReadLine();
            Console.WriteLine("Price");
            price = Console.ReadLine();
        }
        public string fullBook()
        {
            return title + " Authors: " + authors + " Pages: " + pages + " SKU: " + sku + " Publisher: " + publisher + " Price: " + price;
        }

    }
    public class Airplane
    {
        string manufacturer = string.Empty;
        string model = string.Empty;
        string varient = string.Empty;
        int capasity = 0;
        int numberOfEngines = 0;

        public Airplane()
        {
            manufacturer = "South West Airlines";
            model = "K2V789 Gold 69";
            varient = "green";
            capasity = 100;
            numberOfEngines = 8;
        }
        public string fullPLane()
        {
            return manufacturer + " Model: " + model + " Available in " + varient + " Capasity: " + capasity + " # of engines: " + numberOfEngines;
        }
    }
}

