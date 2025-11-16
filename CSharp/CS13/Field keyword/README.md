# The `field` Keyword

The `field` keyword in C# is used within property accessors to refer to the compiler-synthesized backing field of a property.

Use `@field` or `this.field` to access an actual field named `field`. This could be a breaking change for existing code.

This is a preview feature. You need to explicitly enable preview features in your project to use it.
It became an official feature in [C# 14](../../CS14/Field%20keyword/).

## Example

```csharp
// Previous C# versions
class PreviousCSharpClass : INotifyPropertyChanged
{
    public int myProperty;

    public int MyProperty
    {
        get => myProperty;
        set
        {
            myProperty = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyProperty)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}

// C# 13 with 'field' keyword
class CSharp14Class : INotifyPropertyChanged
{
    public int MyProperty
    {
        get;
        set
        {
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyProperty)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
```

## Further information

* [Field backed property declarations](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/field)
