using System;
using System.Collections.Generic;

namespace toDoCheckPoint
{
    public class App
    {
        ConsoleUtils cu = new ConsoleUtils();
        ItemRepository ir = new ItemRepository();

        public void Start()
        {
            string input = cu.RunApp();
            do
            {
                if (input.ToLower() == "add")
                {
                    ToDoItem addItem = cu.AddItem();
                    
                    ir.AddItem(addItem);
                    
                    Console.WriteLine("Item added!");

                } else if (input.ToLower() == "edit")
                {
                    var list = ir.ListAll();

                    var answer = cu.GetItemName(list);

                    ir.DeleteItem(answer);

                    ToDoItem addItem = cu.AddItem();

                    ir.AddItem(addItem);

                    Console.WriteLine("Item udated!");

                }
                else if (input.ToLower() == "delete")
                {
                    var list = ir.ListAll();

                    var answer = cu.GetItemName(list);

                    ir.DeleteItem(answer);

                    Console.WriteLine("Item deleted.");

                } else if (input.ToLower() == "list")
                {
                    var list = ir.ListAll();
                    cu.ListAll(list);

                } else if (input.ToLower() == "done")
                {
                    var list = ir.ListDone();
                    cu.ListDone(list);

                }
                else if (input.ToLower() == "pending")
                {
                    var list = ir.ListPending();
                    cu.ListPending(list);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                Console.ReadKey();
                Console.Clear();
                input = cu.RunApp();

            } while (input.ToLower() != "exit");
        }
    }
}