namespace Decorator.Components
{
    /// <summary>
    /// The beverage.
    /// </summary>
    public interface IBeverage
    {
        /// <summary>
        /// Gets the name of the beverage.
        /// </summary>
        /// <returns>The name.</returns>
        string GetName();

        /// <summary>
        /// Gets the description of the beverage.
        /// </summary>
        /// <returns>The description.</returns>
        string GetDescription();

        /// <summary>
        /// Gets the cost of the beverage.
        /// </summary>
        /// <returns>The cost.</returns>
        double GetCost();
    }
}
