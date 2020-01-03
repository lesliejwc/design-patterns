using System;

using Factory.Factories;
using Factory.Models;

namespace Factory
{
    /// <summary>
    /// Abstract factory implementation.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new VehicleFactory();
            IVehicle vehicle;

            vehicle = factory.Manufacture("Toyota", "Car");
            Console.WriteLine(vehicle.Name);

            vehicle = factory.Manufacture("Toyota", "Truck");
            Console.WriteLine(vehicle.Name);

            vehicle = factory.Manufacture("Honda", "Motorcycle");
            Console.WriteLine(vehicle.Name);

            vehicle = factory.Manufacture("Mazda", "Truck");
            Console.WriteLine(vehicle.Name);
        }
    }
}
