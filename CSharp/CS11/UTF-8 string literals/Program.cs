ReadOnlySpan<byte> utf8StringLiteral = "Hello 🌎!"u8;

Console.WriteLine(System.Text.Encoding.UTF8.GetString(utf8StringLiteral));

// You can use those bytes to access any API which requires raw byte data, or you may want to use raw bytes for performance reasons.
