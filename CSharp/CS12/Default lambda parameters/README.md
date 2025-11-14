# Default lambda parameters

In C# 12, you can declare a lambda expression with default parameters or with `params` array.

## Example

```csharp
var isLongerThan = (string text, int limit = 7) => text.Length > limit;
var sumSquared = (params int[] values) => values.Sum(x => x * x);
```

## Further information

* [Input parameters of a lambda expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions#input-parameters-of-a-lambda-expression)
