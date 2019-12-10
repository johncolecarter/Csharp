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

       
    }
}
