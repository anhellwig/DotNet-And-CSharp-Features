Point p = new(1.0, 2.0);

// Uses the traditional user-defined addition operator:
p = p + new Point(3.0, 4.0);

// Uses the new user-defined addition assignment operator:
p += new Point(5.0, 6.0);

Console.WriteLine(p);


class Point(double x, double y)
{
    public double X { get; set; } = x;
    
    public double Y { get; set; } = y;

    public override string ToString() => $"({X}, {Y})";

    // Traditional user-defined addition operator:
    public static Point operator +(Point p1, Point p2) => new(p1.X + p2.X, p1.Y + p2.Y);

    // User-defined addition assignment operator:
    public void operator +=(Point other)
    {
        X += other.X;
        Y += other.Y;
    }
}
