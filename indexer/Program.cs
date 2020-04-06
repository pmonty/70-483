using System;

namespace indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeekTemp w = new WeekTemp();
            w[0] = 20;
            w[1] = w[0];

            Console.WriteLine("{0} {1}", w[0], w[1]);
        }
    }

    public class WeekTemp
    {
        private float[] weekTemp =
            { 47.5F, 40.0F, 52.5F, 45.5F, 48.0F, 38.0F, 35.7F };

        // Use float indexer, to encapsulate weekTemp
        public float this[int index]
        {
            get
            {
                if (index >= 0 && index < weekTemp.Length)
                {
                    return weekTemp[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (value > 0)
                {
                    weekTemp[index] = value;
                }
                else
                {
                    Console.WriteLine("Please set value greater than 0");
                }
            }
        }
    }
}
