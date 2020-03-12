# Introduction

Software design principles are a set of guidelines to help promote better 
software design. Based on fundamental concepts, a greater understanding to these 
concepts will allow you to see how and why application of these principles will 
lead your designs to be more maintainable, understandable and flexible.



# Fundamental Software Design Concepts

The object model, on which object-oriented design was based upon, is composed of
principles of abstraction, encapsulation, modularity, hierarchy, typing, 
concurrency, and persistence. 

The key concepts to focus on are abstraction, encapsulation, modularity and hierarchy. These are the definitions as defined by Grady Booch:

An **abstraction** denotes the essential characteristics of an object that 
distinguish it from all other kinds of objects and thus provide crisply 
defined conceptual boundaries, relative to the perspective of the viewer.

**Encapsulation** is the process of compartmentalizing the elements of an 
abstraction that constitute its structure and its behavior; encapsulation 
serves to separate the contractual interface of an abstraction and its 
implementation.

**Modularity** is the property of a system that has been decomposed into a set of
cohesive and loosely coupled modules.

**Hierarchy** is a ranking or ordering of abstractions.



# Software Design Principles

### Don't repeat yourself

Don't write duplicate code, more code means more maintainence. Abstract common 
functionality, but only if they are related to each other. Given two similar 
tasks with different purposes, using common code for them results in tightly 
coupling these two tasks together. Given they are two different tasks for two 
different purposes, their commonalities may not remain the same in future.


### Occam's Razor

Also known as the law of parsimony, the name comes from Willian of Ockham, a 
scholastic philosopher and theologian. The principle states that:

> Entities are not to be multiplied without necessity.

Think about the benefits of adding new details or functionality to your 
solutions, if there are no valid benefits for the purpose of solving the 
problem, why would you increadse the complexity of your solution? Essentially, 
the simplest solution is most likely to be the most correct solution. 


### Keep It Simple, Stupid

The simplier a system is, the easier it is to maintain. An increase in 
complexity, also means an increase in debugging effort required to maintain and 
improve the software.


### You Aren't Gonna Need It

Don't build things for the sake of future-proofing. The extra effort spent 
implementing and debugging these, could be spent more productively elsewhere.
Requirements change, your understanding of the problem changes, and these could  
result in your extra efforts becoming obselete.


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


### Encapsulate what varies

Isolate the code you expect to change, from what doesn't. This is achieved 
through encapsulation. Setting apart the related concerns from unrelated 
concerns, allows you to focus on the module's objective.

Implementations can be changed without affecting other unrelated parts of the 
software, giving you a more modular design where parts of the software are able 
to evolve independently of each other. Less code to be modified and tested, 
leads to more maintainable and adaptable software.


### Programming for Interface not Implementation

Focus more on what the code does, rather than how it's done. The interface 
limits your knowledge, and provides you with how its supposed to be used. While 
with the implementation, the underlying knowledge on how it works is exposed,  
there are no safeguards from misuse, which likely leads to unexpected behaviours. 

Interface is not limited to literal interfaces, but the same concept applies to 
an abstraction. It describes how to use the underlying class, and as long as how 
it's used doesn't change, the implementation can undergo changes without 
affecting those that use it. Leading to a more correct, flexible and 
maintainable design.


### Favor Composition over Inheritance

Code reuse is achieved through inheritance and composition, both with their own
advantages and disadvantages. In regard to this principle, composition also 
refers to association and aggregation.

Composition offers more flexibility, the behavior of the class can adapt 
dynamically to different situations, by changing the implementation of the 
associated class during run-time. Allowing it to be more tolerant to change.
While inheritance is more rigid; it breaks encapsulation, tightly coupled 
between the child and parent class, and is relatively harder to maintain.


### Law of Demeter

Divide the areas of responsibilities to encourage low coupling between classes. 
Formally, the law of demeter requires that a method m of an object O may only 
invoke the methods of O itself, m's parameters, any objects created within m, 
O's direct component objects, and global variables accessible by O in the scope 
of m.

Essentially what that all means is, don't talk to strangers. Entities should be 
independent and have limited knowledge about each other. Entities should only 
speak to its immediate friends; classes that they have direct access to. 


### Principle of Least Astonishment

Unexpected behaviours add to the debugging effort. Software behaviour should be 
intuitive and obvious. As a user whether it's the end user or another developer, 
the design should match the user's experience, expectectations and mental 
models. This aims to leverage pre-existing knowledge of users to minimize the 
learning curve to use the software.

---

### The principle of Least Effort
This principle (also called Zipf’s Law) stems from a basic human behaviour: Everyone tends to follow the path that is as close to effortless as possible. So for example if our design follows a particular pattern, the next developer will follow the same pattern again and again unless there is a significantly easier way to perform the task, in which case they will change! Or, taking this further, once they find acceptable results for a task, there is no immediate need to improve the current solution.
Least effort is a variant of least work
As such it is imperative to aim for a strong start by putting the right architecture in place: it sets high expectations and ensures everyone understands that the quality is not compromised in the project’s lifecycle and it will be adhered to in case of future changes.
For me, the greatness of this principle lies in the fact that its benefits extrapolate: once we put a right design in place, we can create an architectural framework which will be the basis of the next systems we build. In other words, we are able to establish a successful and future-proof template for the organisation’s software systems.

### The principle of Opportunity Cost
Every time we make a choice, there is a certain value we place on that choice. Value has two parts: benefits and costs. The opportunity cost of a choice is what we give up to get it. To make a good economic decision, we want to choose the option with the greatest benefit to us but the lowest cost.
For example, if we have two choices, either an in-house built system or an off-the-shelf vendor product and we choose the latter, then our opportunity cost is the shiny new system our development team could have developed but didn’t.
This is what architecture is all about: weighing choices against each other and trying to make an informed decision on which one will add the most value for the project. For instance, a very common dichotomy is whether to create a tactical solution with quick time to market or a more strategic one which will be more expensive now with the view to leverage it in future projects and hence minimise the cost later down the line.
Here are some points to consider:
What is the time available for the architectural analysis/evaluation? It is challenging enough to come up with one solution, let alone a few!
What is the product pipeline for the next 1–3 years? And what other projects are lined up? Can you see any synergies?
What is your current technical debt that you could potentially address?
And turning this around: How much new technical debt will incur if you pursue a tactical solution?
Which quality attributes tend to be the most important for systems in your organisation and how will they be compromised by the proposed solution?
Apart from the architecture team who else is a stakeholder that will affect the decision? The Business? Your boss? The Technical Design Authority? What are the key objectives of each stakeholder? How will you mitigate conflicting needs?

### The principle of Last Responsible Moment
This principle (aka Cost of Delay) originates from Lean Software Development and emphasises holding on taking important actions and crucial decisions for as long as possible. This is done so as to not eliminate important alternatives until the last possible moment i.e. wait to narrow the options down until you are better informed.
A strategy of not making a premature decision but instead delaying commitment and keeping important and irreversible decisions open until the cost of not making a decision becomes greater than the cost of making a decision.
One way to mitigate the risk of deciding too late is to build Proof of Concepts (POCs) to prototype the alternative options and demonstrate to the stakeholders what they are asking for.

---



### SOLID Principles

"SOLID" is an acronym for 5 software design principles specific to 
object-oriented programming.


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



#### Liskov Substitution Principle

> "Let Φ(x) be a property provable about objects x of type T. Then Φ(y) should 
> be true for objects y of type S where S is a subtype of T."
>
> \- Barbara Liskov

The objects of a parent class should be replacable with objects of its child 
class without disrupting the integrity of the software. This requires the child 
class to behave the same as the parent class, as well as the following:

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
the functionality and responsibility of the class, can lead to potential misuse 
and unexpected behaviours.



#### Dependency Inversion Principle

> "High level modules should not depend on low level module. Both should depend 
> on abstractions. Abstractions should not depend on details.  Details should 
> depend upon abstractions."

Modules and the components that make up the modules, should be reusable and 
unaffected by changes of each other. This is achieved through abstraction to 
decouple the high-level modules and low-level components from each other.
Allowing minimal interference to the integrity of the modules and components,
which lead to a more adaptable and maintainable design.

