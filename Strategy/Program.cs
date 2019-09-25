using Strategy.Behavior;
using Strategy.Model;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Orange orange = new Orange();
            Lemon lemon = new Lemon();

            // dynamically change fruit's behavior at runtime.
            apple.Taste = new SweetTaste();
            lemon.Taste = new SourTaste();

            apple.Eat();
            orange.Eat();
            lemon.Eat();
        }
    }
}
