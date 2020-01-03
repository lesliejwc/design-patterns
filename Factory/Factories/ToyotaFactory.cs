using Factory.Models;

namespace Factory.Factories
{
    /// <summary>
    /// Toyota factory class.
    /// </summary>
    public class ToyotaFactory : Factory
    {
        /// <summary>
        /// Initializes an instance of the <see cref="ToyotaFactory" /> class.
        /// </summary>
        public ToyotaFactory()
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
                    result = new ToyotaMotorcycle();
                    break;

                case "Car":
                    result = new ToyotaCar();
                    break;

                case "Truck":
                    result = new ToyotaTruck();
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}
