using System;
using System.Collections.Generic;
using System.Linq;

namespace gradeBook
{
    class Program
    {
        private const string Arg0 = ":";

        static void Main(string[] args)
        {
            bool program = true;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string studentName = string.Empty;

            while (program)
            {
                Console.WriteLine("Enter a students name. Once you're done entering names and grades enter 'quit'.");
                studentName = Console.ReadLine();
                string studentGrades = string.Empty;

                if (studentName != "quit")
                {
                    Console.WriteLine("Enter the students grades with a space in between each grade.");
                    studentGrades = Console.ReadLine();
                    dict.Add(studentName, studentGrades);
                }
                else if (studentName == "quit")
                {
                    break;
                }
            }           
            foreach(var key in dict.Keys)
            {
                int[] grades;
                grades = Array.ConvertAll<string, int>(dict[key].Split(), Convert.ToInt32);

                int lowestGrade = grades.Min();
                int highestGrade = grades.Max();
                double average = grades.Average();

                Console.WriteLine("{0}  highest grade: {1}   lowest grade: {2}   average: {3}", key, highestGrade, lowestGrade, average);

            }
        }   
    }
}
