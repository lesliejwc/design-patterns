namespace Factory.Models
{
    /// <summary>
    /// The motorcycle manufactured by Honda.
    /// </summary>
    public class HondaMotorcycle : IVehicle
    {
        /// <summary>
        /// The name of the vehicle.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes an instance of the <see cref="HondaMotorcycle" /> class.
        /// </summary>
        public HondaMotorcycle()
        {
            Name = "Honda Motorcycle";
        }
    }
}
