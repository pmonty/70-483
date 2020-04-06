using System;

namespace struct_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Pauls car");
            Vehicle v2 = new Vehicle("Pauls train", VehicleType.Train);

            Console.WriteLine(v2.details.engines);
        }
    }

    public enum VehicleType
    {
        // start enum from 1 by specifiying first enum
        Car = 1,
        Train,
        Plane,
        MonsterTruck
    }

    public readonly struct VehicleDetails
    {
        public VehicleDetails(VehicleType v)
        {
            switch (v)
            {
                case VehicleType.Car:
                default:
                    wheels = 4;
                    engines = 1;
                    type = v;
                    break;
                case VehicleType.MonsterTruck:
                    wheels = 8;
                    engines = 1;
                    type = v;
                    break;
                case VehicleType.Train:
                    wheels = 100;
                    engines = 2;
                    type = v;
                    break;
                case VehicleType.Plane:
                    wheels = 5;
                    engines = 2;
                    type = v;
                    break;
            }
        }

        public int wheels { get; }
        public int engines { get; }
        public VehicleType type { get; }
    }

    public class Vehicle
    {
        public VehicleDetails details;
        public string name;

        // default create a car vehicle
        public Vehicle(string name)
        {
            details = new VehicleDetails();
            // ReadOnly Struct so below won't work
            // this.details.engines = 3;
            this.name = name;
        }

        // default create a specified vehicle type
        public Vehicle(string name, VehicleType v)
        {
            details = new VehicleDetails(v);
            this.name = name;
        }
    }
}
