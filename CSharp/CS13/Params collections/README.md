# `params` collections

Previously, the `params` modifier was limited to single-dimensional array types. In C# 13, you can use `params` with any recognized collection type.
This includes types such as `Span<T>`, `ReadOnlySpan<T>`, `List<T>`, and others that implement the appropriate interfaces.

## Example

```csharp
void PrintItems<T>(params ReadOnlySpan<T> items)
{
    for (int i = 0; i < items.Length; i++)
    {
        Console.WriteLine(items[i]);
    }
}
```

## Further information

* [`params` Collections](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-13.0/params-collections)
* [`params` modifier](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters#params-modifier)
