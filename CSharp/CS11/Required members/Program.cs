Person person = new()
{
    // We must set all required properties:
    Name = "Alice",
    Age = 30
};

Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

person = new Person("Bob")
{
    // Now, we don't have to set the required properties because of the [SetsRequiredMembers] attribute.
};

Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

person = new Person("Bob", 42);

Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

internal class Person
{
    public Person()
    {
    }

    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
    public Person(string name)
    {
        Name = name;
        // We should set all required properties here, but technically, we're not required to.
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
