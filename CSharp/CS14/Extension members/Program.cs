Point p1 = new(1.0, 2.0);
Point p2 = new(3.0, 4.0);

Console.WriteLine($"Distance: {p2.DistanceToTraditional(p1)}");

Console.WriteLine($"Distance: {p2.DistanceTo(p1)}");

Point p3 = p1 + p2;
Console.WriteLine($"Result of add operator: {p3}");

Point p4 = Point.Create(5.0, Math.PI / 4);
Console.WriteLine($"Created point: {p4}");

return 0;

record Point(double X, double Y);

// Previuosly possible in C#: extension methods
static class PointExtensions
{
    public static double DistanceToTraditional(this Point p1, Point p2)
    {
        double dx = p2.X - p1.X;
        double dy = p2.Y - p1.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}

// New in C# 14: extension members, including extension properties and user-defined operators
static class PointExtensionsMembers
{
    extension(Point source) // parameter "source" is called the "receiver"
    {
        // Extension method:
        public double DistanceTo(Point other)
        {
            double dx = other.X - source.X;
            double dy = other.Y - source.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Extension property:
        public bool IsZero => source.X == 0.0 && source.Y == 0.0;
    }

    // Extending the type:
    extension(Point)
    {
        // static extension property:
        public static Point Origin => new(0.0, 0.0);

        // static extension method:
        public static Point Create(double radius, double angle)
        {
            double x = radius * Math.Cos(angle);
            double y = radius * Math.Sin(angle);
            return new(x, y);
        }

        // static user-defined operator:
        public static Point operator +(Point left, Point right) => new(left.X + right.X, left.Y + right.Y);
    }
}
