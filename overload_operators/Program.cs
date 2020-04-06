using System;

namespace overload_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Age = 5, Name = "Paul" };
            Person p2 = new Person { Age = 6, Name = "Samuel" };
            Console.WriteLine("p1 Age {0}", p1.Age);

            Person p3;
            p3 = p1 + p2;
            Console.WriteLine("p3 Age {0}", p3.Age);

            p1++;
            Console.WriteLine("p1 Age {0}", p1.Age);

            bool isOlder = p1 > p3;
            Console.WriteLine("p1 > p3 = {0}", isOlder);

        }
    }

    public class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = "Default";
        }

        // overload operator examples
        // binary operator
        public static Person operator + (Person p1, Person p2) 
        {
            Person p = new Person();
            p.Age = p1.Age + p2.Age;
            return p;
        }

        // unary operator
        public static Person operator ++ (Person p1)
        {
            p1.Age += 5;
            return p1;
        }


        // comparison operators
        public static bool operator > (Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator < (Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
    }
}
