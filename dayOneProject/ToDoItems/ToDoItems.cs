using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoItems
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoItems.List();
        }
    }
    class ToDoItems
    {
        
        private static Dictionary<String, String> dict = new Dictionary<String, String>();
        private static string descrip;
        private static string duedate;

        public static void List()
        {
            bool runList = true;

            while (runList)
            {
                Console.WriteLine("What would you like to put on your ToDo list? Enter \"q\" if you are done.");
                descrip = Console.ReadLine();

                if(descrip != "q")
                {
                    Console.WriteLine("Enter the date (ex. 11-3-19) you need to do it by and it's priority (high, medium, or low).");
                    duedate = Console.ReadLine();
                    dict.Add(descrip, duedate);
                } else if(descrip == "q")
                {
                    break;
                }
            }

            string[] array = duedate.Split(" ");
            foreach(var key in dict.Keys)
            {
                Console.WriteLine($"ToDo item: {key} | Due Date: {array[0]} | Priority: {array[1]}");
            }
        }
    }
}
