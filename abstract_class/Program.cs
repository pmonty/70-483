using System;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari f = new Ferrari();
            f.Model = "F40";
            f.FillUpPetrol(); // Abstract base class
            f.DriveCar(); // Override for Ferrari class
            f.DriveCar("Italy"); // Overloaded method for Ferrari class
        }
    }

    public abstract class Car
    {
        // Abstract method and property need to be overridden
        public abstract string Model { get; set; }
        public abstract void DriveCar();

        // Non abstract method with implementation
        public void FillUpPetrol()
        {
            Console.WriteLine("Petrol has been filled for {0}", this.Model);
        }
    }

    public class Ferrari: Car
    {
        public override string Model { get; set; }
        public override void DriveCar()
        {
            Console.WriteLine("Driving Ferrari {0}", this.Model);
        }
        
        // Overloaded method
        public void DriveCar(string location)
        {
            Console.WriteLine("Driving Ferrari {0} in location {1}", this.Model, location);
        }
    }

    public class Lambo: Car
    {
        public override string Model { get; set; }
        public override void DriveCar()
        {
            Console.WriteLine("Driving Lambo {0}", this.Model);
        }
    }
}
