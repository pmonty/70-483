using System;

namespace accessors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.SetupStudent("Paul");
            Console.WriteLine("Name = {0}, Gender = {1}, Age = {2}", s1.Name, s1.Gender, s1.Age);

            Student s2 = new Student();
            s2.SetupStudent("Kristina");
            // This won't let me change the gender as the accessor is private or protected
            // s2.Gender = "Female";
        }
    }

    public class Student
    {
        private string name;
        private string gender;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender 
        {
            get { return gender; }
            protected set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            private set 
            {
                if (age <= 0)
                    Console.WriteLine("Age must be greater than zero");
                else
                    age = value; 
            }
        }

        public void SetupStudent(string name)
        {
            // Pretend all students will be male
            Name = name;
            Gender = "male";
            Age = 0;
        }

    }
}
