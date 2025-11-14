# Required members

In C# 11, you can use the `required` modifier to indicate that a property must be set during object initialization.

Also, the `SetsRequiredMembers` attribute can be applied to constructors to indicate that the constructor sets all required members of a class.

The `required` modifier complements the `init` accessor modifier to ensure that the property can only be set during object initialization, so that your object represents an immutable set of data.

If you need to target .NET Framework or .NET Standard 2.0, you need to define some attributes in your project,
see e.g. [this SO post](https://stackoverflow.com/questions/74447497/is-it-possible-to-use-the-c11-required-modifier-with-net-framework-4-8-and).

## Example

```csharp
class Person
{
    public Person()
    {
    }

    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public required string Name { get; init; }
    public required int Age { get; init; }
}

Person person = new()
{
    Name = "Alice",
    Age = 30
};
```

## Further information

* [Required properties](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties#required-properties)
