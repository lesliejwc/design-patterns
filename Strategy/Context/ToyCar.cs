using System;

namespace Strategy.Context
{
    public class ToyCar : Vehicle
    {
        public ToyCar(string name)
        {
            Name = name;
        }

        public override void Refuel()
        {
            if (Fuel != null)
            {
                Console.WriteLine(Name + "'s fuel type is invalid.");
            }
            else
            {
                Console.WriteLine(Name + " cannot be refueled.");
            }
        }
    }
}
