# Primary constructors

In C# 12, you can declare a primary constructor in classes and structs by placing any parameters in parentheses following the type name.
The main use case is to initialize properties.

## Example

```csharp
class Point(double x, double y)
{
    public double X { get; } = x;
    public double Y { get; } = y;
}
```

## Further information

* [Declare primary constructors for classes and structs](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors)
* [Primary constructors](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors#primary-constructors)
