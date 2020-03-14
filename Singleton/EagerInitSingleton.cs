namespace Singleton
{
    /// <summary>
    /// Eager initialization singleton implementation.
    /// </summary>
    public class EagerInitSingleton
    {
        // creates instance as the class is loaded.
        private static EagerInitSingleton _instance = new EagerInitSingleton();

        // prevent direct instantiation.
        private EagerInitSingleton() { }

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        public static EagerInitSingleton GetInstance()
        {
            return _instance;
        }
    }
}
