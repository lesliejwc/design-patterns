namespace Factory.Models
{
    /// <summary>
    /// The truck manufactured by Honda.
    /// </summary>
    public class HondaTruck : IVehicle
    {
        /// <summary>
        /// The name of the vehicle.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes an instance of the <see cref="HondaTruck" /> class.
        /// </summary>
        public HondaTruck()
        {
            Name = "Honda Truck";
        }
    }
}
