using System;

namespace ref_vs_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 10;
            int value2 = 0;
            int result = 0;

            Console.WriteLine("Initial values result = {0}, value1 = {1} and value2 = {2}", result, value1, value2);

            Add(out result, value1, ref value2);

            // output new values and result
            Console.WriteLine("value1 = {0} and value2 = {1} added together = {2}", value1, value2, result);
        }

        public static void Add(out int result, int value1, ref int value2)
        {
            // If value2 is  >= 0 we updated the value
            if (value2 <= 0)
            {
                value2 = 5;
            }

            // Set result reference to the result
            result = value1 + value2;
        }
    }
}
