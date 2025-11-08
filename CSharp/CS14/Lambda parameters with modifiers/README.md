# Simple lambda parameters with modifiers

This example demonstrates how to use parameter modifiers such as `out` in lambda expressions without specifying the parameter type.

## Example

```csharp
delegate bool TryParseInvariant<T>(string text, out T result);

TryParseInvariant<double> parse1 = (text, out result) =>
    double.TryParse(text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out result);
```

## Further information

* [Input parameters of a lambda expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions#input-parameters-of-a-lambda-expression)
