using System;

using Factory.Products;

namespace Factory.Factories
{
    /// <summary>
    /// The Mazda factory.
    /// </summary>
    public class MazdaFactory : FactoryBase
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
                    result = new MazdaMotorcycle();
                    break;

                case "Car":
                    result = new MazdaCar();
                    break;

                case "Truck":
                    result = new MazdaTruck();
                    break;

                default:
                    throw new ArgumentException("No such class of vehicle");
            }

            return result;
        }
    }
}
