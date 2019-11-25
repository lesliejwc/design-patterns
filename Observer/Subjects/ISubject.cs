using Observer.Observers;

namespace Observer.Subjects
{
    /// <summary>
    /// The subject.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// The value, a representation of the subjects state.
        /// </summary>
        double Value { get; set; }

        /// <summary>
        /// Register an observer to allow it to be notified of state changes.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Register(IObserver observer);

        /// <summary>
        /// Remove an observer from being notified anymore.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Unregister(IObserver observer);

        /// <summary>
        /// Notifies the registered observers that a change has occurred.
        /// </summary>
        void Notify();
    }
}
