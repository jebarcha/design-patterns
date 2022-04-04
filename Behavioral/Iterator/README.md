# Iterator Design Pattern

Allows to access and traverse the elements of a collection without the need to understand
or expose the underlying structure of the collection. (List, array, etc.)

We create an interface to define the capabilities of our iterator.
So we can implement that interface in our classes, for example we can have
a class ListIterator and an ArrayIterator that implements IIterator interface.

