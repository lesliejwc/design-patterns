using System;

using Decorator.Components;
using Decorator.Decorators;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // latte.
            IBeverage latte = new Latte();
            latte = new Milk(latte);
            latte = new SoyMilk(latte);

            Console.WriteLine("This {0} consists of: {1} and costs ${2}.",
                              latte.GetName(),
                              latte.GetDescription(),
                              latte.GetCost());

            // cappuccino.
            IBeverage cappuccino = new Cappuccino();
            cappuccino = new Chocolate(cappuccino);
            cappuccino = new VanillaExtract(cappuccino);
            cappuccino = new Chocolate(cappuccino);

            Console.WriteLine("This {0} consists of: {1} and costs ${2}.",
                              cappuccino.GetName(),
                              cappuccino.GetDescription(),
                              cappuccino.GetCost());
        }
    }
}
