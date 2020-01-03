# Factory Pattern

### Definition

Define an interface for creating an object, but let subclasses decide which 
class to instantiate. Factory method lets a class defer instantiation to 
subclasses.


### Application

Where a class can't anticipate the class of objects it must create, or you want
the subclasses to decide the objects to create.


### Notes

- Encapsulates object creation.
- Promotes loose coupling by reducing the dependency on concrete classes.
- Relies on inheritance, object creation is delegated to subclasses.
- Abstract Factory relies on object composition, object creation is implemented
  in methods exposed in the factory interface.
- Abstract Factory creates families of related objects without having to depend 
  on their concrete classes.
- Adheres to dependency inversion principle, and coding to abstractions and not 
  implementations.
