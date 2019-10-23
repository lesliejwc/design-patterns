using Strategy.Behavior;

namespace Strategy.Model
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
