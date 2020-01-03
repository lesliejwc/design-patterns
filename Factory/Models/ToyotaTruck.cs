namespace Factory.Models
{
    /// <summary>
    /// The truck manufactured by Toyota class.
    /// </summary>
    public class ToyotaTruck : IVehicle
    {
        /// <summary>
        /// The name/model of the vehicle.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes an instance of the <see cref="ToyotaTruck" /> class.
        /// </summary>
        public ToyotaTruck()
        {
            Name = "Toyota Truck";
        }
    }
}
