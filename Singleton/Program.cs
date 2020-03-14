using System;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton tests:");

            // thread 1
            Task.Run(() =>
            {
                EagerInitSingleton es1 = EagerInitSingleton.GetInstance();
                Console.WriteLine("Thread 1 - Eager initialized singleton: " + es1.GetHashCode());

                LazyInitSingleton ls1 = LazyInitSingleton.GetInstance();
                Console.WriteLine("Thread 1 - Lazy initialized singleton: " + ls1.GetHashCode());

                DoubleCheckLockSingleton ds1 = DoubleCheckLockSingleton.GetInstance();
                Console.WriteLine("Thread 1 - Double-check lock singleton: " + ds1.GetHashCode());
            });

            // thread 2
            Task.Run(() =>
            {
                EagerInitSingleton es2 = EagerInitSingleton.GetInstance();
                Console.WriteLine("Thread 2 - Eager initialized singleton: " + es2.GetHashCode());

                // may yield different instance, but not neccessarily.
                LazyInitSingleton ls2 = LazyInitSingleton.GetInstance();
                Console.WriteLine("Thread 2 - Lazy initialized singleton: " + ls2.GetHashCode());

                DoubleCheckLockSingleton ds2 = DoubleCheckLockSingleton.GetInstance();
                Console.WriteLine("Thread 2 - Double-check lock singleton: " + ds2.GetHashCode());
            }); 
        }
    }
}
