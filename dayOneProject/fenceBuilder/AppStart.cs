using System;
namespace fenceBuilder
{
    public class AppStart
    {
        public AppStart()
        {
            public void Start()
            {
                Console.WriteLine("Is this fence made out of wood or medal?");
                string answer = Console.ReadLine();

                if(answer == "wood" || answer == "Wood")
                {
                    RunWood();
                } else if (answer == "Medal" || answer == "medal")
                {
                    RunMedal();
                } else
                {
                    Console.WriteLine("Invalid input");
                    Start();
                }
            }

        }
    }
}
