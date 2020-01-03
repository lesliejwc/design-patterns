using Factory.Models;

namespace Factory.Factories
{
    /// <summary>
    /// Mazda factory class.
    /// </summary>
    public class MazdaFactory : Factory
    {
        /// <summary>
        /// Initializes an instance of the <see cref="MazdaFactory" /> class.
        /// </summary>
        public MazdaFactory()
            : base()
        {
        }

        /// <summary>
        /// Manufacture the vehicle.
        /// </summary>
        public override IVehicle Manufacture(string type)
        {
            IVehicle result = null;

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
                    break;
            }

            return result;
        }
    }
}
