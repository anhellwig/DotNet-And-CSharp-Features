# Implicit span conversions

C# 14 supports some conversions between `ReadOnlySpan<T>`, `Span<T>`, and `T[]`. 

## Example

```csharp
char[] array = ['H', 'e', 'l', 'l', 'o'];
Console.WriteLine(array.ContainsA());

Console.WriteLine("Hello".ContainsA());

public static class Extensions
{
    public static bool ContainsA(this ReadOnlySpan<char> span) => span.Contains('a');
}
```

## Further information

* [First-class Span Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-14.0/first-class-span-types)
* [Built-in types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)
