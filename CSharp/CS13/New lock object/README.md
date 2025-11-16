# New lock object

The lock statement in C# 13.0 introduces support for the new `Lock` type which was intruduced in .NET 9.
Use it to prevent concurrent accesses to a resource.

## Example

```csharp
Lock newLockObject = new();
lock (newLockObject) // calls newLockObject.EnterScope
{
   // do some work
}
```

## Further information

* [`Lock` object](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-13.0/lock-object)
* [`Lock` Class](https://learn.microsoft.com/en-us/dotnet/api/system.threading.lock?view=net-9.0)
* [The lock statement](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/lock)
