using System;
using System.ComponentModel;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Pass += OnPassed;
            s.Fail += OnFailed;
            s.Changed += OnPropertyChanged;

            s.Name = "Paul";
            s.Math = 50;
            s.English = 50;
            s.Science = 50;
        }

        private static void OnPassed(object sender, EventArgs e)
        {
            Console.WriteLine("passed!");
        }
        private static void OnFailed(object sender, EventArgs e)
        {
            Console.WriteLine("failing!");
        }

        private static void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Student s = (Student)sender;
            Console.WriteLine("{0} score has been updated", e.PropertyName);
        }
    }

    public class Student
    {
        public event EventHandler Pass;
        public event EventHandler Fail;
        public event PropertyChangedEventHandler Changed;

        private string name;
        private int math;
        private int english;
        private int science;
        private int total;

        public string Name { get; set; }
        public int Math { 
            get
            {
                return math;
            }
            set
            {
                math = value;
                if (Changed != null)
                {
                    Changed(this, new PropertyChangedEventArgs("Math"));
                }
                Total += value;
            }
        }
        public int English {
            get
            {
                return english;
            }
            set
            {
                english = value;
                if (Changed != null)
                {
                    Changed(this, new PropertyChangedEventArgs("English"));
                }
                Total += value;
            }
        }
        public int Science {
            get
            {
                return science;
            }
            set
            {
                science = value;
                if (Changed != null)
                {
                    Changed(this, new PropertyChangedEventArgs("Science"));
                }
                Total += value;
            }
        }
        public int Total {
            get
            {
                return total;
            }
            set
            {
                total += value;
                if (Pass != null && Fail != null)
                {
                    if (total > 75)
                    {
                        Pass(this, EventArgs.Empty);
                    }
                    else
                    {
                        Fail(this, EventArgs.Empty);
                    }
                }
            }
        }
    }
}
