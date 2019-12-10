namespace Decorator.Components
{
    /// <summary>
    /// The Macchiato, a type of beverage.
    /// </summary>
    public class Macchiato : IBeverage
    {
        // The beverage's name.
        private string _name;

        // The beverage's description.
        private string _description;   

        // The beverage's cost.
        private double _cost;

        /// <summary>
        /// Initializes an instance of the <see cref="Macchiato"/> class.
        /// </summary>
        public Macchiato()
        {
            _name = "Macchiato";
            _description = "Macchiato";
            _cost = 4.50;
        }

        /// <summary>
        /// Gets the name of the beverage.
        /// </summary>
        /// <returns>The name.</returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Gets the description of the beverage.
        /// </summary>
        /// <returns>The description.</returns>
        public string GetDescription()
        {
            return _description;
        }

        /// <summary>
        /// Gets the cost of the beverage.
        /// </summary>
        /// <returns>The cost.</returns>
        public double GetCost()
        {
            return _cost;
        }
    }
}
