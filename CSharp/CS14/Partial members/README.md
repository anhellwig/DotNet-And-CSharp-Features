# More partial members

This example demonstrates the use of partial constructors and partial events in C#.

## Example

```csharp
partial class MyClass
{
    // We're just declaring the constructor here:
    public partial MyClass();

    // We're declaring the event here using the field-like syntax:
    public partial event EventHandler<PropertyChangedEventArgs>? PropertyChanged;
}
```
```csharp
partial class MyClass
{
    // Implementing the constructor here:
    public partial MyClass()
        // constructor initializer must be added on the implementing declaration
        : base(Random.Shared.Next(1, 100))
    {
        Console.WriteLine("Hello from partial constructor.");
    }

    // The implementing declaration must declare the add and remove accessors:
    private EventHandler<PropertyChangedEventArgs>? propertyChanged;
    public partial event EventHandler<PropertyChangedEventArgs>? PropertyChanged
    {
        add
        {
            propertyChanged += value;
            Console.WriteLine("Someone subscribed to PropertyChanged event.");
        }
        remove
        {
            propertyChanged -= value;
            Console.WriteLine("Someone unsubscribed from PropertyChanged event.");
        }
    }
}
```

## Further information

* [Partial members](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/partial-member)
* [Partial constructors](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors#partial-constructors)
