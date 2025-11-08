# Extension members

Extension members allow you to add new methods, properties, and other members to existing types without modifying their source code.

## Example

```csharp
record Point(double X, double Y);

static class PointExtensionsMembers
{
    extension(Point source) // parameter "source" is called the "receiver"
    {
        // extension method
        public double DistanceToNew(Point other)
        {
            double dx = other.X - source.X;
            double dy = other.Y - source.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // extension property
        public bool IsZero => source.X == 0.0 && source.Y == 0.0;
    }

    // extending the type
    extension(Point)
    {
        // static extension property:
        public static Point Origin => new(0.0, 0.0);

        // static extension method
        public static Point Create(double radius, double angle)
        {
            double x = radius * Math.Cos(angle);
            double y = radius * Math.Sin(angle);
            return new(x, y);
        }

        // static user-defined operator
        public static Point operator +(Point left, Point right) => new(left.X + right.X, left.Y + right.Y);
    }
}
```

## Further information

* [Extension declaration](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/extension)
* [Extension members](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)
