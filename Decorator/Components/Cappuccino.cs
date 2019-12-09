﻿using System;

namespace Decorator.Components
{
    /// <summary>
    /// The Cappuccino, a type of beverage.
    /// </summary>
    public class Cappuccino : Beverage
    {
        // The beverage's name.
        private string _name;

        // The beverage's description.
        private string _description;

        // The beverage's cost.
        private double _cost;

        /// <summary>
        /// Initializes an instance of the <see cref="Cappuccino"/> class.
        /// </summary>
        public Cappuccino()
        {
            _name = "Cappuccino";
            _description = "Cappuccino";
            _cost = 4.00;
        }

        /// <summary>
        /// Gets the name of the beverage.
        /// </summary>
        /// <returns>The name.</returns>
        public override string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Gets the description of the beverage.
        /// </summary>
        /// <returns>The description.</returns>
        public override string GetDescription()
        {
            return _description;
        }

        /// <summary>
        /// Gets the cost of the beverage.
        /// </summary>
        /// <returns>The cost.</returns>
        public override double GetCost()
        {
            return _cost;
        }
    }
}
