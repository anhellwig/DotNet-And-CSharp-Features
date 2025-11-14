# UTF-8 string literals

If you need the UTF-8 byte representation of string literal, e.g. for a sending raw data to a certain API for performance reasons, use the `u8` suffix.

## Example

```csharp
ReadOnlySpan<byte> utf8StringLiteral = "Hello 🌎!"u8;
```

## Further information

* [UTF-8 string literals](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#utf-8-string-literals)
