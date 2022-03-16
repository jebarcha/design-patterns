# Facade Design Pattern

The issue we try to solve is that we have too many classes and all those classes
are tightly couple with the main class and represent a lot of steps.

For example is we want to send a message, we need to connect first to the server,
then create a message, then get a token, then send the message and then disconnect from the server.
What if we have more steps or things to do, then we need to add more classes and tight it.

To reduce coupling we can add a new class NotificationService which will take care of
sending the message with all needed steps.

### Facade means Front or Face
So a NotificationService class is acting as a facade or front from an notification system.






