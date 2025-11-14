// Lambda expressions can have optional parameters or a params array in C# 12.

var isLongerThan = static (string text, int limit = 7) => text.Length > limit;
Console.WriteLine(isLongerThan("Hello, World!", 7));

// use either 'var' or define a delegate type that includes default parameter values
SomeIntNumbersDelegate sumSquared = static (params int[] values) => values.Sum(x => x * x);
Console.WriteLine(sumSquared(1, 2, 3));

return 0;

delegate int SomeIntNumbersDelegate(params int[] values);
