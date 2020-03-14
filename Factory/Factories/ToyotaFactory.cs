using System;

using Factory.Models;

namespace Factory.Factories
{
    /// <summary>
    /// The Toyota factory.
    /// </summary>
    public class ToyotaFactory : FactoryBase
    {
        /// <summary>
        /// Manufacture the vehicle.
        /// </summary>
        /// <param name="type">The class of vehicle.</param>
        /// <returns>The vehicle.</returns>
        public override IVehicle Manufacture(string type)
        {
            IVehicle result;

            switch (type)
            {
                case "Motorcycle":
                    result = new ToyotaMotorcycle();
                    break;

                case "Car":
                    result = new ToyotaCar();
                    break;

                case "Truck":
                    result = new ToyotaTruck();
                    break;

                default:
                    throw new ArgumentException("No such class of vehicle");
            }

            return result;
        }
    }
}
