# Checked and unchecked user defined operators

C# 11 introduces the ability to define checked and unchecked user-defined operators.
This allows developers to specify how their custom types should behave in checked and unchecked contexts, providing a customized overflow behavior.

This feature complements the [generic math](../Generic%20math%20support) capabilities introduced in C# 11.

## Example

```csharp
record Point(int X, int Y)
{
    public static Point operator *(Point a, int scalar)
    {
        return new Point(a.X * scalar, a.Y * scalar);
    }

    public static Point operator checked *(Point a, int scalar)
    {
        checked
        {
            return new Point(a.X * scalar, a.Y * scalar);
        }
    }
}
```

## Further information

* [User-defined checked operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#user-defined-checked-operators)
* [Checked user-defined operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/checked-user-defined-operators)
