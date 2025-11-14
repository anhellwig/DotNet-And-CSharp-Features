# Newlines in string interpolations

In C# 11, raw string literals allow for multi-line strings and can be combined with string interpolation.
This means you can include newlines directly within the interpolated expressions without needing to escape them.
Raw string literals are enclosed in at least three quotation marks (`"""`).

## Example

```csharp
string multiLineMessage = """
    This is a text
    spanning multiple lines,
        and having different
            amounts of indentation.
    """;

string messageWithMoreQuotes = """"
    She said, """This is a raw string literal containing more quotes."""
    """";

string interpolatedMessage = $"""
    Hello, {Environment.UserName}!
    """;

string interpolatedMessageWithBraces = $$"""
    To use braces like {these} in an interpolated raw string literal, use double braces:
    Today is {{DateTime.Now:dddd, MMMM dd, yyyy}}.
    """;
```

## Further information

* [String literals](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#string-literals)
* [String interpolation using `$`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)
