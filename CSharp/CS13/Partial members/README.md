# More partial members

In addition to partial methods, C# 13 allows to declare partial properties and partial indexers.

## Example

```csharp
internal partial class MyClass
{
    // declaring declarations (they do not declare body):
    public partial string? SomeProperty { get; set; }
    public partial int this[int index] { get; set; }
}
```

```csharp
internal partial class MyClass
{
    private int[] numbers = [1, 2, 3];
    private string? someProperty;

    // implementation declarations:
    public partial string? SomeProperty
    {
        get => someProperty;
        set
        {
            someProperty = value;
            // do some additional work like raising an event
        }
    }

    public partial int this[int index] 
    { 
        get => numbers[index];
        set => numbers[index] = value;
    }
}
```

## Further information

* [Partial member](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/partial-member)
