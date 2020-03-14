namespace Factory.Products
{
    /// <summary>
    /// The car manufactured by Honda.
    /// </summary>
    public class HondaCar : IVehicle
    {
        /// <summary>
        /// The name of the vehicle.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes an instance of the <see cref="HondaCar" /> class.
        /// </summary>
        public HondaCar()
        {
            Name = "Honda Car";
        }
    }
}
