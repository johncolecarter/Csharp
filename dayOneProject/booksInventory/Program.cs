using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace booksInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            BookContext addBook = new BookContext();

            addBook.Database.EnsureCreated();


            int count = 0;

            string end = string.Empty;

            do
            {


                count++;

                Console.WriteLine("Enter the title of the book.");
                string Title = Console.ReadLine();

                if (Title == " ")
                {
                    Console.WriteLine("Please enter a title.");
                }

                Console.WriteLine("Enter the name of the author");
                string Author = Console.ReadLine();

                if (Author == " ")
                {
                    Console.WriteLine("Please enter the name of the author.");
                }

                Book newBook = new Book(count, Title, Author);

                addBook.Add(newBook);

                addBook.SaveChanges();

                Console.WriteLine("Enter q to stop or enter to continue.");
                end = Console.ReadLine();

            } while (end != "q");

            Console.WriteLine("Here is a list of the books and the Author!");

            foreach (var b in addBook.books)
            {
                Console.WriteLine("{0} | {1}", b.Title, b.Author);
            }
        }
    }
}
