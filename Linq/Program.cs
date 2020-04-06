using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.QueryHighScores();
            Student.QueryByLastName();
        }
    }

    public class Student
    {
        #region data
        public enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public GradeLevel Year;

        protected static List<Student> students = new List<Student>
        {
            new Student {FirstName = "Terry", LastName = "Adams", Id = 120,
                Year = GradeLevel.SecondYear},

            new Student {FirstName = "Fadi", LastName = "Fakhouri", Id = 116,
                Year = GradeLevel.ThirdYear},

            new Student {FirstName = "Hanying", LastName = "Feng", Id = 117,
                Year = GradeLevel.FirstYear},

            new Student {FirstName = "Cesar", LastName = "Garcia", Id = 114,
                Year = GradeLevel.FourthYear},

            new Student {FirstName = "Debra", LastName = "Garcia", Id = 115,
                Year = GradeLevel.ThirdYear},

            new Student {FirstName = "Hugo", LastName = "Garcia", Id = 118,
                Year = GradeLevel.SecondYear},

            new Student {FirstName = "Sven", LastName = "Mortensen", Id = 113,
                Year = GradeLevel.FirstYear},

            new Student {FirstName = "Claire", LastName = "O'Donnell", Id = 112,
                Year = GradeLevel.FourthYear},

            new Student {FirstName = "Svetlana", LastName = "Omelchenko", Id = 111,
                Year = GradeLevel.SecondYear},

            new Student {FirstName = "Lance", LastName = "Tucker", Id = 119,
                Year = GradeLevel.ThirdYear},

            new Student {FirstName = "Michael", LastName = "Tucker", Id = 122,
                Year = GradeLevel.SecondYear},

            new Student {FirstName = "Eugene", LastName = "Zabokritski", Id = 121,
                Year = GradeLevel.FourthYear}
        };
        #endregion

        public static void QueryHighScores()
        {
            var results = students.GroupBy(s => s.Year, s => s.Id, (a, b) => new
            {
                Key = a,
                Count = b.Count(),
                Ids = b
            });

            foreach (var item in results)
            {
                foreach (int id in item.Ids)
                {
                    Console.WriteLine($"{item.Key}{item.Count}{id}");
                }
            }
        }

        public static void QueryByLastName()
        {
            var results = students.GroupBy(s => s.Year, s => s.Id, (a, b) => new
            {
                Key = a,
                Count = b.Count(),
                Ids = b
            });

            foreach (var item in results)
            {
                foreach (int id in item.Ids)
                {
                    Console.WriteLine($"{item.Key}{item.Count}{id}");
                }
            }
        }
    }
}
