using System;

using Factory.Factories;
using Factory.Products;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle;
            SimpleFactory sFactory = new SimpleFactory();
            GenericFactory gFactory = new GenericFactory();


            // Simple factory pattern demonstration.
            Console.WriteLine("Simple factory:");

            vehicle = sFactory.Manufacture("HondaCar");
            Console.WriteLine(vehicle.Name);

            vehicle = sFactory.Manufacture("ToyotaMotorcycle");
            Console.WriteLine(vehicle.Name);


            // factory method pattern demonstration.
            Console.WriteLine("\nFactory method:");

            vehicle = gFactory.Manufacture("Honda", "Car");
            Console.WriteLine(vehicle.Name);

            vehicle = gFactory.Manufacture("Toyota", "Motorcycle");
            Console.WriteLine(vehicle.Name);
        }
    }
}
