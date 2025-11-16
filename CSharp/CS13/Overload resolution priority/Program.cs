int[] exampleValues = [1, 2, 3];

MyClass.MyMethod(1, 2, 3);

// Uses the array overload then no OverloadResolutionPriority attribute is present.
// Uses the span overload then the attribute is present, as shown below.
MyClass.MyMethod(exampleValues);


internal class MyClass
{
    // Higher overload resolution priority of 1
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void MyMethod(params ReadOnlySpan<int> span) => Console.WriteLine($"Span with {span.Length} items.");

    // Default overload resolution priority of 0
    public static void MyMethod(params int[] array) => Console.WriteLine($"Array with {array.Length} items.");
}
