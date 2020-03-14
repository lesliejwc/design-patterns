namespace Singleton
{
    /// <summary>
    /// Lazy initialization singleton implementation.
    /// </summary>
    public class LazyInitSingleton
    {
        // creates instance when we need it.
        private static LazyInitSingleton _instance;

        // prevent direct instantiation.
        private LazyInitSingleton() { }

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        public static LazyInitSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LazyInitSingleton();
            }

            return _instance;
        }
    }
}
