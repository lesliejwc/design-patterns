using System;

using Strategy.Behavior;

namespace Strategy.Model
{
    public abstract class Fruit
    {
        public ITaste Taste { get; set; }

        // initialize the fruit.
        protected Fruit()
        {
            // set default taste.
            Taste = new Tasteless();
        }

        public abstract void Eat();
    }
}
