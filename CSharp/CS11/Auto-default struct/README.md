# Auto-default struct

Any field or auto property of a `struct` which is not initialized by a constructor is automatically initialized to their default value by the compiler.

## Example

```csharp
// This would not compile with C# 10 or earlier
struct MyStruct
{
    public int X;
    public int Y;

    public MyStruct()
    {
        X = 42;
        // starting with C# 11, Y is initialized to its default value of 0 automatically
    }
}
```

## Further information

* [Struct initialization and default values](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#struct-initialization-and-default-values)
