// Previous versions of C# supported nameof only with non-generic types or bound generic types:
Console.WriteLine(nameof(IntPtr));
Console.WriteLine(nameof(List<string>));

// In C# 14 you can use nameof with unbound generic types:
Console.WriteLine(nameof(List<>));
