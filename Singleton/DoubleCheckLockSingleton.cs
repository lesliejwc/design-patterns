namespace Singleton
{
    /// <summary>
    /// Double-check lock singleton implementation.
    /// </summary>
    public class DoubleCheckLockSingleton
    {
        // thread synchronization lock.
        private static readonly object syncLock = new object();

        // creates instance when we need it.
        private static volatile DoubleCheckLockSingleton _instance;

        // prevent direct instantiation.
        private DoubleCheckLockSingleton() { }

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        public static DoubleCheckLockSingleton GetInstance()
        {   
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new DoubleCheckLockSingleton();
                    }
                }                
            }

            return _instance;
        }
    }
}
