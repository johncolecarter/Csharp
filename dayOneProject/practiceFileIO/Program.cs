using System;
using System.IO;

namespace practiceFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"c:\Users\colecarter\Desktop\Colors.txt";

            String[] lines = File.ReadAllLines(path);
            foreach(var l in lines)
            {
                Console.WriteLine(l);
            }
        }
    }
}
