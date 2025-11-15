namespace ExperimentalAttribute;

[System.Diagnostics.CodeAnalysis.Experimental("EA1234", Message = "This class is experimental and may change in future versions.")]
public class MyClass
{
    private readonly Random rnd = new(42);

    // The diagnostic ID must be a valid C# identifier.
    // The attribute has an optional Message property starting with .NET 10.
    [System.Diagnostics.CodeAnalysis.Experimental("EA1235", Message = "This method is experimental and may change in future versions.")]
    public int CalculateTheNumber()
    {
        return 42 + rnd.Next();
    }
}
