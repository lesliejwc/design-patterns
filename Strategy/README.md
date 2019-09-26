# Strategy Pattern

### Introduction

The strategy pattern is a behavioral design pattern that allows an algorithm 
(strategy) to be executed based on context, these algorithms are interchangable 
at runtime. Useful when you have a set of objects with a common aspect with 
variable behaviors depending on the context of the object.


### Implementation

The implementation illustrates the example of eating fruits. All fruits can 
be eaten which is the common property among them, but different fruits have 
different tastes, but also two fruits of the same type do not neccessarily 
taste the same. An apple could be sweet or sour. The tastes are encapsulated 
into the fruits, and act as delegates to execute these behaviors.
