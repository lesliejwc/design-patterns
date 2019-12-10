# Principles of Software Design

Software Design principles promote good practices that allow software designs to
be more scalable, maintainable and understandable.



### Don't repeat yourself

Don't write duplicate code, more code means more maintainence. Abstract common 
functionality, but only if they are related to each other. Given two similar 
tasks with different purposes, using common code for them results in tightly 
coupling these two tasks together. Given they are two different tasks for two 
different purposes, their commonalities may not remain the same in future.



### Favor Composition over Inheritance

Code reuse is achieved through inheritance and composition, both with their own
advantages and disadvantages. In regard to this principle, composition also 
refers to association and aggregation.

Composition offers more flexibility, the behavior of the class can adapt 
dynamically to different situations, by changing the implementation of the 
associated class during run-time. Allowing it to be more tolerant to change.
While inheritance is more rigid; it breaks encapsulation, tightly coupled 
between the child and parent class, and is relatively harder to maintain.



### Occam's Razor

Also known as the law of parsimony, the name comes from Willian of Ockham, a 
scholastic philosopher and theologian. The principle states that:

> Entities are not to be multiplied without necessity.

Think about the benefits of adding new details or functionality to your 
solutions, if there are no valid benefits for the purpose of solving the 
problem, why would you increadse the complexity of your solution? Essentially, 
the simplest solution is most likely to be the most correct solution. 



### Encapsulate what varies

Isolate the code you expect to change, from what doesn't. This is achieved 
through encapsulation. Setting apart the related concerns from unrelated 
concerns, allows you to focus on the module's objective.

Implementations can be changed without affecting other unrelated parts of the 
software, giving you a more modular design where parts of the software are able 
to evolve independently of each other. Less code to be modified and tested, 
leads to more maintainable and adaptable software.



### Law of Demeter

Divide the areas of responsibilities to encourage low coupling between classes. 
Formally, the law of demeter requires that a method m of an object O may only 
invoke the methods of O itself, m's parameters, any objects created within m, 
O's direct component objects, and global variables accessible by O in the scope 
of m.

Essentially what that all means is, "don't talk to strangers". Entities should 
be independent and have limited knowledge about each other. Entities should only 
speak to its immediate friends; classes that they have direct access to. 



### Programming for Interface not implementation

Focus more on what the code does, rather than how it's done. The interface 
limits your knowledge, and provides you with how its supposed to be used. While 
with the implementation, the underlying knowledge on how it works is exposed,  
there are no safeguards from misuse, which likely leads to unexpected behaviours. 

The interface describes how to use it, and as long as how it's used doesn't 
change, the implementation can undergo changes without affecting those that use 
it. Leading to a more correct, flexible and maintainable design.



### Principle of least astonishment

Unexpected behaviours add to the debugging effort. Software behaviour should be 
intuitive and obvious. As a user whether it's the end user or another developer, 
the design should match the user's experience, expectectations and mental 
models. This aims to leverage pre-existing knowledge of users to minimize the 
learning curve to use the software.



### Avoid premature optimization

> "Premature optimization is the root of all evil (or at least most of it) in 
> programming"
> 
> \- Donald Knuth

Optimization aims to improve performance, readability, maintainability, and 
reudce consumption of resources, but optimizing in the early stages of 
development can be more detrimental than beneficial. Optimization takes time, 
effort, and possibly increase complexity. Quite often it is necessary to first 
verify correctness of the code, if it ends up not being correct, fixing the 
optimized solution is likely to be more difficult than fixing a simpler, less 
complex solution. Changing requirements is also a factor to consider. 
Re-optimization of the new corrected solution is likely required, adding even
more to the maintainence effort.



### SOLID principles

"SOLID" is an acronym for 5 software design principles targetted at 
object-oriented programming, but the concepts themselves can still be applied to 
other areas of software development.



#### Single Responsibility Principle

> "A class should have one, and only one, reason to change."
>
> \- Robert C. Martin

A class should have a single responsibility, this allows for the class to be 
highly cohesive and have low coupling between other classes. This will improve 
the flexibility and maintainability of the class, by reducing modifications 
required for new or changing requirements, as well as reduce testing needed.



#### Open-Closed Design

> "Software entities (classes, modules, functions, etc.) should be open for 
> extension, but closed for modification."
> 
> \- Bertrand Meyer

Write code so that you will be able to add new functionality, without modifying 
existing code. Existing code is tested and correct, avoiding modification of 
existing code makes the code easier to maintain. The ability to add new 
functionality allows the code to be more adaptable to change.



#### Liskov Substitution Principle (LSP)

> "Let Φ(x) be a property provable about objects x of type T. Then Φ(y) should 
> be true for objects y of type S where S is a subtype of T."
>
> \- Barbara Liskov

The principle describes, objects of a parent class should be replacable with 
objects of its child class without disrupting the integrity of the software. 
This requires the child class to behave the same as the parent class, this can 
be achieved in a few ways:

- Methods in the child class can implement less restrictive rules, but not 
  enforce stricter rules. Otherwise it could lead to unexpected behaviour in the 
  parent class. 
  
- Return values must also follow the same format as the parent class, or 
  else you would alter the behaviour of the module, violating the integrity of 
  the software.



#### Interface Segregation Principle

> "Clients should not be forced to depend upon interfaces that they do not use."
>
> \- Robert C. Martin

Interfaces describe the functionality, and from that you can infer the 
purpose and responsibility of the class. Using unsuitable interfaces for a given 
implementation forces it to implement unecessary methods. This adds confusion to 
the functionality and responsibility of the class, potentially results in misuse 
by other developers, as well as possibly produce unexpected behaviours.



#### Dependency Inversion principle

> "High level modules should not depend on low level module. Both should depend 
> on abstractions. Abstractions should not depend on details.  Details should 
> depend upon abstractions."

Modules and the components that make up the modules, should be reusable and 
unaffected by changes of each other. This is achieved through abstraction to 
decouple the high-level modules and low-level components from each other.
Allowing minimal interference to the integrity of the modules and components,
which lead to a more adaptable and maintainable design.



&nbsp;

## Definitions

#### Abstraction

> "An abstraction denotes the essential characteristics of an object that 
> distinguish it from all other kinds of objects and thus provide crisply 
> defined conceptual boundaries, relative to the perspective of the viewer"
>
> \- Grady Booch



#### Encapsulation

> "Encapsulation is the process of compartmentalizing the elements of an 
> abstraction that constitute its structure and its behavior; encapsulation 
> serves to separate the contractual interface of an abstraction and its 
> implementation."
>
> \- Grady Booch



#### Modularity

> "Modularity is the property of a system that has been decomposed into a set of
> cohesive and loosely coupled modules."
>
> \- Grady Booch



#### Hierarchy

> "Hierarchy is a ranking or ordering of abstractions"
>
> \- Grady Booch
