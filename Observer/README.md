# Observer Pattern

### Definition

Define a one-to-many dependency between objects so that when one object changes 
state, all its dependents are notified and updated automatically.


### Application

You have an object called the subject, where whenever its state changes, you 
can notify other objects who want to know about the state changes 
(called observers), that the subject's state has changed. Observers may be 
added or removed independently at runtime.


### Notes

- one-to-many dependency between objects can be defined without being tightly 
coupled.
- large monolithic design does not scale well, the more observers within the 
application, the less responsive it becomes.
    - implementing a one-to-many dependency between objects is an option if 
    performance is important. It will cause tight coupling, may be harder to 
    implement, but compiler can detect errors at compile time, and optimize the 
    code at CPU instruction level better.
- can cause memory leaks, implementation requires explicit registration and 
explicit de-registration, meaning it holds strong references to the observers, 
keeping them alive. This can be mitigated by the subject holding weak 
references to the observers.
- similar to publisher-subscriber pattern, but they are not the same.
    - publishers, do not program the messages to be sent directly to specific 
    subscribers. Meaning publishers and subscribers do not know the existence 
    of one another.
