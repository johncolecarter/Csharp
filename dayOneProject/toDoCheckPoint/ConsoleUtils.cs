using System;

namespace toDoCheckPoint
{
    public class ConsoleUtils
    {
        public static void RunApp()
        {
            string menu = "Please enter on eof the following." +
                "\n 'Add' to add an item." +
                "\n 'Edit' to edit an item." +
                "\n 'Delete' to delete an item." +
                "\n 'List' to list all items." +
                "\n 'Done' to list all done items." +
                "\n 'Pending' to list all pending items." +
                "\n 'Exit' to exit the program.";
            Console.WriteLine(menu);
            string input = Console.ReadLine();

            do
            {
                if (input == "Add" || input == "add")
                {
                    AddItem();

                } /*else if (inupt == "Edit" || input == "edit")
                {
                    EditItem();

                } else if (input == "Delete" || input == "delete")
                {
                    DeleteItem();

                } else if (input == "List" || input == "list")
                {
                    ListAll();

                } else if (input == "Done" || input == "done")
                {
                    DoneItems();

                } else if (input == "Pending" || input == "pending")
                {
                    PendingItems();

                }*/
                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey();
                    Console.Clear();
                    RunApp();
                }
            } while (input != "Exit" || input != "exit");
        }

        public static void AddItem()
        {
            ItemContext itemAdd = new ItemContext();

            itemAdd.Database.EnsureCreated();

            int Id = 0;

            string end = string.Empty;

            do
            {
                Id++;

                Console.WriteLine("Enter the items description.");
                string Item = Console.ReadLine();

                Console.WriteLine("Enter the status of the item. 'Done' or 'Pending'.");
                string Status = Console.ReadLine();

                if (Status == " ")
                {
                    _ = Status == "pending";
                }

                ToDoItem newItem = new ToDoItem(Id, Item, Status);

                itemAdd.Add(newItem);


                Console.WriteLine("Enter 'Done' to exit to the menu or press enter to add another item.");
                end = Console.ReadLine();

                itemAdd.SaveChanges();

            } while (end != "done" || end != "Done");
        }
    }
}
