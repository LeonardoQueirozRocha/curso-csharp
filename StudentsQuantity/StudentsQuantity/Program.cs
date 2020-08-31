using System;
using System.Collections.Generic;

namespace StudentsQuantity
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            int quantity = 0;

            Console.Write("How many students for course A?");
            quantity = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantity; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                courseA.Add(studentNumber);
            }

            Console.Write("How many students for course B?");
            quantity = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantity; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                courseB.Add(studentNumber);
            }

            Console.Write("How many students for course C?");
            quantity = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantity; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                courseC.Add(studentNumber);
            }

            HashSet<int> allStudents = new HashSet<int>(courseA);
            allStudents.UnionWith(courseB);
            allStudents.UnionWith(courseC);
            Console.WriteLine("Total students: " + allStudents.Count);
        }
    }
}
