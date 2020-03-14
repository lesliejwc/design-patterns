namespace Factory.Models
{
    /// <summary>
    /// The truck manufactured by Mazda.
    /// </summary>
    public class MazdaTruck : IVehicle
    {
        /// <summary>
        /// The name of the vehicle.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes an instance of the <see cref="MazdaTruck" /> class.
        /// </summary>
        public MazdaTruck()
        {
            Name = "Mazda Truck";
        }
    }
}
