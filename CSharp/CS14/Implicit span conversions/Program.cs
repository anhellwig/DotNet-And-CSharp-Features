char[] array = ['H', 'e', 'l', 'l', 'o'];

// Implicitly converts array to ReadOnlySpan<char>
Console.WriteLine(array.ContainsA());

// Implicitly converts string to ReadOnlySpan<char>
Console.WriteLine("Hello".ContainsA());

public static class Extensions
{
    public static bool ContainsA(this ReadOnlySpan<char> span) => span.Contains('a');
}
