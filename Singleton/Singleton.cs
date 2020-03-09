using System;

namespace Singleton
{
    /// <summary>
    /// The singleton.
    /// </summary>
    public class Singleton
    {
        private static readonly object syncLock = new object();
        private static Singleton _instance;

        // prevent direct instantiation calls with the `new` operator.
        private Singleton() { }

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        public static Singleton GetInstance()
        {
            lock (syncLock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
}
