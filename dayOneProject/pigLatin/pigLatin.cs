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
            string pigLatin = "";
            string firstLetter;
            string restOfWord;
            string vowels = "AEIOUaeiou";
            int letterPos;


            if (vowelList.Contains(first) && vowelList.Contains(last))
            {
                Console.WriteLine(answer + "yay");
            } else if (vowelList.Contains(first))
            {
                Console.WriteLine(answer + "ay");
            } else if(answer.IndexOfAny(vowelList2) == -1)
            {
                Console.WriteLine(answer + "ay");
            } else foreach (string word in answer.Split())
        
            {
                firstLetter = word.Substring(0, 1);
                restOfWord = word.Substring(1, word.Length - 1);
                letterPos = vowels.IndexOf(firstLetter);
                if (letterPos == -1)
                {
                    pigLatin = restOfWord + firstLetter + "ay";
                }
                else
                {
                    pigLatin = word + "way";
                }
                Console.WriteLine(pigLatin);

            }
        }
    }
}
