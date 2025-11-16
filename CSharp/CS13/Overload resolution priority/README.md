# Overload resolution priority

In C# 13, the `OverloadResolutionPriority` attribute allows developers to influence the overload resolution process by specifying a priority level for method overloads.
You can use this if a certain overload (e.g. a better performing one) should be preferred over others during method resolution.

## Example

```csharp
class MyClass
{
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void MyMethod(params ReadOnlySpan<int> span) => Console.WriteLine($"Span with {span.Length} items.");

    public static void MyMethod(params int[] array) => Console.WriteLine($"Array with {array.Length} items.");
}
```

## Further information

* [`OverloadResolutionPriority` attribute](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/general#overloadresolutionpriority-attribute)
* [Overload Resolution Priority](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-13.0/overload-resolution-priority#overload-resolution-priority)
