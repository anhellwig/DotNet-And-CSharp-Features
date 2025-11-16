# New escape sequence

In C# 13, you can use `\e` as a character literal escape sequence for the ESCAPE character as shorthand for `\u001b`.

## Example

```csharp
Console.WriteLine("\e[31;1;4mHello, world!\e[0m");
```

## Further information

* [Character literals](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/lexical-structure#6455-character-literals)
