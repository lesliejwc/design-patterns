using System;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // the subject.
            Stock companyStock = new Stock();

            // the observers.
            Person personA = new Person("Warren");
            Person personB = new Person("Thomas");

            // watch the stock prices.
            companyStock.Register(personA);
            companyStock.Register(personB);

            // state changes.
            companyStock.Value = 10.1;
            companyStock.Value = 10.5;
            companyStock.Value = 9.4;
        }
    }
}
