namespace Factory.Models
{
    /// <summary>
    /// The car manufactured by Honda class.
    /// </summary>
    public class HondaCar : IVehicle
    {
        /// <summary>
        /// The name/model of the vehicle.
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
