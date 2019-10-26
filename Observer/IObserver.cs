namespace Observer
{
    /// <summary>
    /// The observer.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Handles state changes of the subject/s the observer is observing.
        /// </summary>
        void Update(ISubject subject);
    }
}
