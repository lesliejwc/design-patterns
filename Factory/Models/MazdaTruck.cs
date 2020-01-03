namespace Factory.Models
{
    /// <summary>
    /// The truck manufactured by Mazda class.
    /// </summary>
    public class MazdaTruck : IVehicle
    {
        /// <summary>
        /// The name/model of the vehicle.
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
