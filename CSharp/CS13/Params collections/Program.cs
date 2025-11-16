ReadOnlySpan<char> greeting = "Hello, World!";

PrintItems(greeting);
PrintItems('H', 'e', 'l', 'l', 'o');
PrintItems<char>();

return 0;


// params was limited to T[], now can be used e.g. with IEnumerable<T> or ReadOnlySpan<T>
static void PrintItems<T>(params ReadOnlySpan<T> items)
{
    Console.Write($"{items.Length} items: ");
    foreach (T item in items)
    {
        Console.Write(item);
    }

    Console.WriteLine();
}
