# `Experimental` attribute

The `Experimental` attribute is used to mark code elements (such as classes, methods, properties, etc.) as experimental.
This can be used to indicate that the marked code is still in development and may change or be removed in future releases.
The consuming developer must explicitly disable the specified error IDs to use the experimental code.

## Example

```csharp
[System.Diagnostics.CodeAnalysis.Experimental("EA1234")]
public class MyClass
{
    [System.Diagnostics.CodeAnalysis.Experimental("EA1235")]
    public int CalculateTheNumber() => 42;
}
```

## Further information

* [`Experimental` attributes](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/general#experimental-attributes)
* [ExperimentalAttribute](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/experimental-attribute)
