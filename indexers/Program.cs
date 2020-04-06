using System;
using System.Collections;
using System.Collections.Generic;

namespace indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<Student> students = new CustomList<Student>();
            students.Add(new Student { Age = 1, FirstName = "Samuel", Surname = "Montagna" });
            students.Add(new Student { Age = 30, FirstName = "Paul", Surname = "Montagna" });
            students.Add(new Student { Age = 33, FirstName = "Kristina", Surname = "Montagna" });

            // Uses indexer
            students[1].Age = 5;

            // Uses enumerator
            foreach(Student s in students)
            {
                Console.WriteLine(s.FirstName);
            }
        }
    }

    // If we add "where T: struct" then we will get an error in Main that Student is not a value type
    public class CustomList<T> : IEnumerable<T>, ICollection<T>, IList<T>
        where T: new()
    {
        // Our custom array of user defined types
        public List<T> array = new List<T>();

        // Indexer example
        public T this [int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        // .NET interfaces for enumeration
        public int Count => array.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            array.Add(item);
        }

        public void Clear()
        {
            array.Clear();
        }

        public bool Contains(T item)
        {
            return array.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.array.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
            {
                yield return item;
            } 
        }

        public int IndexOf(T item)
        {
            return array.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            array.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return array.Remove(item);
        }

        public void RemoveAt(int index)
        {
            array.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    public class Student
    {
        public string FirstName;
        public string Surname;
        public int Age;
    }
}
