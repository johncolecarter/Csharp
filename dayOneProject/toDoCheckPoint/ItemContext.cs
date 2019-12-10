using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace toDoCheckPoint
{
    public class ItemContext : DbContext
    {
        public DbSet<ToDoItem> list { get; set; }

        public ItemContext()
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoList.db");

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }

        public void AddItem(ToDoItem item)
        {
            Database.ExecuteSqlRaw("INSERT INTO list (Item, Status) VALUES ({0}, {1})", item.Item, item.Status);
        }
    }
}
