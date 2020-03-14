namespace Factory.Models
{
    /// <summary>
    /// The car manufactured by Mazda.
    /// </summary>
    public class MazdaCar : IVehicle
    {
        /// <summary>
        /// The name of the vehicle.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes an instance of the <see cref="MazdaCar" /> class.
        /// </summary>
        public MazdaCar()
        {
            Name = "Mazda Car";
        }
    }
}
