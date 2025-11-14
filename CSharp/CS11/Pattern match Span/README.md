# Pattern match `Span<char>` or `ReadOnlySpan<char>` on a constant `string`

C# 11 allows to pattern match a `Span<char>` and `ReadOnlySpan<char>` instance against a constant `string`.

## Example

```csharp
ReadOnlySpan<char> result = "42";
// This would not compile using C# 10.
if (result is "42")
{
    Console.WriteLine("Matched!");
}
```

## Further information

* [Constant pattern](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#constant-pattern)
