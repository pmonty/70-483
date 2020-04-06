using System;

namespace Simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                Console.WriteLine("What operation would you like to perform");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Subtract");
                Console.WriteLine("3 - Divide");
                Console.WriteLine("4 - Multiply");
                int operation = int.Parse(Console.ReadLine());

                Console.Write("Value one: ");
                int value1 = int.Parse(Console.ReadLine());

                Console.Write("Value two:");
                int value2 = int.Parse(Console.ReadLine());

                int result = 0;
                switch ((Operation)operation)
                {
                    case Operation.Add:
                        result = Add(value1, value2);
                        break;
                    case Operation.Subtract:
                        result = Subtract(value1, value2);
                        break;
                    case Operation.Divide:
                        result = Divide(value1, value2);
                        break;
                    case Operation.Multiply:
                        result = Multiply(value1, value2);
                        break;
                }

                Console.WriteLine("{0} {1} {2} = {3}", value1, (Operation)operation, value2, result);
                Console.Write("Would you like to continue y/n:");

                string runAgain = Console.ReadLine();
                RunAgain(ref keepAlive, runAgain);
            }
        }

        public static int Add(int value1, int value2)
        {
            return value1 +  value2;
        }

        public static int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        public static int Divide(int value1, int value2)
        {
            return value1 / value2;
        }

        public static int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public static void RunAgain(ref bool keepAlive, string runAgain)
        {
            if (runAgain.ToLower() == "y")
            {
                keepAlive = true;
            }
            else
            {
                keepAlive = false;
            }
        }
    }

    public enum Operation
    {
        Add = 1,
        Subtract,
        Divide,
        Multiply
    }
}
