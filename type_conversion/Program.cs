using System;

namespace type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // DataType  Example  Default   MemorySize                      Classification
            // int       456      0         4 bytes                         Value Type
            // float     10.05f   0.0f      4 bytes                         Value Type
            // Double    19.5D    0.0D      8 bytes                         Value Type
            // Char      'A'      '\0'      2 bytes                         Value Type
            // byte      5        0         8 bit                           Value Type
            // string    "Dev"    Null      (2 bytes) * (length of string)  Reference Type
            // bool      true     False     1 byte                          Value Type

            // implicit conversion (small to larger type)
            int i = 10;
            double d = i;
            Console.WriteLine(d);

            // explicit conversion (larger to small type)
            double r = 20;
            int x = (int)r;
            Console.WriteLine(x);

            // implicit conversion (derived class (ferrari) back to base class (car))
            Car ferrari = new Ferrari();

            // explicit conversion back to derived type
            Ferrari f1 = ferrari as Ferrari;

            // type cast or 'as' keyword above
            Ferrari f2 = (Ferrari)ferrari;
        }
    }

    public class Car
    {
        public Car()
        {
            // Todo
        }
    }

    public class Ferrari: Car
    {
        public Ferrari()
        {
            // Todo
        }
    }

}
