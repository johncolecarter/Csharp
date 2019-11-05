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
            Dictionary<String, Stack<int>> Board = new Dictionary<string, Stack<int>>();
            Stack A = new Stack();
            Stack B = new Stack();
            Stack C = new Stack();
            Board.Add("A: ", A, 1, 2, 3, 4);
            Board.Add("B: ", B, null);


            
            printBoard();
        }
        public static void printBoard()
        {
            
        }
    }
}
