using System;

using Factory.Models;

namespace Factory.Factories
{
    /// <summary>
    /// Factory method pattern implementation.
    /// </summary>
    public class GenericFactory
    {
        /// <summary>
        /// Manufacture a vehicle.
        /// </summary>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="type">The class of vehicle.</param>
        public IVehicle Manufacture(string manufacturer,
                                    string type)
        {
            FactoryBase factory;

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

            return factory.Manufacture(type);
        }
    }
}
