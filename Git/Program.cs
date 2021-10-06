using System;
using System.Collections.Generic;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car());
            vehicles.Add(new Car());
            vehicles.Add(new Car());
            vehicles.Add(new Car());
            
            /*for (int i = 0; i < vehicles.Count; i++)
            {
                Vehicle vehicle = vehicles[i];
                Console.WriteLine(vehicle.GetVehicleType());
            }*/

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetVehicleType());
            }
        }
    }
}