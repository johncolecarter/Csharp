using System;
using System.Collections;
using System.Collections.Generic;

namespace towersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            game();
        }
        public static void game()
        {
            Console.WriteLine("Welcome to Towers Of Hanoi! Your board should look like this at the end.");
            Console.WriteLine("A: ");
            Console.WriteLine("B: ");
            Console.WriteLine("C: 1234");
            Console.WriteLine("\n");
            Dictionary<String, Stack<int>> Board = new Dictionary<string, Stack<int>>();
            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 4;

            Stack<int> A = new Stack<int>();
            Stack<int> B = new Stack<int>();
            Stack<int> C = new Stack<int>();
            A.Push(int4);
            A.Push(int3);
            A.Push(int2);
            A.Push(int1);
     
            Board.Add("A: ", A);
            Board.Add("B: ", B);
            Board.Add("C: ", C);

            foreach (var item in Board)
            {
                Console.Write(item.Key);
                var array = item.Value.ToArray();
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                }
                Console.WriteLine();
            }
            int playerScore = 0;
            int number = 0;
            while (playerScore == 0)
            {
                Console.WriteLine("Choose the stack you want to move from");
                string userInput = Console.ReadLine();
                Console.WriteLine("Choose which one you want to move to.");
                string userInput2 = Console.ReadLine();
                if (userInput == "a" || userInput == "A")
                {
                    number = A.Pop();
                    if (userInput2 == "b" || userInput2 == "B")
                    {
                        B.Push(number);
                    }
                    else if (userInput2 == "c" || userInput == "C")
                    {
                        C.Push(number);
                    }
                }
                if (userInput == "b" || userInput == "B")
                {
                    number = B.Pop();
                    if (userInput2 == "a" || userInput2 == "A")
                    {
                        A.Push(number);
                    }
                    else if (userInput2 == "c" || userInput == "C")
                    {
                        C.Push(number);
                    }
                }
                if (userInput == "c" || userInput == "C")
                {
                    number = C.Pop();
                    if (userInput2 == "b" || userInput2 == "B")
                    {
                        B.Push(number);
                    }
                    else if (userInput2 == "a" || userInput == "A")
                    {
                        A.Push(number);
                    }
                }
                foreach (var item in Board)
                {
                    Console.Write(item.Key);
                    var array = item.Value.ToArray();
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i]);
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
