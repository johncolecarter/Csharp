using System;
using Microsoft.EntityFrameworkCore;
using System.IO;


namespace ToDoApp
{
    public class ItemContext : DbContext
    {

        public DbSet<ToDoItem> ToDoItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoItems.db");

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}
