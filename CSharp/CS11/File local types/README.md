# File local types

File local types are types that are declared with the `file` modifier.
These types are accessible only within the file in which they are declared.
This feature helps to avoid name collisions across different files in a project, mainly for source generators.

## Example

```csharp
file class FileLocalClass
{
    public Guid Id { get; } = Guid.NewGuid();
}
```

## Further information

* [The file modifier](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/file)
