# `ref` and `unsafe` in iterators and `async` methods

In C# 13, `async` methods can declare `ref` local variables and also local variables of a `ref struct` type.
Also, iterator methods can declare `ref` local variables.
Those variables can't be accessed across an await boundary or across a yield return boundary.
C# 13 also allows unsafe contexts in iterator methods.

## Example

```csharp
class MyData : IEnumerable<int>
{
    private int[] items = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    public IEnumerator<int> GetEnumerator()
    {
        // can use ref locals in iterators
        ref int i = ref items[1];
        i += 40;

        // can use unsafe code in iterators
        unsafe
        {
            fixed (int* ptr = &items[^1])
            {
                *ptr = 99;
            }
        }

        foreach (int item in items)
        {
            yield return item;
        }
    }

    public async Task DoSomethingAsync()
    {
        // can use ref locals in async methods
        ref int i = ref items[3];
        i = 666;

        // can use ref structs in async methods
        Span<int> buffer = items.AsSpan()[2..3];
        buffer[0] = 999;

        await Task.Delay(1);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
```

## Further information

* [`ref` and `unsafe` in iterators and `async` methods](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#ref-and-unsafe-in-iterators-and-async-methods)
