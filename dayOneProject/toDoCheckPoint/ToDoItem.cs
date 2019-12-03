using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace toDoCheckPoint
{
    public class ToDoItem
    {
        

        public int Id { get; set; }
        public string Item { get; set; }
        public string Status { get; set; }

        public ToDoItem(int Id, string Item, string Status)
        {
            this.Id = Id;
            this.Item = Item;
            this.Status = Status;
        }
    }
}
