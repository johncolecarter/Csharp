using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace toDoCheckPoint
{
    public class ItemContext : DbContext
    {
        public DbSet<ToDoItem> ToDoList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoList.db");

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }

        public ItemContext()
        {
        }
    }
}
