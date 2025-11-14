Point p1 = new(int.MaxValue / 4, int.MaxValue / 3);

p1 *= 5; // Uses the regular operator. This will overflow silently and result in some "arbitrary" bit pattern.

Console.WriteLine(p1);

Point p2 = new(int.MaxValue / 4, int.MaxValue / 3);

try
{
    checked
    {
        // Uses the checked operator. This will throw an OverflowException.
        p2 *= 5;
    }

    Console.WriteLine(p2);
}
catch (Exception)
{
    Console.WriteLine("Overflow occurred during checked multiplication.");
}


record Point(int X, int Y)
{
    // A checked operator declaration requires a pair-wise declaration of a regular operator:
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
