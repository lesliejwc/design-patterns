# Strategy Pattern

### Definition

A behavioral software design pattern that enables selecting an algorithm at 
runtime. Instead of implementing a single algorithm directly into code, code 
receives run-time instructions as to which in a family of algorithms to use.


### Application

Where you have an object/s (context objects) with a common purpose that 
has variable behaviors (strategies) depending on the context of the object.


### Notes

- Adheres to open/closed principle
    - strategies are coupled with an abstraction, and are not 
    impacted by the increasing/decreasing number of strategies, or the changing 
    logic within these strategies.
    - uses composition instead of inheritance to decouple context objects from 
    the strategies.
