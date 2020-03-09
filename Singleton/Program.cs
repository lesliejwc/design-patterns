using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton inst1 = Singleton.GetInstance();
            Singleton inst2 = Singleton.GetInstance();

            if (inst1 == inst2)
            {
                Console.WriteLine("Same instance");
            }
            else
            {
                Console.WriteLine("Not the same");
            }
        }
    }
}
