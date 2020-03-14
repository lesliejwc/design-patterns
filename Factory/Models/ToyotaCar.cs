namespace Factory.Models
{
    /// <summary>
    /// The car manufactured by Toyota.
    /// </summary>
    public class ToyotaCar : IVehicle
    {
        /// <summary>
        /// The name of the vehicle.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes an instance of the <see cref="ToyotaCar" /> class.
        /// </summary>
        public ToyotaCar()
        {
            Name = "Toyota Car";
        }
    }
}
