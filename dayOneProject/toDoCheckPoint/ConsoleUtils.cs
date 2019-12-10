using System;
using System.Collections.Generic;

namespace toDoCheckPoint
{
    public class ConsoleUtils
    {
        public string RunApp()
        {
            string menu = "Please enter one of the following." +
                "\n 'Add' to add an item." +
                "\n 'Edit' to edit an item." +
                "\n 'Delete' to delete an item." +
                "\n 'List' to list all items." +
                "\n 'Done' to list all done items." +
                "\n 'Pending' to list all pending items." +
                "\n 'Exit' to exit the program.";
            Console.WriteLine(menu);
            return Console.ReadLine();
        }

        public ToDoItem AddItem()
        {
         
            Console.WriteLine("Enter the items description.");
            string item = Console.ReadLine();

            Console.WriteLine("Enter the status of the item. 'Done' or 'Pending'.");
            string status = Console.ReadLine();

            return new ToDoItem() { Item = item, Status = status };
            
        }

        public void ListAll(List<ToDoItem> item)
        {
            foreach(var l in item)
            {
                Console.WriteLine(l.Id + " | " + l.Item.ToString() + " | " + l.Status);
            }
        }

        public void ListPending(List<ToDoItem> item)
        {
            foreach(var l in item)
            {
                Console.WriteLine(l.Id + " | " + l.Item.ToString() + " | " + l.Status);
            }
        }

        public void ListDone(List<ToDoItem> item)
        {
            foreach (var l in item)
            {
                Console.WriteLine(l.Id + " | " + l.Item.ToString() + " | " + l.Status);
            }
        }

        public string GetItemName(List<ToDoItem> toDoItems)
        {
            ListAll(toDoItems);
            Console.WriteLine("Enter the name of the item.");
            return Console.ReadLine();
        }
    }
}
