using System;

namespace PaperRockScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            game();
        }
        public static void game()
        {
            bool playAgain = true;
            int playerScore = 0;
            int computerScore = 0;

            while (playAgain)
            {
                Console.WriteLine("Choose between rock, paper, or scissors");
                string userInput = Console.ReadLine();
                string computerInput;
                int computer;
                Random number = new Random();
                computer = number.Next(1, 4);

                switch (computer)
                {
                    case 1:
                        computerInput = "rock";
                        if (userInput == "rock")
                        {
                            Console.WriteLine("Computer chose rock");
                            Console.WriteLine("It's a draw!");
                            Console.WriteLine("Your score: " + playerScore + "   " + "CPU score: " + computerScore);
                        }
                        else if (userInput == "paper")
                        {
                            Console.WriteLine("Computer chose rock");
                            Console.WriteLine("You win!!");
                            playerScore++;
                            Console.WriteLine("Your score: " + playerScore + "   " + "CPU score: " + computerScore);
                        }
                        else if (userInput == "scissors")
                        {
                            Console.WriteLine("Computer chose rock");
                            Console.WriteLine("Computer wins:(");
                            computerScore++;
                            Console.WriteLine("Your score: " + playerScore + "   " + "CPU score: " + computerScore);
                        }
                        else
                        {
                            Console.WriteLine("Invaild input");
                        }
                        break;
                    case 2:
                        computerInput = "paper";
                        if (userInput == "rock")
                        {
                            Console.WriteLine("Computer chose paper");
                            Console.WriteLine("Computer wins:(");
                            computerScore++;
                            Console.WriteLine("Your score: " + playerScore + "   " + "CPU score: " + computerScore);

                        }
                        else if (userInput == "paper")
                        {
                            Console.WriteLine("Computer chose paper");
                            Console.WriteLine("It's a draw");
                            Console.WriteLine("Your score: " + playerScore + "   " + "CPU score: " + computerScore);
                        }
                        else if (userInput == "scissors")
                        {
                            Console.WriteLine("Computer chose paper");
                            Console.WriteLine("You win!!");
                            playerScore++;
                            Console.WriteLine("Your score: " + playerScore + "   " + "CPU score: " + computerScore);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;
                    case 3:
                        computerInput = "scissors";
                        if (userInput == "rock")
                        {
                            Console.WriteLine("Computer chose scissors");
                            Console.WriteLine("You win!!");
                            playerScore++;
                            Console.WriteLine("Your score: " + playerScore + "   " + "CPU score: " + computerScore);
                        }
                        else if (userInput == "paper")
                        {
                            Console.WriteLine("Computer chose scissors");
                            Console.WriteLine("Computer wins:(");
                            computerScore++;
                            Console.WriteLine("Your score: " + playerScore + "   " + "CPU score: " + computerScore);
                        }
                        else if (userInput == "scissors")
                        {
                            Console.WriteLine("Computer chose scissors");
                            Console.WriteLine("It's a draw");
                            Console.WriteLine("Your score: " + playerScore + "   " + "CPU score: " + computerScore);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;
                }
                if(playerScore == 3)
                {
                    Console.WriteLine("You won the game!!");
                    Console.WriteLine("Do you want to play again?");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        game();
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!!");
                    }
                    break;
                } else if(computerScore == 3)
                {
                    Console.WriteLine("You lost the game:(");
                    Console.WriteLine("Do you want to play again?");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        game();
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!!");
                    }
                    break;
                }
            }
        }
    }
}


