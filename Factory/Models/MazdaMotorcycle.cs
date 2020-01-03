namespace Factory.Models
{
    /// <summary>
    /// The motorcycle manufactured by Mazda class.
    /// </summary>
    public class MazdaMotorcycle : IVehicle
    {
        /// <summary>
        /// The name/model of the vehicle.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes an instance of the <see cref="MazdaMotorcycle" /> class.
        /// </summary>
        public MazdaMotorcycle()
        {
            Name = "Mazda Motorcycle";
        }
    }
}