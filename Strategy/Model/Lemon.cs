using System;

namespace Strategy.Model
{
    public class Lemon : Fruit
    {
        public Lemon()
        {
        }

        public override void Eat()
        {
            Console.WriteLine("This lemon is " + Taste.Value + ".");
        }
    }
}
