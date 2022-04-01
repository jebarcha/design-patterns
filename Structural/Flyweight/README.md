# Flyweight Design Pattern

We use this pattern in applications when we have a large number of objects
and those objects takes a significat amount of memory.
With the flyweight pattern we can reduce the amount of memory consume by these objects.

For example in a map application we can have a list of points and the point object 
contains x, y, type and the icon which can be very big. So in a list we would use
a big amount of memory.
To solve this problem, we can use the flyweight pattern.
We can extract the type and icon in a separate class (because those 2 are close related)
then use a Factory class that returns the object depending on the type we send as a parameter.



