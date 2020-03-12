using Strategy.Context;
using Strategy.Strategies;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car carA = new Car("Car A");
            Car carB = new Car("Car B");
            Plane plane = new Plane("Plane");
            ToyCar toy = new ToyCar("Toy car");

            // set behavior.
            carA.Fuel = new UnleadedPetrol();
            carB.Fuel = new Diesel();
            plane.Fuel = new JetFuel();

            carA.Refuel();
            carB.Refuel();
            plane.Refuel();
            toy.Refuel();
        }
    }
}
