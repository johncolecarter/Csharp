using System;
using System.Collections.Generic;

namespace masterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();
        }
        public static void Game()
        {
            Console.WriteLine("Welcome to Master Mind.");
            Console.WriteLine("\n");
            Console.WriteLine("Pick two colors (RED, BLUE, or YELLOW).");
            Console.WriteLine("\n");
            int computer;
            Random number = new Random();
            computer = number.Next(1, 10);
            bool play = true;
            int playerScore = 0;

            while (play)
            {
                string computerInput;
                Console.WriteLine("Enter your guess.");
                string user = Console.ReadLine();

                switch (computer)
                {
                    case 1:
                        computerInput = "red red";
                        if (user == "red red")
                        {
                            Console.WriteLine("Congradulations, you won!");
                            playerScore++;
                        }
                        else if (user == "red blue" || user == "red yellow" || user == "blue red" || user == "yellow red")
                        {
                            Console.WriteLine("your hint: 0-1");
                        }
                        else if (user == "blue yellow" || user == "yellow blue" || user == "blue blue" || user == "yellow yellow")
                        {
                            Console.WriteLine("your hint: 0-0");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case 2:
                        computerInput = "blue blue";
                        if (user == "blue blue")
                        {
                            Console.WriteLine("Congradulations, you won!");
                            playerScore++;
                        }
                        else if (user == "blue red" || user == "blue yellow" || user == "red blue" || user == "yellow blue")
                        {
                            Console.WriteLine("your hint: 0-1");
                        }
                        else if (user == "red yellow" || user == "yellow red" || user == "red red" || user == "yellow yellow")
                        {
                            Console.WriteLine("your hint: 0-0");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case 3:
                        computerInput = "yellow yellow";
                        if (user == "yellow yellow")
                        {
                            Console.WriteLine("Congradulations, you won!");
                            playerScore++;
                        }
                        else if (user == "blue yellow" || user == "red yellow" || user == "yellow blue" || user == "red yellow")
                        {
                            Console.WriteLine("your hint: 0-1");
                        }
                        else if (user == "red blue" || user == "blue red" || user == "red red" || user == "blue blue")
                        {
                            Console.WriteLine("your hint: 0-0");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case 4:
                        computerInput = "red yellow";
                        if (user == "red yellow")
                        {
                            Console.WriteLine("Congradulations, you won!");
                            playerScore++;
                        }
                        else if (user == "red blue" || user == "blue yellow" || user == "red red" || user == "yellow yellow")
                        {
                            Console.WriteLine("your hint: 0-1");
                        }
                        else if (user == "yellow blue" || user == "blue red")
                        {
                            Console.WriteLine("your hint: 1-0");
                        }
                        else if (user == "blue blue")
                        {
                            Console.WriteLine("your hint: 0-0");
                        }
                        else if (user == "blue red")
                        {
                            Console.WriteLine("your hint: 2-0");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case 5:
                        computerInput = "red blue";
                        if (user == "red blue")
                        {
                            Console.WriteLine("Congradulations, you won!");
                            playerScore++;
                        }
                        else if (user == "red yellow" || user == "yellow blue" || user == "red red" || user == "blue blue")
                        {
                            Console.WriteLine("your hint: 0-1");
                        }
                        else if (user == "yellow red" || user == "blue yellow")
                        {
                            Console.WriteLine("your hint: 1-0");
                        }
                        else if (user == "yellow yellow")
                        {
                            Console.WriteLine("your hint: 0-0");
                        }
                        else if (user == "blue red")
                        {
                            Console.WriteLine("your hint: 2-0");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case 6:
                        computerInput = "blue red";
                        if (user == "blue red")
                        {
                            Console.WriteLine("Congradulations, you won!");
                            playerScore++;
                        }
                        else if (user == "yellow red" || user == "blue yellow" || user == "red red" || user == "blue blue")
                        {
                            Console.WriteLine("your hint: 0-1");
                        }
                        else if (user == "red yellow" || user == "yellow blue")
                        {
                            Console.WriteLine("your hint: 1-0");
                        }
                        else if (user == "yellow yellow")
                        {
                            Console.WriteLine("your hint: 0-0");
                        }
                        else if (user == "red blue")
                        {
                            Console.WriteLine("your hint: 2-0");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case 7:
                        computerInput = "blue yellow";
                        if (user == "blue yellow")
                        {
                            Console.WriteLine("Congradulations, you won!");
                            playerScore++;
                        }
                        else if (user == "red yellow" || user == "blue red" || user == "yellow yellow" || user == "blue blue")
                        {
                            Console.WriteLine("your hint: 0-1");
                        }
                        else if (user == "red blue" || user == "yellow red")
                        {
                            Console.WriteLine("your hint: 1-0");
                        }
                        else if (user == "red red")
                        {
                            Console.WriteLine("your hint: 0-0");
                        }
                        else if (user == "yellow blue")
                        {
                            Console.WriteLine("your hint: 2-0");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case 8:
                        computerInput = "yellow blue";
                        if (user == "yellow blue")
                        {
                            Console.WriteLine("Congradulations, you won!");
                            playerScore++;
                        }
                        else if (user == "yellow red" || user == "red blue" || user == "yellow yellow" || user == "blue blue")
                        {
                            Console.WriteLine("your hint: 0-1");
                        }
                        else if (user == "blue red" || user == "red yellow")
                        {
                            Console.WriteLine("your hint: 1-0");
                        }
                        else if (user == "red red")
                        {
                            Console.WriteLine("your hint: 0-0");
                        }
                        else if (user == "blue yellow")
                        {
                            Console.WriteLine("your hint: 2-0");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case 9:
                        computerInput = "yellow red";
                        if (user == "yellow red")
                        {
                            Console.WriteLine("Congradulations, you won!");
                            playerScore++;
                        }
                        else if (user == "yellow blue" || user == "blue red" || user == "yellow yellow" || user == "red red")
                        {
                            Console.WriteLine("your hint: 0-1");
                        }
                        else if (user == "red blue" || user == "blue yellow")
                        {
                            Console.WriteLine("your hint: 1-0");
                        }
                        else if (user == "blue blue")
                        {
                            Console.WriteLine("your hint: 0-0");
                        }
                        else if (user == "red yellow")
                        {
                            Console.WriteLine("your hint: 2-0");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                }
                if(playerScore == 1)
                {
                    Console.WriteLine("Woudl you like to play again?");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Game();
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                    }
                    break;
                }
            }
        }
    }   
}
