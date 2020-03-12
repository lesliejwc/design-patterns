using System;

namespace Strategy.Context
{
    public class Car : Vehicle
    {
        public Car(string name)
        {
            Name = name;
        }

        public override void Refuel()
        {
            if (Fuel != null)
            {
                Console.WriteLine(Name + " has been refueled with " + Fuel.Value + ".");
            }
            else
            {
                Console.WriteLine(Name + "'s fuel type has not been specified.");
            }
        }
    }
}
