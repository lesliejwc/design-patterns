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

- Promotes loose coupling by reducing the dependency on concrete classes.

- Relies on inheritance, object creation is delegated to subclasses.

- Abstract Factory relies on object composition, object creation is implemented
  in methods exposed in the factory interface.

- Abstract Factory creates families of related objects without having to depend 
  on their concrete classes.

- Adheres to coding to abstractions and not to implementations.
