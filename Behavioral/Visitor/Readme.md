# Visitor Pattern

Open-Closes Principle in action
In this patter we use method overloading because we use the same method name with different types of parameters.

For example let's say we have an Operation interface with two methods: apply(heading) and apply(anchor)
then create a class with a concrete implementation of the interface.

We should use this solution only for object structure that are stables. Otherwise if we are adding new operations/type frequently then
we need to modify our interface and add all the classes that implement the interface.
