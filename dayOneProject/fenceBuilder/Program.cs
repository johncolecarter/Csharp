using System;

namespace fenceBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            AppStart a = new AppStart();
            a.Start();


            Console.WriteLine("Wood or Medal?");
            string userInput = Console.ReadLine();
            bool run = true;

            while (run)
            {
                if (userInput == "wood" || userInput == "Wood")
                {
                    Console.WriteLine("How tall is the fence?");
                    string woodSize = Console.ReadLine();
                    int newWoodSize = int.Parse(woodSize);

                    if (newWoodSize == 6)
                    {
                        Console.WriteLine("de or normal?");
                        string woodType = Console.ReadLine();

                        if (woodType == "de")
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 10) + (newDEGates * 50);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newWoodSize} foot dog eared fence with {newDEGates} gates.");
                            break;
                        }
                        else if (woodType == "normal")
                        {
                            Console.WriteLine("BOB or no?");
                            string bob = Console.ReadLine();
                            if (bob == "BOB" || bob == "bob")
                            {
                                Console.WriteLine("How many feet of fence?");
                                string deFeet = Console.ReadLine();
                                int newDEFeet = int.Parse(deFeet);
                                Console.WriteLine("How many gates?");
                                string deGates = Console.ReadLine();
                                int newDEGates = int.Parse(deGates);
                                double totalDE = (newDEFeet * 18) + (newDEGates * 100);
                                Console.WriteLine("\n");
                                Console.WriteLine($"You should charge about {totalDE}.");
                                Console.WriteLine($"This is a {newWoodSize} BOB foot fence with {newDEGates} gates.");
                                break;
                            }
                            else if (bob == "no")
                            {
                                Console.WriteLine("How many feet of fence?");
                                string deFeet = Console.ReadLine();
                                int newDEFeet = int.Parse(deFeet);
                                Console.WriteLine("How many gates?");
                                string deGates = Console.ReadLine();
                                int newDEGates = int.Parse(deGates);
                                double totalDE = (newDEFeet * 12) + (newDEGates * 100);
                                Console.WriteLine("\n");
                                Console.WriteLine($"You should charge about {totalDE}.");
                                Console.WriteLine($"This is a {newWoodSize} foot fence with {newDEGates} gates.");
                                break;
                            }
                        }
                    }
                    else if (newWoodSize == 7)
                    {
                        Console.WriteLine("BOB or no?");
                        string bob = Console.ReadLine();
                        if (bob == "BOB" || bob == "bob")
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 35) + (newDEGates * 250);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newWoodSize} foot BOB fence with {newDEGates} gates.");
                            break;
                        }
                        else if (bob == "no")
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 20) + (newDEGates * 100);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newWoodSize} foot fence with {newDEGates} gates.");
                            break;
                        }
                    }
                    else if (newWoodSize == 8)
                    {
                        Console.WriteLine("BOB or no?");
                        string bob = Console.ReadLine();
                        if (bob == "BOB" || bob == "bob")
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 30) + (newDEGates * 125);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newWoodSize} foot BOB fence with {newDEGates} gates.");
                            break;
                        }
                        else if (bob == "no")
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 25) + (newDEGates * 125);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newWoodSize} foot fence with {newDEGates} gates.");
                            break;
                        }
                    }
                    else if (newWoodSize == 10)
                    {
                        Console.WriteLine("BOB or no?");
                        string bob = Console.ReadLine();
                        if (bob == "BOB" || bob == "bob")
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 40) + (newDEGates * 150);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newWoodSize} foot BOB fence with {newDEGates} gates.");
                            break;
                        }
                        else if (bob == "no")
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 30) + (newDEGates * 150);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newWoodSize} foot fence with {newDEGates} gates.");
                            break;
                        }
                    }
                }
                else if (userInput == "medal" || userInput == "Medal")
                {
                    Console.WriteLine("What kind? cl or ri");
                    string typeMedal = Console.ReadLine();
                    if (typeMedal == "cl")
                    {
                        Console.WriteLine("How tall?");
                        string clSize = Console.ReadLine();
                        int newClSize = int.Parse(clSize);
                        if (newClSize == 6)
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 15) + (newDEGates * 100);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newClSize} foot fence with {newDEGates} gates.");
                            break;
                        }
                        else if (newClSize == 7)
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 20) + (newDEGates * 125);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newClSize} foot fence with {newDEGates} gates.");
                            break;
                        }
                        else if (newClSize == 8)
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 30) + (newDEGates * 150);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newClSize} foot fence with {newDEGates} gates.");
                            break;
                        }
                    }
                    else if (typeMedal == "ri")
                    {
                        Console.WriteLine("How tall?");
                        string riSize = Console.ReadLine();
                        int newRiSize = int.Parse(riSize);
                        if (newRiSize == 4)
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 30) + (newDEGates * 100);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newRiSize} foot fence with {newDEGates} gates.");
                            break;
                        }
                        else if (newRiSize == 5)
                        {
                            Console.WriteLine("How many feet of fence?");
                            string deFeet = Console.ReadLine();
                            int newDEFeet = int.Parse(deFeet);
                            Console.WriteLine("How many gates?");
                            string deGates = Console.ReadLine();
                            int newDEGates = int.Parse(deGates);
                            double totalDE = (newDEFeet * 30) + (newDEGates * 150);
                            Console.WriteLine("\n");
                            Console.WriteLine($"You should charge about {totalDE}.");
                            Console.WriteLine($"This is a {newRiSize} foot fence with {newDEGates} gates.");
                            break;
                        }
                    }
                }
            }
        }
    }
}
