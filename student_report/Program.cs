using System;

namespace student_report
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] students = null;

            Console.WriteLine("***************************************");
            Console.Write("Enter total students: ");
            int totalStudents = int.Parse(Console.ReadLine());

            students = new string[totalStudents, 5];

            for (int i = 0; i < totalStudents; i++)
            {
                Console.Write("Enter student name: ");
                students[i, 0] = Console.ReadLine();

                Console.Write("Enter english score: ");
                students[i, 1] = Console.ReadLine();

                Console.Write("Enter math score: ");
                students[i, 2] = Console.ReadLine();

                Console.Write("Enter science score: ");
                students[i, 3] = Console.ReadLine();
            }

            CalculateTotal(ref students, totalStudents);

            Console.WriteLine("***************************************");
            Console.WriteLine("Report Cards!");
            Console.WriteLine("***************************************");

            for (int i = 0; i < totalStudents; i++)
            {
                Console.WriteLine("Name: {0} Total Score: {1}", students[i, 0], students[i, 4]);
                Console.WriteLine("***************************************");
            }
        }

        public static void CalculateTotal(ref string[,] students, int totalStudents)
        {
            for (int i = 0; i < totalStudents; i++)
            {
                students[i, 4] = (int.Parse(students[i, 1]) + int.Parse(students[i, 2]) + int.Parse(students[i, 3])).ToString();
            }
        }

        // This example is just how to use a multi dimensional array and ref
        // will expand and do something where we use an indexer instead to access the 
        // students in a future example
    }
}
