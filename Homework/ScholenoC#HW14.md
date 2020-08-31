# Programming in C# Chapter 14 Homework
### Anthony Scholeno

1. What is the difference between a managed and unmanaged resource?

A managed resource is something like an array and an unmanaged resource is something like a file handle.  One is a local resource created and managed within the program whereas the other is a reference to something that may exist outside the program executing it.

2. When is memory for an object allocated? When is the memory deallocated?

The new operation allocates a chunk of raw memory from the heap. When the variable goes out of scope the object can be destroyed. The CLR must return the memory previously belonging to the object back to the heap; the memory that the object lived in must be deallocated. 

3. What is a destructor?

Is a special method of a class and it is used in a class to destroy the object or instances of classes. The destructor automatically invoked by garbage collector whenever the class object that are no longer need in application.

4. What is the difference in syntax between a constructor and destructor?

The syntax for writing a destructor is a tilde followed by the name of the class. The difference is only that the class is prefaced by the tilde.

5. Give some examples of scarce resources. Why would you want to manage scarce resources?

An example of scarce resources would be memory, database connection, or file handles.  They need to be managed because they are finite resources and eventually run out.

6. What is exception safe disposal?

One way to ensure that a disposal method (such as Close) is always called, regardless of whether there is an exception, is to call the disposal method within a finally block.

7. How do you think the using statement works for resource management? Give an informal English language explanation of how it works.

The using statement provides a clean mechanism for controlling the lifetime of resources. You can create an object, and this object will be destroyed when the using statement block finishes. The using statement introduces its own block for scoping purposes. This arrangement means that the variable you declare in a using statement automatically goes out of scope at the end of the embedded statement and you can not accidentally attempt to access a disposed resource. 

8. What ill effects could result from attempting to dispose of a resource more than once?

Disposing of the resources held by an object more than once might or might not be disastrous, but it is definitely not good practice. 

9. We will look at threads later in the term. For now what is your understanding of how threads interact with resource management?  A good guess is a sufficient answer to this question.

Based on the context of this chapter it appears that the CLR manages the resource management of multiple threads without any guidance from the programmer or the user.  It is inferred that both the garbage collection function and resource management functions of the CLR are quite robust and sophisticated in order to free the programmer up to focus on the logic of their code rather than the housekeeping of resource management and garbage collection.

10. Why does this book not recommend trying to force the garbage collector? Are there any exceptions to this recommendation?

Essentially the book infers that since it is beyond us to understand exactly how and when the CLR works garbage collection that we shouldn't mess with it as it is more likely to have unintended consequences than to accomplish its intended use.  I did not find any exceptions to this guidance in the chapter.  