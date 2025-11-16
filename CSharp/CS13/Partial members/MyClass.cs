namespace PartialMembers;

internal partial class MyClass
{
    // declaring declarations:
    public partial string? SomeProperty { get; set; }

    public partial int this[int index] { get; set; }
}
