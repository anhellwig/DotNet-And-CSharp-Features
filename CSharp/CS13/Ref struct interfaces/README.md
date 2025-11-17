# `ref struct` interfaces and `allows ref struct`

In C# 13, `ref struct` types can implement interfaces. A ref struct type can't be converted to an interface type, though,
because that would require a boxing operation.

To access the interface methods, use generic type declarations with an added anti-constraint, `allows ref struct`,
meaning that the type argument supplied for that type parameter can be a `ref struct` type.

## Example

```csharp
static void DoSomething<T>(T arg) where T : IMyInterface, allows ref struct
{
    arg.MyMethod();
}

ref struct MyRefStruct : IMyInterface
{
    public readonly void MyMethod() => Console.WriteLine("MyRefStruct MyMethod called");
}

interface IMyInterface
{
    void MyMethod();
}
```

## Further information

* [Allows ref struct](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters#allows-ref-struct)
* [`ref` modifier on structs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/ref-struct#restrictions-for-ref-struct-types-that-implement-an-interface)
* [`where` (generic type constraint)](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint)
* [Constraints on type parameters](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters)
* [C# 13 ref struct interfaces and the ‘allows ref struct’ generic anti-constraint](https://blog.ndepend.com/c-13-ref-struct-interfaces-and-the-allows-ref-struct-generic-anti-constraint/)
* [ref struct interfaces](https://developers.redhat.com/articles/2025/04/21/c-13-advanced-features#generic_ref_struct_parameters)
