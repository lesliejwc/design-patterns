using System;

namespace Strategy.Model
{
    public class Apple : Fruit
    {
        public Apple()
        {
        }

        public override void Eat()
        {
            Console.WriteLine("This apple is " + Taste.Value + ".");
        }
    }
}
