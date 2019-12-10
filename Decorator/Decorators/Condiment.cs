using Decorator.Components;

namespace Decorator.Decorators
{
    /// <summary>
    /// The condiment class, may be added to beverages.
    /// </summary>
    public abstract class Condiment : IBeverage
    {
        // The beverage to add this condiment to.
        private IBeverage _beverage;

        /// <summary>
        /// Initializes an instance of the <see cref="Condiment"/> class.
        /// </summary>
        /// <param name="beverage">The beverage.</param>
        public Condiment(IBeverage beverage)
        {
            _beverage = beverage;
        }

        /// <summary>
        /// Gets the name of the beverage.
        /// </summary>
        /// <returns>The name.</returns>
        public virtual string GetName()
        {
            return _beverage.GetName();
        }

        /// <summary>
        /// Gets the description of the beverage.
        /// </summary>
        /// <returns>The description.</returns>
        public virtual string GetDescription()
        {
            return _beverage.GetDescription();
        }

        /// <summary>
        /// Gets the cost of the beverage.
        /// </summary>
        /// <returns>The cost.</returns>
        public virtual double GetCost()
        {
            return _beverage.GetCost();
        }
    }
}
