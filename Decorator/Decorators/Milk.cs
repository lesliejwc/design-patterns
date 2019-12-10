using Decorator.Components;

namespace Decorator.Decorators
{
    /// <summary>
    /// The milk class, a type of condiment.
    /// </summary>
    public class Milk : Condiment
    {
        // condiment's description.
        private string _description;

        // condiment's cost.
        private double _cost;

        /// <summary>
        /// Initializes an instance of the <see cref="Milk"/> class.
        /// </summary>
        /// <param name="beverage">The beverage.</param>
        public Milk(IBeverage beverage)
            : base(beverage)
        {
            _description = ", milk";
            _cost = 0.0;
        }

        /// <summary>
        /// Gets the name of the beverage.
        /// </summary>
        /// <returns>The name.</returns>
        public override string GetName()
        {
            return base.GetName();
        }

        /// <summary>
        /// Gets the description of the beverage.
        /// </summary>
        /// <returns>The description.</returns>
        public override string GetDescription()
        {
            return base.GetDescription() + _description;
        }

        /// <summary>
        /// Gets the cost of the beverage.
        /// </summary>
        /// <returns>The cost.</returns>
        public override double GetCost()
        {
            return base.GetCost() + _cost;
        }
    }
}
