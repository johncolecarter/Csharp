using System;
using System.Collections;
using System.Collections.Generic;

namespace towersOfHanoi
{
    class Program
    {
        private static Dictionary<String, Stack<int>> Board = new Dictionary<string, Stack<int>>();
        private static Stack<int> A = new Stack<int>();
        private static Stack<int> B = new Stack<int>();
        private static Stack<int> C = new Stack<int>();

        static void Main(string[] args)
        {
            game();
            CheckWin();
        }
        public static void game()
        {
            Console.WriteLine("Welcome to Towers Of Hanoi! Your board should look like this at the end.");
            Console.WriteLine("A: ");
            Console.WriteLine("B: ");
            Console.WriteLine("C: 1234");
            Console.WriteLine("\n");
            
            A.Push(4);
            A.Push(3);
            A.Push(2);
            A.Push(1);
     
            Board.Add("A: ", A);
            Board.Add("B: ", B);
            Board.Add("C: ", C);
            
            int number = 0;
            int number2 = 0;

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

            while (C.Count != 4)
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
                        if (B.Count == 0)
                        {
                            B.Push(number);
                        } else if(B.Count > 0)
                        {
                           number2 = B.Peek();
                             if(number > number2)
                             {
                                Console.WriteLine("Illegal move.");
                                A.Push(number);
                             } else
                            {
                                B.Push(number);
                            }
                        }
                    }
                    else if (userInput2 == "c" || userInput == "C")
                    {
                        if (C.Count == 0)
                        {
                            C.Push(number);
                        }
                        else if (C.Count > 0)
                        {
                            number2 = C.Peek();
                            if (number > number2)
                            {
                                Console.WriteLine("Illegal move.");
                                A.Push(number);
                            } else
                            {
                                C.Push(number);
                            }
                        }
                    }
                }
                if (userInput == "b" || userInput == "B")
                {
                    number = B.Pop();
                    if (userInput2 == "a" || userInput2 == "A")
                    {
                        if (A.Count == 0)
                        {
                            A.Push(number);
                        }
                        else if (A.Count > 0)
                        {
                            number2 = A.Peek();
                            if (number > number2)
                            {
                                Console.WriteLine("Illegal move.");
                                B.Push(number);
                            }
                            else
                            {
                                A.Push(number);
                            }
                        }
                    }
                    else if (userInput2 == "c" || userInput == "C")
                    {
                        if (C.Count == 0)
                        {
                            C.Push(number);
                        }
                        else if (C.Count > 0)
                        {
                            number2 = C.Peek();
                            if (number > number2)
                            {
                                Console.WriteLine("Illegal move.");
                                B.Push(number);
                            }
                            else
                            {
                                C.Push(number);
                            }
                        }
                    }
                }
                if (userInput == "c" || userInput == "C")
                {
                    number = C.Pop();
                    if (userInput2 == "b" || userInput2 == "B")
                    {
                        if (B.Count == 0)
                        {
                            B.Push(number);
                        }
                        else if (B.Count > 0)
                        {
                            number2 = B.Peek();
                            if (number > number2)
                            {
                                Console.WriteLine("Illegal move.");
                                C.Push(number);
                            }
                            else
                            {
                                B.Push(number);
                            }
                        }
                    }
                    else if (userInput2 == "a" || userInput == "A")
                    {
                        if (A.Count == 0)
                        {
                            A.Push(number);
                        }
                        else if (A.Count > 0)
                        {
                            number2 = A.Peek();
                            if (number > number2)
                            {
                                Console.WriteLine("Illegal move.");
                                C.Push(number);
                            }
                            else
                            {
                                A.Push(number);
                            }
                        }
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
        public static void CheckWin()
        {
           if(C.Count == 4)
            {
                Console.WriteLine("You Won!!!!!!!!");
            }
        }
    }
}
