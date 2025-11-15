# Inline arrays

Inline arrays allow you to define a fixed-size array directly within a struct, without needing an unsafe context.
They might be utilized e.g. by library authors in high-performance scenarios.

## Example

```csharp
[System.Runtime.CompilerServices.InlineArray(42)]
public struct IntBuffer
{
    private int numbers;
}
```

## Further information

* [Inline arrays](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#inline-arrays)
