ReadOnlySpan<char> result = "42";

// C# 11 allows pattern matching of Span<char> or ReadOnlySpan<char> on a constant string.
// This would not compile using C# 10.
if (result is "42")
{
    Console.WriteLine("Matched!");
}
