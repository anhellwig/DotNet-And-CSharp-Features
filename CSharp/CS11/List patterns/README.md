# List patterns

Starting with C# 11, you can use pattern matching against a sequence of patterns.

## Example

```csharp
byte[] bytes = [0x1, 0x2, 0x3];

Console.WriteLine($"Exact match: {bytes is [1, 2, 3]}");

Console.WriteLine($"Check specific elements with discard pattern: {bytes is [_, 2, _]}");

Console.WriteLine($"Combine with relational and slice patterns: {bytes is [.., > 1]}");

if (bytes is [.., var last])
{
    Console.WriteLine($"Capture an element using var pattern: {last}");
}
```

## Further information

* [List patterns](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#list-patterns)
