using Strategy.Strategies;

namespace Strategy.Context
{
    public abstract class Vehicle
    {
        public string Name { get; protected set; }
        public IFuel Fuel { get; set; }

        protected Vehicle()
        {
            // default behavior logic.
        }

        public abstract void Refuel();
    }
}
