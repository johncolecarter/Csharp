using System;

namespace superVillain
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Cole", "John");
            
            Person p2 = new Person("Willson", "Will");
            
            SuperHero s = new SuperHero("Clark Kent", "Super Man", "Super Strength");

            SuperHero s2 = new SuperHero("Peter Parker", "Spiderman", "Fighting Crime");

            SuperVillain v = new SuperVillain("The Joker", "Batman");

            SuperVillain v2 = new SuperVillain("Thanos", "The Avengers");

        }
    }
    class Person
    {
        private string name;
        private string nickName;

        public Person(string Name, string NickName)
        {
            name = Name;
            nickName = NickName;
            Console.WriteLine($"{name}: Hi, my name is {name}, but you can call me {nickName}.");
        }
    }
    class SuperHero
    {
        private string power;
        private string name;
        private string superName;

        public SuperHero(string Name, string SuperName, string Power)
        {
            superName = SuperName;
            name = Name;
            power = Power;
            Console.WriteLine($"{name}: I am {name}. When I am {superName}, my power is {power}.");
        }
    }
    class SuperVillain
    {
        private string name;
        private string nemesis;

        public SuperVillain(string Name, string Nemesis)
        {
            name = Name;
            nemesis = Nemesis;
            Console.WriteLine($"{name}: I am {name}. Have you seen {nemesis}?");
        }
    }
}
