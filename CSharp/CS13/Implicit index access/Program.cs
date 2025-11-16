MyClass beforeCs12 = new()
{
    Buffer =
    {
        [0] = "Hello",
        [1] = "World"
    }
}; 

MyClass withCs12 = new()
{
    Buffer =
    {
        [0] = "Oops, I'll get overwritten",
        [^1] = "World",
        [^2] = "Hello"
    }
}; 

Console.WriteLine(string.Join(", ", withCs12.Buffer));


class MyClass
{
    public string[] Buffer { get; set; } = new string[2];
}
