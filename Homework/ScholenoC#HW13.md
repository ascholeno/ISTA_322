# Programming in C# Chapter 13 Homework
### Anthony Scholeno

1. What is an interface as the term is used in object oriented programming?

An interface does not contain any code or data; it just specifies the methods and properties that a class that inherits from the interface must provide. 

2. How do you define an interface?

Defining an interface is syntactically similar to defining a class, except that you use the interface keyword instead of the class keyword. 

3. Can an interface have variables, fields, or properties?

No.

4. How do you define a method in an interface?

Example
```
interface ILandBound
{
  int NumberOfLegs();
}
```


5. Can you instantiate an object through an interface? Why or why not?

Yes, you can reference an object by using a variable defined as an interface that the object's class implements.

6. Using the new keyword, can you declare a reference to an interface?

No.

7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so how can it do so?

Yes. A class can have at most one base class, but it is allowed to implement an unlimited number of interfaces. 

8. What does it mean to explicitly implement an interface?

To explicitly implement an interface you specify which interface a method belongs to when you implement it. 

9. What are the restrictions on interfaces?

An interface never contains any implementation. Therefore you're not allowed to define any fields in an interface, not even static fields. You're not allowed to define any constructors or destructors.  You can not specify an access modifier for any method. You can not nest any types.  An interface is not allowed to inherit from a structure or class.

10. What is the difference between an abstract class and an interface?

An abstract class is just a class that does not permit instantiation of itself.  Therefore it otherwise shares all the properties of a class and has the same differences from an interface that a class has from interfaces.

11. What is an abstract method?

An abstract method is similar in principal to a virtual method, except that it does not contain a method body. A derived class must override this method. An abstract method can not be private. 

12. What is a sealed class?

You can use the sealed keyword to prevent a class from being used as a base class if you decide that it should not be.

13. What is a sealed method?

You can also use the sealed keyword to declare that an individual method in an unsealed class is sealed. This means that a derived class can not override this method.