# Singleton Pattern

### Definition

Ensure a class only has one instance, and provide a global point of access to 
it.


### Application

Where you must have one and exactly one instance of a class, and also must be 
accessible from a well known access point.


### Notes

- lazy initialization is not thread safe
- can have performance issues in high traffic use cases when singleton is 
  locked to make it thread safe
- variations:
    - eager initialization
        - instance is created even though it may not have been used
        - does not have multi-threading issues
    - lazy initialization
        - has multi-threading issues
            - if two or more calls are made to retrieve the singleton, where the 
              instance has not yet been instantiated, this can result in 
              multiple instantiations of the singleton.
            - fixed by thread synchronization
        - by using thread synchronization to fix the concurrency issues, it 
          slows down performance because of a blocking operation that comes from 
          synchronizing threads.
    - double-check lock
        - solves multi-threading issues as well as no hit to performance.
        - only performs a synchronized task when the check for the singleton 
          instance is null
          
