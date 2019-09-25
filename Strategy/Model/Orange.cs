using System;

namespace Strategy.Model
{
    public class Orange : Fruit
    {
        public Orange()
        {
        }

        public override void Eat()
        {
            Console.WriteLine("This orange is " + Taste.Value + ".");
        }
    }
}
