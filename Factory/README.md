# Factory Pattern

### Definition

Define an interface for creating an object, but let subclasses decide which 
class to instantiate. Factory method lets a class defer instantiation to 
subclasses.


### Application

When a class can't anticipate the class of objects it must create, a factory 
method can be used to solve this issue. 


### Notes

- Encapsulates object creation.
- Promotes loose coupling, decouples clients from concrete classes.
- Relies on inheritance, object creation is delegated to subclasses.
- Adheres to coding to abstractions and not to implementations.
- variations:
    - simple factory
    - factory method
