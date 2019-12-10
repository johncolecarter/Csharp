using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.EntityFrameworkCore;


namespace ToDoApp
{
    public class ItemRepository
    {
        ItemContext context;
        
        public ItemRepository()
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }
        public List<ToDoItem> GetAllItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems;
            return list.ToList();
        }
        public void AddItem(string description, string status)
        {
            ToDoItem item = new ToDoItem(description, status);
            context.ToDoItems.Add(item);
            context.SaveChanges();
        }
        public void UpdateItem(int id, string newDescription, string newStatus)
        {
            ToDoItem findItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            
            findItem.Description = newDescription;
            findItem.Status = newStatus;
            
            context.Update(findItem);
            context.SaveChanges(); 
        }
        public void DeleteItem(int id)
        {
            ToDoItem findItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            
            context.Remove(findItem);
            context.SaveChanges();
        }
        public List<ToDoItem> GetPendingItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems.Where(item => item.Status == "Pending");
            //IEnumerable<ToDoItem> List = context.Database.ExecuteSqlCommand("SELECT * FROM list WHERE status = 'Pending', null");
            return list.ToList();
        }
        public List<ToDoItem> GetDoneItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems.Where(item => item.Status == "Done");
            return list.ToList();
        }
    }
}