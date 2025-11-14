PointWithTraditionalConstructor p1 = new(1.0, 2.0);
PointWithPrimaryConstructor p2 = new(3.0, 4.0);

Console.WriteLine($"Point 1: {p1}");
Console.WriteLine($"Point 2: {p2}");


// There's no implicit parameterless constructor for a class...
//PointWithPrimaryConstructor p3 = new(); <- error CS7036
// ... but for a struct with primary constructor:
PointStructWithPrimaryConstructor ps = new();
Console.WriteLine($"Point struct: {ps}");


ClassWithPrimaryConstructor c = new(42.0);
c.DoSomething();

return 0;


internal class PointWithTraditionalConstructor
{
    [SomeExample] // traditional attribute declaration
    public PointWithTraditionalConstructor(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }

    public double Y { get; }

    public override string ToString() => $"({X}; {Y})";
}


[method: SomeExample] // use "method:" target, if you wish to apply an attribute to the constructor
internal class PointWithPrimaryConstructor(double x, double y)
{
    public double X { get; } = x;

    public double Y { get; } = y;

    public override string ToString() => $"({X}; {Y})";
}

[AttributeUsage(AttributeTargets.Constructor)]
internal class SomeExampleAttribute : Attribute;


internal struct PointStructWithPrimaryConstructor(double x, double y)
{
    public double X { get; } = x;

    public double Y { get; } = y;

    public override string ToString() => $"({X}; {Y})";
}


internal class ClassWithPrimaryConstructor(double value)
{
    // A usual use case is to initialize a property.
    // If you also use a primary constructor parameter
    // elsewhere in the class, you'll get compiler warning CS9124.
    // Define a field to mitigate this. It can be readonly.
    private readonly double value = value;

    public double Value { get; } = value;

    public void DoSomething()
    {
        Console.WriteLine($"The value is {value}.");

        // not allowed!
        //value *= 5.0;
    }
}
