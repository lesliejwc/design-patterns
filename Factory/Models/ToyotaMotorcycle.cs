namespace Factory.Models
{
    /// <summary>
    /// The motorcycle manufactured by Toyota class.
    /// </summary>
    public class ToyotaMotorcycle : IVehicle
    {
        /// <summary>
        /// The name/model of the vehicle.
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
