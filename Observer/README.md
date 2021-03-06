# Observer Pattern

### Definition

Define a one-to-many dependency between objects so that when one object changes 
state, all its dependents are notified and updated automatically.


### Application

Where you have an object/s, the observers, that are dependent on another object, 
the subject, such that observers require changes to be made when the subject 
changes. 


### Notes

- Favours composition over inheritance.
    - The subject keeps track its observers through a list, which is actually 
      composition set up in runtime.
- One-to-many dependency between objects can be defined without being tightly 
  coupled.
    - The subject knows about the observers, and updates them through a common 
      interface, allowing them to be loosely coupled.
- The observers can be changed dynamically in run-time.
- Observers do not necessarily receive updates in the same order as how they 
  were implemented.
- Large monolithic design does not scale well, the more observers within the 
  application, the less responsive it becomes.
    - Implementing a one-to-many dependency between objects is an option if 
      performance is important. It will cause tight coupling, may be harder to 
      implement, but compiler can detect errors at compile time, and optimize 
      the code at CPU instruction level better.
- can cause memory leaks, implementation requires explicit registration and 
  explicit de-registration, meaning it holds strong references to the observers, 
  keeping them alive. This can be mitigated by the subject holding weak 
  references to the observers.
- Similar to publisher-subscriber pattern, but they are not the same. 
  Publishers, do not program the messages to be sent directly to specific 
  subscribers. Meaning publishers and subscribers do not know the existence 
  of one another.
