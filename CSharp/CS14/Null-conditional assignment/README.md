# Null-conditional assignment

The “null-conditional assignment” feature allows developers to use the null-conditional operator (`?.`) in assignment expressions, simplifying the null-check.

## Example

```csharp
// before C# 14
if (service != null)
{
    service.SomethingHappened += (s, e) => { /*...*/ };
    service.SomeProperty = 42;
    service.DoSomething();
}

// possible with C# 14
service?.SomethingHappened += (s, e) => { /*...*/ };
service?.SomeProperty = 42;
service?.DoSomething();
```

## Further information

* [Null-conditional assignment](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-14.0/null-conditional-assignment)
