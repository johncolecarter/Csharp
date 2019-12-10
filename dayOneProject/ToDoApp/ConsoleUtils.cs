using System;
using System.Collections.Generic;
using System.Globalization;
namespace ToDoApp
{
    public class ConsoleUtils
    {
        
        public static string DisplayMenu()
        {
            string menu = "Please choose a selection to continue through the app. " +
                "\n 'List' List All Items " +
                "\n 'Add' Add a new item " +
                "\n 'Delete' Remove an item " +
                "\n 'Edit' Edit an item " +
                "\n 'Pending' List the pending items " +
                "\n 'Done' List the done items" +
                "\n 'Exit' To exit the application";
            Console.WriteLine(menu);
            string action = Console.ReadLine();
            action = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(action);
            return action;
        }

        public static int GetItemID()
        {
            Console.WriteLine("Which item do you want to update/delete?");
            string userInput = Console.ReadLine();
            int itemID = int.Parse(userInput);
            return itemID;
        }
        public static void PrintAllItems(List<ToDoItem> list)
        {
            Console.Clear();
            foreach (ToDoItem item in list)
            {
                Console.WriteLine($"{item.Id} | {item.Description} | {item.Status} ");
            }

        }
        public static string[] ItemUserInput()
        {
            string[] newItem = new string[3];
            Console.WriteLine("What is the description of the item?");
            newItem[0] = Console.ReadLine();
            Console.WriteLine("What is the status of the item?");
            newItem[1] = Console.ReadLine();

            return newItem;
        }


    }
}