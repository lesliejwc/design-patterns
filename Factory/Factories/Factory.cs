using Factory.Models;

namespace Factory.Factories
{
    /// <summary>
    /// The base factory class.
    /// </summary>
    public abstract class Factory
    {
        /// <summary>
        /// Initializes an instance of the <see cref="Factory" /> class.
        /// </summary>
        public Factory()
        {
            // do some stuff.
        }
        
        /// <summary>
        /// Manufacture the vehicle.
        /// </summary>
        public abstract IVehicle Manufacture(string type);
    }
}
