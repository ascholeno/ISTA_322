## Name: Anthony Scholeno
## File: C# HW 17

1. What is a type parameter?

A generic parameter placeholder to substitute an explicit type declaration.

2. What does a type parameter do?

It specifies a generic type name. It can be used to declare the return type and act as placeholders for the type of the arguments passed to the generic method.

3. How many type parameters can a generic class have?

A generic class can have many type parameters with no specified limit. (Unlimited)

4. What is the difference between a generic class and a generalized class?

generic class uses type parameters is different from a generalized 
class designed to take parameters that can be cast to different types.


5. What is a constraint? How do you specify a constraint?

you can limit the type parameters of a generic class to those that implement a particular set of interfaces and therefore provide the methods defi ned by those interfaces
where keyword ( where T : IPrintable )

6. What is a generic method? How do you define a generic method?

A generic method can specify the types of the parameters and the return type by using a type parameter in a manner similar to that used when you define a generic class. You define generic methods by using the same type parameter syntax you use when you create generic classes

7. What do we mean when we say that a generic type interface is invariant?

invariant generic type parameter is neither covariant no contravariant.

8. What do we mean when we say that a generic type interface is covariant?

It means that it must follow the folowing conditions: they type parameter is used only as a return type of interface mthods and not used as a type of method arguments.

9. Does covariance work with value types? Does it work with reference types?

Covariance only works with reference types does not work with value types.

10. What do we mean when we cay that a generic type interface is contravariant?

Contravariance follows a similar principle to covariance except that it works in the opposite direction; it enables you to use a generic interface to reference an object of type B through a reference to type A as long as type B derives from type A. 
