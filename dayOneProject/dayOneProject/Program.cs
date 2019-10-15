using System;

namespace dayOneProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            hello();
            addition();
            catDog();
            oddEvent();
            inches();
            echo();
            killGrams();
            printDateTime();
            printAge();
            guess();
        }

        public static void hello()
        {
            Console.WriteLine("Hello, what is your name?");
            string responce = Console.ReadLine();
            Console.WriteLine("Hello " + responce);
            Console.WriteLine("Bye " + responce);
        }
        public static void addition()
        {
            Console.WriteLine("Choose any two numbers");
            string numberOne = Console.ReadLine();
            int newNumberOne = int.Parse(numberOne);
            string numberTwo = Console.ReadLine();
            int newNumberTwo = int.Parse(numberTwo);
            Console.WriteLine((newNumberOne + newNumberTwo) + " is your answer");
        }
        public static void catDog()
        {
            Console.WriteLine("Do you prefer cats or dogs?");
            string answer = Console.ReadLine();
            if (answer == "cats" || answer == "cat")
            {
                Console.WriteLine("meow");
            }
            else if (answer == "dogs" || answer == "dog")
            {
                Console.WriteLine("bark");
            }
            else
            {
                Console.WriteLine("That wasn't a cat or a dog");
            }
        }
        public static void oddEvent()
        {
            Console.WriteLine("Choose any number");
            int oddNumber = int.Parse(Console.ReadLine());
            if (oddNumber % 2 == 1)
            {
                Console.WriteLine("Your number is odd");

            }
            else if (oddNumber % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("That wasn't a number");
            }
        }
        public static void inches()
        {
            Console.WriteLine("What is your height in feet? Type feet then inches.");
            int heightFeet = int.Parse(Console.ReadLine());
            int heightInches = int.Parse(Console.ReadLine());
            Console.WriteLine("You are " + (heightFeet * 12 + heightInches) + " inches tall");
        }
        public static void echo()
        {
            Console.WriteLine("What is your favorite word?");
            string word = Console.ReadLine();
            string upperWord = word.ToUpper();
            string lowerWord = word.ToLower();
            Console.WriteLine(upperWord);
            Console.WriteLine(lowerWord);
            Console.WriteLine(lowerWord);
        }
        public static void killGrams()
        {
            Console.WriteLine("What is your weight in pounds?");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Your weight is " + (weight * .453592) + " killograms");
        }
        public static void printDateTime()
        {
            Console.WriteLine(DateTime.Now);
        }
        public static void printAge()
        {
            Console.WriteLine("What year were you born?");
            int yearBorn = int.Parse(Console.ReadLine());
            Console.WriteLine("You are " + (2019 - yearBorn) + " years old.");
        }
        public static void guess()
        {

            string csharp = "";
            while (csharp != "csharp")
            {
                Console.WriteLine("Try to guess the word. HINT: it's the language I'm learning.");
                csharp = Console.ReadLine();

                if (csharp == "csharp")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("WRONG!");
                }
            }
            Console.WriteLine("CORRECT!");

        }
    }
}

