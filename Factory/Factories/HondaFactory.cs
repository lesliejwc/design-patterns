using System;

using Factory.Products;

namespace Factory.Factories
{
    /// <summary>
    /// The Honda factory.
    /// </summary>
    public class HondaFactory : FactoryBase
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
                    result = new HondaMotorcycle();
                    break;

                case "Car":
                    result = new HondaCar();
                    break;

                case "Truck":
                    result = new HondaTruck();
                    break;

                default:
                    throw new ArgumentException("No such class of vehicle");
            }

            return result;
        }
    }
}
