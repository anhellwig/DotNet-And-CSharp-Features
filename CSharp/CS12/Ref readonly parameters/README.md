# `ref readonly` parameters

In C# 12, the `ref readonly` modifier allows you to pass an argument to a method by reference while ensuring that the method cannot modify the data.
In contrast to the `in` modifier, which also passes arguments by reference for read-only purposes, `ref readonly` is intended to be used with a variable (lvalue).

## Example

```csharp
static void MethodUsingRefReadonly(ref readonly MyStruct data)
{
    // perform read-only operations on data
}
```

## Further information

* [`ref readonly` modifier](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters#ref-readonly-modifier)
* [`ref readonly` parameters](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/ref-readonly-parameters)
