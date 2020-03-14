using Factory.Models;

namespace Factory.Factories
{
    /// <summary>
    /// The factory base class.
    /// </summary>
    public abstract class FactoryBase
    {
        /// <summary>
        /// Manufacture the vehicle.
        /// </summary>
        /// <param name="type">The class of vehicle.</param>
        /// <returns>The vehicle.</returns>
        public abstract IVehicle Manufacture(string type);
    }
}
