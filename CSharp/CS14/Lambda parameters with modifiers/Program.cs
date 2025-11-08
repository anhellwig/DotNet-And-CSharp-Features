using System.Globalization;

// Previously, adding a modifier like 'out' to a lambda parameter required explicit types for all parameters:
TryParseInvariant<double> parse2 = (string text, out double result) =>
    double.TryParse(text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out result);

// Now, with C# 14, you can omit the types of other parameters when using modifiers:
TryParseInvariant<double> parse1 = (text, out result) =>
    double.TryParse(text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out result);

if (parse1("4.2", out double i1))
{
    Console.WriteLine(i1);
}

if (parse2("4.2", out double i2))
{
    Console.WriteLine(i2);
}

return 0;

delegate bool TryParseInvariant<T>(string text, out T result);
