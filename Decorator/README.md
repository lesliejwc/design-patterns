# Decorator Pattern

### Definition

Attach additional responsibilities to an object dynamically. Decorators provide 
a flexible alternative to sub-classing for extending functionality.


### Application

Where you want to add or remove respsonsibilities (decorators) to individual 
objects (components) rather than the entire class. This is done dynamically and 
transparently, such that it doesn't affect other objects.


### Notes

- Decorator adds its own behaviour through composition, either before or after 
  delegating to the object it decorates to do the rest of the job.
    - Extension by inheritance is less flexible, children classes have no 
      control over the behaviours defined in the parent class. Behaviours are 
      also determined statically at compile time.

- Decorators have the same superclass type as the objects they decorate, so 
  decorated objects can be used in place of the original object.
    - If you depend on a concrete component type, you can't use the same 
      decorators and need to make new ones for this concrete component type. At
      this point you should re-think your design and if use of decorators is 
      appropriate.
