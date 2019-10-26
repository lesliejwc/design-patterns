using System.Collections.Generic;

namespace Observer
{
    /// <summary>
    /// A type of security that signifies proportionate ownership in the issuing
    /// corporation.
    /// </summary>
    public class Stock : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private double _value;

        /// <summary>
        /// Initializes an isntance of the <see cref="Stock"/> class.
        /// </summary>
        public Stock()
        {
            _value = 0.0;
        }

        /// <summary>
        /// The value.
        /// </summary>
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value >= 0.0)
                {
                    _value = value;
                    Notify();
                }
            }
        }

        /// <summary>
        /// register an observer to be notified when this object's state 
        /// changes.
        /// </summary>
        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// unregister an observer to stop it being notified of this object's
        /// state changes.
        /// </summary>
        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// logic to notify the registered observers.
        /// </summary>
        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
