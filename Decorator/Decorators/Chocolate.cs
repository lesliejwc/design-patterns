using Decorator.Components;

namespace Decorator.Decorators
{
    /// <summary>
    /// The chocolate class, a type of condiment.
    /// </summary>
    public class Chocolate : Condiment
    {
        // condiment's description.
        private string _description;

        // condiment's cost.
        private double _cost;

        /// <summary>
        /// Initializes an instance of the <see cref="Chocolate"/> class.
        /// </summary>
        /// <param name="beverage">The beverage.</param>
        public Chocolate(IBeverage beverage)
            : base(beverage)
        {
            _description = ", chocolate";
            _cost = 1.00;
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
