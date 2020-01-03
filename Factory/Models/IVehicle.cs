namespace Factory.Models
{
    /// <summary>
    /// The base for vehicles.
    /// </summary>
    public interface IVehicle
    {
        /// <summary>
        /// The name/model of the vehicle.
        /// </summary>
        string Name { get; }
    }
}
