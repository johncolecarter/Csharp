﻿using System;
using System.Globalization;
using System.Collections.Generic;
namespace ToDoApp
{
    public class App
    {
        ItemRepository repo;
        public App()
        {
            repo = new ItemRepository();
        }
        private void DisplayALL()
        {
            List<ToDoItem> list = repo.GetAllItems();
            ConsoleUtils.PrintAllItems(list);
        }
        public void ProcessInput()
        {
            //Display menu
            //DisplayALL();
            string action = ConsoleUtils.DisplayMenu();
            while (action != "Exit")
            {
                switch (action)
                {
                    case "List":
                        DisplayALL();
                        break;
                    case "Add":
                        string[] newItem = ConsoleUtils.ItemUserInput();
                        repo.AddItem(newItem[0], newItem[1]);
                        DisplayALL();
                        break;
                    case "Delete":
                        
                        int itemID = ConsoleUtils.GetItemID();
                      
                        repo.DeleteItem(itemID);
                        DisplayALL();
                        break;
                    case "Edit":
                        itemID = ConsoleUtils.GetItemID();
                        string[] updatedItem = ConsoleUtils.ItemUserInput();
                        repo.UpdateItem(itemID, updatedItem[0], updatedItem[1]);
                        DisplayALL();
                        break;
                    case "Pending":
                        repo.GetPendingItems();
                        Console.WriteLine();
                        DisplayALL();
                        break;
                    case "Done":
                        repo.GetDoneItems();
                        Console.WriteLine();
                        DisplayALL();
                        break;
                    case "Exit":
                        DisplayALL();
                        Console.WriteLine("You have now quit the program");
                        break;
                    default:
                        Console.WriteLine("You have entered an invalid option. Please try again.");
                        break;
                }
                action = ConsoleUtils.DisplayMenu();
            }
        }
    }
}