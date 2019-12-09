using Decorator.Components;

namespace Decorator.Decorators
{
    /// <summary>
    /// The condiment class, may be added to beverages.
    /// </summary>
    public abstract class Condiment : Beverage
    {
        // The beverage to add this condiment to.
        protected Beverage _beverage;

        /// <summary>
        /// Initializes an instance of the <see cref="Condiment"/> class.
        /// </summary>
        /// <param name="beverage">The beverage.</param>
        public Condiment(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}
