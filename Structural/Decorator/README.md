# Decorator Design Pattern

We use this patter to add additional behavior to an object.

For example implement a class to store data in the cloud
Then we need to encrypt that data (to not store it in plain text)
Then also we need to compress the data.
And so on we can have more requirements like encrypt and also compress the data,
so need to add more classes to combine features and our structure can become complex.

This problem is solved using the decorator pattern adding aditional behavior to our object.
So in our main program we can have our regular class (for example CloudStream) and decorate it with additional behavior
like adding compression, encryption, logging, etc.

It is similar than the **Adapter pattern**. In the Adapter pattern we change the interface of a class to 
a different form and with the **Decorator pattern** we add additional behavior to an object.
In both patterns, in both implementatons we use **Composition**
