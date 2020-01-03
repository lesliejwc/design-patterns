namespace Factory.Models
{
    /// <summary>
    /// The truck manufactured by Honda class.
    /// </summary>
    public class HondaTruck : IVehicle
    {
        /// <summary>
        /// The name/model of the vehicle.
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
