using Decorator.Components;

namespace Decorator.Decorators
{
    /// <summary>
    /// The soy milk class, a type of condiment.
    /// </summary>
    public class SoyMilk : Condiment
    {
        // condiment's description.
        private string _description;

        // condiment's cost.
        private double _cost;

        /// <summary>
        /// Initializes an instance of the <see cref="SoyMilk"/> class.
        /// </summary>
        /// <param name="beverage">The beverage.</param>
        public SoyMilk(Beverage beverage)
            : base(beverage)
        {
            _description = ", soy milk";
            _cost = 1.50;
        }

        /// <summary>
        /// Gets the name of the beverage.
        /// </summary>
        /// <returns>The name.</returns>
        public override string GetName()
        {
            return _beverage.GetName();
        }

        /// <summary>
        /// Gets the description of the beverage.
        /// </summary>
        /// <returns>The description.</returns>
        public override string GetDescription()
        {
            return _beverage.GetDescription() + _description;
        }

        /// <summary>
        /// Gets the cost of the beverage.
        /// </summary>
        /// <returns>The cost.</returns>
        public override double GetCost()
        {
            return _beverage.GetCost() + _cost;
        }
    }
}
