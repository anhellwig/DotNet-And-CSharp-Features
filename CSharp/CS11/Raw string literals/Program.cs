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


Console.WriteLine(multiLineMessage);
Console.WriteLine(messageWithMoreQuotes);
Console.WriteLine(interpolatedMessage);
Console.WriteLine(interpolatedMessageWithBraces);
