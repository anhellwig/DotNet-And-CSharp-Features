# Alias any type

In C# 12, you can use the `using` alias directive to alias any type, not just namespaces and named types. 

## Example

```csharp
using Point = (int x, int y);
using IntArray = int[];
using NullableInt = int?;
```

## Further information

* [Allow using alias directive to reference any kind of Type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/using-alias-types)
* [Refactor your code using alias any type](https://devblogs.microsoft.com/dotnet/refactor-your-code-using-alias-any-type/)
* [The `using` alias](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive#the-using-alias)
