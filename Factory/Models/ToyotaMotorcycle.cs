namespace Factory.Models
{
    /// <summary>
    /// The motorcycle manufactured by Toyota.
    /// </summary>
    public class ToyotaMotorcycle : IVehicle
    {
        /// <summary>
        /// The name of the vehicle.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes an instance of the <see cref="ToyotaMotorcycle" /> class.
        /// </summary>
        public ToyotaMotorcycle()
        {
            Name = "Toyota Motorcycle";
        }
    }
}
