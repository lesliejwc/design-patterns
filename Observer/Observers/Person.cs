using System;

using Observer.Subjects;

namespace Observer.Observers
{
    /// <summary>
    /// A person.
    /// </summary>
    public class Person : IObserver
    {
        /// <summary>
        /// Initializes an instance of the <see cref="Person"/> class.
        /// </summary>
        public Person(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The person's name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Handles state changes of the subject/s the person is observing.
        /// </summary>
        public void Update(ISubject subject)
        {
            Console.WriteLine("Notified {0} of {1}'s value change to {2:C}",
                              Name, subject.GetType().Name, subject.Value);
        }
    }
}
