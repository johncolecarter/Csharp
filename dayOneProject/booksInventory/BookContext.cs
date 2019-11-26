using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace booksInventory
{
    public class BookContext : DbContext
    {
        public DbSet<Book> books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(ProjectBase.FullName, "booksInventory.db");

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }

        public BookContext()
        {

        }
    }
}
