# Generic math support

With C# 11 and .NET 7, you can use generic math support to create algorithms that work with any numeric type.
This is made possible through a set of new interfaces in the `System.Numerics` namespace that define common numeric operations.
These interfaces make use of the new static abstract members feature in C# 11, allowing you to define static members in interfaces that can be implemented by different types.

## Example

```csharp
static T Sum<T>(IEnumerable<T> values) where T : System.Numerics.INumber<T>
{
    T result = T.Zero; // static abstract Zero property is defined in INumberBase

    foreach (T value in values)
    {
        result += value; // static abstract + operator is defined in IAdditionOperators
    }

    return result;
}
```

## Further information

* [Preview Features in .NET 6 – Generic Math](https://devblogs.microsoft.com/dotnet/preview-features-in-net-6-generic-math/)
* [Tutorial: Static virtual members in interfaces](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/static-virtual-interface-members)
