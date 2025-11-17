using System.Collections;

MyData numbers = new();

await numbers.DoSomethingAsync();

foreach (int n in numbers)
{
    Console.WriteLine(n);
}


class MyData : IEnumerable<int>
{
    private readonly int[] items = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

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

        //yield return i; // error: cannot use ref local across yield boundary
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

        //i = 7777; // error: cannot use ref local across await boundary
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
