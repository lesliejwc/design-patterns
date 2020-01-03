using System;

using Factory.Models;

namespace Factory.Factories
{
    /// <summary>
    /// The vehicle factory class.
    /// </summary>
    public class VehicleFactory
    {
        /// <summary>
        /// Initializes an instance of the <see cref="VehicleFactory" /> class.
        /// </summary>
        public VehicleFactory()
        {
        }

        /// <summary>
        /// Manufacture a vehicle.
        /// </summary>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="type">The class of vehicle.</param>
        public IVehicle Manufacture(string manufacturer,
                                    string type)
        {
            Factory factory = null;
            IVehicle result = null;

            switch (manufacturer)
            {
                case "Toyota":
                    factory = new ToyotaFactory();
                    break;

                case "Mazda":
                    factory = new MazdaFactory();
                    break;

                case "Honda":
                    factory = new HondaFactory();
                    break;

                default:
                    throw new ArgumentException("No such manufacturer.");
            }

            result = factory.Manufacture(type);

            if (result == null)
            {
                throw new ArgumentException("No such class of vehicle.");
            }

            return result;
        }
    }
}
