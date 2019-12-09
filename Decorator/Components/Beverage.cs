namespace Decorator.Components
{
    /// <summary>
    /// The beverage.
    /// </summary>
    public abstract class Beverage
    {
        /// <summary>
        /// Gets the name of the beverage.
        /// </summary>
        /// <returns>The name.</returns>
        public abstract string GetName();

        /// <summary>
        /// Gets the description of the beverage.
        /// </summary>
        /// <returns>The description.</returns>
        public abstract string GetDescription();

        /// <summary>
        /// Gets the cost of the beverage.
        /// </summary>
        /// <returns>The cost.</returns>
        public abstract double GetCost();
    }
}
