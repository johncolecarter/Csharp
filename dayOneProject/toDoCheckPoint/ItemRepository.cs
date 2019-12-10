using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace toDoCheckPoint
{
    public class ItemRepository
    {
        ItemContext context;

        public ItemRepository()
        {
            context = new ItemContext();
           
        }

        public void AddItem(ToDoItem item)
        {
            context.AddItem(item);
        }

        public void DeleteItem(string itemName)
        {
            int itemKey = 0;
            foreach (var item in context.list)
            {
                if (item.Item == itemName)
                {
                    itemKey = item.Id;
                }
            }

            var result = context.list.Find(itemKey);
            context.Remove(result);
            context.SaveChanges();
        }

        public List<ToDoItem> ListAll()
        {
            List<ToDoItem> list = new List<ToDoItem>();

            var obj = context.list.FromSqlRaw("SELECT * FROM list");
            foreach(var l in obj)
            {
                list.Add(l);
            }
            return list;
           
        }

        public List<ToDoItem> ListPending()
        {
            List<ToDoItem> list = new List<ToDoItem>();

            var obj = context.list.FromSqlRaw("SELECT * FROM list WHERE Status = 'pending'");
            foreach(var l in obj)
            {
                list.Add(l);
            }
            return list;
        }

        public List<ToDoItem> ListDone()
        {
            List<ToDoItem> list = new List<ToDoItem>();

            var obj = context.list.FromSqlRaw("SELECT * FROM list WHERE Status = 'done'");
            foreach(var l in obj)
            {
                list.Add(l);
            }
            return list;
        }
    }
}
