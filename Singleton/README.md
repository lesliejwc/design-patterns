# Singleton Pattern

### Definition

Ensure a class only has one instance, and provide a global point of access to 
it.


### Application

Where you must have one and exactly one instance of a class, and also must be 
accessible from a well known access point.


### Notes

- variations:
    - eager initialization
    - lazy initialization
    - double-check lock
- lazy initialization is not thread safe
- can have performance issues in high traffic use cases when singleton is 
  locked to make it thread safe
