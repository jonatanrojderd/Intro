using System;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Common Value Types (Primitive Types) used in .NET
             */
            int @int;
            float @float;
            double @double;
            bool @bool;
            char @char;
            
            // Using the created enum as an example.
            VehicleType vehicleType;
            
            // Reference Types (Non-Primitive Types)
            string @string;
            int[] array;
            
            // Using the created class as an example.
            Vehicle vehicle;
            vehicle = new Car();

            // if (vehicle.GetVehicleType() == VehicleType.None)
            // {
            //     // Do nothing
            // }
            // else if (vehicle.GetVehicleType() == VehicleType.Car)
            // {
            //     // Process car information
            // }
            // else if (vehicle.GetVehicleType() == VehicleType.Motorcycle)
            // {
            //     // Process motorcycle information
            // }
            // else if (vehicle.GetVehicleType() == VehicleType.Truck)
            // {
            //     // Process truck information
            // }

            // You can use a switch statement instead of if-else
            
            vehicleType = vehicle.GetVehicleType(); 
            switch (vehicleType)
            {
                // if (vehicleType == VehicleType.Car) {}
                case VehicleType.Car:
                {
                    Console.WriteLine($"This vehicle is a: {vehicleType}");
                    break;
                }
                // else if (vehicleType == VehicleType.Motorcycle) {}
                case VehicleType.Motorcycle:
                    break;
                case VehicleType.Truck:
                    break;
                case VehicleType.None:
                    break;
            }

            Vehicle[] vehicles = new Vehicle[4];
            vehicles[0] = vehicle;
            vehicles[1] = new Car();
        }
    }
}