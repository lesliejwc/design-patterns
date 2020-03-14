# Strategy Pattern

### Definition

Define a family of algorithms, encapsulate each one, and make them 
interchangeable. Strategy lets the algorithm vary independently from clients 
that use it.


### Application

Where you have related classes, known as the context, that have one of many 
behaviours known as strategies, you can configure a class to one of these many 
behaviours to suit the context of the situation.


### Notes

- Adheres to open/closed principle
    - Strategies are coupled with an abstraction, and are not impacted by the 
      increasing/decreasing number of strategies, or the changing logic within 
      these strategies.
- Uses composition instead of inheritance to decouple context objects from the 
  strategies.
- Strategies are interchangable dynamically at run-time.
