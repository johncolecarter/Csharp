using System;
using System.Linq;
namespace pigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any word");
            string answer = Console.ReadLine();

            string[] vowelList = { "a", "e", "i", "o", "u" };
            char[] vowelList2 = { 'a', 'e', 'i', 'o', 'u' };

            string first = answer.Substring(0, 1);
            string last = answer.Substring(answer.Length - 1);
            string pig1 = ""; //pig latin
            string pig2 = ""; //first letter
            string space = " ";
            string extra = ""; //extra letters
            int pos = 0; //position

            if (vowelList.Contains(first) && vowelList.Contains(last))
            {
                Console.WriteLine(answer + "yay");
            } else if (vowelList.Contains(first))
            {
                Console.WriteLine(answer + "ay");
            } else if(answer.IndexOfAny(vowelList2) == -1)
            {
                Console.WriteLine(answer + "ay");
            } else 
            {
                foreach (string word in answer.Split())
                {
                    if (pos != 0)
                    {
                        pig1 = pig1 + space;
                    }

                    else
                    {
                        pos = 1;
                    }

                    pig2 = word.Substring(0, 1);
                    extra = word.Substring(1, word.Length - 1);
                    pig1 = pig1 + extra + pig2 + "ay";

                }

            }
        }
    }
}
