# User defined compound assignment

C# 14 introduces support for user-defined compound assignment operators, allowing developers to define custom behavior for compound assignment operations (like `+=`, `-=`, etc.) on their own types.

## Example

```csharp
Point p = new(1.0, 2.0);
p += new Point(3.0, 4.0);

class Point(double x, double y)
{
    public double X { get; set; } = x;
    
    public double Y { get; set; } = y;

    // User-defined addition assignment operator:
    public void operator +=(Point other)
    {
        X += other.X;
        Y += other.Y;
    }
}
```

## Further information

* [User Defined Compound Assignment Operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-14.0/user-defined-compound-assignment)
