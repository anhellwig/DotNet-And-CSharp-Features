# Unbound generic type argument to `nameof`

Previous versions of C# supported nameof only with non-generic types or bound generic types.
Starting with C# 14, you can use unbound generic types as arguments to the `nameof` operator.

## Example

```csharp
Console.WriteLine(nameof(List<>));
```

## Further information

* [nameof expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof)
