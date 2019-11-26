using System;
namespace fenceBuilder
{
    public class Wood
    {
        public Wood()
        {
            public void RunWood()
            {
                Console.WriteLine("What size fence is it?");
                string answer = Console.ReadLine();
                int intAnswer = int.Parse(answer);

                if(intAnswer == 6)
                {
                    bob();
                }
            }
        }
    }
}
