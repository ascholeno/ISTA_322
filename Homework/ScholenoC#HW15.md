## Anthony Scholeno
## C# HW15



1. What is the difference between a property and a field?

A field you assign a value, with a property you have implementation. You use them both the same way.

2. What is the difference between a property and a method?

A property is basicallly information that an object has. Methods are what an object can do. Methods have paramater list, properties don't.

3. What is your understanding of encapsulation?

It packages and holds everything together.  

4. Some languages are case insensitive, that is, an "a" and an "A" are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?

In my limited experience with coding I have found this very issue to be a source of great frustration in creating and editing code. Particularly when moving between code that is case sensitive like C# and code that is not case sensitive like SQL. Using only case to differentiate identifiers can be a significant source of errors in code that are difficult to find. It also can also make the code more difficult to read an understand. I avoid this practice when writing code.

5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use a write-only property.

A read only property will be useful in any instance you want to be able to see a property, but not modify it such as a constant that will be used by multiple elements of a program. Write only properties are most useful for security measures such as passwords or anything else that requires an input, but should not be read back or accessible to be read back by the user.

6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.

I can not think of an instance where both getters and setters should be private, if they were both private the element would be inaccessible. The only possible instance I could think of (which I am fairly certain would not work) is if you were trying to hide a feature or element of a program, such as an Easter egg in a video game. Likewise I can not mount a meaningful defense for always making them both public except in instances where security is not an issue.

7. What are restrictions on the use of properties?

You can assign a value through a property of a structure or class only after the structure or class has been initialized. You can't use a property as a ref or an out argument to a method. A property can contain at most one get accessor and one set accessor and those accessors can not take any parameters. You can't declare properties by using const. 

8. What is an object initializer? What is the syntax for an object initializer?

You can use object initializers to initialize type objects in a declarative manner without explicitly invoking a constructor for the type.