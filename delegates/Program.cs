using System;

namespace delegates
{
    class Program
    {
        // Need to declare delegate
        public delegate void consoles(string test);

        static void Main(string[] args)
        {
            consoles c = new consoles(Show);
            c += Screen;
            c("test");

            c -= Show;
            c("new test");

            // Built in delegates
            Func<int, int, int> funcs = (int a, int b) =>
            {
                return a + b;
            };
            funcs += Mul;
            funcs += Sub;

            foreach (Func<int, int, int> f in funcs.GetInvocationList())
            {
                Console.WriteLine(f(4, 3));
            }
        }

        // Delegates
        public static void Show(string test)
        {
            Console.WriteLine("Show " + test);
        }
        public static void Screen(string test)
        {
            Console.WriteLine("Screen " + test);
        }

        // Same setup for Predicate<T> (bool) or Action<T> (void)
        // Func's return a value
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }


    }

}
