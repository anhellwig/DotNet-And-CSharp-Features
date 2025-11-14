# Newlines in string interpolations

Starting with C# 11, you can include newlines within the expressions of string interpolations.
This feature can enhance code readability, especially for complex expressions.

## Example

```csharp
Console.WriteLine($"The number is: {
    (7 * 7 - 1) / 3.0 * 2.0 + 10
    }");
```

## Further information

* [String interpolation using `$`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)
