# Assignment_7

1. Describe the problem generics address.

Generics allow us to design classes and methods that defer the specification of one or more types until the class or method is declared and instantiated by client code. It addresses the problem of code duplication. Without generics, when writing code that needs to work with multiple data types, we often have to write separate implementations for each data type. Generics make it possible to write code in a more flexible, maintainable, and reusable manner.

2. How would you create a list of strings, using the generic List class?

List<string> myString = new List<string>();

3. How many generic type parameters does the Dictionary class have?

Two. TKey and TValue. 

4. True/False. When a generic class has multiple type parameters, they must all match.

False.

5. What method is used to add items to a List object?

Add method.

6. Name two methods that cause items to be removed from a List.

Remove and RemoveAt. 

7. How do you indicate that a class has a generic type parameter?

<T>.

8. True/False. Generic classes can only have one generic type parameter.

False.

9. True/False. Generic type constraints limit what can be used for the generic type.

True.

10. True/False. Constraints let you use the methods of the thing you are constraining to.

True.
