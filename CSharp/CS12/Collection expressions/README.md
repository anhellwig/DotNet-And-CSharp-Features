# Collection expressions

C# 12 introduces a terse syntax to create common collection values, which works for arrays, Span, interfaces like IEnumerable<T>,
and types that supports a collection initializer.

## Example

```csharp
IEnumerable<int> Vaylues => [1, 2, 3, 4, 5];
ReadOnlySpan<char> span = ['H', 'e', 'l', 'l', 'o', '!'];
PrintElements(['H', 'e', 'l', 'l', 'o', '!']);
```

## Further information

* [Collection expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/collection-expressions)
* [Collection initializers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers#collection-initializers)
