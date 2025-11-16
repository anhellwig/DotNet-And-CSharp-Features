# Implicit index access

In C# 13, you can use the index from end operator `^` in collection initializers to set elements from the end of a collection.

## Example

```csharp
MyClass data = new()
{
    Buffer =
    {
        [^1] = "World",
        [^2] = "Hello"
    }
}; 
```

## Further information

* [Index from end operator ^](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#index-from-end-operator-)
* [Object and Collection Initializers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers)
