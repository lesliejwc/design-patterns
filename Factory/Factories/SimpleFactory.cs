using Factory.Models;

namespace Factory.Factories
{
    /// <summary>
    /// Simple factory pattern implementation.
    /// </summary>
    public class SimpleFactory
    {
        /// <summary>
        /// Manufacture the vehicle.
        /// </summary>
        /// <param name="type">The class of vehicle.</param>
        /// <returns>The vehicle.</returns>
        public IVehicle Manufacture(string type)
        {
            IVehicle result;

            switch (type)
            {
                case "HondaMotorcycle":
                    result = new HondaMotorcycle();
                    break;

                case "HondaCar":
                    result = new HondaCar();
                    break;

                case "HondaTruck":
                    result = new HondaTruck();
                    break;

                case "MazdaMotorcycle":
                    result = new MazdaMotorcycle();
                    break;

                case "MazdaCar":
                    result = new MazdaCar();
                    break;

                case "MazdaTruck":
                    result = new MazdaTruck();
                    break;

                case "ToyotaMotorcycle":
                    result = new ToyotaMotorcycle();
                    break;

                case "ToyotaCar":
                    result = new ToyotaCar();
                    break;

                case "ToyotaTruck":
                    result = new ToyotaTruck();
                    break;

                default:
                    result = new HondaCar();
                    break;
            }

            return result;
        }
    }
}
