using Factory.Models;

namespace Factory.Factories
{
    /// <summary>
    /// Honda factory class.
    /// </summary>
    public class HondaFactory : Factory
    {
        /// <summary>
        /// Initializes an instance of the <see cref="HondaFactory" /> class.
        /// </summary>
        public HondaFactory()
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
                    result = new HondaMotorcycle();
                    break;

                case "Car":
                    result = new HondaCar();
                    break;

                case "Truck":
                    result = new HondaTruck();
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}
